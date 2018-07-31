using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Modal.Login.Models;
using Microsoft.AspNetCore.Http;

namespace Core.Modal.Login.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(JsModel model)
        {
            model.OpenModalJs = "";
            return View(model);
        }

        public IActionResult About(JsModel model)
        {
            var time = HttpContext.Session.GetString("Login_Session");
            model.OpenModalJs = "showModal()";
            if (string.IsNullOrEmpty(time))
            {
                return RedirectToAction("Login", "Account");
            }
            var str = HttpContext.Session.GetString("Login_Session");
            ViewData["Session"] = str;
            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
