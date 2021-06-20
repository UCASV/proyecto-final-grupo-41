using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class EfectoSecundario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? IdVacuna { get; set; }

        public virtual Vacuna IdVacunaNavigation { get; set; }
    }
}
