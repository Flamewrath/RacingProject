using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace RacingTest.Classes
{
    public class Race
    {
        public Race()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
            Bikes = new List<Bike>();
            RaceFinished = false;
            Lap = 1;
        }
        /// <summary>
        /// Длина круга
        /// </summary>
        public double RaceDistance { get; set; }
        /// <summary>
        /// Признак того, что гонка закончена
        /// </summary>
        public bool RaceFinished { get; set; }
        /// <summary>
        /// Текущий круг
        /// </summary>
        public int Lap { get; set; }
        /// <summary>
        /// Перечень машин участвующих в гонке
        /// </summary>
        public List<Car> Cars { get; set; }
        /// <summary>
        /// Перечень грузовиков участвующих в гонке
        /// </summary>
        public List<Truck> Trucks { get; set; }
        /// <summary>
        /// Перечень мотоциклов участвующих в гонке
        /// </summary>
        public List<Bike> Bikes { get; set; }
        /// <summary>
        /// Время обновления данных
        /// </summary>
        public int RefreshTime { get; set; }
        /// <summary>
        /// Проверка параметров гонки
        /// </summary>
        public void CheckParameters()
        {
            if ((RaceDistance <= 0) || (RefreshTime <= 0))
                throw new ApplicationException("Проверьте параметры гонки. " +
                    "Все параметры должны быть больше нуля.");
        }
        /// <summary>
        /// Сохранение текущих параметров в файле json.
        /// Используется только в отладке
        /// </summary>
        public void CreateJsonSettings()
        {
            Car car = new Car(80, 20, 2, 5, 3.5);
            Truck truck = new Truck(40, 5, 200, 5, 0.2);
            Bike bike = new Bike(90, 25, false, 5, 50);

            RaceDistance = 5000;
            RefreshTime = 500;
            Cars.Add(car);
            Trucks.Add(truck);
            Bikes.Add(bike);

            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(@"config.json", json);
            MessageBox.Show("JSON сформирован!");
        }
    }
}