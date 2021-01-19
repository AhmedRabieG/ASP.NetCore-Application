using EmployeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public SqlEmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Employee Create(Employee employee)
        {
            _appDbContext.Add(employee);
            _appDbContext.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _appDbContext.Employees.Find(Id);
            if(employee != null)
            {
                _appDbContext.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _appDbContext.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return _appDbContext.Employees.Find(id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = _appDbContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
            return employeeChanges;
        }
    }
}
