using System;

namespace whileLoop {
    class whileStatement {
        static void Main(string[] args) {
            int i = 1;

            while (i <= 5) {
                Console.WriteLine("C# while loop: Iteration {0}", i);
                i++;
            }
        }
    }
}