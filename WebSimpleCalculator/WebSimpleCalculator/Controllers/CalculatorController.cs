using Microsoft.AspNetCore.Mvc;
using WebSimpleCalculator.Models;

namespace WebSimpleCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public IActionResult Index(Calculator model)
        {
            switch (model.oper)
            {
                case "+":
                    model.ans = model.num1 + model.num2;
                    break;
                case "-":
                    model.ans = model.num1 - model.num2;
                    break;
                case "*":
                    model.ans = model.num1 * model.num2;
                    break;
                case "/":
                    model.ans = model.num2 == 0 ? double.NaN : model.num1 / model.num2;
                    break;
                case "%":
                    model.ans = model.num2 == 0 ? double.NaN : model.num1 % model.num2;
                    break;
                default:
                    model.ans = 0;
                    break;
            }
            return View(model);
        }

    }
}
