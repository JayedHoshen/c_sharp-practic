// method of passing parameters by value
using System;

namespace calculatorApplication {
    class numberManipulator {
        public void swap (int x, int y) {
            int temp;

            temp = x;
            x = y;
            y = temp;

            // Console.WriteLine("Inner function, value of a: {0}", x);
            // Console.WriteLine("Inner function, vlaue of b: {0}", y);
        }

        static void Main(string[] args) {
            numberManipulator n = new numberManipulator();

            int a = 100;
            int b = 200;

            Console.WriteLine("Befor Swap, value of a: {0}", a);
            Console.WriteLine("Befor Swap, value of b: {0}\n", b);

            n.swap(a, b);

            Console.WriteLine("After swap, value of a: {0}", a);
            Console.WriteLine("After swap, value of b: {0}", b);

            Console.ReadLine();
        }
    }
}