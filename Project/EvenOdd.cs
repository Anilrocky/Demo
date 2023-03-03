using System;
namespace Project
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter any Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine(num + " is Even");
            }
            else
            {
                Console.WriteLine(num + " is Odd");
            }
        }
    }
}