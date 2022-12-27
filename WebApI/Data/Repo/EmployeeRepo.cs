using Microsoft.EntityFrameworkCore;
using WebApI.Interfaces;
using WebApI.Models;

namespace WebApI.Data.Repo
{
    public class EmployeeRepo : IEmployee
    {
        private readonly DataContext dc;

        public EmployeeRepo(DataContext dc)
        {
            this.dc = dc;
        }

        public void AddEmployee(Employee employee)
        {
            dc.Employees.AddAsync(employee);
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = dc.Employees.Find(employeeId);
            dc.Employees.Remove(employee);
        }

        public async Task<Employee> FindEmployee(int id)
        {
            return await dc.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await dc.Employees.ToListAsync();
        }
    }
}
