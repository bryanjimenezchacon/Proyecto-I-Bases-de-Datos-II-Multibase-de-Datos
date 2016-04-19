using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Conexiones;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using WebApplication3.Models;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebAPI.Controllers
{
    public class listDatabasesController : Controller
    {
        // GET: listDatabases
        public ActionResult Index() {
            return View();
        }
        public ActionResult GetProducts() //IEnumerable<listDatabases> Index()
        
            {
            MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=META;User id=root;Password='salmo23';");
            List<listDatabases> datos = new List<listDatabases>();

                DataTable dt = new DataTable();
               Conexion.Open();
                using (MySqlCommand cmd = new MySqlCommand("select * from BDS;", Conexion))
                {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(
                        new listDatabases
                        {
                            
                            database_type = reader.GetValue(1).ToString(),
                            user = reader.GetValue(2).ToString(),
                            pass = reader.GetValue(3).ToString(),
                            server = reader.GetValue(4).ToString(),
                            protocol = reader.GetValue(5).ToString(),
                            port = reader.GetValue(6).ToString(),
                            alias = reader.GetValue(7).ToString(),
                            nombre = reader.GetValue(8).ToString()

                        }
                    );
                }
                    return Json(datos, JsonRequestBehavior.AllowGet);
                }
            }
        
            /*
ConexionMariaDBMeta con = new ConexionMariaDBMeta();
string json = con.ConvertDataTabletoString();
JavaScriptSerializer serializer = new JavaScriptSerializer();
return Json();*/

        

        // GET: listDatabases/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: listDatabases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: listDatabases/Create
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

        // GET: listDatabases/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: listDatabases/Edit/5
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

        // GET: listDatabases/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: listDatabases/Delete/5
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
