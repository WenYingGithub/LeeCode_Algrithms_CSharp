using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Programs
    {
        static void Main()
        {
            Console.WriteLine("Input the Problem Number to begin: \r\n\r\n Problem Number : ");

            int problemNumber = Convert.ToInt32( Console.ReadLine());

            string outPut = "";

            switch (problemNumber)
            {
                case 349:
                    Solutions hi = new Solutions();
                    outPut = hi.hrrrr();
                    break;

                default:
                    outPut = "The End";
                    break;

            }
            Console.WriteLine("\r\n\r\nResult: " + outPut);
            Console.ReadKey();
        }

    }

    public class Solutions
    {
        public string hrrrr()
        {
            return "hhh";
        }
    }
}
