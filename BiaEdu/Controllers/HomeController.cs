﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiaEdu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           // ViewBag.Message = "Know us before the point of no return.";

            return View();
        }

        public ActionResult Contact()
        {
          //  ViewBag.Message = ".";

            return View();
        }
        public ActionResult Jobs()
        {
            //ViewBag.Message = ".";

            return View();
        }
    }
}