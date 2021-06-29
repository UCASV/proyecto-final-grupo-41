using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_Final.Models
{
    public partial class ProyectoFinalDBContext : DbContext
    {
        public ProyectoFinalDBContext()
        {
        }

        public ProyectoFinalDBContext(DbContextOptions<ProyectoFinalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<CentroVacunacion> CentroVacunacions { get; set; }
        public virtual DbSet<Cita1> Cita1s { get; set; }
        public virtual DbSet<Cita2> Cita2s { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<Dosi> Doses { get; set; }
        public virtual DbSet<DosisxEfectoSecundario> DosisxEfectoSecundarios { get; set; }
        public virtual DbSet<EfectoSecundario> EfectoSecundarios { get; set; }
        public virtual DbSet<EnfermedadCronica> EnfermedadCronicas { get; set; }
        public virtual DbSet<Gestor> Gestors { get; set; }
        public virtual DbSet<InicioSesion> InicioSesions { get; set; }
        public virtual DbSet<InstitucionEsencial> InstitucionEsencials { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleados { get; set; }
        public virtual DbSet<Vacuna> Vacunas { get; set; }
        public virtual DbSet<Vacunacion> Vacunacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PEÑA; Database=ProyectoFinalDB; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.ToTable("CABINA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<CentroVacunacion>(entity =>
            {
                entity.ToTable("CENTRO_VACUNACION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Cita1>(entity =>
            {
                entity.ToTable("CITA_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora");

                entity.Property(e => e.IdCentroVacunacion).HasColumnName("id_centro_vacunacion");

                entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.HasOne(d => d.IdCentroVacunacionNavigation)
                    .WithMany(p => p.Cita1s)
                    .HasForeignKey(d => d.IdCentroVacunacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA_1__id_centr__403A8C7D");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Cita1s)
                    .HasForeignKey(d => d.IdCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA_1__id_ciuda__4222D4EF");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Cita1s)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA_1__id_gesto__412EB0B6");
            });

            modelBuilder.Entity<Cita2>(entity =>
            {
                entity.ToTable("CITA_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora");

                entity.Property(e => e.IdCentroVacunacion).HasColumnName("id_centro_vacunacion");

                entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.HasOne(d => d.IdCentroVacunacionNavigation)
                    .WithMany(p => p.Cita2s)
                    .HasForeignKey(d => d.IdCentroVacunacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA_2__id_centr__4316F928");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Cita2s)
                    .HasForeignKey(d => d.IdCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA_2__id_ciuda__44FF419A");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Cita2s)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA_2__id_gesto__440B1D61");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.ToTable("CIUDADANO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dui)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.IdEnfermedadCronica).HasColumnName("id_enfermedad_cronica");

                entity.Property(e => e.IdInstitucionEsencial).HasColumnName("id_institucion_esencial");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdEnfermedadCronicaNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdEnfermedadCronica)
                    .HasConstraintName("FK__CIUDADANO__id_en__45F365D3");

                entity.HasOne(d => d.IdInstitucionEsencialNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdInstitucionEsencial)
                    .HasConstraintName("FK__CIUDADANO__id_in__46E78A0C");
            });

            modelBuilder.Entity<Dosi>(entity =>
            {
                entity.ToTable("DOSIS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaEspera)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_espera");

                entity.Property(e => e.FechaVacunacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_vacunacion");

                entity.Property(e => e.HoraEspera)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_espera");

                entity.Property(e => e.HoraVacunacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_vacunacion");

                entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");

                entity.HasOne(d => d.IdVacunaNavigation)
                    .WithMany(p => p.Dosis)
                    .HasForeignKey(d => d.IdVacuna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSIS__id_vacuna__47DBAE45");
            });

            modelBuilder.Entity<DosisxEfectoSecundario>(entity =>
            {
                entity.HasKey(e => new { e.IdDosis, e.IdEfectoSecundario })
                    .HasName("PK_VacunaxEfectoSecundario");

                entity.ToTable("DOSISxEFECTO_SECUNDARIO");

                entity.Property(e => e.IdDosis).HasColumnName("id_dosis");

                entity.Property(e => e.IdEfectoSecundario).HasColumnName("id_efecto_secundario");

                entity.HasOne(d => d.IdDosisNavigation)
                    .WithMany(p => p.DosisxEfectoSecundarios)
                    .HasForeignKey(d => d.IdDosis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSISxEFE__id_do__4CA06362");

                entity.HasOne(d => d.IdEfectoSecundarioNavigation)
                    .WithMany(p => p.DosisxEfectoSecundarios)
                    .HasForeignKey(d => d.IdEfectoSecundario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSISxEFE__id_ef__4D94879B");
            });

            modelBuilder.Entity<EfectoSecundario>(entity =>
            {
                entity.ToTable("EFECTO_SECUNDARIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<EnfermedadCronica>(entity =>
            {
                entity.ToTable("ENFERMEDAD_CRONICA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Gestor>(entity =>
            {
                entity.ToTable("GESTOR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.CorreoInstitucional)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo_institucional");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdTipoEmpleado).HasColumnName("id_tipo_empleado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdTipoEmpleadoNavigation)
                    .WithMany(p => p.Gestors)
                    .HasForeignKey(d => d.IdTipoEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GESTOR__id_tipo___3F466844");
            });

            modelBuilder.Entity<InicioSesion>(entity =>
            {
                entity.HasKey(e => new { e.IdGestor, e.IdCabina })
                    .HasName("PK_GestorxCabina");

                entity.ToTable("INICIO_SESION");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.FechaYHora)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fecha_y_hora");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.InicioSesions)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INICIO_SE__id_ca__49C3F6B7");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.InicioSesions)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INICIO_SE__id_ge__48CFD27E");
            });

            modelBuilder.Entity<InstitucionEsencial>(entity =>
            {
                entity.ToTable("INSTITUCION_ESENCIAL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoEmpleado>(entity =>
            {
                entity.ToTable("TIPO_EMPLEADO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Vacuna>(entity =>
            {
                entity.ToTable("VACUNA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Vacunacion>(entity =>
            {
                entity.HasKey(e => new { e.IdCiudadano, e.IdDosis })
                    .HasName("PK_VacunanorxVacuna");

                entity.ToTable("VACUNACION");

                entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");

                entity.Property(e => e.IdDosis).HasColumnName("id_dosis");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Vacunacions)
                    .HasForeignKey(d => d.IdCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACUNACIO__id_ci__4AB81AF0");

                entity.HasOne(d => d.IdDosisNavigation)
                    .WithMany(p => p.Vacunacions)
                    .HasForeignKey(d => d.IdDosis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACUNACIO__id_do__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
