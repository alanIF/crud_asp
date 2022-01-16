using Microsoft.AspNetCore.Mvc;

namespace Dicas.Controllers
{
    public class TesteController : Controller
    {
       

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
