using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"> Usuario</param>

        /// <returns>Ok</returns>
        [HttpPost]
        public IActionResult index(UserModel user) {
            return Ok(new { response= "logado!"});
        }
    }
}
