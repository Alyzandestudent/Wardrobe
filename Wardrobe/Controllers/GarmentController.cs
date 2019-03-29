using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wardrobe.Controllers
{
    public class GarmentController : Controller
    {

        private Wardrobe.Services.IService.IGarmentService _garmentService;

        public GarmentController()
        {
            _garmentService = new Wardrobe.Services.Service.GarmentService();
        }
        // GET: Garment
        public ActionResult Garments()
        {
            return View("index", _garmentService.GetGarments());
        }

        // GET: Garment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Garment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Garment/Create
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

        // GET: Garment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Garment/Edit/5
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

        // GET: Garment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Garment/Delete/5
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
