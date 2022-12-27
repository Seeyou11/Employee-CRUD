namespace WebApI.Dtos
{
    public class EmployeeDto
    {

        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Department { get; set; }
        public string? PhotoPath { get; set; }
        public string? CompanyName { get; set; }
        public int JobExperiance { get; set; }
        public int Salary { get; set; }
    }
}
