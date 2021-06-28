using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class InicioSesion
    {
        public int IdGestor { get; set; }
        public int IdCabina { get; set; }
        public string FechaYHora { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Gestor IdGestorNavigation { get; set; }

        public InicioSesion(int IdGestor, int IdCabina, string FechaYHora)
        {
            this.IdGestor = IdGestor;
            this.IdCabina = IdCabina;
            this.FechaYHora = FechaYHora;
        }
    }
}
