﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Huella_de_Carbono.Models;

namespace Huella_de_Carbono.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public void prove(usuario a)
        {
            using (var db = new HuelladeCarbonoEntities1())
            {
                var al = db.usuario.Find(a.idUsuario);
            }       
        }
    }
}