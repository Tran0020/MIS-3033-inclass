using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Adam";
            int counter = 0;
            string wordwithhyphens=string.Empty;
            while (counter < word.Length)
            {
                if (counter == word.Length - 1)
                {
                    Console.Write(word[counter] );
                    wordwithhyphens += word[counter] ;
                }
                else
                {
                    Console.Write(word[counter] + "-");
                    wordwithhyphens += word[counter] + "-";
                }
                //Console.Write(word[counter] + "-");
               // wordwithhyphens += word[counter] + "-";
                //wordwithhyphens = wordwithhyphens + word[counter] + "-";
                counter++;
            }
            for(int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine("\n" + wordwithhyphens);
            Console.ReadKey();
        }
    }
}
