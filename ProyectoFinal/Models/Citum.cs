using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class Citum
    {
        public int Id { get; set; }
        public DateTime? FechaCita1 { get; set; }
        public string LugarVacunacion1 { get; set; }
        public DateTime? FechaCita2 { get; set; }
        public string LugarVacunacion2 { get; set; }
        public int IdGestor { get; set; }
        public int IdUsuario { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
