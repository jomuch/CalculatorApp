using CalculatorApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculator _calculator;

        public HomeController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            int sum = _calculator.Add(10, 5);
            ViewData["SumResult"] = $"The result of 10 + 5 is: {sum}";
            return View();
        }
    }
}