using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class Vacuna
    {
        public Vacuna()
        {
            AplicarVacunas = new HashSet<AplicarVacuna>();
            EfectoSecundarios = new HashSet<EfectoSecundario>();
        }

        public int Id { get; set; }
        public DateTime? FechaEsperaVacuna1 { get; set; }
        public DateTime? FechaVacunacionVacuna1 { get; set; }
        public DateTime? FechaEsperaVacuna2 { get; set; }
        public DateTime? FechaVacunacionVacuna2 { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; }
        public virtual ICollection<EfectoSecundario> EfectoSecundarios { get; set; }
    }
}
