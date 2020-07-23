using System;
namespace nestedifelse {
    class ifelseNested
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
            }
            Console.WriteLine("Exact value of a is: {0}", a);
            Console.WriteLine("Exact value of b is: {0}", b);
            Console.ReadKey();
        }
    }
}