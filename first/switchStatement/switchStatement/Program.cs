using System;
namespace switchStatement{
    class switchcase {
        public static void Main(string[] args) {
            char ch;

            Console.Write("Enter an alphabet:");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch)) { 
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel\n");
                    break;
                default:
                    Console.WriteLine("Consonent or Not any letter");
                    break;
            }
            Console.ReadKey();
        }
    }
}