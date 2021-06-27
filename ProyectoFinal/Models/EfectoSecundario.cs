using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class EfectoSecundario
    {
        public EfectoSecundario()
        {
            VacunaxEfectoSecundarios = new HashSet<VacunaxEfectoSecundario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<VacunaxEfectoSecundario> VacunaxEfectoSecundarios { get; set; }
    }
}
