using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using POS.web.Data;

namespace POS.web.Controllers.ShopCustomization
{
    public class ShopCustomization : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopCustomization(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,001")]
        public IActionResult Customize()
        {
            
            return View("Customize");
        }
    }
}
