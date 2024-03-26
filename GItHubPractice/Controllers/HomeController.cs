using GitHubPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitHubPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
