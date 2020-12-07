using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine("Result : " + result);

            // ASCII value convertion here
            Console.Write("Please enter any character that print ASCII value: ");
            char ch = Convert.ToChar(Console.Read());
            int chAscii = ch;

            Console.WriteLine("ASCII value is " + chAscii);

            Console.ReadKey();
        }
    }
}
