using System;

namespace digit_number {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Комплексные числа");

            var a = new ComplexDigit(4.5, 2.0);
            var b = new ComplexDigit(7.5, 1.15);

            var c = a + b;
            Console.WriteLine(a.print() + " + " + b.print() + " = " + c.print());

            Console.ReadLine();
        }
    }
}
