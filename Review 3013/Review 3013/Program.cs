using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3013
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz Buzz conditional question

            string FirstName = "Sam";

            if (FirstName.Length % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }else if (FirstName.Length % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("Fizzbuzz");
            }

            Console.ReadKey();
        }
    }
}
