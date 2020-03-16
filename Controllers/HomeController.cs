using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using customerBase.Models;

namespace customerBase.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customer(Customer customer)
        {
            return View(customer);
        }

        public IActionResult CustomerList()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
