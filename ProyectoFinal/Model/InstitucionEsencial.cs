using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal
{
    public partial class InstitucionEsencial
    {
        public InstitucionEsencial()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public InstitucionEsencial(string nombre)
        {
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
