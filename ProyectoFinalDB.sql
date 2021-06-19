CREATE DATABASE ProyectoFinalDB;
USE ProyectoFinalDB;
SET LANGUAGE us_english;

-- CREANDO TABLAS
CREATE TABLE GESTOR(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	tipo_encargado VARCHAR(50) NOT NULL,
	correo_institucional VARCHAR(20) NOT NULL,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE CABINA(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	telefono VARCHAR(12) NOT NULL,
	correo_electronico VARCHAR(20) NOT NULL,
	nombre_encargado VARCHAR(50) NOT NULL
);

CREATE TABLE VACUNADOR(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	tipo_encargado VARCHAR(50) NOT NULL,
	correo_institucional VARCHAR(20) NOT NULL,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE ENFERMEDAD_CRONICA(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL,
);

CREATE TABLE INSTITUCION_ESENCIAL(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE USUARIO(
	id INT PRIMARY KEY IDENTITY,
	dui VARCHAR(10) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	correo_electronico VARCHAR(20) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	telefono VARCHAR(12) NOT NULL,
	id_institucion_esencial INT NULL, -- FK
	id_enfermedad_cronica INT NULL -- FK
);

CREATE TABLE VACUNA(
	id INT PRIMARY KEY IDENTITY,
	fecha_espera_vacuna1 DATETIME NULL,
	fecha_vacunacion_vacuna1 DATETIME NULL,
	fecha_espera_vacuna2 DATETIME NULL,
	fecha_vacunacion_vacuna2 DATETIME NULL,
	id_usuario INT --FK
);

CREATE TABLE CITA(
	id INT PRIMARY KEY IDENTITY,
	fecha_cita1 DATETIME NULL,
	lugar_vacunacion1 VARCHAR(50) NULL,
	fecha_cita2 DATETIME NULL,
	lugar_vacunacion2 VARCHAR(50) NULL,
	id_gestor INT NOT NULL, --FK
	id_usuario INT NOT NULL --FK
);

CREATE TABLE EFECTO_SECUNDARIO(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL,
	id_vacuna INT NULL -- FK
);

CREATE TABLE APLICAR_VACUNA(
	id_vacunador INT NOT NULL,
	id_vacuna INT NOT NULL
	CONSTRAINT PK_VacunanorxVacuna PRIMARY KEY (id_vacunador,id_vacuna)
);

CREATE TABLE INICIO_SESION(
	id_gestor INT NOT NULL,
	id_cabina INT NOT NULL,
	CONSTRAINT PK_GestorxCabina PRIMARY KEY (id_gestor,id_cabina)
);

-- CREANDO LLAVES FORANEAS (FK)
-- gestor -> cita
ALTER TABLE CITA ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- usuario -> cita
ALTER TABLE CITA ADD FOREIGN KEY (id_usuario) REFERENCES USUARIO(id);
-- usuario -> vacuna
ALTER TABLE VACUNA ADD FOREIGN KEY (id_usuario) REFERENCES USUARIO(id);
-- institucion_esencial -> usuario
ALTER TABLE USUARIO ADD FOREIGN KEY (id_institucion_esencial) REFERENCES INSTITUCION_ESENCIAL(id);
-- enfermedad_cronica -> usuario
ALTER TABLE USUARIO ADD FOREIGN KEY (id_enfermedad_cronica) REFERENCES ENFERMEDAD_CRONICA(id);
-- vacuna -> efecto_secundario
ALTER TABLE EFECTO_SECUNDARIO ADD FOREIGN KEY (id_vacuna) REFERENCES VACUNA(id);
-- vacunador -> aplicar_vacuna
ALTER TABLE APLICAR_VACUNA ADD FOREIGN KEY (id_vacunador) REFERENCES VACUNADOR(id);
-- vacuna -> aplicar_vacuna
ALTER TABLE APLICAR_VACUNA ADD FOREIGN KEY (id_vacuna) REFERENCES VACUNA(id);
-- gestor -> inicio_sesion
ALTER TABLE INICIO_SESION ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- cabina -> inicio_sesion
ALTER TABLE INICIO_SESION ADD FOREIGN KEY (id_cabina) REFERENCES CABINA(id);

-- Insertando datos en institucion esencial
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Educacion');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Salud');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('PNC');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Fuerza Armada');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Periodismo');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Personal de gobierno');

-- Insertando datos en enfermedad cronica
INSERT INTO ENFERMEDAD_CRONICA VALUES('Enfermedad Cardiovascular');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Enfermedad Renal');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Enfermedad Respiratoria');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Diabetes');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Cancer');

-- Insertando efectos secundarios
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor en el brazo', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Enrojecimiento en el brazo', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Hinchazon en el brazo', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Cansancio', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor de cabeza', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor muscular', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Escalofrios', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Fiebre', NULL);
INSERT INTO EFECTO_SECUNDARIO VALUES('Nauseas', NULL);

SELECT * FROM INSTITUCION_ESENCIAL;
SELECT * FROM ENFERMEDAD_CRONICA;
SELECT * FROM EFECTO_SECUNDARIO;
SELECT * FROM USUARIO;

-- dotnet ef dbcontext scaffold ”Server=PEÑA; Database=ProyectoFinalDB; Trusted_Connection=True;” Microsoft.EntityFrameworkCore.SqlServer -c ProyectoFinalContext
-- dotnet ef migrations add init (migracion inicial)
-- dotnet ef migrations add changeN (migraciones -N)
-- dotnet ef database update changeN (actualiza la migracion -N en la BD)