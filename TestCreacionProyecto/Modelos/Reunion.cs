using System;
using System.Collections.Generic;

namespace TestCreacionProyecto.Modelos
{
    public partial class Reunion
    {
        public Reunion()
        {
            Asistencia = new HashSet<Asistencia>();
        }

        public int IdReunion { get; set; }
        public int IdGrupoFase { get; set; }
        public DateTime? FechaReunion { get; set; }
        public string TipoReunion { get; set; }
        public string TemaFormacion { get; set; }
        public string RhemaOracion { get; set; }
        public string Predicador { get; set; }
        public int IdAsignacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Grupofase IdGrupoFaseNavigation { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
    }
}
