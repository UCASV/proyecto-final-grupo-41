using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class Usuario
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private EnfermedadCronica eCdb;
        private InstitucionEsencial edb;

        public Usuario()
        {
            Cita = new HashSet<Citum>();
            Vacunas = new HashSet<Vacuna>();
        }

        public Usuario(string text1, string text2, string text3, string text4, string text5, EnfermedadCronica eCdb, InstitucionEsencial edb)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.eCdb = eCdb;
            this.edb = edb;
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
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Vacuna> Vacunas { get; set; }
    }
}
