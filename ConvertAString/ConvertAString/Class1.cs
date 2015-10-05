using System;

namespace ConvertAString
{
    /// <summary>
    /// simple program for getting a string input from the user and converting to lower case.
    /// </summary>
    class StringConverter
    {
        static void Main()
        {
            bool ans = true;

            while (ans)
            {
                /// Gets user input.
                Console.WriteLine("Enter a string.  I will convert all the letters to lower case.");
                string arg = Console.ReadLine();
                
                /// Initializes an instance of the LowerCase class and calls the ConvertToLower method.
                LowerCase lowerit = new LowerCase();
                string newString = lowerit.ConvertToLower(arg);
                
                ///Output
                Console.WriteLine("The converted string is : \"{0}\"", newString);
                
                /// Block to determine if the user would like to convert another string.
                Console.WriteLine("Convert another?");
                string Ans = Console.ReadLine();
                if (Ans == "Y" || Ans == "y")
                    {
                        ans = true;
                    }
                else ans = false;
            }
        }

    }

    class LowerCase
    {
        /// <summary>
        /// This is the method that converts and returns the string to lower case
        /// </summary>
        public string ConvertToLower(string arg)
        {
            string newString = arg.ToLower();
            return newString;
        }
        
    }
}
