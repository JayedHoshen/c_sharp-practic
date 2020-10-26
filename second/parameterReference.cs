// method of passing parameters by reference
using System;

namespace calculatorApplication {
    class numberManipulator {
        public void swap (ref int x, ref int y) {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args) {
            numberManipulator n = new numberManipulator();

            int a = 100;
            int b= 200;

            Console.WriteLine("Befor swap, value of a: {0}", a);
            Console.WriteLine("Befor swap, value of b: {0}", b);

            n.swap(ref a, ref b);

            Console.WriteLine("\nAfter swap, value of a: {0}", a);
            Console.WriteLine("After swap, value of b: {0}", b);

            Console.ReadLine();
        }
    }
}