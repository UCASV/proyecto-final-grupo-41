using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Cabina
    {
        public Cabina()
        {
            InicioSesions = new HashSet<InicioSesion>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreEncargado { get; set; }

        public virtual ICollection<InicioSesion> InicioSesions { get; set; }
    }
}
