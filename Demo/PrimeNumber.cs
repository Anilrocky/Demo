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
                        Console.WriteLine("is not prime " + i);
                        break;
                    }
                }
                Console.WriteLine("is prime" + i);
            }
        }
    }
}
