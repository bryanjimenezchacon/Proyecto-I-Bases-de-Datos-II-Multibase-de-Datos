using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class deleteDataController : Controller
    {
        // GET: deleteData
        public ActionResult Index()
        {
            return View();
        }

        // GET: deleteData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: deleteData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: deleteData/Create
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

        // GET: deleteData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: deleteData/Edit/5
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

        // GET: deleteData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: deleteData/Delete/5
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
