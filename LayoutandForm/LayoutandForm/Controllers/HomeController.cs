using LayoutandForm.Models;
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
        //public ActionResult Login(FormCollection fc) {
        //public ActionResult Login(string Username, string Password) {
        public ActionResult Login(LoginModel login) {
            //var temp = Request["Username"];
            //ViewBag.Uname= fc["Username"];
            //ViewBag.Pass = fc["Password"];
            //ViewBag.Uname = Username;
            //ViewBag.Pass = Password;

            return View(login);
        }
        [HttpGet]
        public ActionResult SignUp() {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpModel signUp) {
            if (ModelState.IsValid) {  //all validation in submitted model
                return RedirectToAction("Index");
            }
            return View(signUp);
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