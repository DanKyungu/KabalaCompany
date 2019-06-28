
using KabalaCompany.DataAccess;
using KabalaCompany.DataEnties;
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
            Console.WriteLine("Enregistrement d'un nouvel employee en cours");

            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();

            employeeDataAccess.Add(new Employee()
            {
                FirstName = "Alex",
                LastName = "Maxwel",
                PreferedName = "Alexis Max",
                DateOfBirth = new DateTime(1992, 5, 23),
                Email = "alex.max@kabalacompany.com",
                HiredDate = new DateTime(2014, 8, 12)
            });

            Console.WriteLine("Enregistrement effectué avec succès");
            Console.ReadKey();

        }
    }
}
