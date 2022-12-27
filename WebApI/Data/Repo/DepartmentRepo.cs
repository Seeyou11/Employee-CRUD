using Microsoft.EntityFrameworkCore;
using WebApI.Interfaces;
using WebApI.Models;

namespace WebApI.Data.Repo
{
    public class DepartmentRepo : IDepartment
    {
        private readonly DataContext dc;

        public DepartmentRepo(DataContext dc)
        {
            this.dc = dc;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            return await dc.Departments.ToListAsync();
        }
    }
}
