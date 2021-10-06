using System;

namespace RacingTest.Classes
{
    public class Truck : Vehicle
    {
        public Truck(double speedIn, int punctureProbIn, double cargoWeightIn,
            int punctureTime, double cargoImpact)
        {
            PunctureProb = punctureProbIn;
            CargoImpact = cargoImpact;
            CargoWeight = cargoWeightIn;
            Speed = speedIn;
            Status = VehicleStatus.Waiting;
            TimeInRace = new TimeSpan(0, 0, 0, 0, 0);
            PunctureTime = new TimeSpan(0, 0, punctureTime);
        }
        /// <summary>
        /// Вес груза
        /// </summary>
        public double CargoWeight { get; set; }
        /// <summary>
        /// Влияние груза на скорость
        /// </summary>
        public double CargoImpact { get; set; }
        /// <summary>
        /// Проверка парамтров перед запуском
        /// </summary>
        public void CheckParameters() // релизовано отдельным методом из-за JsonConvert.DeserializeObject
        {
            Speed -= CargoWeight * CargoImpact;
            if (Speed <= 0)
                throw new ApplicationException("Скорость не может быть отрицательной или " +
                    "равной нулю. Проверьте параметры грузовика.");
            if ((CargoImpact < 0) || (PunctureProb < 0) || (CargoWeight < 0))
                throw new ApplicationException("Проверьте стартовые параметры грузовика!");
        }
    }
}