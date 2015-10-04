using System;
using System.Collections.Generic;

namespace SumofPrimeNumbersChallenge
{
    internal class Program
    {
        private static void Main()
        {
            string num1String;

            int num1;
            List<string> primeNumbers = new List<string>();

            for (int i = 2; i < 1000; i++)
            {
                num1 = i;

                {
                    for (int a = 2; a <= num1/2; a++)
                    {
                        if (num1%a == 0)
                        {
                            return;
                        }
                        num1String = num1.ToString();
                        primeNumbers.Add(num1String);
                    }
                }
            }

            Console.WriteLine(primeNumbers);
            Console.ReadLine();
        }
    }   
}





