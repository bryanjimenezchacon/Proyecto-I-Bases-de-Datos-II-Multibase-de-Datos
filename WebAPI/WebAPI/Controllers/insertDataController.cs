﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class insertDataController : Controller
    {
        // GET: insertData
        public ActionResult Index()
        {
            return View();
        }

        // GET: insertData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: insertData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: insertData/Create
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

        // GET: insertData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: insertData/Edit/5
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

        // GET: insertData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: insertData/Delete/5
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
