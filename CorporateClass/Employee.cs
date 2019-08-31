using System;
using System.Collections.Generic;

namespace CorporateClass
{
    public class Employee
    {
        //Properties
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        //Fields
        //Constructor
        public Employee(string name, string jobTitle, DateTime startDate)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
        //Methods
        public string GetName(string employeeName)
        {
            return $"Name: {employeeName}";
        }

        public string GetJobTitle(string employeeJob)
        {
            return $"Job Title: {employeeJob}";
        }

        public string GetStartDate(string employeeStartDate)
        {
            return $"Start Date: {employeeStartDate}";
        }
    }
}