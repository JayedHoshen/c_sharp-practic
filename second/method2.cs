using System;

namespace calculatorApplication {
    class numberManipulator {
        public int findMax (int num1, int num2) {
            int result;
            if (num1 > num2) result = num1;
            else result = num2;
            return result;
        }
    }

    class test {
        static void Main(string[] args) {
            int a = 100;
            int b = 200;
            int ret;

            numberManipulator n = new numberManipulator();
            ret = n.findMax(a, b);
            Console.WriteLine("Max value is {0}", ret);
            Console.ReadLine();
        }
    }
}