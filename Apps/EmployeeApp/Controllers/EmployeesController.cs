using EmployeeApp.Models;
using EmployeeApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public EmployeesController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Employees);
        }

        [HttpGet("{id:int}", Name ="Get")]
        public IActionResult Get([FromRoute(Name ="id")] int id)
        {
            var emp = _context.Employees.Single(e => e.Id.Equals(id));
            return Ok(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
            return CreatedAtRoute("Get", new { id = emp.Id }, emp);
        }
    }
}
