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
    public class EventCalandarController : ApiController
    {
        private PirateBackendContext db = new PirateBackendContext();

        // GET: api/EventCalandar
        public IQueryable<EventCalandar> GetEventCalandars()
        {
            return db.EventCalandars;
        }

        // GET: api/EventCalandar/5
        [ResponseType(typeof(EventCalandar))]
        public IHttpActionResult GetEventCalandar(int id)
        {
            EventCalandar eventCalandar = db.EventCalandars.Find(id);
            if (eventCalandar == null)
            {
                return NotFound();
            }

            return Ok(eventCalandar);
        }

        // PUT: api/EventCalandar/5
        [ResponseType(typeof(void))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult PutEventCalandar(int id, EventCalandar eventCalandar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventCalandar.EventCalandarId)
            {
                return BadRequest();
            }

            db.Entry(eventCalandar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventCalandarExists(id))
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

        // POST: api/EventCalandar
        [ResponseType(typeof(EventCalandar))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult PostEventCalandar(EventCalandar eventCalandar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EventCalandars.Add(eventCalandar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eventCalandar.EventCalandarId }, eventCalandar);
        }

        // DELETE: api/EventCalandar/5
        [ResponseType(typeof(EventCalandar))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult DeleteEventCalandar(int id)
        {
            EventCalandar eventCalandar = db.EventCalandars.Find(id);
            if (eventCalandar == null)
            {
                return NotFound();
            }

            db.EventCalandars.Remove(eventCalandar);
            db.SaveChanges();

            return Ok(eventCalandar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventCalandarExists(int id)
        {
            return db.EventCalandars.Count(e => e.EventCalandarId == id) > 0;
        }
    }
}