using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinqQuery
{
    #region Developers Class

    /// <summary>
    /// This is a class to hold attributes for the developers.
    /// </summary>
    public class Developers
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string SecretSkill { get; set; }
    }

    #endregion

    #region Main Program Class
    /// <summary>
    ///  Main program class for querying the data and then printing it to the screen.
    /// </summary>
    public class Program
    {
        // Method for entering data into the list of developers. Returns a list of type Developers
        public static List<Developers> GetDevelopers()
        {
            return new List<Developers>  
            {
                new Developers // Creates a new instance of type Developers and inserts data into its members.
                {
                    Name = "Adam Sprich",
                    Title = "Superboy",
                    SecretSkill = "Magnetism",
                },

                new Developers
                {
                    Name = "Mathew Stephens",
                    Title = "Screen Scraper Guy",
                    SecretSkill = "Shushing",
                },

                new Developers
                {
                    Name = "Reuben Otero",
                    Title = "Sandwich",
                    SecretSkill = "BreakDancing",
                }
            };
        }

        // Method for querying the data from the List source.
        public static void LinqMethod()
        {
            List<Developers> developerInfo = new List<Developers>(GetDevelopers());

            IEnumerable<Developers> devResults =
                from devs in developerInfo
                select devs;

            Console.WriteLine("\nQuerying the Dev Dataset\n");
            Console.WriteLine("-------------------\n");

            foreach (Developers devs in devResults)
            {
                Console.WriteLine("Name: {0} \nTitle: {1}\nSecret Skill: {2}\n", devs.Name, devs.Title, devs.SecretSkill);
            }
            Console.WriteLine("Hit any key to continue.");
            Console.ReadLine();
        }

        // Main method.  Simply calls the Linq Method. 
        static void Main()
        {
            LinqMethod();
        }
    }
    #endregion
}