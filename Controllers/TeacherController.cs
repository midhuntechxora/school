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

        // GET: Teacher
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            return await _context.Teacher.ToListAsync();
        }

        private bool TeacherExists(long id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}
