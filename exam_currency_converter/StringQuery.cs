using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_currency_converter {
    public class StringQuery {
        const int OK = 0;
        const int ERROR = 1;

        readonly string[] CURRENCIES =  { "RUB", "USD", "EUR" };

        List<CurrenciesByDate> currenciesByDates = new List<CurrenciesByDate>();

        decimal enteredValue;
        string enteredFrom;
        string enteredTo;
        DateTime enteredDate;

        public Func<int> WorkByQueryType;


        public StringQuery(string[] args) {
            enteredValue = Decimal.Parse(args[0]);
            enteredFrom = args[1];

            switch (args.Length) {
                case 4:
                    enteredTo = args[2];
                    enteredDate = DateTime.Parse(args[3]);
                    WorkByQueryType = ConvertToOneByEnteredDate;
                    break;

                case 3:
                    DateTime tempDT;
                    if (DateTime.TryParse(args[2], out tempDT)) {
                        enteredDate = tempDT;
                        WorkByQueryType = ConvertToAllByEnteredDate;
                    }
                    else {
                    enteredTo = args[2];
                    WorkByQueryType = ConvertToOneByActualDate;
                    }
                    break;

                case 2:
                    WorkByQueryType = ConvertToAllByActualDate;
                    break;

                default:
                    break;
            }
        }

        public void AddCurrenciesByDate(string csvLine)
        {
            currenciesByDates.Add(
                new CurrenciesByDate(csvLine)
                );
        }

        private void CalcAndShowResult(decimal courseFrom, decimal courseTo, string literalTo)
        {
            decimal convertedValue = enteredValue * courseFrom / courseTo;
            Console.WriteLine("\n{0:f2} {1}", convertedValue, literalTo);
        }


        private int ConvertToOneByEnteredDate() {
            var q = currenciesByDates.FirstOrDefault(e => e.Date == enteredDate);

            if (q!=null)
            {
                CalcAndShowResult(q.CoursesByCurrencies[enteredFrom], q.CoursesByCurrencies[enteredTo], enteredTo);
                return OK;
            }
            else
            {
                return ERROR;
            }

        }

        private int ConvertToOneByActualDate() {
            var maxDate = currenciesByDates.Max(e => e.Date);
            var q = currenciesByDates.FirstOrDefault(e => e.Date == maxDate);

            CalcAndShowResult(q.CoursesByCurrencies[enteredFrom], q.CoursesByCurrencies[enteredTo], enteredTo);
 
            return OK;
        }

        private int ConvertToAllByActualDate() {
            var maxDate = currenciesByDates.Max(e => e.Date);
            var q = currenciesByDates.FirstOrDefault(e => e.Date == maxDate);

            foreach (var c in CURRENCIES)
            {
                if (c != enteredFrom)
                {
                    CalcAndShowResult(q.CoursesByCurrencies[enteredFrom], q.CoursesByCurrencies[c], c);
                }
            }

            return OK;
        }

        private int ConvertToAllByEnteredDate() {
            var q = currenciesByDates.FirstOrDefault(e => e.Date == enteredDate);

            if (q != null)
            {
                foreach (var c in CURRENCIES)
                {
                    if (c!=enteredFrom)
                    {
                        CalcAndShowResult(q.CoursesByCurrencies[enteredFrom], q.CoursesByCurrencies[c], c);                      
                    }
                }

                return OK;
            }
            else
            {
                return ERROR;
            }
        }
    }
}
