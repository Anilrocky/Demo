using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            int a=13;
            for (int i = 2; i <= a/2; i++)
            { 
                if (a%i == 0)
                {
                    Console.WriteLine("a is not prime number");
                }
                break;
            }
            Console.WriteLine("a is prime number");
        }
    }
}
