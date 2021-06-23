using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class AplicarVacuna
    {
        public int IdVacunador { get; set; }
        public int IdVacuna { get; set; }

        public virtual Vacuna IdVacunaNavigation { get; set; }
        public virtual Vacunador IdVacunadorNavigation { get; set; }

        public AplicarVacuna(int idVacunador, int idVacuna)
        {
            IdVacunador = idVacunador;
            IdVacuna = idVacuna;
        }
    }
}
