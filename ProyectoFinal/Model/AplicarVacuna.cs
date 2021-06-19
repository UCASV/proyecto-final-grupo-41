using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class AplicarVacuna
    {
        public int IdVacunador { get; set; }
        public int IdVacuna { get; set; }

        public virtual Vacuna IdVacunaNavigation { get; set; }
        public virtual Vacunador IdVacunadorNavigation { get; set; }
    }
}
