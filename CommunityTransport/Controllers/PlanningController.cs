using AutoMapper;
using CommunityTransport.Models;
using Data.Models;
using Domain.Entities;
using GUI.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class PlanningController : Controller
    {
        IPlanningService ause=null;
        ICityService cityservice = new CityService();
        PlanningViewModels PM = new PlanningViewModels();


        public PlanningController(IPlanningService ause)
        {
            this.ause=ause;
           // ause = new PlanningService();
        }

        // GET: Planning

        public ActionResult Index()
        {
            //var l = ause.getAllPlannings();
            //return View(l);          
            List<planning> plannings = ause.getAllPlannings().ToList();
           
            List<PlanningViewModels> liste = Mapper.Map<List<planning>, List<PlanningViewModels>>(plannings);
            return View(liste);

            List<city> lis = cityservice.getAllCity().ToList();
            ViewBag.category = lis;
        }

        // GET: Planning/Details/5
        public ActionResult Details(int id)
        {
            planning c = ause.getPlanningById(id);
            PlanningViewModels cu = Mapper.Map<PlanningViewModels>(c);
            return View(cu);
        }

        // GET: Planning/Create
        public ActionResult Create()
        {
            List<city> lis = cityservice.getAllCity().ToList();
            ViewBag.city = lis;
            return View(PM);
        }

        // POST: Planning/Create
        [HttpPost]
        public ActionResult Create(PlanningViewModels p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
                var obj = Mapper.Map<planning>(p);   
                ause.AddPlanning(obj);
                return RedirectToAction("Index");
        }

        // GET: Planning/Edit/5
        public ActionResult Edit(int id)
        {
            List<city> lis = cityservice.getAllCity().ToList();
            ViewBag.city = lis;
            return View(PM);
        }

        // POST: Planning/Edit/5
        [HttpPost]
        public ActionResult Edit(PlanningViewModels p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var obj = Mapper.Map<planning>(p);
            ause.UpdatePlanning(obj);
            return RedirectToAction("Index");

        }

        // GET: Planning/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Planning/Delete/5
        [HttpPost]
        public ActionResult Delete(PlanningViewModels p)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            PlanningViewModels p = ause.getPlanningById(p.id);
            var obj = Mapper.Map<planning>(p);
            ause.Delete(obj);
            return RedirectToAction("Index");
        }

        public List<city> Load()
        {
            List<city> lis = cityservice.getAllCity().ToList();
            return lis;
        }

    }
}
