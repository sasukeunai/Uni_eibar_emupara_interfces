using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Emuparadise.Controllers
{
    public class EmuparadiseController : Controller
    {
        // GET: Emuparadise
        public ActionResult Index()
        {
            return View();
        }

        // GET: Emuparadise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emuparadise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emuparadise/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Emuparadise/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emuparadise/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Emuparadise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emuparadise/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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