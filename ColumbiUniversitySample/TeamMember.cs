using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbiUniversitySample
{
    public class TeamMember : Person
    {
        public float Salary { get; set; }
        public string Address { get; set; }

        public TeamMember(float salary, string address, string firstName, string lastName, string emailAddress, int age) : base(firstName, lastName, emailAddress, age)
        {
            Salary = salary;
            Address = address;
        }

        public void AddTeamMember(string firstName, string lastname, int age, string emailAddress, float salary,
            string address)
        {
            List<TeamMember> teamMembers =
                new List<TeamMember> { new TeamMember(salary, address, firstName, lastname, emailAddress, age) };

            foreach (var teamMember in teamMembers)
            {
                Console.WriteLine($"First Name: {teamMember.FirstName} Last Name: {teamMember.LastName} Email Address: {teamMember.EmailAddress}");
            }


        }
    }
}
