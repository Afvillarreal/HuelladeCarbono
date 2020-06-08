using Huella_de_Carbono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Huella_de_Carbono.Controllers
{
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            try
            {

                using (var db = new HuelladeCarbonoEntities1())
                {

                    List<informes> info = db.informes.ToList();
                    return View();

                }
                   
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpPost]
        public ActionResult Index(informes ing)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                using(var db = new HuelladeCarbonoEntities1())
                {
                    //ing.bustime *=  2;
                    //ing.sumatoria += ing.bustime;
                    db.informes.Add(ing);
                    db.SaveChanges();

                    return View(ing);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
}