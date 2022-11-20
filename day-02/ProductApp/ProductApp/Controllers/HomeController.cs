using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var list = new List<string>
        {
            "Ahmet",
            "Arif",
            "Ahmetoğlu"
        };

        return View("Index", list);
    }
    
}
