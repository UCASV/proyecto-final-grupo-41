using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class VacunaxEfectoSecundario
    {
        public int IdVacuna { get; set; }
        public int IdEfectoSecundario { get; set; }

        public virtual EfectoSecundario IdEfectoSecundarioNavigation { get; set; }
        public virtual Vacuna IdVacunaNavigation { get; set; }
    }
}
