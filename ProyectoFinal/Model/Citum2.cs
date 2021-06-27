using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    public partial class Citum2
    {
        public int Id { get; set; }
        public string FechaCita2 { get; set; }
        public string HoraCita2 { get; set; }
        public int IdGestor { get; set; }
        public int IdUsuario { get; set; }
        public int IdCentroVacunacion { get; set; }

        public virtual CentroVacunacion IdCentroVacunacionNavigation { get; set; }
        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }

        public Citum2(string fechaCita2, string horaCita2, int idGestor, int idUsuario, int idCentroVacunacion)
        {
            FechaCita2 = fechaCita2;
            HoraCita2 = horaCita2;
            IdGestor = idGestor;
            IdUsuario = idUsuario;
            IdCentroVacunacion = idCentroVacunacion;
        }
    }
}
