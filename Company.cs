using System;
using System.Collections.Generic;

namespace Classes
{
  public class Company
  {
    public Company(string name, DateTime createdOn) {
      Name = name;
      CreatedOn = createdOn;
      Employees = new List<Employee>();
    }
    public string Name { get; }
    public DateTime CreatedOn { get; }
    public List<Employee> Employees { get; } 
    public void ListEmployees()
    {
      foreach (Employee Employee in Employees)
      {
        Console.WriteLine($"{Employee.FirstName} {Employee.LastName} works for {Name} as {Employee.Title} since {Employee.StartDate}");
      }
    }
  }
}
