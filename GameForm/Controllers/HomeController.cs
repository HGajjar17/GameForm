using GameForm.Models;
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
            // Create a list of photos
            return View();
        }

        // Display a discussion thread
        public IActionResult DiscusstionDetail(int id)
        {
            // To-do: Entity framework - fetch the discusstion by id

            Discussion discussion = new Discussion()
            {
                DiscussionId = 1,
                Title = "Discussion Title",
                Content = "Discussion Content",
                ImageFilename = "image.jpg",
                CreateDate = DateTime.Now
            };
            return View(discussion);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
