using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            Cita1s = new HashSet<Cita1>();
            Cita2s = new HashSet<Cita2>();
            Vacunacions = new HashSet<Vacunacion>();
        }

        public int Id { get; set; }
        public string Dui { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int? IdEnfermedadCronica { get; set; }
        public int? IdInstitucionEsencial { get; set; }

        public virtual EnfermedadCronica IdEnfermedadCronicaNavigation { get; set; }
        public virtual InstitucionEsencial IdInstitucionEsencialNavigation { get; set; }
        public virtual ICollection<Cita1> Cita1s { get; set; }
        public virtual ICollection<Cita2> Cita2s { get; set; }
        public virtual ICollection<Vacunacion> Vacunacions { get; set; }

        public Ciudadano(string Dui, string Direccion, string CorreoElectronico,
            string Nombre, string Telefono, int? IdEnfermedadCronica, int? IdInstitucionEsencial)
        {

            this.Dui = Dui;
            this.Direccion = Direccion;
            this.CorreoElectronico = CorreoElectronico;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.IdEnfermedadCronica = IdEnfermedadCronica;
            this.IdInstitucionEsencial = IdInstitucionEsencial;
        }
    }
}
