using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class Cita1
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int IdCentroVacunacion { get; set; }
        public int IdGestor { get; set; }
        public int IdCiudadano { get; set; }

        public virtual CentroVacunacion IdCentroVacunacionNavigation { get; set; }
        public virtual Ciudadano IdCiudadanoNavigation { get; set; }
        public virtual Gestor IdGestorNavigation { get; set; }

        public Cita1(string Fecha, string Hora, int IdCentroVacunacion, int IdGestor, int IdCiudadano)
        {
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.IdCentroVacunacion = IdCentroVacunacion;
            this.IdGestor = IdGestor;
            this.IdCiudadano = IdCiudadano;
        }
    }
}
