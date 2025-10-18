using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.web.Data;
using POS.web.ViewModels;


namespace POS.web.Controllers.landing
{
    public class LandingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LandingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            //btw what is model
            var model = new Reciept {
              
                ProductResult = new List<ProductResult>(),
               
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Reciept model)
        {
            // Resetting input fields (e-e)
            //model.ProductId = 0;
            //model.Quantity = 1;

            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == model.ProductId);

            if (product != null && model.Quantity > 0)
            {
                model.ProductResult ??= new List<ProductResult>();
                model.ProductResult.Add(new ProductResult
                {
                    ProductId = product.Id,
                    ProductName = product.ProductName,
                    Category = product.Category.Name,
                    Quantity = model.Quantity,
                    Price = product.Price
                });
          }
          else if (product == null)
          {
                ModelState.AddModelError("","Product not found.");
          }

            // I don't get why we have to reset the model state here
            model.ProductId = 0;
            model.Quantity = 1;

            return View(model);
        }
    }
}
