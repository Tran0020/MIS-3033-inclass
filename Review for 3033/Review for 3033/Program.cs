using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_for_3033
{
    class Program
    {
        static void Main(string[] args)
        {//You are a judge at a olympic weightlifting competition. In order for athletes to advance to the next round in the "clean and jerk" competition, they must lift a minimum of 275lbs. 
            // You are given the weights in kilograms. You need to convert the weights from kilograms to pounds to determine if the athletes qualify for the next round. If an athlete is able to lift 400lbs,
            //they automatically advance to the final round. 


            double kg = 0.00;
            double lbs = 0.00;

            Console.WriteLine("Please enter the amount lifted in kilograms.");
            kg = Convert.ToDouble(Console.ReadLine());
            lbs = kg * 2.2;
            Console.WriteLine($"There is {lbs} pounds in {kg} kilograms. ");

            if (lbs >= 400)
            {
                Console.WriteLine("The athlete advances to the final round.");
            }else if (lbs >= 275||lbs<400)
            {
                Console.WriteLine("The athlete advances to the next round.");

            }else
            {
                Console.WriteLine("The athelete didn't advance to the next round.");
            }

            Console.ReadKey();
        }
    }
}
