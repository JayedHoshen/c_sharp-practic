using System;

namespace nestedloop {
    class nestedLoopStatement {
        internal static void Main(string[] args) {
            int outerLoop = 0, innerLoop = 0;
            
            for (int i = 1; i <= 5; i++) {
                outerLoop ++;

                for (int j = 1; j <= 5; j++) {
                    innerLoop ++;
                }
            }

            Console.WriteLine("Outer loop runs {0} times", outerLoop);
            Console.WriteLine("Inner loop runs {0} times", innerLoop);
        }
    }
}