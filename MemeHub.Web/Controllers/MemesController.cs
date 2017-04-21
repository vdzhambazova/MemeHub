using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemeHub.Web.Controllers
{
    public class MemesController : Controller
    {
        // GET: Memes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Memes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Memes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memes/Create
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

        // GET: Memes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Memes/Edit/5
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

        // GET: Memes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Memes/Delete/5
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
