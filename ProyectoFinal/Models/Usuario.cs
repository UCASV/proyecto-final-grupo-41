﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cita1s = new HashSet<Cita1>();
            Cita2s = new HashSet<Cita2>();
            Vacunas = new HashSet<Vacuna>();
        }

        public int Id { get; set; }
        public string Dui { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int? IdInstitucionEsencial { get; set; }
        public int? IdEnfermedadCronica { get; set; }

        public virtual EnfermedadCronica IdEnfermedadCronicaNavigation { get; set; }
        public virtual InstitucionEsencial IdInstitucionEsencialNavigation { get; set; }
        public virtual ICollection<Cita1> Cita1s { get; set; }
        public virtual ICollection<Cita2> Cita2s { get; set; }
        public virtual ICollection<Vacuna> Vacunas { get; set; }
    }
}
