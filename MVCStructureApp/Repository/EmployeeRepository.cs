using MVCStructureApp.Models;
using MVCStructureApp.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStructureApp.Repository
{
    public class EmployeeRepository
    {
        EmployeeContext dbContext = new EmployeeContext();
        public List<EmployeeViewModel> GetEmployees()
        {
            try
            {
                List<EmployeeViewModel> list = (from e in dbContext.Employees
                                                join d in dbContext.Departments on e.DepartmentId equals d.DeptId
                                                join s in dbContext.Salaries on e.SalaryId equals s.SalaryId
                                                select new EmployeeViewModel
                                                {
                                                    EmpId = e.EmpId,
                                                    Name = e.Name,
                                                    Gender = e.Gender,
                                                    DepartmentId = d.DeptId,
                                                    Department = d.DeptName,
                                                    SalaryId = s.SalaryId,
                                                    Amount = s.Amount,
                                                    StartDate = e.StartDate,
                                                    Description = e.Description
                                                }).ToList<EmployeeViewModel>();

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}