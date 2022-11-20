using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetOneProduct()
        {
            var list = new Product()
            {
                Id = 4,
                ProductName = "Bilal",
                Price = 678
            };
            
            return View(list);
        }

        public IActionResult GetAllProducts()
        {
            var list = new List<Product>
        {
            new Product(1, "Ahmet", 123),
            new Product(2, "Arif", 234),
            new Product(3, "Ahmetoğlu", 345)
        };

            list.Add(new Product(3, "Ahmeet", 456));
            return View(list);
        }
    }
}