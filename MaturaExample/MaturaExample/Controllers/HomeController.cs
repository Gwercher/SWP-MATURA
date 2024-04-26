using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MaturaExample.Models;

namespace MaturaExample.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs(){
        return View();
    }
}
