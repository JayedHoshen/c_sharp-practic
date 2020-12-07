using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            Console.WriteLine("While loop ...........");
            int i = 0;
            while (i < 20)
            {
                i++;
                if (i % 5 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            // do while loop
            Console.WriteLine("\nDo while loop ............");

            int j = 1;
            do
            {
                Console.WriteLine(j);

                if (j >= 10)
                {
                    break;
                }
                j++;
            } while (true);

            Console.ReadKey();
        }
    }
}
