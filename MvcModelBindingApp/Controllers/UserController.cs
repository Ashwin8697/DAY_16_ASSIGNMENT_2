using Microsoft.AspNetCore.Mvc;
using MvcModelBindingApp.Models;

namespace MvcModelBindingApp.Controllers
{
    public class UserController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Index(User user)
        {
            return View("Result", user);
        }
    }
}