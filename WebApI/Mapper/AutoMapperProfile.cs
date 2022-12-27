using AutoMapper;
using WebApI.Dtos;
using WebApI.Models;

namespace WebApI.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
