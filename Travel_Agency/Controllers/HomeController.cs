﻿using MyDatabase;
using PersistenceLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    
    public class HomeController : Controller
    {
        public ApplicationDbContext db;
        private HomeRepository homeService;
        public HomeController()
        {
            db = new ApplicationDbContext();
            homeService= new HomeRepository(db);
        }
         

        [Authorize]
        public ActionResult AdminIndex()
        {
            return View();
        }
        
        public ActionResult Index()
        {
            var offersList=homeService.GetThreeMaxDiscounts();
            ViewBag.ListHighestDiscount=offersList; 
            return View();
        }
        [Authorize]
        public ActionResult About()
        {


            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {


            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}