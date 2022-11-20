﻿using System.Diagnostics;
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

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult GetProduct()
    {
        //var product = new Product();
        //product.Id = 1;
        //product.ProductName = "Computer";
        //product.Price = 15000;

        var product = new Product(2, "Laptop", 17000);

        return View(product);
    }

    
}
