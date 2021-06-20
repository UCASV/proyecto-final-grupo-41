using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class Citum
    {
        public int Id { get; set; }
        public string FechaCita1 { get; set; }
        public string HoraCita1 { get; set; }
        public string LugarVacunacion1 { get; set; }
        public string FechaCita2 { get; set; }
        public string HoraCita2 { get; set; }
        public string LugarVacunacion2 { get; set; }
        public int IdGestor { get; set; }
        public int IdUsuario { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
