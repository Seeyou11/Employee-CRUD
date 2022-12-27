using WebApI.Models;

namespace WebApI.Interfaces
{
    public interface IDepartment
    {
        Task<IEnumerable<Department>> GetDepartmentsAsync();
    }
}
