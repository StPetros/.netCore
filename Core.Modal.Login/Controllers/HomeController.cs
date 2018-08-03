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
            return View(model);
        }

        public IActionResult About(JsModel model)
        {
            var time = HttpContext.Session.GetString("Login_Session");

            if (string.IsNullOrEmpty(time))
            {
                model.OpenModalJs = "ShowErrorPopup()";
            }
            var str = HttpContext.Session.GetString("Login_Session");
            ViewData["Session"] = str;
            return View(model);
        }

        public IActionResult Contact(JsModel model)
        {
            var time = HttpContext.Session.GetString("Login_Session");

            if (string.IsNullOrEmpty(time))
            {
                model.OpenModalJs = "ShowErrorPopup()";
            }
            ViewData["Message"] = "Your contact page.";
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
