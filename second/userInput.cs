using System;

namespace Sample{
    class program{
        static void Main(string[] args) {
            string testString;
            Console.Write("Enter a string -- ");
            testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
            Console.ReadKey();
        }
    }
}