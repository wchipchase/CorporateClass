using System;
using System.Collections.Generic;

namespace CorporateClass
{
    public class Company
    {

        //Properties

        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees

        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        //Constructor for Employee List
        //private Company(List<Employee> employees)
        //{
        //    Employees = employees;
        //}

        List<Employee> CHEmployees = new List<Employee>();


        // Create a method that allows external code to add an employee

        public void AddEmployee()
        {

        }

        // Create a method that allows external code to remove an employee

        public void RemoveEmployee()
        {

        }


        static void Main(string[] args)
        {
            //GrassKisser Company
            Company GrassKisser = new Company("Chipchase Holdings", DateTime.Parse("02/19/2019"));


            //Employees
            Employee owner = new Employee("Wayne Chipchase", "CEO", DateTime.Parse("02/14/2020"));
            Employee developer = new Employee("Maggie Chipchase", "Best Dog", DateTime.Parse("05/15/2016"));
            Employee investor = new Employee("Patricia Reno", "Investor", DateTime.Parse("02/19/2019"));

            List<Employee> CHEmployees = new List<Employee>();
            CHEmployees.Add(owner);
            CHEmployees.Add(developer);
            CHEmployees.Add(investor);


            foreach (var employee in CHEmployees)
            {
                var Name = employee.Name;
                var Job = employee.JobTitle;
                var Start = employee.StartDate;

                Console.WriteLine(Name);
                Console.WriteLine(Job);
                Console.WriteLine(Start);
                Console.WriteLine("");
            }
        }
    }

}