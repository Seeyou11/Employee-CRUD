using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApI.Dtos;
using WebApI.Interfaces;

namespace WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public DepartmentController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }


        [HttpGet("Department")]

        public async Task<IActionResult> GetDepartments()
        {
            var departments = await uow.department.GetDepartmentsAsync();
            var departmentsDto = mapper.Map<IEnumerable<DepartmentDto>>(departments);

            return Ok(departmentsDto);
        }
    }
}

