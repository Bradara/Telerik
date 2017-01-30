using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = new DateTime(int.Parse(Console.ReadLine()),01,01);

            if (DateTime.IsLeapYear(year.Year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
            
        }
    }
}
