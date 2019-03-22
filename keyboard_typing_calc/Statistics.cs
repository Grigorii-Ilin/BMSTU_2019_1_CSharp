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
            wordsPerMinute=new List<double>();

            if (File.Exists(STATS_FILE_NAME)) {
                using (var streamReader = new StreamReader(STATS_FILE_NAME)) {
                    string jsonFromLoadedFile = streamReader.ReadToEnd();
                    wordsPerMinute= JsonConvert.DeserializeObject<List<double>>(jsonFromLoadedFile);
                }
            }
        }

        public void TimeWork(TimeSpan dtSec, string curTxt) {
            wordPerMinute = curTxt.Length / dtSec.Seconds / 60;
            wordsPerMinute.Add(wordPerMinute);

            meanTime = wordsPerMinute.Sum() / wordsPerMinute.Count;

            bestTime = wordsPerMinute.Max();
        }
    }
}
