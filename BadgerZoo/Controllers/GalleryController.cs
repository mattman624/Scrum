﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BadgerZoo.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Show()
        {
            return View();
        }

        // GET: Gallery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gallery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gallery/Create
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

        // GET: Gallery/Edit/5
        public ActionResult Edit1(int id)
        {
            return View("Badger1");
        }

	    public ActionResult Edit2(int id)
	    {
		    return View("Badger2");
	    }

	    public ActionResult Edit3(int id)
	    {
		    return View("Badger3");
	    }

	    public ActionResult Edit4(int id)
	    {
		    return View("Badger4");
	    }



		// POST: Gallery/Edit/5
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

        // GET: Gallery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gallery/Delete/5
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
