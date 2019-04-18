using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers
{
    public class DashboardController : Controller
    {
        private LoginRegContext dbContext;

        public DashboardController(LoginRegContext context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            return View("Dashboard");
        }
    }
}
