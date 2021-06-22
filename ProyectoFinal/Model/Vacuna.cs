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

        public Vacuna(string fechaEsperaVacuna1, string horaVacuna1, string fechaVacunacionVacuna1, string horaVacunacion1, int? idUsuario)
        {
            FechaEsperaVacuna1 = fechaEsperaVacuna1;
            HoraVacuna1 = horaVacuna1;
            FechaVacunacionVacuna1 = fechaVacunacionVacuna1;
            HoraVacunacion1 = horaVacunacion1;
            IdUsuario = idUsuario;
        }
    }
}
