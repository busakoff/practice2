using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}