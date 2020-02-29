using System;

namespace constant {
    class testCons {
        public static void Main(string[] args) {
            const double pi = 3.14159; // Constant Declaration
            double r;
            Console.Write("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadKey();
        }
    }
}