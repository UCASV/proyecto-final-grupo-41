using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class Vacuna
    {
        public Vacuna()
        {
            AplicarVacunas = new HashSet<AplicarVacuna>();
            EfectoSecundarios = new HashSet<EfectoSecundario>();
        }

        public int Id { get; set; }
        public string FechaEsperaVacuna1 { get; set; }
        public string HoraVacuna1 { get; set; }
        public string FechaVacunacionVacuna1 { get; set; }
        public string HoraVacunacion1 { get; set; }
        public string FechaEsperaVacuna2 { get; set; }
        public string HoraVacuna2 { get; set; }
        public string FechaVacunacionVacuna2 { get; set; }
        public string HoraVacunacion2 { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; }
        public virtual ICollection<EfectoSecundario> EfectoSecundarios { get; set; }
    }
}
