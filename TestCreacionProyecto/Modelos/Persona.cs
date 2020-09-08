using System;
using System.Collections.Generic;

namespace TestCreacionProyecto.Modelos
{
    public partial class Persona
    {
        public Persona()
        {
            Asignacion = new HashSet<Asignacion>();
        }

        public int IdPersona { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FecNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string PaisOrigen { get; set; }
        public string NombreCompletoResponsable { get; set; }
        public string TelefonoResponsable { get; set; }
        public string EstadoCivil { get; set; }
        public int? NumeroHijos { get; set; }
        public string NombreCompletoAcompanador { get; set; }
        public int IdComunidad { get; set; }
        public int IdMinisterio { get; set; }
        public bool? Estado { get; set; }
        public string EstadoAsignacionGrupo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public virtual Comunidad IdComunidadNavigation { get; set; }
        public virtual Ministerio IdMinisterioNavigation { get; set; }
        public virtual ICollection<Asignacion> Asignacion { get; set; }
    }
}
