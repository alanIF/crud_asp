using Microsoft.AspNetCore.Mvc;

namespace SquadManage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
