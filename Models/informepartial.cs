using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Huella_de_Carbono.Models
{
    public class informepartial
    {
        public int idInformes { get; set; }
        
        [Display (Name ="ingrese sumatoria")]
        public double sumatoria { get; set; }
        public double promedio { get; set; }
        public int cantidad { get; set; }

    }

    public partial class informes
    {
        [Display(Name ="Cuanto tiempo pasa en autobus")]
        public int bustime { get; set; }
        public int cartime { get; set; }
        public int mototime { get; set; }

        //public String NombreCompleto {get {return Nombres + " " + Apellidos; } }
        [Display (Name ="Resultado")]
        public double total { get { return Convert.ToDouble(bustime) + sumatoria ; } }

    }
}