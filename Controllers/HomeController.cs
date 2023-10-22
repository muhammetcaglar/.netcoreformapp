using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmallFormApp.Models;

namespace SmallFormApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(new List<string>()
            {
                "Gömlek",
                "Pantolon",
                "Tişört",
                "Ayakkabı"
            });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductRepository.AddProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
          
            return View(ProductRepository.Products.Where(p=> p.Id==id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Search(string search   )
        {
            if(string.IsNullOrEmpty(search))
            {
                return View();

            }
            return View("Index",ProductRepository.Products.Where(p=> p.Name.Contains(search)));

        }
    }
}