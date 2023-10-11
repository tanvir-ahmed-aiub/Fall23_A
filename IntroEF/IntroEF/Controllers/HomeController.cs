using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new DemoF23_AEntities();
            var data = db.Departments.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d) {
            var db = new DemoF23_AEntities();
            db.Departments.Add(d);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new DemoF23_AEntities();
            var data = db.Departments.Find(id);
            //var data = (from d in db.Departments
            //            where d.Id == id
            //            select d).SingleOrDefault();
            return View(data);
        }
        public ActionResult Details(int id) { 
            var db = new DemoF23_AEntities();
            var dept = db.Departments.Find(id);
            //ViewBag.Students = (from s in db.Students
            //                where s.DeptId == id
            //                select s).ToList();
            //ViewBag.Courses = (from c in db.Courses
            //               where c.DeptId == id
            //               select c).ToList();
            return View(dept);

        }
        [HttpPost]
        public ActionResult Edit(Department d) {
            var db = new DemoF23_AEntities();
            var ex = db.Departments.Find(d.Id);
            ex.Name = d.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id) {
            var db = new DemoF23_AEntities();
            var ex = db.Departments.Find(id);
            db.Departments.Remove(ex);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}