using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var weeks = new List<WeekDay>();

            var mondey = new WeekDay();
            mondey.NameDay = "понедельник";
            mondey.Index = 0;
            mondey.Lessons = new List<string>();
            mondey.Lessons.Add("МатАнализ");
            mondey.Lessons.Add("ООП");
        

            weeks.Add(mondey);

            ViewBag.Weeks = weeks;
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