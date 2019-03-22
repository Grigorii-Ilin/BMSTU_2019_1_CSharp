using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class Program {
        static void Main(string[] args) {
            var texts = new Texts();
            string stayInProg = "Y";
            do {           
                string language = "";
                do {
                    Console.WriteLine("Введите желаемый язык текстов: RUS или ENG");
                    language = Console.ReadLine().ToUpper();
                } while (language != Texts.RUS_LANG && language != Texts.ENG_LANG);

                texts.SetCurrentTxt(language);
                Console.WriteLine( texts.CurrentTxt);

                Console.WriteLine("Продолжить?: Y/N.");
                stayInProg = Console.ReadLine().ToUpper();
            } while (stayInProg != "N");
        }
    }
}
