using System;
namespace OperatorsApp1 {
    class Program_one {

        public static void Main(string[] args) {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line 1 Value of c is {0}", c);

            c = a - b;
            Console.WriteLine("Line 2 value of c is {0}", c);

            c = a * b;
            Console.WriteLine("Line 3 value of c is {0}", c);

            c = a / b;
            Console.WriteLine("Line 4 value of c is {0}", c);

            c = a % b;
            Console.WriteLine("Line 5 value of c is {0}", c);

            c = a++;
            Console.WriteLine("Line 6 value of c is {0}", c);

            c = a--;
            Console.WriteLine("Line 7 value of c is {0}", c);

            c = -a;
            Console.WriteLine("Line 8 value of c is {0}", c);

            Console.ReadKey();

        }
    }
}