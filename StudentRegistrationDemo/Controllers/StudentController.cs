
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentRegistrationDemo.Models;

namespace StudentRegistrationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
         // GET: api/<controller>
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }
        [HttpGet("GetAllStudentRecords")]
        public JsonResult GetAllStudentRecords()
        {
            return Json(StudentRegistration.getInstance().getAllStudent());
        }

         // POST: api/<controller>
        [HttpPost]
        public Studentdto RegisterStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            Studentdto stdregreply = new Studentdto();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return stdregreply;
        }

        [HttpPost("InsertStudent")]
        public IActionResult InsertStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            Studentdto stdregreply = new Studentdto();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return Ok(stdregreply);
        }

        [Route("student/")]
        [HttpPost("AddStudent")]
        public JsonResult AddStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            Studentdto stdregreply = new Studentdto();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return Json(stdregreply);
        }

    }
}