using System;

namespace typeConversion {
    class program {
        static void Main(string[] args) {
            int num1 = 20000;
            int num2 = 50000;
            int num3 = 65;
            long total;
            char alpha;
            alpha = (char)num3;
            total = num1 + num2;
            Console.WriteLine($"Total is: {total}");
        }
    }
}
