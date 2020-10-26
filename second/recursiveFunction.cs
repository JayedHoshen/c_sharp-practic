using System;

namespace calculateFactorials {
    class numberManipulator {
        public int factorial (int num) {
            int result;

            if (num == 1) return 1;
            else {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args) {
            numberManipulator f = new numberManipulator();
            
            // calling the factorial method
            Console.WriteLine("Factorial of 6 is : {0}", f.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", f.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", f.factorial(8));

            Console.ReadLine();
        }
    }
}