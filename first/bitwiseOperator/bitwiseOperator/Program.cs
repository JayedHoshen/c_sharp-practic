using System;

namespace bitwiseOperator
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 60;
            int b = 13;
            int c;

            c = a & b;
            Console.WriteLine("Line 1: vlaue of c is {0}", c);

            c = a | b;
            Console.WriteLine("Line 2: vlaue of c is {0}", c);

            c = a ^ b;
            Console.WriteLine("Line 3: vlaue of c is {0}", c);

            c = ~a;
            Console.WriteLine("Line 4: vlaue of c is {0}", c);

            c = a << 2;
            Console.WriteLine("Line 5: vlaue of c is {0}", c);

            c = a >> 2;
            Console.WriteLine("Line 6: vlaue of c is {0}", c);

            Console.ReadLine();
        }
    }
}
