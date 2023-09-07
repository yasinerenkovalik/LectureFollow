using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace LectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLectureController : ControllerBase
    {
        private readonly IStudentLectureService _studentLectureService;
        
        public StudentLectureController(IStudentLectureService studentLectureService)
        {
            _studentLectureService = studentLectureService;
        }
        
        [HttpPost("add")]
        public IActionResult Add(StudentLecture studentLecture)
        {
            var result = _studentLectureService.Add(studentLecture);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
            
        }

        [HttpPost("update")]
        public IActionResult Update(StudentLecture studentLecture)
        {
            var result = _studentLectureService.Update(studentLecture);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _studentLectureService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("harddelete")]
        public IActionResult HardDelete(int id)
        {
            var result = _studentLectureService.HardDelete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= _studentLectureService.GetAll();
            if (result==null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _studentLectureService.GetById(id);
            if (result==null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("studentlecture")]
        public IActionResult StudentLecture(int id)
        {
            var result = _studentLectureService.StudenLecture(id);
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest();
        }


    }
}
