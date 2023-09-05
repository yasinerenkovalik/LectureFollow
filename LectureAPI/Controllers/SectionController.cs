using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpPost("add")]
        public IActionResult Add(Section section)
        {
            var result = _sectionService.Add(section);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
            
        }

        [HttpPost("uppdate")]
        public IActionResult Update(Section section) 
        {
            var result= _sectionService.Update(section);
            if (result)
            {
                return Ok();
            }
            return BadRequest();    
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result= _sectionService.Delete(id);
            if (result) 
            {
                return Ok();
            }
            return BadRequest();

        }

        [HttpDelete("harddelete")]
        public IActionResult HardDelete(int id) 
        {
            var result=_sectionService.HardDelete(id);
            if(result)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            var result=_sectionService.GetAll();
            if (result==null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result=_sectionService.GetById(id);
            if (result==null)
            {
                return BadRequest();
            }
            return Ok();    
        }
    }
}
