
using KabalaCompany.DataAccess;
using KabalaCompany.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabalaCompany.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Update d'un nouvel employee en cours");

            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

            //employeeDataAccess.Add(new Employee()
            //{
            //    FirstName = "Jean",
            //    LastName = "Darsen",
            //    PreferedName = "Jean Dars",
            //    DateOfBirth = new DateTime(1994, 8, 9),
            //    Email = "jean.dars@kabalacompany.com",
            //    HiredDate = new DateTime(2018, 5, 10)
            //});

            employeeDataAccess.Update(1, new Employee() { FirstName = "Henock" });

            Console.WriteLine("Update effectué avec succès");
            Console.ReadKey();

        }
    }
}
