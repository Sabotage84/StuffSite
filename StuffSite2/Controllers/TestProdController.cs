using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuffSite2.Controllers
{
    public class TestProdController : Controller
    {
        // GET: TestProd
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestProd/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestProd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestProd/Create
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

        // GET: TestProd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestProd/Edit/5
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

        // GET: TestProd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestProd/Delete/5
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
