using System;

namespace assignmentOperator {
    class assignmentOP {
        static void Main(string[] args) {
            int a = 21;
            int c = a;

            Console.WriteLine("Line 1 - op = vlaue of c = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - op += vlaue of c = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - op -= vlaue of c = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - op *= vlaue of c = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - op /= vlaue of c = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - op %= vlaue of c = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - op <<= value of c = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - op >>= value of c = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - op &= value of c = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - op ^= value of c = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - op |= value of c = {0}", c);
            Console.ReadKey();
        }
    }
}