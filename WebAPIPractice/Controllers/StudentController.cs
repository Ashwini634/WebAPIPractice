using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIPractice.Models;

namespace WebAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AshwiniDbContext _context;

        public StudentController(AshwiniDbContext context)
        {
            _context = context;
        }

        // GET: Retrieve all employees
        [HttpGet]
        public ActionResult<List<EmpTable>> GetEmp()
        {
            return _context.EmpTables.ToList();
        }

        // POST: Add a new employee
        [HttpPost]
        public ActionResult<int> AddEmp(EmpTable emp)
        {
            if (emp == null)
            {
                return BadRequest("Invalid employee data.");
            }

            _context.EmpTables.Add(emp);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetEmp), new { id = emp.Id }, emp);
        }

        // PUT: Update an existing employee
        [HttpPut("{id}")]
        public IActionResult UpdateEmp(int id, EmpTable updatedEmp)
        {
            var emp = _context.EmpTables.Find(id);
            if (emp == null)
            {
                return NotFound();
            }

            emp.Name = updatedEmp.Name;
            emp.Age = updatedEmp.Age;
            emp.Gender = updatedEmp.Gender;
            emp.EmpType = updatedEmp.EmpType;
            emp.Languages = updatedEmp.Languages;

            _context.Entry(emp).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: Remove an employee by ID
        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id)
        {
            var emp = _context.EmpTables.Find(id);
            if (emp == null)
            {
                return NotFound();
            }

            _context.EmpTables.Remove(emp);
            _context.SaveChanges();

            return NoContent();
        }


        [HttpGet("{id}")]
        public ActionResult<EmpTable> GetEmpById(int id)
        {
            var emp = _context.EmpTables.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            return emp;
        }

    }
}
