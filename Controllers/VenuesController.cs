using CricketBooking.Data;
using CricketBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;
namespace CricketBooking.Controllers
{
    public class VenuesController : Controller
    {
       
        //Added Default Constructor
       
       

        AppTransaction ObjApp = new AppTransaction();
        DataAcess objDB = new DataAcess();
        // GET: Venues
        public ActionResult Index()
        {

            var result = objDB.VenuesGet();

            return View(result);
        }

        // GET: Venues/Details/5
        public ActionResult Details(int id)
        {
            var venulist = objDB.VenuesGetById(id);
            if (venulist == null)
            {
                return HttpNotFound();
            }
            return View(venulist);
        }

        // GET: Venues/Create
        public ActionResult Create()
        {
            var result = objDB.LocationGet();

            var model = new venue();
            model.locationList = new SelectList(result, "Value", "Text");



            return View(model);

        }
        // GET: Locations
     

          
        // POST: Venues/Create
        [HttpPost]
        public ActionResult Create(venue objvenue)
        {
           
            try
            {
                if (ModelState.IsValid) //checking model is valid or not    
                {
                    DataAcess objDB = new DataAcess();
                    objvenue.iCId = 1;
                    string result = objDB.InsertData(objvenue);
                    //ViewData["result"] = result;    
                    TempData["result1"] = result;
                    ModelState.Clear(); //clearing model    
                                        //return View();    
                    return RedirectToAction("Index");
                }

                else
                {
                    ModelState.AddModelError("", "Error in saving data");
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Venues/Edit/5
        public ActionResult Edit(int id)
        {
            var venulist = objDB.VenuesGetById(id);
            if (venulist == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(venulist);
            }
        }

        // POST: Venues/Edit/5
        [HttpPost]
        public ActionResult Edit(venue objvenue)
        {
            try
            {
                if (ModelState.IsValid) //checking model is valid or not    
                {
                    var result = objDB.VenuesUpd(objvenue);
                    if (result == "Success")

                        return RedirectToAction("Index");
                    else
                    {

                        return View(objvenue);
                    }
                }
                else
                {
                    return View(objvenue);
                }
            }
            catch 
            {
                return View();
            }
           
        }

        // GET: Venues/Delete/5
        public ActionResult Delete(int id)
        {
            var venulist = objDB.VenuesGetById(id);
            if (venulist == null)
            {
                return HttpNotFound();
            }
            return View(venulist);
        }

        // POST: Venues/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                objDB.VenuesDel(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
