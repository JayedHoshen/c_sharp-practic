using System;
namespace ifelse_elseif{
    class elseifelse{
        public static void Main(string[] args){
            int number = 12;

            if(number < 5) {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if(number > 5){
                Console.WriteLine("{0} is greater than 5", number);
            }
            else{
                Console.WriteLine("{0} is equal to 5", number);
            }
            Console.WriteLine("This statement is always executed");
            Console.ReadKey();
        }    
    }
}