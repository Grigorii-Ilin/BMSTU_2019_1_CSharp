using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class TextsStorage {
        public Dictionary<string, List<string>> LoadTexts() {
            return new Dictionary<string, List<string>>() {
                { Languages.ENG, LoadJson(Languages.ENG) },
                { Languages.RUS, LoadJson(Languages.RUS) }
            };
        }

        private List<string> LoadJson(string fileName) {
            //texts are from https://lim-english.com/posts/prostie-teksti-na-angliiskom-dlya-nachinaushih/

            using (var streamReader = new StreamReader(fileName + ".json")) {
                string jsonFromLoadedFile = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<string>>(jsonFromLoadedFile);
            }
        }
    }
}
