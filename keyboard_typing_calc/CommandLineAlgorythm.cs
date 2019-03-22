using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    class CommandLineMenu {
        //public string Language { get; set; }
        //public string stayInProg { get; set; }
        public CommandLineMenu() {
        }

        public string GetSelectedLanguage() {
            string lang = "";
            do {
                Console.WriteLine("Введите желаемый язык текстов:" + Languages.RUS + " или " + Languages.ENG + ".");
                lang = Console.ReadLine().ToUpper();
            } while (lang != Languages.RUS && lang != Languages.ENG);
            return lang;
        }
        
        public bool StayInProg() {
            string answer;
            do {
                Console.WriteLine("Продолжить?: Y/N.");
                answer = Console.ReadLine().ToUpper();
            } while (answer != "Y" && answer != "N");

            return (answer == "Y");
        }
    }
}
