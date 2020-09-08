using System;
using System.Collections.Generic;

namespace TestCreacionProyecto.Modelos
{
    public partial class Asignacion
    {
        public Asignacion()
        {
            Asistencia = new HashSet<Asistencia>();
        }

        public int IdAsignacion { get; set; }
        public int IdPersona { get; set; }
        public int IdGrupo { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string FormaIngreso { get; set; }
        public string Cargo { get; set; }
        public bool? Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Grupo IdGrupoNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
    }
}
