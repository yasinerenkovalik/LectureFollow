using System.Data.Entity.Infrastructure.Design;
using Application.Message;
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;

        public FacultyController( IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        [HttpPost("add")]
        public IActionResult Add(Faculty faculty)
        {
            var result=_facultyService.Add(faculty);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Faculty faculty)
        {
            var result=_facultyService.Update(faculty);
            if (result)
            {
                return Ok();
            }
            return BadRequest();

        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result=_facultyService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_facultyService.GetAll();
            if (result.Count<1)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("harddelete")]
        public IActionResult HardDelete(int id)
        {
           var result=  _facultyService.HardDelete(id);
           if (result)
           {
               return Ok();
           } 
           return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result=_facultyService.GetById(id);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }


    }
    
}
