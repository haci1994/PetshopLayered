﻿using Microsoft.AspNetCore.Mvc;

namespace Petshop.MVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
