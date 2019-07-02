using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_currency_converter {
    public class StringQuery {
        //string[] args;
        decimal enteredValue;
        string enteredFrom;
        string enteredTo;
        DateTime enteredDate;


        private Func<int> WorkByQueryType;


        public StringQuery(string[] args) {
            //int len = args.Length;

            enteredValue = Decimal.Parse(args[0]);
            enteredFrom = args[1];

            switch (args.Length) {
                case 4:
                    enteredTo = args[2];
                    enteredDate = DateTime.Parse(args[3]);
                    WorkByQueryType = ConvertFromToOneByEnteredDate;
                    break;



                case 3:
                    DateTime tempDT;
                    if (DateTime.TryParse(args[2], out tempDT)) {
                        enteredDate = tempDT;
                        WorkByQueryType = ConvertFromToAllByEnteredDate;
                    }
                    else {

                    }

                    enteredTo = args[2];
                    break;

                case 2:
                    WorkByQueryType = ConvertFromToAllByActualDate;
                    break;

                default:
                    break;
            }
        }

        //public void ParseArgs() {

        //}


        private int ConvertFromToOneByEnteredDate() {

        }

        private int ConvertFromToOneByActualDate() {

        }

        private int ConvertFromToAllByActualDate() {

        }

        private int ConvertFromToAllByEnteredDate() {

        }
    }
}
