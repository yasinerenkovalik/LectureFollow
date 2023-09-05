using Application.Services;
using Domain;

using Microsoft.AspNetCore.Mvc;

namespace LectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;

        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }
        [HttpPost("add")]
        public IActionResult Add(Lecture lecture)
        {
            var result= _lectureService.Add(lecture);
            if (result)
            {
               
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _lectureService.GetAll();
            if (result==null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
        

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _lectureService.GetById(id);
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result=_lectureService.Delete(id);
            if (result)
            {
                return Ok();
            }

            return BadRequest();

        }

        [HttpPost("update")]
        public IActionResult Update(Lecture lecture)
        {
            var result=_lectureService.Update(lecture);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("harddelete")]
        public IActionResult HardDelete(int id)
        {
            var result=_lectureService.HardDelete(id);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("studentselectlecture")]
        public IActionResult StudenSelectLecture(int id)
        {
            var result = _lectureService.StudentSelectLecture(id);
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
       
    }
}
