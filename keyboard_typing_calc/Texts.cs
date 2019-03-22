using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class Texts {
        public const string RUS_LANG = "RUS";
        public const string ENG_LANG = "ENG";

        string currentTxt;
        public string CurrentTxt => currentTxt;

        public void SetCurrentTxt(string language) {
            var stringsHolder = (language == RUS_LANG) ? textsRus : textsEng;
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
            ////var fileNames = new string[] { "RUS", "ENG" };
            ////foreach (var fileName in fileNames) {
            //using (var streamReader = new StreamReader("rus.json")) {
            //    string jsonFromLoadedFile = streamReader.ReadToEnd();
            //    textsRus = JsonConvert.DeserializeObject<List<string>>(jsonFromLoadedFile);
            //}
            ////}
            //using (var streamReader = new StreamReader("eng.json")) {
            //    string jsonFromLoadedFile = streamReader.ReadToEnd();
            //    textsRus = JsonConvert.DeserializeObject<List<string>>(jsonFromLoadedFile);
            //}

            textsRus = LoadJson(RUS_LANG);
            textsEng = LoadJson(ENG_LANG);
        }

    }
}
