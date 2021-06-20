CREATE DATABASE ProyectoFinalDB;
USE ProyectoFinalDB;
SET LANGUAGE us_english;

-- CREANDO TABLAS
CREATE TABLE GESTOR(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	tipo_encargado VARCHAR(50) NOT NULL,
	correo_institucional VARCHAR(50) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	contrase�a VARCHAR(8)
);

CREATE TABLE CABINA(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	telefono VARCHAR(12) NOT NULL,
	id_gestor INT NULL--FK
);

CREATE TABLE VACUNADOR(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	tipo_encargado VARCHAR(50) NOT NULL,
	correo_institucional VARCHAR(50) NOT NULL,
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
	correo_electronico VARCHAR(50),
	nombre VARCHAR(50) NOT NULL,
	telefono VARCHAR(12) NOT NULL,
	id_institucion_esencial INT NULL, -- FK
	id_enfermedad_cronica INT NULL -- FK
);

CREATE TABLE VACUNA(
	id INT PRIMARY KEY IDENTITY,
	fecha_espera_vacuna1 VARCHAR(10) NULL,
	hora_vacuna1 VARCHAR(5) NULL,
	fecha_vacunacion_vacuna1 VARCHAR(10) NULL,
	hora_vacunacion1 VARCHAR(5) NULL,
	fecha_espera_vacuna2 VARCHAR(10) NULL,
	hora_vacuna2 VARCHAR(5) NULL,
	fecha_vacunacion_vacuna2 VARCHAR(10) NULL,
	hora_vacunacion2 VARCHAR(5) NULL,
	id_usuario INT --FK
);

CREATE TABLE CITA(
	id INT PRIMARY KEY IDENTITY,
	fecha_cita1 VARCHAR(10) NULL,
	hora_cita1 VARCHAR(5) NULL,
	lugar_vacunacion1 VARCHAR(50) NULL,
	fecha_cita2 VARCHAR(10) NULL,
	hora_cita2 VARCHAR(5) NULL,
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
-- gestor -> cabina
ALTER TABLE CABINA ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
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
INSERT INTO INSTITUCION_ESENCIAL VALUES ('NA'); -- No aplica

-- Insertando datos en enfermedad cronica
INSERT INTO ENFERMEDAD_CRONICA VALUES('Enfermedad Cardiovascular');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Enfermedad Renal');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Enfermedad Respiratoria');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Diabetes');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Cancer');
INSERT INTO ENFERMEDAD_CRONICA VALUES('NA'); -- No aplica

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

INSERT INTO GESTOR VALUES ('Bo El Centro Av Anastasio Aquino','Soporte T�cnico','anselmoq@gob.cov.sv','Anselmo Quinton Consuelo Holgu�n','e6Jd4ZjD'); 
INSERT INTO GESTOR VALUES ('Bo El Centro 4 Av Sur No 1-11','Soporte T�cnico','roslyne@gob.cov.sv','Roslyn Evelyn Sara Stephens','0YFlrYx6'); 
INSERT INTO GESTOR VALUES ('Bo El Carmen Av Staben No 11','Soporte T�cnico','ingramv@gob.cov.sv','Ingram Velda Truman Reyes','UqLHmm9n'); 
INSERT INTO GESTOR VALUES ('2 Av Sur No 3 San Juan Opico','Soporte T�cnico','sonnyg@gob.cov.sv','Sonny Garfield Eleanor Hancock','alW4kOlV'); 
INSERT INTO GESTOR VALUES ('Resid Pilarica 59 Av Sur No 1','Enfermer�a','coryj@gob.cov.sv','Cory Jessica Georgina Samuel','yAwqxFYi'); 
INSERT INTO GESTOR VALUES ('Urb Jard De Vista Hermosa Av Bella Vista No 23','Enfermer�a','suzane@gob.cov.sv','Suzan Etelvina Custodio Quixada','Z8ZBszEM'); 
INSERT INTO GESTOR VALUES ('Col Layco 29 Cl Pte No 1119','Enfermer�a','vanessam@gob.cov.sv','Vanessa M�ximo Mar�a White','AYtEA9M4'); 
INSERT INTO GESTOR VALUES ('Av Central Sur No 4 - 41, Atiquizaya','Enfermer�a','estebanv@gob.cov.sv','Esteban Vance Praise Knight','7Ios3vMm'); 
INSERT INTO GESTOR VALUES ('Col Jard De La Sabana I Polig 3-E Sda 6 No 31','Doctor','nohemia@gob.cov.sv','Nohemi Ariel Renata Hollands','AG9TzZlm'); 

INSERT INTO VACUNADOR VALUES ('Col Jard De La Sabana I Polig 3-E Sda 6 No 31','Doctor','eusreg@gov.cov.sv','Eusebio Regino Tyron Goddard'); 
INSERT INTO VACUNADOR VALUES ('Bo Nuevo 25 Cl Pte No 1320-B','Doctor','julpau@gov.cov.sv','Julianna Paul Jamison Ortiz'); 
INSERT INTO VACUNADOR VALUES ('Col Roma Cl Lorena Edif Milagro','Doctor','texzar@gov.cov.sv','Tex Zara Wilford Priestley'); 
INSERT INTO VACUNADOR VALUES ('Col Layco 25 Av Nte No 1423 Loc 3','Doctor','primer@gov.cov.sv','Prince Merlyn Jared Hatheway'); 
INSERT INTO VACUNADOR VALUES ('Bo El Centro Cl Ppal','Doctor','lucosm@gov.cov.sv','Luciano Osmaro Boone Woodward'); 
INSERT INTO VACUNADOR VALUES ('Col Lomas De San Francisco Cl Circunv No 10','Enfermeria','fawcru@gov.cov.sv','Fawn Cyrus Rosamond Pocock'); 
INSERT INTO VACUNADOR VALUES ('Col Escal�n 97 Av Nte No 734','Enfermer�a','catmar@gov.cov.sv','Catherine Mar�a de Jes�s Aitana Clay'); 
INSERT INTO VACUNADOR VALUES ('Blvd Venezuela Col Roma No 3416','Enfermer�a','shaama@gov.cov.sv','Sharon Amarilis Fredric Pav�a'); 
INSERT INTO VACUNADOR VALUES ('Bo El Angel Cl Alberto Masferrer No 4-10','Enfermer�a','antcar@gov.cov.sv','Antonia Carmen Pastora Parks'); 
INSERT INTO VACUNADOR VALUES (' Col Escal�n 79 Av Sur No 320','Enfermer�a','erimag@gov.cov.sv','Ericka Magdalen Elaina Woodcock'); 

/*CREATE TABLE CABINA(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NOT NULL,
	telefono VARCHAR(12) NOT NULL,
	id_gestor VARCHAR(50) NOT NULL --FK
);*/

INSERT INTO CABINA VALUES ('Av El Boquer�n Pol�g B-1 Jardines Del Volc�n','+50322894966','1');
INSERT INTO CABINA VALUES ('8 Cl Ote Y 1 Av Sur Sta Tecla','+50322291784','2');
INSERT INTO CABINA VALUES ('Col Jard De Merliot Cl Ayagualo No B-2 Cdad','+50322648550','3');
INSERT INTO CABINA VALUES ('Cl San Antonio Abad No 1817','+50322254277','4');
INSERT INTO CABINA VALUES ('Col Escal�n 91 Av Nte No 515','+50322515461','5');
INSERT INTO CABINA VALUES ('Col El Roble Cl 2 Av A Zona 9 No 133','+50323106614','6');
INSERT INTO CABINA VALUES ('Autop Nte Col El Milagro No 4 Mejicanos','+50326542987','7');
INSERT INTO CABINA VALUES ('Av Gregorio Melara No 14 Usulutan','+50322193122','8');
INSERT INTO CABINA VALUES ('Ps Gral Escal�n C C Galer�as 3Er Nvl Loc 348-B','+50322161862','9');
INSERT INTO CABINA VALUES ('Bo San Sebasti�n, 4 Av Sur No 11','+50324084558','9');

SELECT * FROM INSTITUCION_ESENCIAL;
SELECT * FROM ENFERMEDAD_CRONICA;
SELECT * FROM EFECTO_SECUNDARIO;
SELECT * FROM USUARIO;
SELECT * FROM CABINA;
SELECT * FROM GESTOR;
SELECT * FROM VACUNADOR;

DELETE FROM CABINA;

-- dotnet ef dbcontext scaffold �Server=PE�A; Database=ProyectoFinalDB; Trusted_Connection=True;� Microsoft.EntityFrameworkCore.SqlServer -c ProyectoFinalContext
-- dotnet ef migrations add init (migracion inicial)
-- dotnet ef migrations add changeN (migraciones -N)
-- dotnet ef database update changeN (actualiza la migracion -N en la BD)


--cmd para modificar base dentro de vs 
-- dotnet ef dbcontext scaffold "Data Source=DESKTOP-I2BFQIS;Initial Catalog=ProyectoFinalDB;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
