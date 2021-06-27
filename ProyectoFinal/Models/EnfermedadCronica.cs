﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinal.Models
{
    public partial class EnfermedadCronica
    {
        public EnfermedadCronica()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
