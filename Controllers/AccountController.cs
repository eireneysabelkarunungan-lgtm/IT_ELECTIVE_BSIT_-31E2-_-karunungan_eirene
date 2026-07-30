using Microsoft.AspNetCore.Mvc;
using Webly.Models;

namespace Webly.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Title"] = "Login";
            ViewData["AppName"] = "Webly";
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginView model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Username == "admin" && model.Password == "123456")
            {
                return RedirectToAction("Welcome");
            }

            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return View(model);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}