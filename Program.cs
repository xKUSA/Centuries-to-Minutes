using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Centuries: ");
                double centuries = Convert.ToDouble(Console.ReadLine());
                double years = centuries * 100;
                double days = years * 365;
                double hours = days * 24;
                double minutes = hours * 60;
                double seconds = minutes * 60;
                Console.WriteLine("Centuries {0}, Years {1}, Days {2}, Hours {3}, Minutes {4}, Seconds {5} ", centuries, years, days, hours, minutes, seconds);
            }
            catch
            {
                Console.WriteLine("MAKE SURE THAT YOU TYPED CORRECT NUMBER");
            }
        }        
    }
}

