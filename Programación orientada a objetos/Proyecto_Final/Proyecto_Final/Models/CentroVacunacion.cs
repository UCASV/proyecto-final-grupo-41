using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class CentroVacunacion
    {
        public CentroVacunacion()
        {
            Cita1s = new HashSet<Cita1>();
            Cita2s = new HashSet<Cita2>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cita1> Cita1s { get; set; }
        public virtual ICollection<Cita2> Cita2s { get; set; }
    }
}
