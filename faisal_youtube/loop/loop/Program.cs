using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;

            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                { 
                    Console.Write(i + " + ");
                    sum += i;
                }
            }

            Console.WriteLine("= " + sum);
            Console.ReadKey();
        }
    }
}
