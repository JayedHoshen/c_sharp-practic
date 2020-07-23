using System;

namespace assignmentOperator
{
    class example
    {
        public static void Main(string[] args)
        {
            int a = 21;
            int c;

            c = a;
            Console.WriteLine("Line 1: = value of c = {0}", c);

            c += a;
            Console.WriteLine("Line 2: += value of c = {0}", c);

            c -= a;
            Console.WriteLine("Line 3: -= value of c = {0}", c);

            c *= a;
            Console.WriteLine("Line 4: *= value of c = {0}", c);

            c /= a;
            Console.WriteLine("Line 5: /= value of c = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6: %= value of c = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7: <<= value of c = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8: >>= value of c = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9: &= value of c = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10: ^= value of c = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11: |= value of c = {0}", c);

            Console.ReadKey();
        }
    }
}
