using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using PirateBackend.Models;
using System.Web.Http.Cors;

//using PirateBackend.Filters;

namespace PirateBackend.Controllers
{
    /// <summary>
    /// bug Commented section is broken security
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AcademicCalandarController : ApiController
    {
        private PirateBackendContext db = new PirateBackendContext();

        // GET: api/AcademicCalandar
        public IQueryable<AcademicCalandar> GetAcademicCalandars()
        {
            return db.AcademicCalandars;
        }

        // GET: api/AcademicCalandar/5
        [ResponseType(typeof(AcademicCalandar))]
        public IHttpActionResult GetAcademicCalandar(int id)
        {
            AcademicCalandar academicCalandar = db.AcademicCalandars.Find(id);
            if (academicCalandar == null)
            {
                return NotFound();
            }

            return Ok(academicCalandar);
        }

        // PUT: api/AcademicCalandar/5
        [ResponseType(typeof(void))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult PutAcademicCalandar(int id, AcademicCalandar academicCalandar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != academicCalandar.AcademicCalandarId)
            {
                return BadRequest();
            }

            db.Entry(academicCalandar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcademicCalandarExists(id))
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

        // POST: api/AcademicCalandar
        [ResponseType(typeof(AcademicCalandar))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult PostAcademicCalandar(AcademicCalandar academicCalandar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AcademicCalandars.Add(academicCalandar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = academicCalandar.AcademicCalandarId }, academicCalandar);
        }

        // DELETE: api/AcademicCalandar/5
        [ResponseType(typeof(AcademicCalandar))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult DeleteAcademicCalandar(int id)
        {
            AcademicCalandar academicCalandar = db.AcademicCalandars.Find(id);
            if (academicCalandar == null)
            {
                return NotFound();
            }

            db.AcademicCalandars.Remove(academicCalandar);
            db.SaveChanges();

            return Ok(academicCalandar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AcademicCalandarExists(int id)
        {
            return db.AcademicCalandars.Count(e => e.AcademicCalandarId == id) > 0;
        }
    }
}