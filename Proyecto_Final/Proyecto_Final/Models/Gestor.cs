using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class Gestor
    {
        public Gestor()
        {
            Cita1s = new HashSet<Cita1>();
            Cita2s = new HashSet<Cita2>();
            InicioSesions = new HashSet<InicioSesion>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int IdTipoEmpleado { get; set; }

        public virtual TipoEmpleado IdTipoEmpleadoNavigation { get; set; }
        public virtual ICollection<Cita1> Cita1s { get; set; }
        public virtual ICollection<Cita2> Cita2s { get; set; }
        public virtual ICollection<InicioSesion> InicioSesions { get; set; }
    }
}
