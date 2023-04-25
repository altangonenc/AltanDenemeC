using AltanDenemeC.Data;
using AltanDenemeC.Models;
using AltanDenemeC.Repository;
using AltanDenemeC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AltanDenemeC.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class PostController : ControllerBase
    {
        private readonly IUserService _userService;

        public PostController(IUserService iUserService)
        {
            _userService = iUserService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<Users> userList = _userService.getAll();
            if(userList!=null) {
                return Ok(userList);
            }
            return BadRequest();            
        }

        [HttpDelete]
        public ActionResult DeleteAll()
        {
            bool result = _userService.deleteAll();
            if(result==true)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}