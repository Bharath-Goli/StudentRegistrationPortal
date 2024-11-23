using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRegistrationPortal.Data;
using StudentRegistrationPortal.Models;
using StudentRegistrationPortal.Models.Entities;

namespace StudentRegistrationPortal
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext DbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {

            var a = DbContext.Students.ToList();
            return Ok(a);

        }

        [HttpGet]
        [Route("{ID:int}")]
        public IActionResult GetStudent(int ID)
        {

            var b = DbContext.Students.Find(ID);
            if (b is null)
            {
                return NotFound();
            }
            else {
                return Ok(b);
            }
        }


        [HttpPost]

        public IActionResult AddStudent(AddStudentDto addStudentDto)
        {


            var c = new Student()
            {
                Name = addStudentDto.Name,
                Gender = addStudentDto.Gender,
                DateOfBirth = addStudentDto.DateOfBirth,
                PhoneNumber = addStudentDto.PhoneNumber,
                Address = addStudentDto.Address


            };


            DbContext.Students.Add(c);
            DbContext.SaveChanges();
            return Ok(c);

        }

        [HttpPut]
        [Route("{ID:int}")]

        public IActionResult UpdateStudent(int ID, UpdateStudentDto updateStudentDto)
        {
            var d=DbContext.Students.Find(ID);
            if (d is null)
            {
                return NotFound();
            }

            d.Address= updateStudentDto.Address;
            DbContext.SaveChanges();
            return Ok(d);

        }


        [HttpDelete]

        [Route("{ID:int}")]

        public IActionResult DeleteStudent(int ID)

        {

            var f=DbContext.Students.Find(ID);
            if (f is null)
            {
                return NotFound();
            }
            DbContext.Students.Remove(f);
            DbContext.SaveChanges();
            return Ok(f);
        }
    }
}

