using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Microsoft.AspNetCore.Mvc;
using PalindromeProject.Controllers;

namespace PalindromeProject.TestTools
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsView_true()
        {
            HomeController controller = new HomeController();
            IActionResult actionResult = controller.Index();
            ViewResult result = actionResult as ViewResult;

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
