using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CABINA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    correo_electronico = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    nombre_encargado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABINA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ENFERMEDAD_CRONICA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENFERMEDAD_CRONICA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GESTOR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tipo_encargado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    correo_institucional = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GESTOR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUCION_ESENCIAL",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTITUCION_ESENCIAL", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VACUNADOR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tipo_encargado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    correo_institucional = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VACUNADOR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "INICIO_SESION",
                columns: table => new
                {
                    id_gestor = table.Column<int>(type: "int", nullable: false),
                    id_cabina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestorxCabina", x => new { x.id_gestor, x.id_cabina });
                    table.ForeignKey(
                        name: "FK__INICIO_SE__id_ca__403A8C7D",
                        column: x => x.id_cabina,
                        principalTable: "CABINA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__INICIO_SE__id_ge__3F466844",
                        column: x => x.id_gestor,
                        principalTable: "GESTOR",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dui = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    correo_electronico = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    id_institucion_esencial = table.Column<int>(type: "int", nullable: true),
                    id_enfermedad_cronica = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.id);
                    table.ForeignKey(
                        name: "FK__USUARIO__id_enfe__3B75D760",
                        column: x => x.id_enfermedad_cronica,
                        principalTable: "ENFERMEDAD_CRONICA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__USUARIO__id_inst__3A81B327",
                        column: x => x.id_institucion_esencial,
                        principalTable: "INSTITUCION_ESENCIAL",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CITA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_cita1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    lugar_vacunacion1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fecha_cita2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    lugar_vacunacion2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_gestor = table.Column<int>(type: "int", nullable: false),
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITA", x => x.id);
                    table.ForeignKey(
                        name: "FK__CITA__id_gestor__37A5467C",
                        column: x => x.id_gestor,
                        principalTable: "GESTOR",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__CITA__id_usuario__38996AB5",
                        column: x => x.id_usuario,
                        principalTable: "USUARIO",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VACUNA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_espera_vacuna1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_vacunacion_vacuna1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_espera_vacuna2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecha_vacunacion_vacuna2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    id_usuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VACUNA", x => x.id);
                    table.ForeignKey(
                        name: "FK__VACUNA__id_usuar__398D8EEE",
                        column: x => x.id_usuario,
                        principalTable: "USUARIO",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APLICAR_VACUNA",
                columns: table => new
                {
                    id_vacunador = table.Column<int>(type: "int", nullable: false),
                    id_vacuna = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacunanorxVacuna", x => new { x.id_vacunador, x.id_vacuna });
                    table.ForeignKey(
                        name: "FK__APLICAR_V__id_va__3D5E1FD2",
                        column: x => x.id_vacunador,
                        principalTable: "VACUNADOR",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__APLICAR_V__id_va__3E52440B",
                        column: x => x.id_vacuna,
                        principalTable: "VACUNA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EFECTO_SECUNDARIO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    id_vacuna = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EFECTO_SECUNDARIO", x => x.id);
                    table.ForeignKey(
                        name: "FK__EFECTO_SE__id_va__3C69FB99",
                        column: x => x.id_vacuna,
                        principalTable: "VACUNA",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APLICAR_VACUNA_id_vacuna",
                table: "APLICAR_VACUNA",
                column: "id_vacuna");

            migrationBuilder.CreateIndex(
                name: "IX_CITA_id_gestor",
                table: "CITA",
                column: "id_gestor");

            migrationBuilder.CreateIndex(
                name: "IX_CITA_id_usuario",
                table: "CITA",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_EFECTO_SECUNDARIO_id_vacuna",
                table: "EFECTO_SECUNDARIO",
                column: "id_vacuna");

            migrationBuilder.CreateIndex(
                name: "IX_INICIO_SESION_id_cabina",
                table: "INICIO_SESION",
                column: "id_cabina");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_id_enfermedad_cronica",
                table: "USUARIO",
                column: "id_enfermedad_cronica");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_id_institucion_esencial",
                table: "USUARIO",
                column: "id_institucion_esencial");

            migrationBuilder.CreateIndex(
                name: "IX_VACUNA_id_usuario",
                table: "VACUNA",
                column: "id_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APLICAR_VACUNA");

            migrationBuilder.DropTable(
                name: "CITA");

            migrationBuilder.DropTable(
                name: "EFECTO_SECUNDARIO");

            migrationBuilder.DropTable(
                name: "INICIO_SESION");

            migrationBuilder.DropTable(
                name: "VACUNADOR");

            migrationBuilder.DropTable(
                name: "VACUNA");

            migrationBuilder.DropTable(
                name: "CABINA");

            migrationBuilder.DropTable(
                name: "GESTOR");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "ENFERMEDAD_CRONICA");

            migrationBuilder.DropTable(
                name: "INSTITUCION_ESENCIAL");
        }
    }
}
