using RacingTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace RacingTest
{
    /// <summary>
    /// Логика взаимодействия для Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        private MainWindow mainWindow = null;

        private Race lapRace = null;

        private List<LapResults> lapResults;
        public Results()
        {
            InitializeComponent();
        }
        public Results(Window callingWindow, Race race)
        {
            mainWindow = callingWindow as MainWindow;
            lapRace = race;
            InitializeComponent();
        }
        /// <summary>
        /// Событие генерации грида с данными о результатах круга
        /// </summary>
        private void Results_Activated(object sender, EventArgs e)
        {
            List<LapResults> results = new List<LapResults>();
            lapResults = new List<LapResults>();
            int vehicleNum = 0;
            foreach (Car i in lapRace.Cars)
            {
                vehicleNum++;
                results.Add(new LapResults($"Машина {vehicleNum}", Math.Round(i.DistPassed, 2), i.TimeInRace , i));
            }
            vehicleNum = 0;
            foreach (Truck i in lapRace.Trucks)
            {
                vehicleNum++;
                results.Add(new LapResults($"Грузовик {vehicleNum}", Math.Round(i.DistPassed, 2), i.TimeInRace, i));
            }
            vehicleNum = 0;
            foreach (Bike i in lapRace.Bikes)
            {
                vehicleNum++;
                results.Add(new LapResults($"Мотоцикл {vehicleNum}", Math.Round(i.DistPassed, 2), i.TimeInRace, i)); ;
            }
            lapResults = results.OrderBy(o => o.Time).ToList();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)FindResource("ItemCollectionViewSource");
            itemCollectionViewSource.Source = lapResults;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ButtonStart.IsEnabled = true;
            Close();
        }

        private void NextLap_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ButtonStart_Click(sender, e);
            Close();
        }

        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}