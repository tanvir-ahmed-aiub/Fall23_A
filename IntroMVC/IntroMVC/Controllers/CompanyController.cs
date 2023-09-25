using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class CompanyController : Controller
    {
        

        // GET: Company
        public ActionResult Index()
        {
            /*Company c = new Company();
            c.Name = "ABC ";
            c.Address = "Dhaka";
            c.Email = "abc@xyz";
            c.Descr = "Lorem Ipsum";*/
            Person p = new Person() {
                Name="Tanvir",
                Address="AIUB",
                Email="tanvir.ahmed@aiub.edu",
                Descr="D building,FST,CS"
            };

            return View(p);
        }
        public ActionResult Projects() {
            var p1 = new Project() { 
                Name ="p1",
                Client ="c1"
            };
            var p2 = new Project() { 
                Name ="p2",
                Client="c2"
            };

            var projects = new Project[] { p1,p2};
            return View(projects);
        }
        public ActionResult Team() {
            return View();
        }
    }
}