﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal;

namespace ProyectoFinal.Migrations
{
    [DbContext(typeof(ProyectoFinalContext))]
    partial class ProyectoFinalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoFinal.AplicarVacuna", b =>
                {
                    b.Property<int>("IdVacunador")
                        .HasColumnType("int")
                        .HasColumnName("id_vacunador");

                    b.Property<int>("IdVacuna")
                        .HasColumnType("int")
                        .HasColumnName("id_vacuna");

                    b.HasKey("IdVacunador", "IdVacuna")
                        .HasName("PK_VacunanorxVacuna");

                    b.HasIndex("IdVacuna");

                    b.ToTable("APLICAR_VACUNA");
                });

            modelBuilder.Entity("ProyectoFinal.Cabina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("correo_electronico");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("NombreEncargado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_encargado");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.ToTable("CABINA");
                });

            modelBuilder.Entity("ProyectoFinal.Citum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaCita1")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_cita1");

                    b.Property<DateTime?>("FechaCita2")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_cita2");

                    b.Property<int>("IdGestor")
                        .HasColumnType("int")
                        .HasColumnName("id_gestor");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<string>("LugarVacunacion1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lugar_vacunacion1");

                    b.Property<string>("LugarVacunacion2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lugar_vacunacion2");

                    b.HasKey("Id");

                    b.HasIndex("IdGestor");

                    b.HasIndex("IdUsuario");

                    b.ToTable("CITA");
                });

            modelBuilder.Entity("ProyectoFinal.EfectoSecundario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdVacuna")
                        .HasColumnType("int")
                        .HasColumnName("id_vacuna");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.HasIndex("IdVacuna");

                    b.ToTable("EFECTO_SECUNDARIO");
                });

            modelBuilder.Entity("ProyectoFinal.EnfermedadCronica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("ENFERMEDAD_CRONICA");
                });

            modelBuilder.Entity("ProyectoFinal.Gestor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoInstitucional")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("correo_institucional");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("TipoEncargado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipo_encargado");

                    b.HasKey("Id");

                    b.ToTable("GESTOR");
                });

            modelBuilder.Entity("ProyectoFinal.InicioSesion", b =>
                {
                    b.Property<int>("IdGestor")
                        .HasColumnType("int")
                        .HasColumnName("id_gestor");

                    b.Property<int>("IdCabina")
                        .HasColumnType("int")
                        .HasColumnName("id_cabina");

                    b.HasKey("IdGestor", "IdCabina")
                        .HasName("PK_GestorxCabina");

                    b.HasIndex("IdCabina");

                    b.ToTable("INICIO_SESION");
                });

            modelBuilder.Entity("ProyectoFinal.InstitucionEsencial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("INSTITUCION_ESENCIAL");
                });

            modelBuilder.Entity("ProyectoFinal.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("correo_electronico");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("Dui")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("dui");

                    b.Property<int?>("IdEnfermedadCronica")
                        .HasColumnType("int")
                        .HasColumnName("id_enfermedad_cronica");

                    b.Property<int?>("IdInstitucionEsencial")
                        .HasColumnType("int")
                        .HasColumnName("id_institucion_esencial");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.HasIndex("IdEnfermedadCronica");

                    b.HasIndex("IdInstitucionEsencial");

                    b.ToTable("USUARIO");
                });

            modelBuilder.Entity("ProyectoFinal.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaEsperaVacuna1")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_espera_vacuna1");

                    b.Property<DateTime?>("FechaEsperaVacuna2")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_espera_vacuna2");

                    b.Property<DateTime?>("FechaVacunacionVacuna1")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_vacunacion_vacuna1");

                    b.Property<DateTime?>("FechaVacunacionVacuna2")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha_vacunacion_vacuna2");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("VACUNA");
                });

            modelBuilder.Entity("ProyectoFinal.Vacunador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoInstitucional")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("correo_institucional");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("TipoEncargado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipo_encargado");

                    b.HasKey("Id");

                    b.ToTable("VACUNADOR");
                });

            modelBuilder.Entity("ProyectoFinal.AplicarVacuna", b =>
                {
                    b.HasOne("ProyectoFinal.Vacuna", "IdVacunaNavigation")
                        .WithMany("AplicarVacunas")
                        .HasForeignKey("IdVacuna")
                        .HasConstraintName("FK__APLICAR_V__id_va__3E52440B")
                        .IsRequired();

                    b.HasOne("ProyectoFinal.Vacunador", "IdVacunadorNavigation")
                        .WithMany("AplicarVacunas")
                        .HasForeignKey("IdVacunador")
                        .HasConstraintName("FK__APLICAR_V__id_va__3D5E1FD2")
                        .IsRequired();

                    b.Navigation("IdVacunadorNavigation");

                    b.Navigation("IdVacunaNavigation");
                });

            modelBuilder.Entity("ProyectoFinal.Citum", b =>
                {
                    b.HasOne("ProyectoFinal.Gestor", "IdGestorNavigation")
                        .WithMany("Cita")
                        .HasForeignKey("IdGestor")
                        .HasConstraintName("FK__CITA__id_gestor__37A5467C")
                        .IsRequired();

                    b.HasOne("ProyectoFinal.Usuario", "IdUsuarioNavigation")
                        .WithMany("Cita")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__CITA__id_usuario__38996AB5")
                        .IsRequired();

                    b.Navigation("IdGestorNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("ProyectoFinal.EfectoSecundario", b =>
                {
                    b.HasOne("ProyectoFinal.Vacuna", "IdVacunaNavigation")
                        .WithMany("EfectoSecundarios")
                        .HasForeignKey("IdVacuna")
                        .HasConstraintName("FK__EFECTO_SE__id_va__3C69FB99");

                    b.Navigation("IdVacunaNavigation");
                });

            modelBuilder.Entity("ProyectoFinal.InicioSesion", b =>
                {
                    b.HasOne("ProyectoFinal.Cabina", "IdCabinaNavigation")
                        .WithMany("InicioSesions")
                        .HasForeignKey("IdCabina")
                        .HasConstraintName("FK__INICIO_SE__id_ca__403A8C7D")
                        .IsRequired();

                    b.HasOne("ProyectoFinal.Gestor", "IdGestorNavigation")
                        .WithMany("InicioSesions")
                        .HasForeignKey("IdGestor")
                        .HasConstraintName("FK__INICIO_SE__id_ge__3F466844")
                        .IsRequired();

                    b.Navigation("IdCabinaNavigation");

                    b.Navigation("IdGestorNavigation");
                });

            modelBuilder.Entity("ProyectoFinal.Usuario", b =>
                {
                    b.HasOne("ProyectoFinal.EnfermedadCronica", "IdEnfermedadCronicaNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdEnfermedadCronica")
                        .HasConstraintName("FK__USUARIO__id_enfe__3B75D760");

                    b.HasOne("ProyectoFinal.InstitucionEsencial", "IdInstitucionEsencialNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdInstitucionEsencial")
                        .HasConstraintName("FK__USUARIO__id_inst__3A81B327");

                    b.Navigation("IdEnfermedadCronicaNavigation");

                    b.Navigation("IdInstitucionEsencialNavigation");
                });

            modelBuilder.Entity("ProyectoFinal.Vacuna", b =>
                {
                    b.HasOne("ProyectoFinal.Usuario", "IdUsuarioNavigation")
                        .WithMany("Vacunas")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__VACUNA__id_usuar__398D8EEE");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("ProyectoFinal.Cabina", b =>
                {
                    b.Navigation("InicioSesions");
                });

            modelBuilder.Entity("ProyectoFinal.EnfermedadCronica", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal.Gestor", b =>
                {
                    b.Navigation("Cita");

                    b.Navigation("InicioSesions");
                });

            modelBuilder.Entity("ProyectoFinal.InstitucionEsencial", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal.Usuario", b =>
                {
                    b.Navigation("Cita");

                    b.Navigation("Vacunas");
                });

            modelBuilder.Entity("ProyectoFinal.Vacuna", b =>
                {
                    b.Navigation("AplicarVacunas");

                    b.Navigation("EfectoSecundarios");
                });

            modelBuilder.Entity("ProyectoFinal.Vacunador", b =>
                {
                    b.Navigation("AplicarVacunas");
                });
#pragma warning restore 612, 618
        }
    }
}
