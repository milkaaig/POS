using Microsoft.AspNetCore.Mvc;
using POS.web.Data;


namespace POS.web.Controllers.landing
{
    public class Landing : Controller
    {

        private readonly ApplicationDbContext _context;
        public Landing(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reciept()
        {




            return View("Index");


        }
    }
}
