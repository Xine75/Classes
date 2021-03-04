using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            DateTime founded = new DateTime(1999, 12, 1);
            Company CatsInc = new Company("Cats Inc.", founded);

            // Create three employees
            Employee lemon = new Employee()
            {
                FirstName = "Liz",
                LastName = "Lemon",
                Title = "Perimeter Specialist",
                StartDate = new DateTime(2020, 3, 12)

            };
            Employee loretta = new Employee()
            {
                FirstName = "Loretta",
                LastName = "Dink",
                Title = "Sunlight Analyst",
                StartDate = new DateTime(2012, 4, 2),

            };
            Employee birdie = new Employee()
            {
                FirstName = "Birdie",
                LastName = "Doza",
                Title = "Miinister of Napping",
                StartDate = new DateTime(2001, 5, 18),

            };
            List<Employee> assignEmployees = new List<Employee>()
            {
                birdie, lemon, loretta
            };
            // Assign the employees to the company
            CatsInc.CurrentEmployees = assignEmployees;

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employee cat in CatsInc.CurrentEmployees)
            {
                Console.WriteLine($"{cat.FirstName} {cat.LastName} works for {CatsInc.Name} as {cat.Title} since {cat.StartDate} ");
            }



        }
    }
}