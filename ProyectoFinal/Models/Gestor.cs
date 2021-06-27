using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class Gestor
    {
        public Gestor()
        {
            Cabinas = new HashSet<Cabina>();
            Cita1s = new HashSet<Cita1>();
            Cita2s = new HashSet<Cita2>();
            InicioSesions = new HashSet<InicioSesion>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string TipoEncargado { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Cabina> Cabinas { get; set; }
        public virtual ICollection<Cita1> Cita1s { get; set; }
        public virtual ICollection<Cita2> Cita2s { get; set; }
        public virtual ICollection<InicioSesion> InicioSesions { get; set; }
    }
}
