using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Huella_de_Carbono.Controllers;

namespace Huella_de_Carbono.Models
{
    public class informepartial
    {
        public int idInformes { get; set; }
        public double sumatoria { get; set; }
        public double promedio { get; set; }
        [Display(Name ="Intentos")]
        public int cantidad { get; set; }

    }

    

    public partial class informes
    {
        [Display(Name = "Cuantas veces consume carne a la semana")]

        public double meat { get; set; }

        [Display(Name ="Cuanto tiempo pasa en autobus")]
        
        public double bustime { get; set; }

        [Display(Name = "Cuanto tiempo pasa en carro")]
        public double cartime { get; set; }

        [Display(Name = "Cuanto tiempo pasa en moto")]
        public double mototime { get; set; }

        [Display(Name ="INTENTOS")]
        public double intentos { get { return CalculoController.numcantidad(); } }

        [Display(Name = "Promedio")]
        public double suma { get { return CalculoController.sumatodo(); } }

        //public String NombreCompleto {get {return Nombres + " " + Apellidos; } }
        [Display (Name ="Resultado")]
        public double total { get { return (bustime * 0.1) + (cartime* 0.3) + (mototime * 0.2) + (meat*2.9); }}
        //public double total { get { return meat; } }
    }
}