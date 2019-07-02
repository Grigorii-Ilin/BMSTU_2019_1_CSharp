using System;
using System.Collections.Generic;
using System.IO;

namespace exam_currency_converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            using (var reader = new StreamReader("test.csv")) {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }
        }
    }
}
