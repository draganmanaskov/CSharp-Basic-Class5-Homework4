using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] birthDate = DateOfBirth();

            if(birthDate.Length == 0)
            {
                return;
            }

            AgeCalculator(birthDate);
        }

        private static void AgeCalculator(int[] birthDate)
        {
            DateTime yourBirthday = new DateTime(birthDate[2], birthDate[1], birthDate[0]);

            DateTime currentDay = DateTime.Today;

            //not totaly accurate, just a simplified version
            int age = currentDay.Year - yourBirthday.Year;

            if(age > 0)
            {
                Console.WriteLine($"You are {age} old");
            }
            else
            {
                Console.WriteLine($"You are not born yet");
                return;
            }

            if(yourBirthday.Month == currentDay.Month && yourBirthday.Day == currentDay.Day)
            {
                Console.WriteLine("Happy Birthday");
            }
         
        }

        public static int[] DateOfBirth()
        {
            Console.WriteLine("Enter your full birth date. example 19.3.2000");

            string dateOfBirth = Console.ReadLine();

            string[] splited = dateOfBirth.Split('.');

            if(splited.Length != 3)
            {
                Console.WriteLine("Invalid Input");
                return new int[0];
            }

            bool isValidParseOne = int.TryParse(splited[0], out int birthDay);
            bool isValidParseTwo = int.TryParse(splited[1], out int birthMonth);
            bool isValidParseThree = int.TryParse(splited[2], out int birthYear);

            if (!isValidParseOne || !isValidParseTwo || !isValidParseThree)
            {
                Console.WriteLine("Invalid Input");
                return new int[0];
            }

            if(birthDay > 31)
            {
                Console.WriteLine("Invalid day of month");
                return new int[0];
            }

            if(birthMonth > 12)
            {
                Console.WriteLine("Invalid month");
                return new int[0];
            }

            return new int[] { birthDay, birthMonth, birthYear };
        }
    }
}
