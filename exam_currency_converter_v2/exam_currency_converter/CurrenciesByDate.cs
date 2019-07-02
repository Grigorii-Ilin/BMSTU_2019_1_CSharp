using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_currency_converter {
    public class CurrenciesByDate {
        public DateTime Date { get;}
        //public decimal Rub { get; }
        //public decimal Eur { get; }
        //public decimal Usd { get; }
        public readonly Dictionary<string, decimal> CoursesByCurrencies;

        public CurrenciesByDate(string csvLine) {
            var values = csvLine.Split(';');
            //0-date, 1-Rub, 2-Eur, 3-Usd
            int index = 0;
            Date = DateTime.Parse(values[index++]);
            //Rub = Decimal.Parse(values[index++]);
            //Eur = Decimal.Parse(values[index++]);
            //Usd = Decimal.Parse(values[index++]);

            CoursesByCurrencies = new Dictionary<string, decimal>();
            CoursesByCurrencies["RUB"] = Decimal.Parse(values[index++]);
            CoursesByCurrencies["EUR"] = Decimal.Parse(values[index++]);
            CoursesByCurrencies["USD"] = Decimal.Parse(values[index++]);
        }
    }
}
