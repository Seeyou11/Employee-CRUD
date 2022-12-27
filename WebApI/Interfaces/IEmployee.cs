using WebApI.Models;

namespace WebApI.Interfaces
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        void AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);

        Task<Employee> FindEmployee(int id);
    }
}
