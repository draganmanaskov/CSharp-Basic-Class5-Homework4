using System;
using Task2.Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = GetUserInput();

            int.TryParse(userInput[2], out int age);

            Human user = new Human(userInput[0], userInput[1], age);

            Console.WriteLine(user.GetPersonStats());
        }

        private static string[] GetUserInput()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age");
            string age = Console.ReadLine();

            if(!int.TryParse(age, out int ageParsed))
            {
                age = "0";
            }

            return new string[] { firstName, lastName, age };
        }
    }
}
