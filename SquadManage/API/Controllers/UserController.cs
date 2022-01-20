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
        /// Autenticacao
        /// </summary>
        /// <param name="user"> Usuario</param>
        /// <returns>Ok</returns>
        [HttpPost]
        public IActionResult login(UserModel user) {

            return Ok(new { response = "logado!" });
        }
       
        /// <summary>
        /// Register
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public IActionResult Register(UserModel user) {
            return Ok(new { response = "OK" });

        }
    }
}
