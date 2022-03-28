using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string fNAme, string lNAme , int age)
        {
            this.FirstName = fNAme;
            this.LastName = lNAme;
            Age = age;
        }

        public string GetPersonStats()
        {
            return $"Full Name: {FirstName} {LastName} Age: {Age}";
        }
    }
}
