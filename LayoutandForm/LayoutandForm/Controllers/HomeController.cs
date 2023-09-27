using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutandForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login() { 

            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc) {
            //var temp = Request["Username"];
            ViewBag.Uname= fc["Username"];
            ViewBag.Pass = fc["Password"];
            return View();
        }
        public ActionResult LoginSubmit() {
            //validation
            //authentication
            //redirection
            TempData["Msg"] = "Login Successfull";
            //return Redirect("https://www.aiub.edu");
            return RedirectToAction("Index","Dashboard");
            //return null;
        }
    }
}