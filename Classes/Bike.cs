using System;

namespace RacingTest.Classes
{
    public class Bike: Vehicle
    {
        public Bike(double speedIn, int punctureProbIn, bool carriageIn,
            int punctureTime, double carriageImpact)
        {
            CarriageImpact = carriageImpact;
            PunctureProb = punctureProbIn;
            Carriage = carriageIn;
            Speed = speedIn;
            Status = VehicleStatus.Waiting;
            TimeInRace = new TimeSpan(0, 0, 0, 0, 0);
            PunctureTime = new TimeSpan(0, 0, punctureTime);
        }
        /// <summary>
        /// Наличие коляски
        /// </summary>
        public bool Carriage { get; set; }
        /// <summary>
        /// Параметр влияния коляски на скорость
        /// </summary>
        public double CarriageImpact { get; set; }
        /// <summary>
        /// Проверка парамтров перед запуском
        /// </summary>
        public void CheckParameters() // релизовано отдельным методом из-за JsonConvert.DeserializeObject
        {
            if (Carriage)
                Speed -= CarriageImpact;
            if (Speed <= 0)
                throw new ApplicationException("Скорость не может быть отрицательной или " +
                    "равной нулю. Проверьте параметры мотоцикла.");
            if ((CarriageImpact < 0) || (PunctureProb < 0))
                throw new ApplicationException("Проверьте стартовые параметры грузовика!");
        }
    }
}