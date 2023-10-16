using PreRegistrationDemo.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreRegistrationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Login() {
            //validation
            //authentication
            Session["uname"] = "Tanvir";
            return RedirectToAction("Info","Registration");
        }

        
    }
}