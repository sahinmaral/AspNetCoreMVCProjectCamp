using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApiDemo.DataAccess;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("getEmployees")]
        public IActionResult GetEmployees()
        {
            using var context = new Context();
            var employees = context.Employees.ToList();
            return Ok(employees);
        }

        [HttpPost("addEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            using var context = new Context();
            context.Employees.Add(employee);
            context.SaveChanges();
            return Ok("Basariyla kaydedildi");
        }

        [HttpGet("getEmployeeById")]
        public IActionResult GetEmployeeById(int id)
        {
            using var context = new Context();
            var employee = context.Employees.SingleOrDefault(x => x.Id == id);

            if (employee is null)
                return NotFound("Boyle bir id iceren kullanici bulunamadi");

            return Ok(employee);
        }

        [HttpPut("updateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            using var context = new Context();
            var updatedEmployee = context.Employees.SingleOrDefault(x => x.Id == employee.Id);

            if (updatedEmployee is null)
                return NotFound("Boyle bir id iceren kullanici bulunamadi");

            updatedEmployee.Name = employee.Name;
            context.SaveChanges();

            return Ok("Kullanici basariyla guncellendi");
        }

        [HttpDelete("deleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            using var context = new Context();
            var deletedEmployee = context.Employees.SingleOrDefault(x => x.Id == id);

            if (deletedEmployee is null)
                return NotFound("Boyle bir id iceren kullanici bulunamadi");

            context.Employees.Remove(deletedEmployee);
            context.SaveChanges();

            return Ok("Kullanici basariyla silindi");
        }
    }
}
