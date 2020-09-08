using System;
using System.Collections.Generic;

namespace TestCreacionProyecto.Modelos
{
    public partial class Grupo
    {
        public Grupo()
        {
            Asignacion = new HashSet<Asignacion>();
            Grupofase = new HashSet<Grupofase>();
        }

        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string DiaReunion { get; set; }
        public string Horario { get; set; }
        public string TipoGrupo { get; set; }
        public bool? Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual ICollection<Asignacion> Asignacion { get; set; }
        public virtual ICollection<Grupofase> Grupofase { get; set; }
    }
}
