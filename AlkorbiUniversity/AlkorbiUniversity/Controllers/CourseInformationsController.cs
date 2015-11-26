using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AlkorbiUniversity.Models;


namespace AlkorbiUniversity.Controllers
{
    public class CourseInformationsController : Controller
    {
        

        private AlkorbiUniversityContext db = new AlkorbiUniversityContext();

        // GET: CourseInformations
        public ActionResult Index()
        {
            return View(db.CourseInformations.ToList());
        }

        // GET: CourseInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseInformation courseInformation = db.CourseInformations.Find(id);
            if (courseInformation == null)
            {
                return HttpNotFound();
            }
            return View(courseInformation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
