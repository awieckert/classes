using System;
using System.Collections.Generic;

namespace classes
{
  public class Company
  {

        // Create a public property for holding a list of current employees

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public DateTime DateFounded {get;}

    public string CompanyName {get;}

    public List<Employee> Employees {get; set;}

    public Company (string name, DateTime createdOn)
    {
      CompanyName = name;
      DateFounded = createdOn;
    }

    public void ListEmployees ()
    {
      foreach (Employee employee in this.Employees)
      {
          Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {this.CompanyName} as a {employee.Title} since {employee.StartDate}");
      }
    }

  }
}