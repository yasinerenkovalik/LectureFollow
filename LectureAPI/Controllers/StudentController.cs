using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace LectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        
        [HttpPost("add")]
        public IActionResult Add(Student studentEntity)
        {
           var result= _studentService.Add(studentEntity);
           if (result)
           {
               return Ok();
           }

           return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
          var result=  _studentService.GetAll();
          if (result!=null)
          {
              return Ok(result);
          }

          return BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _studentService.Delete(id);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Student studentEntity)
        {
            var result = _studentService.Update(studentEntity);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
