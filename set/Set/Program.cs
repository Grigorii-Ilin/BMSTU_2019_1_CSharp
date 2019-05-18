using System;

namespace Set {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Множества");

            var a = new MySet(
                new int[] { 0, 18, 18, 4, -5, 0, 5, 11, 2, 2, 2, 7, -1 }
                );

            var b = new MySet(
                new int[] { 6, 12, 13, 2, -18, 0, 2, 14, 1, 1 }
                );

            var c = a + b;
            Console.WriteLine(a.ToString()
                                + " + "
                                + b.ToString()
                                + " = "
                                + c.ToString()
                            );

            var d = a - b;
            Console.WriteLine(a.ToString()
                                + " - "
                                + b.ToString()
                                + " = "
                                + d.ToString()
                            );

            var e = a * b;
            Console.WriteLine(a.ToString()
                                + " * "
                                + b.ToString()
                                + " = "
                                + e.ToString()
                            );

            bool isSame1 = a == b;
            Console.WriteLine(a.ToString()
                                + " == "
                                + b.ToString()
                                + " = "
                                + isSame1.ToString()
                            );


            Console.ReadLine();

            a.UniqueValues.Add(7);
        }
    }
}
