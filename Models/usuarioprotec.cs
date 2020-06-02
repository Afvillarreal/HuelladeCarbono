using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Huella_de_Carbono.Models
{
    public class usuarioprotec
    {
        public int idUsuario { get; set; }
        public string usuario1 { get; set; }
        public string contraseña { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public string entidad { get; set; }
        public string nombreentidad { get; set; }
    }
}