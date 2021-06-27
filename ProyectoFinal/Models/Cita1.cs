using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class Cita1
    {
        public int Id { get; set; }
        public string FechaCita1 { get; set; }
        public string HoraCita1 { get; set; }
        public int IdGestor { get; set; }
        public int IdUsuario { get; set; }
        public int IdCentroVacunacion { get; set; }

        public virtual CentroVacunacion IdCentroVacunacionNavigation { get; set; }
        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
