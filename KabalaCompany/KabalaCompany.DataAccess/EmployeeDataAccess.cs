using System;
using System.Linq;
using KabalaCompany.DataEntities;
using KabalaCompany.DataEntities;
using System.Reflection;

namespace KabalaCompany.DataAccess
{
    public class EmployeeDataAccess : BaseDataAccess<Employee>
    {
        public Employee FindById(int id)
        {
            using (DbContext)
            {
                //var employeeEntity = (from employee in DbContext.Employee
                //                      where employee.Id == id
                //                      select employee).FirstOrDefault();

                return DbContext.Employee.
                    FirstOrDefault(x => x.Id == id);
            }
        }

    }
}
