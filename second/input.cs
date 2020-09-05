using System;

namespace Sample
{
    class input
    {
        public static void Main(string[] agrs)
        {
            int userInput;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Input using Read () -- ");
            userInput = Console.Read();
            Console.WriteLine("Ascii Value = {0}", userInput);
            Console.ReadKey();
        }
    }
}