using DependencyInjectionExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingService;

        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public IActionResult Index()
        {
            // Используем GreetingService
            var greeting = _greetingService.GetGreeting();
            ViewBag.GreetingMessage = greeting;
            return View();
        }
    }
}
