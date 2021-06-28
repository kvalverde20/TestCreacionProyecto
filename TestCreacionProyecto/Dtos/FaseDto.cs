using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCreacionProyecto.Dtos
{
    public class FaseDto
    {
        public int IdFase { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? Duracion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
