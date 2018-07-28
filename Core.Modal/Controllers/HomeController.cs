using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Modal.Models;

namespace Core.Modal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            Credentials credentials = new Credentials();
            ViewData["Message"] = Request.Path.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> EnterPin(int id)
        {
            Credentials credentials = new Credentials();
            return PartialView("~/Views/SalesOrders/_FormLine.cshtml", credentials);
        }

        [HttpPost]
        public async Task<IActionResult> EnterPin(Credentials credentials)
        {

            return Redirect(Request.Path.ToString());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
