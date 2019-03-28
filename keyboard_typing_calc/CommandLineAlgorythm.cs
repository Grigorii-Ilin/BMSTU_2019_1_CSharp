// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_typing_calc {
    public static class CommandLineMenu {
        //public string Language { get; set; }
        //public string stayInProg { get; set; }
        //public CommandLineMenu() {
        //}

        public static string SelectLanguage() {
            string lang = "";
            do {
                Console.WriteLine("Введите желаемый язык текстов: " + Languages.RUS + " или " + Languages.ENG + ".");
                lang = Console.ReadLine().ToUpper();
            } while (lang != Languages.RUS && lang != Languages.ENG);
            return lang;
        }
        
        public static bool StayInProg() {
            string answer;
            do {
                Console.WriteLine("Продолжить?: Y/N.");
                answer = Console.ReadLine().ToUpper();
            } while (answer != "Y" && answer != "N");

            return (answer == "Y");
        }
    }
}
