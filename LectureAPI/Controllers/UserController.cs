using Application.Message;
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            if (!ModelState.IsValid)
            {
               
                return BadRequest(ModelState);
            }
           var result= _userService.Add(user);
           if (result)
           {
               return Ok();
           }

           return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result==null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
        

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result=_userService.Delete(id);
            if (result)
            {
                return Ok();
            }

            return BadRequest();

        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result=_userService.Update(user);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("harddelete")]
        public IActionResult HardDelete(int id)
        {
            var result=_userService.HardDelete(id);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        public class LoginModel
        {
           public string email { get; set; }public string password { get; set; }
        }

        [HttpPost("login")]
       
        public IActionResult Login([FromBody] LoginModel model)
        {
            var result = _userService.Login(model.email, model.password);
            if (result == null)
            {
                return BadRequest(Messages.UserNotFoundMessage);
            }
            return Ok(result);
        }
    }
}
