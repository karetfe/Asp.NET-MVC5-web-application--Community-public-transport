using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class PaiementController : Controller
    {
        IPaiementService ause;
        public PaiementController(IPaiementService ause)
        {
            this.ause = ause;
        }
        // GET: Paiement
        public ActionResult Index()
        {
            var l = ause.getAllPaiements();
            return View(l);
        }

        // GET: Paiement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paiement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paiement/Create
        [HttpPost]
        public ActionResult Create(paiement p)
        {
            if (ModelState.IsValid)
            {
                ause.AddPaiement(p);
                return RedirectToAction("Index");
            }

            else
            {
                return View();
            }
        }

        // GET: Paiement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paiement/Edit/5
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

        // GET: Paiement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paiement/Delete/5
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
