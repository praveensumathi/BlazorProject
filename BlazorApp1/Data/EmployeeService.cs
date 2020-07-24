using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class EmployeeService
    {
        private readonly AppDbContext _appdbContext;
        public string Status { get; set; }
        public EmployeeService(AppDbContext appDbContext)
        {
            this._appdbContext = appDbContext;
        }

        public List<EmployeeDetails> GetEmployee()
        {
            var employeeList = _appdbContext.EmployeeInfo.ToList();
            return employeeList;
        }
        public string AddEmployee(EmployeeDetails newEmployee)
        {
            _appdbContext.EmployeeInfo.Add(newEmployee);
            _appdbContext.SaveChanges();
            return Status = "Added Sucessfully";
        }
    }
}
