using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace callingMethod {
    class print {
        public static void printName () {
            Console.WriteLine("Md. Jayed Hoshen");
            Console.ReadLine();
        }
    }

    class program {
        static void Main(string[] args) {
            print.printName();
        }
    }
}