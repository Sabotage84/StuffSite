using StuffSite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuffSite2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VideoLessons()
        {
            List<Videos> videoLess = new List<Videos>();

            videoLess.Add(new Videos {Name="fist", UrlVideo= "https://www.youtube.com/embed/VltqJa3vorw" });
            videoLess.Add(new Videos { Name = "Second", UrlVideo = "https://www.youtube.com/embed/VltqJa3vorw" });
            videoLess.Add(new Videos { Name = "333333", UrlVideo = "https://www.youtube.com/embed/VltqJa3vorw" });
            videoLess.Add(new Videos { Name = "4444444", UrlVideo = "https://www.youtube.com/embed/VltqJa3vorw" });



            return View(videoLess);
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