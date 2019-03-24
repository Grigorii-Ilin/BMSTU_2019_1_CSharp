using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class Program {
        static void Main(string[] args) {
            var textsDict = new TextsStorage().LoadTexts();
            var texts = new Texts(textsDict);
            //var clm=new CommandLineMenu();
            var stats = new Statistics();

            do {
                string lang= CommandLineMenu.SelectLanguage();
                texts.SetCurrentTxt(lang);

                Console.WriteLine(texts.CurrentTxt);
                DateTime startTyping = DateTime.Now;
                texts.Inputed = Console.ReadLine();
                DateTime endTyping = DateTime.Now;

                if (texts.IsInputWithoutErrors()) {
                    stats.TimeWork(endTyping - startTyping, texts.Inputed);
                    stats.ShowResults();
                }
                else {
                    Console.WriteLine("Текст введен с ошибкой!");
                }

            } while (CommandLineMenu.StayInProg());
            stats.Save();
        }
    }
}
