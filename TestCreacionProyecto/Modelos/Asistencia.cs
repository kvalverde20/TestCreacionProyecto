using System;
using System.Collections.Generic;

namespace TestCreacionProyecto.Modelos
{
    public partial class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdReunion { get; set; }
        public int IdAsignacion { get; set; }
        public string Asistencia1 { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Asignacion IdAsignacionNavigation { get; set; }
        public virtual Reunion IdReunionNavigation { get; set; }
    }
}
