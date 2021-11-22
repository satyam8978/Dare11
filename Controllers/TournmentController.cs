using CricketBooking.Data;
using CricketBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;

namespace CricketBooking.Controllers
{
    public class TournmentController : Controller
    {
        AppTransaction ObjApp = new AppTransaction();
        DataAcess objDB = new DataAcess();

        // GET: Tournment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tournment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tournment/Create
        public ActionResult Create()
        {
            var result = objDB.LocationGet();

            var model = new Tournments();
            model.locationList = new SelectList(result, "Value", "Text");



            return View(model);
        }

        // POST: Tournment/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult VenuesgetByLid(int ilid)
        {

            var result = objDB.venueGetByLid(ilid);

           
            ViewBag.Venulist = new SelectList(result, "Value", "Text");

            return PartialView("DisplayVenues");

        }

        // GET: Tournment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tournment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tournment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tournment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
