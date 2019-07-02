using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] testArgs = { "123,45", "RUB", "USD", "27.06.2019"};

            //var sq = new StringQuery(testArgs);
            var sq = new StringQuery(args);

            using (var reader = new StreamReader("quotes.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var csvLine = reader.ReadLine();
                    sq.AddCurrenciesByDate(csvLine);
                }
            }

            int exitCode = sq.WorkByQueryType();
            Console.ReadLine();

            if (exitCode != 0)
            {
                throw new Exception("Приложение завершилось ошибкой!");
            }
        }
    }
}
