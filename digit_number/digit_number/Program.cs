using System;

namespace digit_number {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Комплексные числа");

            var a = new ComplexDigit(4.9, 2.0);
            var b = new ComplexDigit(7.5, 1.15);

            var c = a + b;
            Console.WriteLine(a.ToString() 
                                + " + " 
                                + b.ToString() 
                                + " = " 
                                + c.ToString()
                              );

            var d = a - b * c;
            Console.WriteLine(a.ToString() 
                                + " - " 
                                + b.ToString() 
                                + " * " 
                                + c.ToString() 
                                + " = " 
                                + d.ToString()
                              );

            var e = (d - b) / a;
            Console.WriteLine("("
                                +d.ToString() 
                                + " - " 
                                + b.ToString() 
                                + ") / " 
                                + a.ToString() 
                                + " = " 
                                + e.ToString()
                              );

            bool isEqual = a == b;
            Console.WriteLine(a.ToString()
                    + " == "
                    + b.ToString()
                    + " = "
                    + isEqual.ToString()
                  );

            Console.ReadLine();
        }
    }
}
