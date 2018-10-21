using EFModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var StudentModel = new Student
            {
                Name = "陈卧龙",
                Sex = "男"
            };

            var CourseModel = new Course()
            {
                Name = "数据结构"
            };

            var ScoreModel = new Score()
            {
                Student = StudentModel,
                Course = CourseModel,
                StudentScore = 98
            };
            //
            using (var context = new StudentContext())
            {
                context.Students.Add(StudentModel);
                context.Courses.Add(CourseModel);
                context.Scores.Add(ScoreModel);
                context.SaveChanges();
            };


            return View();
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