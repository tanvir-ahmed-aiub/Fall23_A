using PreRegistrationDemo.Auth;
using PreRegistrationDemo.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreRegistrationDemo.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [Logged]
        public ActionResult Info()
        {
            
            var db = new DemoF23_AEntities();
            ViewBag.Courses = db.Courses.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Register(int StudentId, int[] Courses) {
            var db = new DemoF23_AEntities();
            foreach (var course in Courses) {
                var cs = new CourseStudent() {
                    CId = course,
                    StId = StudentId
                };
                db.CourseStudents.Add(cs);
            }
            db.SaveChanges();
            return RedirectToAction("Info");
        }
    }
}