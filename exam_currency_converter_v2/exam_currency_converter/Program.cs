using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_currency_converter {
    class Program {
        static void Main(string[] args) {
            List<CurrenciesByDate> currenciesByDates = new List<CurrenciesByDate>();

            using (var reader = new StreamReader("quotes.csv")) {
                //List<string> listA = new List<string>();
                reader.ReadLine();

                while (!reader.EndOfStream) {
                    var csvLine = reader.ReadLine();
                    //var values = line.Split(';');

                    //listA.Add(values[0]);
                    currenciesByDates.Add(
                        new CurrenciesByDate(csvLine)
                        );
                }


            }
        }
    }
}
