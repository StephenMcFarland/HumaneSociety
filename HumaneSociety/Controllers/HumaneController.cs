using HumaneSociety.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HumaneSociety.Controllers
{
    public class HumaneController : Controller
    {
        private HumaneDBContext db = new HumaneDBContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View(db.Humanes.ToList());
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Humane humane)
        {
            if (ModelState.IsValid)
            {
                db.Humanes.Add(humane);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(humane);

        }
        // GET: Restaurant/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Humane humane = db.Humanes.Find(id);
            if (humane == null)
            {
                return HttpNotFound();
            }
            return View(humane);
        }

        // GET: Restaurant/Edit/id
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Humane humane = db.Humanes.Find(id);
            if (humane == null)
            {
                return HttpNotFound();
            }
            return View(humane);
        }


        // GET: Restaurant/Details/id
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Humane humane = db.Humanes.Find(id);
            if (humane == null)
            {
                return HttpNotFound();
            }
            return View(humane);
        }

        //POST: Restaurant/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Humane humane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(humane).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(humane);
        }

        // POST: Restaurant/Delete/id
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Humane humane = db.Humanes.Find(id);
            db.Humanes.Remove(humane);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}