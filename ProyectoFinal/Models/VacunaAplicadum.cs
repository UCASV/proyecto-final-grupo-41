using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class VacunaAplicadum
    {
        public VacunaAplicadum()
        {
            Vacunas = new HashSet<Vacuna>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Vacuna> Vacunas { get; set; }
    }
}
