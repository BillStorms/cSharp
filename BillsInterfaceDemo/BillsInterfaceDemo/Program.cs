using System;

namespace BillsInterfaceDemo
{
    /// <summary>
    /// This is the interface describing a simple method to expose.
    /// </summary>
    public interface IMathIt
    {
        void MathIt();
    }
    #region Main Program Class
    /// <summary>
    /// This will be the class containing my main method.
    /// </summary>
    class Program
    {
        // Main method simply calls the MenuItems method.
        private static void Main()
        {
            MenuItems();
        }

        // Gives the user a short menu with choice to determine age in dog years or year of birth.
        private static void MenuItems()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the age game.");
            Console.WriteLine("(1) for your age in dog years.");
            Console.WriteLine("(2) to learn what year you were born.");
            Console.Write("-> ");

            string ans = Console.ReadLine();
            if (ans == "1")
            {
                DogMath dogmath = new DogMath();
                dogmath.MathIt();
            }
            else if (ans == "2")
            {
                YearYouWereBorn dobMath = new YearYouWereBorn();
                dobMath.MathIt();
            }
            else
            {
                Console.WriteLine("Please try again.");
                MenuItems();
            }

            Console.WriteLine("Again?");
            ans = Console.ReadLine();
            if (ans == "Y" || ans == "y")
            {
                MenuItems();
            }
            else
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }
        }
    }
    #endregion

    #region [Dog Math Class]

    /// <summary>
        /// This class containes methods for calculating the your age in dog years.
        /// </summary>
        class DogMath : IMathIt
        {
            public void MathIt()
            {
                // Variables to hold the age value returned from the Calculate method and the string we'll convert it to.
                string ageString;
                int age;

                // Triggers the method for obtaining your age and then converts the result to a string for output. 
                BirthdayInformation bdInfo = new BirthdayInformation();
                ageString = bdInfo.GetAge();
                age = Int32.Parse(ageString);
                Console.WriteLine(("You are {0} years old in dog years!"), Calculate(age));
            }

            // Private method to calculate your age in dog years.
            private string Calculate(int age)
            {
                decimal dogYears = age/7.0m;
                string dogYearsString = dogYears.ToString("F");  // This formats the string to show two decimal places. 
                return dogYearsString;
            }
        }
    
        #endregion

    #region Year You Were Born Class

        /// <summary>
        /// This class contains methods for calculating what year you were born in based on your age. 
        /// </summary>

        class YearYouWereBorn : IMathIt
        {
            // Reference to interface method
            public void MathIt()
            {
                string ageString;
                int age;
                bool BeforeAfter;
                string year;

                BirthdayInformation bdInfo = new BirthdayInformation();
                ageString = bdInfo.GetAge();
                age = Int32.Parse(ageString);

                BeforeAfter = bdInfo.HaveYouHadYourBirthday();
                if (BeforeAfter)
                {
                    year = CalculateAfter(age);
                }
                else
                    year = CalculateBefore(age);

                Console.WriteLine(("You were born in the year {0}."), year);
                
            }

            // Calculates the year you we born if you haven't had your birthday yet this year.
            private string CalculateBefore(int age)
            {
                string YearOfBirth;
                int YOB;

                YOB = 2014 - age;
                YearOfBirth = YOB.ToString();
                return YearOfBirth;
            }

            // Calculates the year you were born if you have already had your birthday this year.
            private string CalculateAfter(int age)
            {
                string YearOfBirth;
                int YOB;

                YOB = 2015 - age;
                YearOfBirth = YOB.ToString();
                return YearOfBirth;
            }
        }
        #endregion

    #region Birthday Information Class

        /// <summary>
        /// This class holds the methods for obtaining your date of birth age and if you've had a birthday this year or not. 
        /// </summary>
        class BirthdayInformation
        {
            private string _ageString;
            private string _birthdayString;
            private bool _birthday;
            // Gets age from user input and returns the value as a string. 
            public string GetAge()
            {
                Console.Write("Please enter your age : ");
                _ageString = Console.ReadLine();
                return _ageString;
            }

            // Finds out if the user has had a birthday this year or not and returns a boolian value of true or false.
            public bool HaveYouHadYourBirthday()
            {
                Console.Write("Have you had your birthday yet this year? (Y/N)");
                _birthdayString = Console.ReadLine();
                if (_birthdayString == "Y" || _birthdayString == "y")
                {
                    _birthday = true;
                    return _birthday;
                }
                if (_birthdayString == "N" || _birthdayString == "n")
                {
                    return _birthday;
                }
                Console.WriteLine("Try again!");
                HaveYouHadYourBirthday();

                return _birthday;
            }
        }

        #endregion
}









