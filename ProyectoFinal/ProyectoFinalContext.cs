using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProyectoFinal.Model
{
    public partial class ProyectoFinalContext : DbContext
    {
        public ProyectoFinalContext()
        {
        }

        public ProyectoFinalContext(DbContextOptions<ProyectoFinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AplicarVacuna> AplicarVacunas { get; set; }
        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<EfectoSecundario> EfectoSecundarios { get; set; }
        public virtual DbSet<EnfermedadCronica> EnfermedadCronicas { get; set; }
        public virtual DbSet<Gestor> Gestors { get; set; }
        public virtual DbSet<InicioSesion> InicioSesions { get; set; }
        public virtual DbSet<InstitucionEsencial> InstitucionEsencials { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vacuna> Vacunas { get; set; }
        public virtual DbSet<Vacunador> Vacunadors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PEÑA; Database=ProyectoFinalDB; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AplicarVacuna>(entity =>
            {
                entity.HasKey(e => new { e.IdVacunador, e.IdVacuna })
                    .HasName("PK_VacunanorxVacuna");

                entity.ToTable("APLICAR_VACUNA");

                entity.Property(e => e.IdVacunador).HasColumnName("id_vacunador");

                entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");

                entity.HasOne(d => d.IdVacunaNavigation)
                    .WithMany(p => p.AplicarVacunas)
                    .HasForeignKey(d => d.IdVacuna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APLICAR_V__id_va__3F466844");

                entity.HasOne(d => d.IdVacunadorNavigation)
                    .WithMany(p => p.AplicarVacunas)
                    .HasForeignKey(d => d.IdVacunador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APLICAR_V__id_va__3E52440B");
            });

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.ToTable("CABINA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Cabinas)
                    .HasForeignKey(d => d.IdGestor)
                    .HasConstraintName("FK__CABINA__id_gesto__37A5467C");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.ToTable("CITA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaCita1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_cita1");

                entity.Property(e => e.FechaCita2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_cita2");

                entity.Property(e => e.HoraCita1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_cita1");

                entity.Property(e => e.HoraCita2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_cita2");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.LugarVacunacion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugar_vacunacion1");

                entity.Property(e => e.LugarVacunacion2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugar_vacunacion2");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__id_gestor__38996AB5");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__id_usuario__398D8EEE");
            });

            modelBuilder.Entity<EfectoSecundario>(entity =>
            {
                entity.ToTable("EFECTO_SECUNDARIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdVacunaNavigation)
                    .WithMany(p => p.EfectoSecundarios)
                    .HasForeignKey(d => d.IdVacuna)
                    .HasConstraintName("FK__EFECTO_SE__id_va__3D5E1FD2");
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
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.CorreoInstitucional)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_institucional");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.TipoEncargado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_encargado");
            });

            modelBuilder.Entity<InicioSesion>(entity =>
            {
                entity.HasKey(e => new { e.IdGestor, e.IdCabina })
                    .HasName("PK_GestorxCabina");

                entity.ToTable("INICIO_SESION");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.InicioSesions)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INICIO_SE__id_ca__412EB0B6");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.InicioSesions)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INICIO_SE__id_ge__403A8C7D");
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

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dui)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.IdEnfermedadCronica).HasColumnName("id_enfermedad_cronica");

                entity.Property(e => e.IdInstitucionEsencial).HasColumnName("id_institucion_esencial");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdEnfermedadCronicaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEnfermedadCronica)
                    .HasConstraintName("FK__USUARIO__id_enfe__3C69FB99");

                entity.HasOne(d => d.IdInstitucionEsencialNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdInstitucionEsencial)
                    .HasConstraintName("FK__USUARIO__id_inst__3B75D760");
            });

            modelBuilder.Entity<Vacuna>(entity =>
            {
                entity.ToTable("VACUNA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaEsperaVacuna1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_espera_vacuna1");

                entity.Property(e => e.FechaEsperaVacuna2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_espera_vacuna2");

                entity.Property(e => e.FechaVacunacionVacuna1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_vacunacion_vacuna1");

                entity.Property(e => e.FechaVacunacionVacuna2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha_vacunacion_vacuna2");

                entity.Property(e => e.HoraVacuna1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_vacuna1");

                entity.Property(e => e.HoraVacuna2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_vacuna2");

                entity.Property(e => e.HoraVacunacion1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_vacunacion1");

                entity.Property(e => e.HoraVacunacion2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hora_vacunacion2");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Vacunas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__VACUNA__id_usuar__3A81B327");
            });

            modelBuilder.Entity<Vacunador>(entity =>
            {
                entity.ToTable("VACUNADOR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorreoInstitucional)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_institucional");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.TipoEncargado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_encargado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
