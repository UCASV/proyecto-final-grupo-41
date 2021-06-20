using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
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
        public int? IdGestor { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual ICollection<InicioSesion> InicioSesions { get; set; }
    }
}
