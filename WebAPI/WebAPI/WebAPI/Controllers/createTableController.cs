using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Conexiones;

namespace WebAPI.Controllers
{
    public class createTableController : Controller
    {
        // GET: createTable
        public ActionResult Index()
        {
            return View();
        }

        // GET: createTable/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: createTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: createTable/Create
        [HttpPost]
        public ActionResult Create(WebApplication3.Models.createTable collection)
        {
            try
            {
                // TODO: Add insert logic here
                ConexionMariaDBMeta conMeta = new ConexionMariaDBMeta();
                ConexionMongoDB conMongo = new ConexionMongoDB();
                ConexionMariaDB conMaria = new ConexionMariaDB();
                ConexionSQLServer conServer = new ConexionSQLServer();
                conMeta.InsertarTabla(collection.database_type, collection.nombre, collection.Col_alias, collection.col_tipo_dato, collection.col_null);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: createTable/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: createTable/Edit/5
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

        // GET: createTable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: createTable/Delete/5
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
