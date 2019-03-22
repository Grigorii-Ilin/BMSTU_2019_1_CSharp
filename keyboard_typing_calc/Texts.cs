using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class Texts {
        string currentTxt;
        public string CurrentTxt => currentTxt;

        public string Inputed { get; set; }

        public void SetCurrentTxt(string language) {
            var stringsHolder = (language == Languages.RUS) ? textsRus : textsEng;
            var rnd = new Random();
            int index = rnd.Next(stringsHolder.Count);
            currentTxt = stringsHolder[index];
        }

        List<string> textsRus;
        List<string> textsEng;

        private List<string> LoadJson(string fileName) {
            //texts are from https://lim-english.com/posts/prostie-teksti-na-angliiskom-dlya-nachinaushih/

            using (var streamReader = new StreamReader(fileName + ".json")) {
                string jsonFromLoadedFile = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<string>>(jsonFromLoadedFile);
            }
        }

        public Texts() {
            textsRus = LoadJson(Languages.RUS);
            textsEng = LoadJson(Languages.ENG);
        }

        public bool IsInputWithoutErrors() {
            return Inputed == CurrentTxt;
        }
    }
}
