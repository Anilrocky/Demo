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
        static int a = 20; static int b = 10;
        static void Main(string[] args)
        {
            if (a > b)
                {
                Console.WriteLine("a is greater than b");
                }
            else
            {
                Console.WriteLine("b is greater than a");
            }
        }
    }
}
