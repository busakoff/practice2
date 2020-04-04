using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("Say")]
    public class MessagesController : Controller
    {
        [Route("{**message}")]
        public IActionResult ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                ViewData["Message"] = "Message is empty";
            }
            else
            {
                ViewData["Message"] = message;
            }
        
            return View();
        }
    }
}