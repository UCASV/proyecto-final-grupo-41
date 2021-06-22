using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class CentroVacunacion
    {
        public CentroVacunacion()
        {
            Cita = new HashSet<Citum>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}
