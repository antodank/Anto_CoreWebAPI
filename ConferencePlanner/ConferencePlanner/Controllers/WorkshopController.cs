using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferencePlanner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkshopController : Controller
    {
        private ApplicationDbContext _context;
        public WorkshopController(ApplicationDbContext context)
        {

            _context = context;
            if (!_context.Workshops.Any())
            {
                _context.Workshops.Add(new Workshop
                { Name = "Event Management", Speaker = "Ankit Todankar" });
                _context.SaveChanges();
            }
        }

        // GET: Workshop
        [HttpGet]
        public IEnumerable<Workshop> GetWorkshops()
        {
            return _context.Workshops;
        }

        // GET: Workshop/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            if (id == 0)
                return BadRequest();

            var workshop = _context.Workshops.FirstOrDefault(i => i.Id == id);
            if (workshop == null)
                return NotFound();
            else
                return new OkObjectResult(workshop);
        }

        [HttpPost]
        public IActionResult AddWorkshop(Workshop workshop)
        {
            if (workshop == null)
                return BadRequest();

            _context.Workshops.Add(workshop);
            _context.SaveChanges();

            return CreatedAtRoute("GetWorkshops", new { id = workshop.Id }, workshop);
        }

        [HttpPut("{id}")] // means that this id will come from route  
        public IActionResult UpdateWorkshopByID(int id, [FromBody]Workshop ws)
        {

            if (ws == null || ws.Id != id)
                return BadRequest();

            var workshop = _context.Workshops.FirstOrDefault(i => i.Id == id);
            if (workshop == null)
                return NotFound();

            workshop.Name = ws.Name;
            workshop.Speaker = ws.Speaker;

            _context.Workshops.Update(workshop);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete]
        public IActionResult DeleteWorkshopByID(int id)
        {
            var workshop = _context.Workshops.FirstOrDefault(i => i.Id == id);
            if (workshop == null)
                return NotFound();

            _context.Workshops.Remove(workshop);
            _context.SaveChanges();

            return new NoContentResult();
        }


    }
}