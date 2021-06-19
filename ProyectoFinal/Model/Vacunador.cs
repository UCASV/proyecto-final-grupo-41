using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class Vacunador
    {
        public Vacunador()
        {
            AplicarVacunas = new HashSet<AplicarVacuna>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string TipoEncargado { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; }
    }
}
