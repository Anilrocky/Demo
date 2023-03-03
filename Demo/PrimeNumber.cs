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
            for(int i=0; i<=100; i++)
            {
                for (int j=2; j<=i/2; j++)
                {
                    if (i%j == 0) 
                    {
                        Console.WriteLine(i + " is not prime");
                        break;
                    }
                }
                Console.WriteLine(i + " is prime");
            }
        }
    }
}
