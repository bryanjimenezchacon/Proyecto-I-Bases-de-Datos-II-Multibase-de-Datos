using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class deleteTableController : Controller
    {
        // GET: deleteTable
        public ActionResult Index()
        {
            return View();
        }

        // GET: deleteTable/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: deleteTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: deleteTable/Create
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

        // GET: deleteTable/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: deleteTable/Edit/5
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

        // GET: deleteTable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: deleteTable/Delete/5
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
