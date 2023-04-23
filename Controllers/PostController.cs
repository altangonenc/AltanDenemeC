using AltanDenemeC.Data;
using AltanDenemeC.Models;
using AltanDenemeC.Repository;
using AltanDenemeC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AltanDenemeC.Controllers
{

    [ApiController]
    [Route("api/v1")]
    public class PostController:ControllerBase
    {

        private readonly UserService _userService;
        public PostController()
        {
            _userService = new UserService;
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