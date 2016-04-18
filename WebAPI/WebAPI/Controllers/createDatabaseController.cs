using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Conexiones;

namespace WebAPI.Controllers
{
    public class createDatabaseController : Controller
    {
        // GET: createDatabase
        public ActionResult Index()
        {
            return View();
        }

        // GET: createDatabase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: createDatabase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: createDatabase/Create
        [HttpPost]
        public ActionResult Create(WebApplication3.Models.createDatabase collection)
        {
            try
            {
                // TODO: Add insert logic here
                ConexionMongoDB con = new ConexionMongoDB();
                con.CrearMongoDB(collection.database_name);
                con.Insertar();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: createDatabase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: createDatabase/Edit/5
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

        // GET: createDatabase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: createDatabase/Delete/5
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
