using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class DosisxEfectoSecundario
    {
        public int IdDosis { get; set; }
        public int IdEfectoSecundario { get; set; }

        public virtual Dosi IdDosisNavigation { get; set; }
        public virtual EfectoSecundario IdEfectoSecundarioNavigation { get; set; }

        public DosisxEfectoSecundario(int IdDosis, int IdEfectoSecundario)
        {
            this.IdDosis = IdDosis;
            this.IdEfectoSecundario = IdEfectoSecundario;
        }
    }
}
