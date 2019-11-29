using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly ApplicationContext _context;

        public StudentController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _context.Students
                   .Where(s => s.Age > 25)
                   .ToList();

            var students_eager = _context.Students
                .Include(e => e.Evaluations)
                .FirstOrDefault();

            return Ok(students);
        }


    }
}