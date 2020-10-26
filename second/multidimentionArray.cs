using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multidimentionalArray {
    class multiArray {
        static void Main(string[] args) {
            int i, j;
            // declaring multidimentional array
            string[,] Books = new string[3, 3];
            for (i = 0; i < 3; i++) {
                for (j = 0; j < 3; j++) {
                    Console.Write("Enter Book Name for {0} Row and {1} Column:\t", i+1, j+1);
                    Books[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine("\n\n====================================");
            Console.WriteLine("All the element of books array is: \n\n");

            // formatting output
            Console.Write("\t1\t2\t3\n\n");

            // outer loop for accessing rows
            for (i = 0; i < 3; i++) {
                Console.Write("{0}.\t", i+1);

                // inner or nested loop for accessing column of each row 
                for (j = 0; j < 3; j++) {
                    Console.Write("{0}\t", Books[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n===============================");
            Console.ReadLine();
        }
    }
}