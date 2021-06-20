using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class InicioSesion
    {
        public int IdGestor { get; set; }
        public int IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Gestor IdGestorNavigation { get; set; }
    }
}
