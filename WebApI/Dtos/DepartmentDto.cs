using Microsoft.AspNetCore.Mvc;
using WebApI.Data;

namespace WebApI.Dtos
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
    }

}
