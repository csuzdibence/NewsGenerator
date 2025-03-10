using Microsoft.AspNetCore.Mvc;
using NewsGenerator.Models;

namespace NewsGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRandomNewsProvider randomNewsProvider;

        public HomeController(IRandomNewsProvider randomNewsProvider)
        {
            this.randomNewsProvider = randomNewsProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("api/RandomNews")]
        public News GetRandomNews()
        {
            return randomNewsProvider.GetRandomNews();
        }
    }
}
