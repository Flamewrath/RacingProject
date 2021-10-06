using System;
using System.Threading;

namespace RacingTest.Classes
{
    public class Vehicle
    {
       public enum VehicleStatus
        {
            Moving, // в движении
            IsPunctured, // признак пробитого колеса
            Waiting // финишировал ли объект (или новый)
        }
        /// <summary>
        /// Скорость ТС.
        /// Принята метрическая система (км/ч)
        /// </summary>
        public double Speed { get; set; }
        /// <summary>
        /// Время в гонке
        /// </summary>
        public TimeSpan TimeInRace { get; set; }
        /// <summary>
        /// Пройденное расстояние
        /// </summary>
        public double DistPassed { get; set; }
        /// <summary>
        /// Вероятность прокола колеса
        /// </summary>
        public int PunctureProb { get; set; }
        /// <summary>
        /// Время, требуемое для починки.
        /// В секундах
        /// </summary>
        public TimeSpan PunctureTime { get; set; }
        /// <summary>
        /// Текущее время ремонта
        /// </summary>
        public TimeSpan CurrentPunctureSpan { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public VehicleStatus Status { get; set; }
        /// <summary>
        /// Таймер, обеспечивающий движение ТС
        /// </summary>
        public Timer Timer { get; set; }
        /// <summary>
        /// Событие движения ТС
        /// </summary>
        public void VehicleMoving(object state, int refreshTime, double raceDistance)
        {
            TimeSpan span = new TimeSpan(0, 0, 0, 0, refreshTime);
            if (Status == VehicleStatus.Moving)
            {
                DistPassed += Speed / Math.Pow(3.6, 6) * refreshTime; // переводим км/ч в км/мс
                CheckPuncture(raceDistance);
            }
            else
            {
                if (CurrentPunctureSpan >= PunctureTime)
                {
                    Status = VehicleStatus.Moving;
                    CurrentPunctureSpan = new TimeSpan(0);
                }
                else
                    CurrentPunctureSpan = CurrentPunctureSpan.Add(span);
            }
            TimeInRace = TimeInRace.Add(span);
        }
        /// <summary>
        /// Проверка того, пробито ли колесо
        /// </summary>
        private void CheckPuncture(double raceDistance)
        {
            var rnd = new Random();
            double probability = Math.Abs(PunctureProb / (raceDistance / Speed) / 100.0 - 1.0);
            double chance = rnd.NextDouble();
            if (chance > probability)
                Status = VehicleStatus.IsPunctured;
        }
    }
}