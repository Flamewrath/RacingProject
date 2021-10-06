using System;

namespace RacingTest.Classes
{
    public class Car: Vehicle
    {
        public Car(double speedIn, int punctureProbIn, byte peopleCountIn,
            int punctureTime, double peopleImpact)
        {
            PeopleImpact = peopleImpact;
            PunctureProb = punctureProbIn;
            PeopleCount = peopleCountIn;
            Speed = speedIn;
            Status = VehicleStatus.Waiting;
            TimeInRace = new TimeSpan(0, 0, 0, 0, 0);
            PunctureTime = new TimeSpan(0, 0, punctureTime);
        }
        /// <summary>
        /// Кол-во людей в машине
        /// </summary>
        public byte PeopleCount { get; set; }
        /// <summary>
        /// Параметр влияния наличия человека в машине
        /// </summary>
        public double PeopleImpact { get; set; }
        /// <summary>
        /// Проверка парамтров перед запуском
        /// </summary>
        public void CheckParameters() // релизовано отдельным методом из-за JsonConvert.DeserializeObject
        {
            Speed -= (double)PeopleCount * PeopleImpact;
            if (Speed <= 0)
                throw new ApplicationException("Скорость не может быть отрицательной или " +
                    "равной нулю. Проверьте параметры автомобиля.");
            if ((PeopleCount < 0) || (PunctureProb < 0) || (PeopleImpact < 0))
                throw new ApplicationException("Проверьте стартовые параметры автомобиля!");
        }
    }
}