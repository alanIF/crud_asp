using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SquadManage.Models;
using SquadManage.Validator;

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
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);
            if (!results.IsValid) {
                foreach (var error in results.Errors) { 
                    Console.WriteLine(error);
                
                }
            }
            return View("Index", user);
        }
    }
}
