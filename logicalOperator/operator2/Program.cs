using System;
namespace logicalOperator {
    class Operator2 {
        public static void Main(string[] args) {
            bool a = true;
            bool b = true;

            if (a && b) {
                Console.WriteLine("Line 1 Condition is true");
            }
            if (a || b) {
                Console.WriteLine("Line 2 condition is true");
            }
            /* lets change the value of a nad b*/
            a = false;
            b = true;

            if (a && b) {
                Console.WriteLine("Line 3 condition is true");
            }
            else {
                Console.WriteLine("Line 3 condition is not true");
            }

            if (!(a && b)) {
                Console.WriteLine("Line 4 condition is true");
            }

            Console.ReadLine();
        }
    }
}