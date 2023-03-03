using System;
namespace Project
{
    public class Factorial
    {
        public void FactorialOfNumber()
        {
            Console.WriteLine("Enter any Number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <=num; i++)
            {
                fact = fact* i;
            }
            Console.WriteLine($"Factorial of {num} is: {fact}");
            Console.ReadLine();
        }
    }
}
