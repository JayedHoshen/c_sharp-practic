// method of passing parameters by output
using System;

namespace calculatorApplication {
    class numberManipulator {
        public void getValues (out int x, out int y) {
            Console.Write("Enter the first value= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second value= ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args) {
            numberManipulator n = new numberManipulator();
            int a, b;

            n.getValues(out a, out b);

            Console.WriteLine("After method call, value of a: {0}", a);
            Console.WriteLine("After method call, value of b: {0}", b);

            Console.ReadLine();
        }
    }
}