using System;
namespace miscellaneousOperator
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* example of sizeof operator */
            Console.WriteLine("The Size of int is {0} Bytes", sizeof(int));
            Console.WriteLine("The Size of short is {0} Bytes", sizeof(short));
            Console.WriteLine("The Size of double is {0} Bytes", sizeof(double));

           /* example of ternary operator */
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);
            Console.ReadKey();
        }
    }
}
