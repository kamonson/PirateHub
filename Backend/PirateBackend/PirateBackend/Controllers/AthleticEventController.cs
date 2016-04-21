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
using PirateBackend.Models;
//using PirateBackend.Filters;

namespace PirateBackend.Controllers
{
    /// <summary>
    /// bug Commented section is broken security
    /// </summary>
    public class AthleticEventController : ApiController
    {
        private PirateBackendContext db = new PirateBackendContext();

        // GET: api/AthleticEvent
        public IQueryable<AthleticEvent> GetAthleticEvents()
        {
            return db.AthleticEvents;
        }

        // GET: api/AthleticEvent/5
        [ResponseType(typeof(AthleticEvent))]
        public IHttpActionResult GetAthleticEvent(int id)
        {
            AthleticEvent athleticEvent = db.AthleticEvents.Find(id);
            if (athleticEvent == null)
            {
                return NotFound();
            }

            return Ok(athleticEvent);
        }

        // PUT: api/AthleticEvent/5
        [ResponseType(typeof(void))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult PutAthleticEvent(int id, AthleticEvent athleticEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != athleticEvent.AthleticEventId)
            {
                return BadRequest();
            }

            db.Entry(athleticEvent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AthleticEventExists(id))
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

        // POST: api/AthleticEvent
        [ResponseType(typeof(AthleticEvent))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult PostAthleticEvent(AthleticEvent athleticEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AthleticEvents.Add(athleticEvent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = athleticEvent.AthleticEventId }, athleticEvent);
        }

        // DELETE: api/AthleticEvent/5
        [ResponseType(typeof(AthleticEvent))]
        //[ValidateHttpAntiForgeryToken]
        public IHttpActionResult DeleteAthleticEvent(int id)
        {
            AthleticEvent athleticEvent = db.AthleticEvents.Find(id);
            if (athleticEvent == null)
            {
                return NotFound();
            }

            db.AthleticEvents.Remove(athleticEvent);
            db.SaveChanges();

            return Ok(athleticEvent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AthleticEventExists(int id)
        {
            return db.AthleticEvents.Count(e => e.AthleticEventId == id) > 0;
        }
    }
}