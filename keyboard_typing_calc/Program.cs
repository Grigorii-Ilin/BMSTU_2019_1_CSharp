using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class Program {
        static void Main(string[] args) {
            var texts = new Texts();
            var clm=new CommandLineMenu();
            var stats = new Statistics();

            do {
                string lang= clm.GetSelectedLanguage();
                texts.SetCurrentTxt(lang);
                Console.WriteLine( texts.CurrentTxt);

                DateTime startTyping = new DateTime();
                texts.Inputed = Console.ReadLine();
                DateTime endTyping = new DateTime();

                if (texts.IsInputWithoutErrors()) {
                    stats.TimeWork(endTyping - startTyping, texts.Inputed);
                }
                else {
                    Console.WriteLine("Текст введен с ошибкой!");
                }

            } while (!clm.StayInProg());
        }
    }
}
