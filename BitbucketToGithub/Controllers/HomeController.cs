﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitbucketToGithub.Wrapper;

namespace BitbucketToGithub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var configurationWraper = new ConfigurationWrapper();

            var bitbucketKey = configurationWraper.BitBucketCredential.Key;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}