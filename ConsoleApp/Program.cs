using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to fibonnaci method \n");
            Console.WriteLine("Enter the number to compute :");
            string value = Console.ReadLine();
            int number = 0;

            try
            {
                if (value != "")
                {
                    var isnumeric = Int32.TryParse(value, out int n);
                    number = n;
                    long result = WSChallenge.WebService.Fibonnaci(number);
                    Console.WriteLine("The result is : " + result);
                }
                else
                {
                    Console.WriteLine("Enter a number please");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine(); 
        }
    }
}
