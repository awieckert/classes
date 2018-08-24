using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Company BurgerHut = new Company("BurgerHut", DateTime.Now);
            Employee randel = new Employee("Randel", "Lames", "Manager", DateTime.Now);
            Employee eddy = new Employee("Eddy", "McMan", "Fry Master", DateTime.Now);
            Employee linda = new Employee("Linda", "Looney", "Burger Wizard", DateTime.Now);

            BurgerHut.Employees.Add(randel);
            BurgerHut.Employees.Add(eddy);
            BurgerHut.Employees.Add(linda);

            BurgerHut.ListEmployees();


        }
    }
}
