using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{



    public class SqlEmployeesRepository 
    {
        private List<Employee> _employeeList;

        public SqlEmployeesRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name ="Ahmed",Department= Dept.Programming, Email ="Ahmed@gmail.com" },
                new Employee() {Id = 2, Name ="Ali",Department = Dept.Marketing, Email ="Ali@gmail.com" },
                new Employee() {Id = 3, Name ="Mohamed",Department= Dept.HR, Email ="Mohamed@gmail.com" },

            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee Create(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

    }
}
