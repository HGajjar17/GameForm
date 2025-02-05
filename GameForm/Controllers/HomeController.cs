using GameForm.Data;
using GameForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameFormContext _context;
        public HomeController(GameFormContext context)
        {
            _context = context;
        }

        // HomePage - .../Home/Index
        public async Task<IActionResult> Index()
        {
            // get the discussion from the database
            var discussions = await _context.Discussion.ToListAsync();

            return View(discussions);
        }

        // Display a discussion by id - ../Home/DiscussionDetail/33
        public async Task<IActionResult> DiscussionDetail(int id)
        {
            // get discussion from database by id
            var discussion = await _context.Discussion.FirstOrDefaultAsync(m => m.DiscussionId == id);

            return View(discussion);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
