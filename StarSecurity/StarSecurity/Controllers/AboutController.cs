﻿using Microsoft.AspNetCore.Mvc;

namespace StarSecurity.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
