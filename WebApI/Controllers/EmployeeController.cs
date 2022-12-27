using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApI.Dtos;
using WebApI.Interfaces;
using WebApI.Models;

namespace WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public EmployeeController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetEmployees()
        {
            var employees = await uow.employee.GetEmployeesAsync();
            var employeesDto = mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return Ok(employeesDto);
        }


        [HttpPost("post")]

        public async Task<IActionResult> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = mapper.Map<Employee>(employeeDto);

            uow.employee.AddEmployee(employee);
            await uow.SaveAsync();
            return Ok(employee);
        }

        [HttpPut("update/id")]

        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDto employeeDto)
        {
            if (id != employeeDto.EmployeeId)
                return BadRequest("update are not allowed!");

            var employeeFromDB = await uow.employee.FindEmployee(id);

             if(employeeFromDB == null)
                return BadRequest("update are not allowed");

             mapper.Map(employeeDto, employeeFromDB);

            await uow.SaveAsync();
            return StatusCode(200);

        }

        [HttpDelete("delete/id")]

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            uow.employee.DeleteEmployee(id);
            await uow.SaveAsync();
            return StatusCode(200);
        }
    }
}
