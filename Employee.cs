using System;
//all namespaces must match to give access of info between files
namespace Classes
{
    /*creating a custom type "Employee" with four properties. These properties
    will be used in Program.cs to create a employees
    */
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}

