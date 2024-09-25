using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool is_leap_year = false;
                Console.Write("Input year's number: ");
                int year = int.Parse(Console.ReadLine());
                
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    is_leap_year = true;
                }

                if (is_leap_year)
                {
                    Console.WriteLine("Year {0} is a leap year!", year);
                }
                else
                {
                    Console.WriteLine("Year {0} is not a leap year...", year);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

        }
    }
}
