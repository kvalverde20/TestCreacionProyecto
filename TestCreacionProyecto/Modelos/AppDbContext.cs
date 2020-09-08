using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestCreacionProyecto.Modelos
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignacion> Asignacion { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Comunidad> Comunidad { get; set; }
        public virtual DbSet<Fase> Fase { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Grupofase> Grupofase { get; set; }
        public virtual DbSet<Ministerio> Ministerio { get; set; }
        public virtual DbSet<Multitabla> Multitabla { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Reunion> Reunion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=KERWIN;Database=BDAsistenciaShalom2; User ID=system;Password=system;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignacion>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion)
                    .HasName("PK__ASIGNACI__A7235DFF8BF13FD6");

                entity.ToTable("ASIGNACION");

                entity.HasIndex(e => e.IdGrupo)
                    .HasName("XIF2ASIGNACION");

                entity.HasIndex(e => e.IdPersona)
                    .HasName("XIF1ASIGNACION");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaSalida).HasColumnType("date");

                entity.Property(e => e.FormaIngreso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Asignacion)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_5");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Asignacion)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_3");
            });

            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.HasKey(e => e.IdAsistencia)
                    .HasName("PK__ASISTENC__3956DEE6548D1D7D");

                entity.ToTable("ASISTENCIA");

                entity.HasIndex(e => e.IdReunion)
                    .HasName("XIF1ASISTENCIA");

                entity.Property(e => e.Asistencia1)
                    .HasColumnName("Asistencia")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAsignacionNavigation)
                    .WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.IdAsignacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASISTENCIA_ASIGNACION");

                entity.HasOne(d => d.IdReunionNavigation)
                    .WithMany(p => p.Asistencia)
                    .HasForeignKey(d => d.IdReunion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASISTENCIA_REUNION");
            });

            modelBuilder.Entity<Comunidad>(entity =>
            {
                entity.HasKey(e => e.IdComunidad)
                    .HasName("PK__COMUNIDA__04AF005899C3762A");

                entity.ToTable("COMUNIDAD");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fase>(entity =>
            {
                entity.HasKey(e => e.IdFase)
                    .HasName("PK__FASE__1BFA035BEA4076EA");

                entity.ToTable("FASE");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PK__GRUPO__303F6FD9554881AB");

                entity.ToTable("GRUPO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiaReunion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Horario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoGrupo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grupofase>(entity =>
            {
                entity.HasKey(e => e.IdGrupoFase)
                    .HasName("PK__GRUPOFAS__08607055FBADB0BA");

                entity.ToTable("GRUPOFASE");

                entity.HasIndex(e => e.IdFase)
                    .HasName("XIF2GRUPOFASE");

                entity.HasIndex(e => e.IdGrupo)
                    .HasName("XIF1GRUPOFASE");

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFaseNavigation)
                    .WithMany(p => p.Grupofase)
                    .HasForeignKey(d => d.IdFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_8");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Grupofase)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_6");
            });

            modelBuilder.Entity<Ministerio>(entity =>
            {
                entity.HasKey(e => e.IdMinisterio)
                    .HasName("PK__MINISTER__2ACA545ED8277397");

                entity.ToTable("MINISTERIO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Multitabla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MULTITABLA");

                entity.Property(e => e.IdMultitabla)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MultitablaDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__PERSONA__2EC8D2AC907E55B1");

                entity.ToTable("PERSONA");

                entity.HasIndex(e => e.IdComunidad)
                    .HasName("XIF1PERSONA");

                entity.HasIndex(e => e.IdMinisterio)
                    .HasName("XIF2PERSONA");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoAsignacionGrupo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecNacimiento).HasColumnType("date");

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.NombreCompletoAcompanador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompletoResponsable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PaisOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoResponsable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdComunidadNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.IdComunidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_1");

                entity.HasOne(d => d.IdMinisterioNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.IdMinisterio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_2");
            });

            modelBuilder.Entity<Reunion>(entity =>
            {
                entity.HasKey(e => e.IdReunion)
                    .HasName("PK__REUNION__BA7539B3797A9C31");

                entity.ToTable("REUNION");

                entity.HasIndex(e => e.IdAsignacion)
                    .HasName("XIF1REUNION");

                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.FechaReunion).HasColumnType("date");

                entity.Property(e => e.Predicador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RhemaOracion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TemaFormacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActualizacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoFaseNavigation)
                    .WithMany(p => p.Reunion)
                    .HasForeignKey(d => d.IdGrupoFase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REUNION_GRUPOFASE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
