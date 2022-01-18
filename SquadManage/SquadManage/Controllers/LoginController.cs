using Microsoft.AspNetCore.Mvc;
using SquadManage.Models;

namespace SquadManage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult login(UserViewModel user)
        {
            return View("Index", user);
        }
    }
}
