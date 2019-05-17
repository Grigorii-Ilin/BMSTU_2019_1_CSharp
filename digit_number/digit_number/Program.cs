using System;

namespace digit_number {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Комплексные числа");

            var a = new ComplexDigit(4.9, 2.0);
            var b = new ComplexDigit(7.5, 1.15);

            var c = a + b;
            Console.WriteLine(a.str() + " + " + b.str() + " = " + c.str());

            var d = a - b * c;
            Console.WriteLine(a.str() + " - " + b.str() + " * " + c.str() + " = " + d.str());

            var e = (d - b) / a;
            Console.WriteLine("("+d.str() + " - " + b.str() + ") / " + a.str() + " = " + e.str());

            Console.ReadLine();
        }
    }
}
