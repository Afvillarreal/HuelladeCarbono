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
            using (var db = new HuelladeCarbonoEntities1())
            {

                var list = db.usuario.ToList();
                return View(list);

            }
                
        }
    }
}