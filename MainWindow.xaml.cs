using RacingTest.Classes;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;

namespace RacingTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer checkTimer;
        Race race;
        /// <summary>
        /// Инициализация гонки
        /// </summary>
        public void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TimerCallback callback;
                if (race == null)
                {
                    ButtonStart.IsEnabled = false;
                    ButtonStop.IsEnabled = true;
                    race = Func.GetRaceSettings();
                    checkTimer = new DispatcherTimer
                    {
                        Interval = new TimeSpan(0, 0, 0, 0, race.RefreshTime)
                    };
                    checkTimer.Tick += new EventHandler(TimerTick);
                }
                else 
                {
                    race.Lap++;
                }
                race.CheckParameters();
                LabelDistance.Content = $"Длина круга: {race.RaceDistance} м.";
                LabelLap.Content = $"Номер круга: {race.Lap}";
                foreach (Car i in race.Cars)
                {
                    if (race.Lap == 1) i.CheckParameters(); // проверка параметров техники на старте первого круга
                    callback = new TimerCallback(x => i.VehicleMoving(x, race.RefreshTime, race.RaceDistance));
                    i.Status = Vehicle.VehicleStatus.Moving;
                    i.Timer = new Timer(callback, null, 0,
                        race.RefreshTime);
                }
                foreach (Bike i in race.Bikes)
                {
                    if (race.Lap == 1) i.CheckParameters();
                    callback = new TimerCallback(x => i.VehicleMoving(x, race.RefreshTime, race.RaceDistance));
                    i.Status = Vehicle.VehicleStatus.Moving;
                    i.Timer = new Timer(callback, null, 0,
                        race.RefreshTime);
                }
                foreach (Truck i in race.Trucks)
                {
                    if (race.Lap == 1) i.CheckParameters();
                    callback = new TimerCallback(x => i.VehicleMoving(x, race.RefreshTime, race.RaceDistance));
                    i.Status = Vehicle.VehicleStatus.Moving;
                    i.Timer = new Timer(callback, null, 0,
                        race.RefreshTime);
                }
                checkTimer.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации гонки: {ex.Message}");
                LabelDistance.Content = "Длина круга:";
                LabelLap.Content = "Номер круга:";
                StopRace();
                race = null;
                ButtonStart.IsEnabled = true;
                ButtonStop.IsEnabled = false;
                return;
            }
        }
        /// <summary>
        /// Завершение круга
        /// </summary>
        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            StopRace();
        }
        /// <summary>
        /// "Остановка" ТС по требованию.
        /// Досрочное завершение круга
        /// </summary>
        private void StopRace()
        {
            foreach (Car i in race.Cars)
            {
                i.Status = Vehicle.VehicleStatus.Waiting;
                if (i.Timer != null)
                    i.Timer.Dispose();
            }
            foreach (Bike i in race.Bikes)
            {
                i.Status = Vehicle.VehicleStatus.Waiting;
                if (i.Timer != null)
                    i.Timer.Dispose();
            }
            foreach (Truck i in race.Trucks)
            {
                i.Status = Vehicle.VehicleStatus.Waiting;
                if (i.Timer != null)
                    i.Timer.Dispose();
            }
        }
        /// <summary>
        /// Получение текущих результатов заезда
        /// </summary>
        private void GetResults()
        {
            int vehicleCount = 0;
            foreach (Car i in race.Cars)
            {
                CarTextBlock.Text = string.Empty;
                vehicleCount++;
                CarTextBlock.Text += $"Машина {vehicleCount}: Время в пути: {i.TimeInRace.Minutes} мин. {i.TimeInRace.Seconds} с.,"
                    + $"Пройденное расстояние: {Math.Round(i.DistPassed, 2)} м." + Environment.NewLine;
                if (i.Status == Vehicle.VehicleStatus.IsPunctured)
                {
                    Run run = new Run("Пробито колесо!" + Environment.NewLine)
                    {
                        Foreground = Brushes.Red
                    };
                    CarTextBlock.Inlines.Add(run);
                }     
                if (i.DistPassed >= race.RaceDistance * race.Lap)
                {
                    i.Status = Vehicle.VehicleStatus.Waiting;
                    i.Timer.Dispose();
                }
            }
            vehicleCount = 0;
            foreach (Truck i in race.Trucks)
            {
                vehicleCount++;
                TruckTextBlock.Text = $"Грузовик {vehicleCount}: Время в пути: {i.TimeInRace.Minutes} мин. {i.TimeInRace.Seconds} с.,"
                    + $"Пройденное расстояние: {Math.Round(i.DistPassed, 2)} м." + Environment.NewLine;
                if (i.Status == Vehicle.VehicleStatus.IsPunctured)
                {
                    Run run = new Run("Пробито колесо!" + Environment.NewLine)
                    {
                        Foreground = Brushes.Red
                    };
                    TruckTextBlock.Inlines.Add(run);
                }
                if (i.DistPassed >= race.RaceDistance * race.Lap)
                {
                    i.Status = Vehicle.VehicleStatus.Waiting;
                    i.Timer.Dispose();
                }
            }
            vehicleCount = 0;
            foreach (Bike i in race.Bikes)
            {
                vehicleCount++;
                BikeTextBlock.Text = $"Мотоцикл {vehicleCount}: Время в пути: {i.TimeInRace.Minutes} мин. {i.TimeInRace.Seconds} с.,"
                    + $"Пройденное расстояние: {Math.Round(i.DistPassed, 2)} м." + Environment.NewLine;
                if (i.Status == Vehicle.VehicleStatus.IsPunctured)
                {
                    Run run = new Run("Пробито колесо!" + Environment.NewLine)
                    {
                        Foreground = Brushes.Red
                    };
                    BikeTextBlock.Inlines.Add(run);
                }
                if (i.DistPassed >= race.RaceDistance * race.Lap)
                {
                    i.Status = Vehicle.VehicleStatus.Waiting;
                    i.Timer.Dispose();
                }
            }
            if (race.Cars.Where(x => x.Status != Vehicle.VehicleStatus.Waiting).Count() == 0 && race.Bikes.
                Where(x => x.Status != Vehicle.VehicleStatus.Waiting).Count() == 0 && race.Trucks.
                Where(x => x.Status != Vehicle.VehicleStatus.Waiting).Count() == 0)
            {
                checkTimer.Stop();
                race.RaceFinished = true;
                ShowLapResults();
            }
        }
        /// <summary>
        /// Показать итоговые результаты круга.
        /// Срабатывает, когда все пересекли черту
        /// </summary>
        private void ShowLapResults()
        {
            ButtonStop.IsEnabled = false;
            Results results = new Results(this, race);
            results.Show();
        }
        /// <summary>
        /// Событие тика таймера.
        /// </summary>
        private async void TimerTick(Object myObject, EventArgs myEventArgs)
        {
            await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() => GetResults());
            });
        }
        /// <summary>
        /// Кнопка создания файла Json.
        /// Активно только в отладке
        /// </summary>
        private void ButtonCreateJson_Click(object sender, RoutedEventArgs e)
        {
            Race race = new Race();
            race.CreateJsonSettings();
        }
        /// <summary>
        /// Инициализация формы
        /// </summary>
        private void MainForm_Initialized(object sender, EventArgs e)
        {
            race = null;
#if DEBUG
            ButtonCreateJson.Visibility = Visibility.Visible;
#endif
        }
    }
}