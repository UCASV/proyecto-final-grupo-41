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
            VacunaxEfectoSecundarios = new HashSet<VacunaxEfectoSecundario>();
        }

        public int Id { get; set; }
        public string FechaEsperaVacuna1 { get; set; }
        public string HoraEsperaVacuna1 { get; set; }
        public string FechaVacunacionVacuna1 { get; set; }
        public string HoraVacunacionVacuna1 { get; set; }
        public string FechaEsperaVacuna2 { get; set; }
        public string HoraEsperaVacuna2 { get; set; }
        public string FechaVacunacionVacuna2 { get; set; }
        public string HoraVacunacionVacuna2 { get; set; }
        public int IdUsuario { get; set; }
        public int IdVacunaAplicada { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual VacunaAplicadum IdVacunaAplicadaNavigation { get; set; }
        public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; }
        public virtual ICollection<VacunaxEfectoSecundario> VacunaxEfectoSecundarios { get; set; }
    }
}
