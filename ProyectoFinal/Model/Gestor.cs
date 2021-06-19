using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Gestor
    {
        public Gestor()
        {
            Cita = new HashSet<Citum>();
            InicioSesions = new HashSet<InicioSesion>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string TipoEncargado { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<InicioSesion> InicioSesions { get; set; }
    }
}
