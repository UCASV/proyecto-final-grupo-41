using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class Dosi
    {
        public Dosi()
        {
            DosisxEfectoSecundarios = new HashSet<DosisxEfectoSecundario>();
            Vacunacions = new HashSet<Vacunacion>();
        }

        public int Id { get; set; }
        public string FechaEspera { get; set; }
        public string HoraEspera { get; set; }
        public string FechaVacunacion { get; set; }
        public string HoraVacunacion { get; set; }
        public int IdVacuna { get; set; }

        public virtual Vacuna IdVacunaNavigation { get; set; }
        public virtual ICollection<DosisxEfectoSecundario> DosisxEfectoSecundarios { get; set; }
        public virtual ICollection<Vacunacion> Vacunacions { get; set; }
    }
}
