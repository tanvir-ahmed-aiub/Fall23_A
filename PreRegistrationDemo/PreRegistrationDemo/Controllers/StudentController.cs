using AutoMapper;
using PreRegistrationDemo.DTOs;
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
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var data2 = mapper.Map<List<StudentDTO>>(data);
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDTO student) {
            if (ModelState.IsValid)
            {
                #region
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<StudentDTO, Student>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<Student>(student);
                #endregion  

                var db = new DemoF23_AEntities();
                db.Students.Add(Convert(student));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public StudentDTO Convert(Student s) {
            var st = new StudentDTO() { 
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                Cgpa = s.Cgpa,
                DeptId = s.DeptId
            };
            return st;
        }
        public Student Convert(StudentDTO s) {
            var st = new Student()
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                Cgpa = s.Cgpa,
                DeptId = s.DeptId
            };
            return st;
        }
        public List<StudentDTO> Convert(List<Student> students) {
            var sts = new List<StudentDTO>();
            foreach(var s in students)
            {
                sts.Add(Convert(s));
            }
            return sts;
        }
    }
}