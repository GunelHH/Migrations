using System;
using Microsoft.AspNetCore.Mvc;

namespace MigrationToDataBase.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
       
    }
}
