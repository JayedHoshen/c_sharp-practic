using System;

namespace stringApplication {
    class program {
        static void Main(string[] args) {
            // form string literal and string concatenation
            string fname, lname;
            fname = "Roman"; // literal
            lname = "Atkinson";

            char []letters = {'H', 'e', 'l', 'l', 'o'};
            string []sarray = {"Hello", "From", "Tutorials", "Point"};

            string fullname = fname + lname; // concatenation
            Console.WriteLine("Full name: {0}", fullname);

            // by using string constructor 
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            // methods returning string
            string message = string.Join(", ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2020, 10, 17, 12, 25, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            Console.ReadKey();
        }
    }
}