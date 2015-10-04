using System;
using System.Collections.Generic;
using System.Threading;

namespace SumofPrimeNumbersChallenge
{
    /// <summary>
    /// Code challenged to print the sum of the first 1000 primes numnber.
    /// </summary>
    internal class Program

    {
        private static void Main(string[] args)
        {
            int primeCount = 1;
            int sum = 0;
            bool primeResult;
            int i = 2;
            
            while (primeCount <= 1000)
            {
                IsPrime testPrime = new IsPrime();
                primeResult = testPrime.isPrimeNumber(i);

                /// If the number is prime it is added to the sum and the counter goes up by one.
                
                if (primeResult)
                {
                    primeCount ++;
                    sum = sum + i;
                }
                
                i++;
            }
            
            /// Output.
            Console.WriteLine("The sum of the first 1000 prime numbers is {0}.", sum);
            Console.ReadKey();
        }
    }

    /// <summary>
    /// This class contains the method for determining if the input number is prime or not and returns a bool value of true or false.
    /// </summary>
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






