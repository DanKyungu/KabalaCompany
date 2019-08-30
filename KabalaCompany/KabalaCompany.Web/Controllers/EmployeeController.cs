using KabalaCompany.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KabalaCompany.Web.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDataAccess employeeDataAccess;

        public EmployeeController()
        {
            employeeDataAccess = new EmployeeDataAccess();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            var employees = employeeDataAccess.GetAll();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }
}