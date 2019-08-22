using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using school.Models;

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherContext _context;

        public TeacherController(TeacherContext context)
        {
            _context = context;
        }

        // GET: api/Teacher
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            return await _context.Teacher.ToListAsync();
        }
        
        // GET: api/Teacher/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // POST: api/Teacher
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
        {
            try {
                _context.Teacher.Add(teacher);
                await _context.SaveChangesAsync();
            } catch (Exception e) {
                throw e;
            }

            return CreatedAtAction(nameof(GetTeacher), new { id = teacher.Id }, teacher);
        }
        private bool TeacherExists(long id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}
