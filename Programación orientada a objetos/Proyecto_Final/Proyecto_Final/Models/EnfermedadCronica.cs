using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class EnfermedadCronica
    {
        public EnfermedadCronica()
        {
            Ciudadanos = new HashSet<Ciudadano>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Ciudadano> Ciudadanos { get; set; }
    }
}
