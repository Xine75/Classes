using System;
//this is necessary to access List class/type
using System.Collections.Generic;
//same Namespace across all files for data accessibility
namespace Classes
{
    /*creating a custom type "Company" with 2 properties. These properties
   will be used in Program.cs to create a company
   */
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> CurrentEmployees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created


            The constructor will set the value of the public properties
        */
        //constructor to create a company "object"
        public Company(string nameOfCompany, DateTime createdOn)
        {
            Name = nameOfCompany;
            CreatedOn = createdOn;

        }
    }
}
