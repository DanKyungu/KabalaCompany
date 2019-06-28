using System;
using System.Linq;
using KabalaCompany.DataEnties;
using KabalaCompany.DataEntities;
using System.Reflection;

namespace KabalaCompany.DataAccess
{
    public class EmployeeDataAccess : BaseDataAccess, IDataAccess<Employee>
    {
        public void Add(Employee entity)
        {
            using (DbContext)
            {
                DbContext.Employee.Add(entity);
                DbContext.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (DbContext)
            {
                DbContext.Employee.Remove(entity);
                DbContext.SaveChanges();
            }
        }

        public Employee Update(Employee entity)
        {
            using (DbContext)
            {
                var currentEmployee = DbContext.Employee
                    .FirstOrDefault(x => x.Id == entity.Id);

                currentEmployee = entity;
                DbContext.SaveChanges();

                return currentEmployee;
            }
        }

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
