using simpleBlogsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleBlogsite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var blogdetails = db.Blogs.ToList().OrderByDescending(x=>x.Id);
            return View(blogdetails);
        }

        public ActionResult BlogUpload()
        {
           return View();
        }
        [HttpPost]
        public ActionResult BlogUpload(Blog bg)
        {
            db.Blogs.Add(bg);
            db.SaveChanges();
            ViewBag.Message = "All Blogs Detail are here Save Successfully...!!!!!!!!";
             return View();
        }

        public ActionResult Food()
        {
            var Foodarticle = db.Blogs.Where(x => x.Category == "Food");
            return View(Foodarticle);
        }


        public ActionResult Movies()
        {
            var Moviesarticle = db.Blogs.Where(x => x.Category == "Movies");
            return View(Moviesarticle);
        }


        public ActionResult Sports()
        {
            var Sportsarticle = db.Blogs.Where(x => x.Category == "Sports");
            return View(Sportsarticle);
        }



        public ActionResult Fashion()
        {
            var Fashionarticle = db.Blogs.Where(x => x.Category == "Fashion");
            return View(Fashionarticle);
        }


        public ActionResult Technology()
        {
            var Technologyarticle  = db.Blogs.Where(x => x.Category == "Technology");
            return View(Technologyarticle);
        }

        public ActionResult Motivation()
        {
            var Motivationarticle = db.Blogs.Where(x => x.Category == "Motivation");
            return View(Motivationarticle);
        }



        public ActionResult Entertainment()
        {
            var Entertainmentarticle = db.Blogs.Where(x => x.Category == "Entertainment");
            return View(Entertainmentarticle);
        }


        public ActionResult News()
        {
            var Newsarticle = db.Blogs.Where(x => x.Category == "News");
            return View(Newsarticle);
        }


        public ActionResult RecipieWorld()
        {
            return View();
        }

        public ActionResult Crickets()
        {
            return View();
        }

    }
}