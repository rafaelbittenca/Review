using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelex
{
    public static class OddNumber
    {
        public static void ShowOddNumber(int number)
        {
            Console.WriteLine(string.Format("Odd numbers from 1 to {0}. Prints one number per line.", number));
            for (int n = 1; n < (number + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
    }
}
