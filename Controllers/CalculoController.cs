using Huella_de_Carbono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

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

        public static int numcantidad()
        {
            using (var db = new HuelladeCarbonoEntities1())
            {                
                return db.informes.Count();
            }
                
        }

        public static double sumatodo()
        {
            using (var db = new HuelladeCarbonoEntities1())
            {
                double total = 0;
                var lista = db.informes.ToList();
                foreach(var i in lista)
                {                    
                    total += i.sumatoria;
                }
                total /= numcantidad();
                return total;
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