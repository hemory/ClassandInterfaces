using System;
using ColumbiUniversitySample;

namespace ColumbiUniversitySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var addAnother = true;

            while (addAnother)
            {


                Console.WriteLine(" Do you want to add a (1) Person or a (2) Team Member?");
                var input = Convert.ToInt16(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter the new Persons First Name: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter the new Persons Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Enter the new Persons Email Address: ");
                    string emailAddress = Console.ReadLine();

                    Console.WriteLine("Enter the new Persons Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Person person = new Person(firstName, lastName, emailAddress, age);

                    if (person.IsOverEighteen(age))
                    {
                        person.AddPerson(person.FirstName, person.LastName, person.EmailAddress, person.Age);
                    }
                    else
                    {
                        Console.WriteLine("You have to be 18 to be on this list");
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter the new Team Members First Name: ");
                    string tmfirstName = Console.ReadLine();

                    Console.WriteLine("Enter the new Team Members Last Name: ");
                    string tmlastName = Console.ReadLine();

                    Console.WriteLine("Enter the new Team Members Email Address: ");
                    string tmemailAddress = Console.ReadLine();

                    Console.WriteLine("Enter the new Team Members Address: ");
                    string tmAddress = Console.ReadLine();

                    Console.WriteLine("Enter the new Team Members Age: ");
                    int tmAge = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the new Team Members Salary: ");
                    int tmSalary = int.Parse(Console.ReadLine());


                    TeamMember teamMember = new TeamMember(tmSalary, tmAddress, tmfirstName, tmlastName, tmemailAddress,
                        tmAge);

                    teamMember.AddTeamMember(tmfirstName, tmlastName, tmAge, tmemailAddress, tmSalary, tmAddress);
                }

                Console.WriteLine("Would you like to add another? y/n");
                var loop = Console.ReadLine();

                if (loop == "y".ToLower())
                {
                    addAnother = true;
                }
                else if (loop == "n".ToLower())
                {
                    addAnother = false;
                    Console.WriteLine("Goodbye");
                }
            }
        }
    }
}
