using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PirateBackend.Models;

namespace PirateBackend.Controllers
{
    public class HomeController : Controller
    {
        private PirateBackendContext db = new PirateBackendContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.AthleticEvents.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AthleticEvent athleticEvent = db.AthleticEvents.Find(id);
            if (athleticEvent == null)
            {
                return HttpNotFound();
            }
            return View(athleticEvent);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AthleticEventId,AthleticEventType,AthleticEventDescription,AthleticEventDateTime,AthleticEventLocation,AthleticEventOpponent,Self")] AthleticEvent athleticEvent)
        {
            if (ModelState.IsValid)
            {
                db.AthleticEvents.Add(athleticEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(athleticEvent);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AthleticEvent athleticEvent = db.AthleticEvents.Find(id);
            if (athleticEvent == null)
            {
                return HttpNotFound();
            }
            return View(athleticEvent);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AthleticEventId,AthleticEventType,AthleticEventDescription,AthleticEventDateTime,AthleticEventLocation,AthleticEventOpponent,Self")] AthleticEvent athleticEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(athleticEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(athleticEvent);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AthleticEvent athleticEvent = db.AthleticEvents.Find(id);
            if (athleticEvent == null)
            {
                return HttpNotFound();
            }
            return View(athleticEvent);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AthleticEvent athleticEvent = db.AthleticEvents.Find(id);
            db.AthleticEvents.Remove(athleticEvent);
            db.SaveChanges();
            return RedirectToAction("Index");
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
