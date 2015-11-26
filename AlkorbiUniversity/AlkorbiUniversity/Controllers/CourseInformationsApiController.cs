using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AlkorbiUniversity.Models;


namespace AlkorbiUniversity.Controllers
{
    

    public class CourseInformationsApiController : ApiController
    {
        private AlkorbiUniversityContext db = new AlkorbiUniversityContext();

        // GET: api/CourseInformationsApi
        public IQueryable<CourseInformation> GetCourseInformations()
        {
            return db.CourseInformations;
        }

        // GET: api/CourseInformationsApi/5
        [ResponseType(typeof(CourseInformation))]
        public IHttpActionResult GetCourseInformation(int id)
        {
            CourseInformation courseInformation = db.CourseInformations.Find(id);
            if (courseInformation == null)
            {
                return NotFound();
            }

            return Ok(courseInformation);
        }

        // PUT: api/CourseInformationsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCourseInformation(int id, CourseInformation courseInformation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseInformation.CourseInformationID)
            {
                return BadRequest();
            }

            db.Entry(courseInformation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseInformationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CourseInformationsApi
        [ResponseType(typeof(CourseInformation))]
        public IHttpActionResult PostCourseInformation(CourseInformation courseInformation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CourseInformations.Add(courseInformation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = courseInformation.CourseInformationID }, courseInformation);
        }

        // DELETE: api/CourseInformationsApi/5
        [ResponseType(typeof(CourseInformation))]
        public IHttpActionResult DeleteCourseInformation(int id)
        {
            CourseInformation courseInformation = db.CourseInformations.Find(id);
            if (courseInformation == null)
            {
                return NotFound();
            }

            db.CourseInformations.Remove(courseInformation);
            db.SaveChanges();

            return Ok(courseInformation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CourseInformationExists(int id)
        {
            return db.CourseInformations.Count(e => e.CourseInformationID == id) > 0;
        }
    }
}