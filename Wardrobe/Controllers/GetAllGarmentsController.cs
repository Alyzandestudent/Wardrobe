using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wardrobe.Controllers
{
    public class GetAllGarmentsController : Controller
    {
        private Wardrobe.Services.IService.IGarmentService _getAllGarmentsService;

        public GetAllGarmentsController()
        {
            _getAllGarmentsService = new Wardrobe.Services.Service.GarmentService(); 
        }
        // GET: GetAllGarments
        public ActionResult Carousel()
        {
            return View(_getAllGarmentsService.GetAllGarments());
        }

        // GET: GetAllGarments/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GetAllGarments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GetAllGarments/Create
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

        // GET: GetAllGarments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GetAllGarments/Edit/5
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

        // GET: GetAllGarments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GetAllGarments/Delete/5
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
