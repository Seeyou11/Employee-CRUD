using WebApI.Data.Repo;
using WebApI.Interfaces;

namespace WebApI.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;

        public UnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        public IDepartment department => new DepartmentRepo(dc);

        public IEmployee employee => new EmployeeRepo(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
}
