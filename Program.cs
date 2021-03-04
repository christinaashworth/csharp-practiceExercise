using System;
using System.Collections.Generic;

namespace Classes
{

  
    class Program
    {
        static void Main(string[] args)
        {
        // Create an instance of a company. Name it whatever you like.
          Company BluthsBananaStand = new Company("Bluth's Banana Stand", Convert.ToDateTime("01/01/2001"));
        // Create three employees
          Employee georgeMichael = new Employee()
          {
            FirstName = "George Michael",
            LastName = "Bluth",
            Title = "manager",
            StartDate = Convert.ToDateTime("01/01/2001")
          };
          Employee maeby = new Employee()
          {
            FirstName = "Maeby",
            LastName = "Funke",
            Title = "banana salesperson",
            StartDate = Convert.ToDateTime("01/01/2001")
          };
          Employee annyong = new Employee()
          {
            FirstName = "Annyong",
            LastName = "Annyong",
            Title = "Annyong",
            StartDate = Convert.ToDateTime("01/01/2001")
          };

        // Assign the employees to the company
          BluthsBananaStand.Employees.Add(georgeMichael);
          BluthsBananaStand.Employees.Add(maeby);
          BluthsBananaStand.Employees.Add(annyong);
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        BluthsBananaStand.ListEmployees();
        }
    }
}
