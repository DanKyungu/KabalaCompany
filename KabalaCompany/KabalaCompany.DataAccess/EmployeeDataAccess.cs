using System;
using System.Linq;
using KabalaCompany.DataEntity;

namespace KabalaCompany.DataAccess
{
    public class EmployeeDataAccess
    {
        private KabalaCompanyContext KabalaCompanyContext;

        public EmployeeDataAccess()
        {
            KabalaCompanyContext = new KabalaCompanyContext();
        }

        public void Add(Employee employee)
        {
            using (KabalaCompanyContext)
            {
                KabalaCompanyContext.Employee.Add(employee);
                KabalaCompanyContext.SaveChanges();
            }
        }

        public void Delete(Employee employee)
        {
            using (KabalaCompanyContext)
            {
                KabalaCompanyContext.Employee.Remove(employee);
                KabalaCompanyContext.SaveChanges();
            }
        }

        public void Update(Employee employee)
        {
            using (KabalaCompanyContext)
            {
                KabalaCompanyContext.Employee.Update(employee);
                KabalaCompanyContext.SaveChanges();
            }
        }

        public Employee FindById(int id)
        {
            using (KabalaCompanyContext)
            {
                //var employeeEntity = (from employee in KabalaCompanyContext.Employee
                //                      where employee.Id == id
                //                      select employee).FirstOrDefault();

                return KabalaCompanyContext.Employee.
                    FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
