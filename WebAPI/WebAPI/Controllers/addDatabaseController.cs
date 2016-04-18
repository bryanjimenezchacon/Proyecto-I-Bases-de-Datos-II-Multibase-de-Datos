using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using WebApplication3.Conexiones;
using WebApplication3;

namespace WebAPI.Controllers
{
    public class addDatabaseController : Controller
    {
        // GET: addDatabase
        public ActionResult Index()
        {
            return View();
        }

        // GET: addDatabase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: addDatabase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: addDatabase/Create
        [HttpPost]
        public ActionResult Create(WebApplication3.Models.addDatabase collection)
        {
            try
            {
                // TODO: Add insert logic here
                System.Diagnostics.Debug.WriteLine(collection.database_type);

                ConexionMariaDBMeta con = new ConexionMariaDBMeta();
                con.Insertar(collection.database_type, collection.user, collection.pass, collection.server, collection.protocol, collection.port, collection.alias, collection.nombre);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: addDatabase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: addDatabase/Edit/5
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

        // GET: addDatabase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: addDatabase/Delete/5
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
