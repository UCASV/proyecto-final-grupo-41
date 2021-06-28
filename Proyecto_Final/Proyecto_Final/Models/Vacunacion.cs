using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class Vacunacion
    {
        public int IdCiudadano { get; set; }
        public int IdDosis { get; set; }

        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
        public virtual Dosi IdDosisNavigation { get; set; }
    }
}
