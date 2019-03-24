using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class Statistics {
        private const string STATS_FILE_NAME = "stats.json";

        private List<double> wordsPerMinute;
        double wordPerMinute { get; set; }
        double meanTime { get; set; }
        double bestTime { get; set; }

        public Statistics() {
            wordsPerMinute = new List<double>();

            if (File.Exists(STATS_FILE_NAME)) {
                using (var streamReader = new StreamReader(STATS_FILE_NAME)) {
                    string jsonFromLoadedFile = streamReader.ReadToEnd();
                    wordsPerMinute = JsonConvert.DeserializeObject<List<double>>(jsonFromLoadedFile);
                }
            }
        }

        public void TimeWork(TimeSpan dtSec, string curTxt) {
            wordPerMinute = curTxt.Length / dtSec.TotalMinutes;
            wordsPerMinute.Add(wordPerMinute);

            meanTime = wordsPerMinute.Sum() / wordsPerMinute.Count;

            bestTime = wordsPerMinute.Max();
        }

        public void ShowResults() {
            Console.WriteLine("Набрано символов в минуту:");
            Console.WriteLine("Сейчас: {0,3:F}; средний результат: {1,3:F}; лучший результат: {2,3:F}",
                            wordPerMinute,
                            meanTime,
                            bestTime);
        }

        public void Save() {
            string json = JsonConvert.SerializeObject(wordsPerMinute, Formatting.Indented);
            System.IO.File.WriteAllText(STATS_FILE_NAME, json);
        }
    }
}
