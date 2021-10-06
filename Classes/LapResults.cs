using System;
using System.ComponentModel;

namespace RacingTest.Classes
{
    public class LapResults : INotifyPropertyChanged
    {
        public LapResults(string name, double distance, TimeSpan time, object obj)
        {
            Name = name;
            Distance = distance;
            Time = time;
            if (obj is Car car)
            {
                if (car.PeopleCount != 0)
                    Parameters = $"Кол-во людей в салоне: {car.PeopleCount}";
            }
            if (obj is Truck truck)
            {
                if (truck.CargoWeight != 0)
                    Parameters = $"Вес груза: {truck.CargoWeight}";
            }
            if (obj is Bike bike)
            {
                if (bike.Carriage)
                    Parameters = "С коляской";
                else
                    Parameters = "Без коляски";
            }
            TimeString = $"{ Time.Minutes} мин. { Time.Seconds} с.";
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private double distance;
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                OnPropertyChanged("Distance");
            }
        }
        private TimeSpan time;
        public TimeSpan Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }
        private string timeString;

        public string TimeString
        {
            get
            {
                return timeString;
            }
            set
            {
                timeString = value;
                OnPropertyChanged("TimeString");
            }
        }
        private string parameters;
        public string Parameters
        {
            get
            {
                return parameters;
            }
            set
            {
                parameters = value;
                OnPropertyChanged("Parameters");
            }
        }
        protected void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}