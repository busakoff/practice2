using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("[controller]/[action]")]
    public class CalculatorController : Controller
    {
        [Route("{firstNumber:int}/{secondNumber:int:min(1)}")]
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            ViewData["action"] = RouteData.Values["action"].ToString();
            ViewData["mark"] = '+';
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber + secondNumber;

            return View("Result");
        }

        [Route("{firstNumber:int}/{secondNumber:int:min(1)}")]
        public IActionResult Divide(int firstNumber, int secondNumber)
        {
            ViewData["action"] = RouteData.Values["action"].ToString();
            ViewData["mark"] = '/';
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber / secondNumber;

            return View("Result");
        }


    }
}