using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class Vacuna
    {
        public Vacuna()
        {
            Dosis = new HashSet<Dosi>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Dosi> Dosis { get; set; }

        public Vacuna(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }
    }
}
