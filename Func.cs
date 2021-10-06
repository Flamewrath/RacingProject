using Newtonsoft.Json;
using RacingTest.Classes;
using System.IO;

namespace RacingTest
{
    public static class Func
    {
        /// <summary>
        /// Процедура получения параметров гонки.
        /// Конфиг в файле json
        /// </summary>
        public static Race GetRaceSettings()
        {
            string text = File.ReadAllText(@"config.json");
            Race race = JsonConvert.DeserializeObject<Race>(text);
            return race;
        }
    }
}