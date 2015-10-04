using System;
using System.Collections.Generic;

namespace SumofPrimeNumbersChallenge
{
     class Program
    
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
                if (isPrime)
                {
                    sum = sum + i;
                }
                isPrime = true;
            }
            Console.WriteLine("The sum of all prime numbers under 1000 is {0}.", sum);
            Console.ReadKey();
        }
    }
}





