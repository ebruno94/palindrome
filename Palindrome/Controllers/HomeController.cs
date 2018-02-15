using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PalindromeProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View("Form");
        }
    }
}
