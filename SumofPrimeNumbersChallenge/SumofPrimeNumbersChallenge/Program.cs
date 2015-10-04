using System;
using System.Collections.Generic;
using System.Threading;

namespace SumofPrimeNumbersChallenge
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            int primeCount = 1;
            int sum = 0;
            bool isPrime = true;
            int i = 2;

            Console.WriteLine("Prime Numbers : ");
            while (primeCount <= 1000)
            {
               
                bool primeResult;
                IsPrime testPrime = new IsPrime();
                primeResult = testPrime.isPrimeNumber(i);

                if (primeResult)
                {
                    primeCount ++;
                    sum = sum + i;
                }
                
                i++;
            }
            Console.WriteLine("The sum of the first 1000 prime numbers is {0}.", sum);
            Console.ReadKey();
        }
    }

    class IsPrime
    {
        public bool isPrimeNumber(int number)
        {
            for (int j = 2; j <= number/2; j++)
            {
                if (number != j && number % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}






