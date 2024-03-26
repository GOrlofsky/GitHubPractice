using GitHubPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitHubPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Just trying to see what happens
            return View();
        }
    }
}
