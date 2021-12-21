using CricketBooking.Data;
using CricketBooking.Models;
using System.Web.Mvc;
namespace CricketBooking.Controllers
{
    public class SchedulerController : Controller
    {
        AppTransaction ObjApp = new AppTransaction();
        DataAcess objDB = new DataAcess();
        // GET: Scheduler
        public ActionResult Index()
        {
            return View();
        }

        // GET: Scheduler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Scheduler/Create
        public ActionResult Create()
        {
            var result = objDB.LocationGet();

            var model = new Scheduler ();
            model.locationList = new SelectList(result, "Value", "Text");



            return View(model);
        }
        public ActionResult GetTournmentsByVid(int ivid)
        {

            var result = objDB.GetTournmentsByVId(ivid);


            ViewBag.Tournments = new SelectList(result, "Value", "Text");

            return PartialView("DisplayTournments");

        }
        // Post: Scheduler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Scheduler objschduler)
        {
            try
            {
               


                    objDB.SchdulerInsDat(objschduler);

                return RedirectToAction("Index", "Tournment");

            }
            catch
            {
                return RedirectToAction("Index", "Tournment");
            }
            return RedirectToAction("Index", "Tournment");
        }

        // GET: Scheduler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Scheduler/Edit/5
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

        // GET: Scheduler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Scheduler/Delete/5
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
