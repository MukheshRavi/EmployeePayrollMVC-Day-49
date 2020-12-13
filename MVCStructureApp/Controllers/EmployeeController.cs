using MVCStructureApp.Models;
using MVCStructureApp.Models.Common;
using MVCStructureApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStructureApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeViewModel> list = employeeRepository.GetEmployees();
            return View(list);
        } 
    }}