using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class Usuario
    {
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
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Vacuna> Vacunas { get; set; }

        public Usuario(string dui, string direccion, string correoElectronico, string nombre, string telefono, int? idInstitucionEsencial, int? idEnfermedadCronica)
        {
            Dui = dui;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            Nombre = nombre;
            Telefono = telefono;
            IdInstitucionEsencial = idInstitucionEsencial;
            IdEnfermedadCronica = idEnfermedadCronica;
        }
    }
}
