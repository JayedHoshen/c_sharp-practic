using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace declaringMethod {
    class program {
        string name, city;
        int age;

        public void acceptdetails () {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your City: ");
            city = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void printdetails () {
            Console.Write("\n\n...........................");
            Console.Write("\nName: \t" + name);
            Console.Write("\nCity: \t" + city);
            Console.Write("\nAge: \t" + age);
            Console.Write("\n.............................\n");
        }

        static void Main(string[] args) {
            program p = new program();
            p.acceptdetails(); // calling method
            p.printdetails(); // calling method
            Console.ReadLine();
        }
    }
}