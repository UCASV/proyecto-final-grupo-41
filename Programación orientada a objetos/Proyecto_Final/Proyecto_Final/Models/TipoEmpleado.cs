using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class TipoEmpleado
    {
        public TipoEmpleado()
        {
            Gestors = new HashSet<Gestor>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Gestor> Gestors { get; set; }
    }
}
