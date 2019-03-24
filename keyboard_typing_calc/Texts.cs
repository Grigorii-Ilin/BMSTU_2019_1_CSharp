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
            var rnd = new Random();
            int index = rnd.Next(texts[language].Count);
            currentTxt = texts[language][index].Trim();
        }

        Dictionary<string, List<string>> texts;

        public Texts(Dictionary<string, List<string>> texts) {
            this.texts = texts;
        }

        public bool IsInputWithoutErrors() {
            return Inputed.Trim() == CurrentTxt;
        }
    }
}
