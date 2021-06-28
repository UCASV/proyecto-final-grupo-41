using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class EfectoSecundario
    {
        public EfectoSecundario()
        {
            DosisxEfectoSecundarios = new HashSet<DosisxEfectoSecundario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<DosisxEfectoSecundario> DosisxEfectoSecundarios { get; set; }
    }
}
