namespace WebApI.Interfaces
{
    public interface IUnitOfWork
    {
        IDepartment department { get; }

        IEmployee employee { get; } 
        Task<bool> SaveAsync();
    }
}
