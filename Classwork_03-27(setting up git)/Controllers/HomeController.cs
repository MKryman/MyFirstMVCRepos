using Classwork_03_27_setting_up_git_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Classwork_03_27_setting_up_git_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}