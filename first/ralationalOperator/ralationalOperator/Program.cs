using System;
namespace relationalOperator {
    class exampleRO {
        public static void Main(string[] args) {
            int a = 21;
            int b = 10;

            // first condition
            if (a == b)
            {
                Console.WriteLine("Line 1 a is equal to b");
            }
            else
            {
                Console.WriteLine("Line 1 a is not equal to b");
            }

            // second condition
            if (a < b)
            {
                Console.WriteLine("Line 2 a is less than b");
            }
            else
            {
                Console.WriteLine("Line 2 a is not less than b");
            }

            // third condition
            if (a > b)
            {
                Console.WriteLine("Line 3 a is greater than b");
            }
            else
            {
                Console.WriteLine("Line 3 a is not greater than b");
            }

            /*====== lets change value of a and b =====*/
            a = 5;
            b = 20;

            // forth condition
            if (a <= b)
            {
                Console.WriteLine("Line 4 a is either less than or equal to b");
            }
            if(b >= a)
            {
                Console.WriteLine("Line 5 a is either greater than or equal to b");
            }

            Console.ReadLine();
        }
    }
}