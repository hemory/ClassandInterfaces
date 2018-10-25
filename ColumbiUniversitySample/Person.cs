using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbiUniversitySample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public bool Adult { get; set; }

        public Person(string firstName, string lastName, string emailAddress, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Age = age;
        }

        public bool IsOverEighteen(int age)
        {
            if (age >= 18)
            {
                Adult = true;
            }

            return Adult;
        }

        public void AddPerson(string firstName, string lastName, string emailAddress, int age)
        {
            List<Person> list = new List<Person>
            {
                new Person(firstName, lastName, emailAddress, age)
            };
            List<Person> people = list;

            foreach (Person person in people)
            {
                Console.WriteLine($"Person First Name: {person.FirstName} Person Last Name: {person.LastName} Person Email Address: {person.EmailAddress} Person Age: {person.Age}");
            }
        }
    }
}

