using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinanceApp.Models;
using FinanceApp.Models.Services;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using FinanceApp.Web.Interfaces;
using FinanceApp.Web.PageModels;

namespace FinanceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View(new HomePageView());
        }
    }
}
