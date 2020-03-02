using System;

namespace leargestNumber{
    class threeLeargestNumber{
        public static void Main(string[] args){
            // declaretion
            int num1, num2, num3;
            // input three numbers
            Console.WriteLine("Enter three value that calculate largest number.");
            Console.Write("\nEnter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            // condition
            if (num1 > num2 && num1 > num3) {
                Console.WriteLine("\nFirst number {0} is lergest number.", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("\nSecond number {0} is lergest number.", num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("\nThird number {0} is lergest number.", num3);
            }
            else {
                Console.WriteLine("\nNumbers {0} are Equal.");
            }
         
            Console.ReadKey();
        }
    }
}