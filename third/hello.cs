using System;

namespace helloPrint
{
    class printHello{
        public static void Main(string[] args) {
            string name;

            name = "12345";

            Console.WriteLine("Hello, {0}", name);
            Console.ReadKey();
        }
    }
}