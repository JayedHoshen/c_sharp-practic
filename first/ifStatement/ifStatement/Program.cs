using System;

namespace ifStatement {
    class ifStatementP {
        public static void Main(string[] args) {
            int number = 2;
            if (number < 5) {
                Console.WriteLine("{0} is less than 5\n", number);
            }
            Console.WriteLine("This statement is alaways executed");
            Console.ReadKey();
        }
    }
}