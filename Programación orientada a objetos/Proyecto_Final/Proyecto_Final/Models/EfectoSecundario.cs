using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class EfectoSecundario
    {
        public EfectoSecundario(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<DosisxEfectoSecundario> DosisxEfectoSecundarios { get; set; }
    }
}
