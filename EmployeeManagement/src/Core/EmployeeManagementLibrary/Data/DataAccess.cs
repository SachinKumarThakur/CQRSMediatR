using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employee = new();
        public DataAccess()
        {
            _employee.Add(new EmployeeModel { Id = 1, FirstName = "Sachin", LastName = "Kumar" });
            _employee.Add(new EmployeeModel { Id = 2, FirstName = "Krity", LastName = "Singh" });
            _employee.Add(new EmployeeModel { Id = 3, FirstName = "Parth", LastName = "Kumar" });
        }
        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName = lastName };
            newEmployee.Id = _employee.Max(x => x.Id) + 1;
            return newEmployee;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employee;
        }
    }
}
