using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter English Score: ");
            string englishScoreWriteString = Console.ReadLine();
            int englishScore = Convert.ToInt32(englishScoreWriteString);
            string result = String.Empty;
            if (englishScore > 100 || englishScore < 0)
            {
                result = "Score should be 0 to 100";
            }
            else if (englishScore >= 50)
            {
                result = "Congratulations, you have passed";
            }
            else
            {
                result = "Sorry, you have failed";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
