using AutoMapper;
using Domain.Entities;
using GUI.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunityTransport.Controllers
{

    public class SubscriptionController : Controller
    {
        ISubscriptionService ause;
        SubscriptionViewModels PM = new SubscriptionViewModels();

        //IClientService clientservice = new ClientService();
        //IManagerService managerservice = new ManagerService();
        public SubscriptionController(ISubscriptionService ause)
        {
            this.ause = ause;
        }
        // GET: Subscription
        public ActionResult Index()
        {
            
            List<subscription> subscriptions = ause.getAllSubscriptions().ToList();
            List<SubscriptionViewModels> liste = Mapper.Map<List<subscription>, List<SubscriptionViewModels>>(subscriptions);
            return View(liste);

            //List<client> lis = clientservice.getAllClient().ToList();
            //ViewBag.client = lis;

            //List<manager> lis = managerservice.getAllManager().ToList();
            //ViewBag.manager = lis;

        }

        // GET: Subscription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subscription/Create
        public ActionResult Create()
        {
            //List<client> lis = clientservice.getAllClient().ToList();
            //ViewBag.client = lis;


            //List<manager> lis =managerservice.getAllManager().ToList();
            //ViewBag.manager = lis;
            return View(PM);
           
        }

        // POST: Subscription/Create
        [HttpPost]
        public ActionResult Create(SubscriptionViewModels s)
        {

            if (ModelState.IsValid)
            {
                var obj = Mapper.Map<subscription>(s);

                ause.AddSubscription(obj);

                return RedirectToAction("Index");

            }

            else
            {
                return View();
            }
        }

        // GET: Subscription/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subscription/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("Index");

            }

            else
            {
                return View();
            }
        }

        // GET: Subscription/Delete/5
        public ActionResult Delete(int id)
        {
     
            return View();
        }

        // POST: Subscription/Delete/5
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

        //public List<client> Load()
        //{

        //    List<client> lis = clientservice.getAllclient().ToList();
        //    return lis;
        //}

        //public List<manager> Load()
        //{

        //    List<manager> lis = managerservice.getAllmanager().ToList();
        //    return lis;
        //}
    }
}
