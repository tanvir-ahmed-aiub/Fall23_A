using PreRegistrationDemo.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreRegistrationDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new DemoF23_AEntities();
            var data = db.Students.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student) {
            var db = new DemoF23_AEntities();
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}