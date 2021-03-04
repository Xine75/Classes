using System;
//necessary for List type/class
using System.Collections.Generic;
//same namespace across files
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting variable to hold the company founded DateTime(YYYY, MM, DD)
            DateTime founded = new DateTime(1999, 12, 1);
            //Creating instance of a new company called CatsInc with founded date above
            Company CatsInc = new Company("Cats Inc.", founded);

            // Create three employees - these use the properties created in Employee.cs
            Employee lemon = new Employee()
            {
                FirstName = "Liz",
                LastName = "Lemon",
                Title = "Perimeter Sweeper",
                StartDate = new DateTime(2020, 3, 12)

            };
            Employee loretta = new Employee()
            {
                FirstName = "Loretta",
                LastName = "CatWife",
                Title = "Sunlight Analyst",
                StartDate = new DateTime(2012, 4, 2),

            };
            Employee birdie = new Employee()
            {
                FirstName = "Birdie",
                LastName = "Doza",
                Title = "Minister of Naps",
                StartDate = new DateTime(2001, 5, 18),

            };
            //Assigning employees to company using List type/class and calling it assignEmployees
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
                Console.WriteLine($"{cat.FirstName} {cat.LastName} works for {CatsInc.Name} as {cat.Title} since {cat.StartDate.ToString("d")} ");
            }



        }
    }
}