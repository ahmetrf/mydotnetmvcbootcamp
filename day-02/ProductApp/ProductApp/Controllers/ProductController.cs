using Microsoft.AspNetCore.Mvc;
using Repositories.EFCore;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
