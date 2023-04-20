using Microsoft.AspNetCore.Mvc;

namespace AltanDenemeC.Controllers
{
    [ApiController]
    public class PostController:ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll(){
            return Ok();
        }
    }
}