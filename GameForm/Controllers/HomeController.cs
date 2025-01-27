//using GameForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameForm.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {       
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
