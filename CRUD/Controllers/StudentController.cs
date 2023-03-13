using CRUD.Repository;
using CRUD.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public StudentController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet("get-all")]
        public async Task<IActionResult> GetAsync()
        {
            var students = await _dbContext.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetStudentByIdAsync(int id)
        {
            var student = await _dbContext.Students.FindAsync(id);
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return Created($"/get-by-id?id={student.Id}", student);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Student student)
        {
            _dbContext.Students.Update(student);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var student = new Student() { Id = id };
            _dbContext.Students.Attach(student);
            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
