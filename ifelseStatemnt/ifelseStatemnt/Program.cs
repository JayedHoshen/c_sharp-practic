using System;
namespace ifelse {
    class ifelseStatement {
        public static void Main(string[] args) {
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5\n", number);
            }
            else {
                Console.WriteLine("{0} is greater than or equal to 5\n", number);
            }
            Console.WriteLine("This statement is always ececuted");
            Console.Read();
        }
    }
}