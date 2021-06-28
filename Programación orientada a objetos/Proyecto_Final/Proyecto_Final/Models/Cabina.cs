using System;
using System.Collections.Generic;


#nullable disable

namespace Proyecto_Final.Models
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

        public virtual ICollection<InicioSesion> InicioSesions { get; set; }

        public Cabina(string Direccion, string Telefono, string CorreoElectronico)
        {
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.CorreoElectronico = CorreoElectronico;
        }
    }
}
