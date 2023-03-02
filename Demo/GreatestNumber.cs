using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class GreatestNumber
    {
        static int a = 20; static int b = 10; static int c = 35;
        static void Main(string[] args)
        {
            if ( (a > b) && (a > c) )
                {
                Console.WriteLine("a is greatest number");
                }
            else if (b > c)
            {
                Console.WriteLine("b is greatest number");
            }
            else
            {
                Console.WriteLine("c is the gratest number");
            }
        }
    }
}
