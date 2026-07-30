using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Webly.Models;

namespace Webly.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        ViewData["AppName"] = "Webly";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Title"] = "Privacy";
        ViewData["AppName"] = "Webly";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
