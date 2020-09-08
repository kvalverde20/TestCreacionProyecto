using System;
using System.Collections.Generic;

namespace TestCreacionProyecto.Modelos
{
    public partial class Grupofase
    {
        public Grupofase()
        {
            Reunion = new HashSet<Reunion>();
        }

        public int IdGrupoFase { get; set; }
        public int IdFase { get; set; }
        public int IdGrupo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Fase IdFaseNavigation { get; set; }
        public virtual Grupo IdGrupoNavigation { get; set; }
        public virtual ICollection<Reunion> Reunion { get; set; }
    }
}
