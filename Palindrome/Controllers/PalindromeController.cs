using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PalindromeProject.Models;
using PalindromeProject.Controllers;

namespace PalindromeProject.Controllers
{
    public class PalindromeController : Controller
    {
        [HttpPost("/Palindrome/Display")]
        public ActionResult Display()
        {
            Palindrome.SetWord(Request.Form["word"]);
            if (Palindrome.IsPalindrome())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
