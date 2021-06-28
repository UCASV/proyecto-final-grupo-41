CREATE DATABASE ProyectoFinalDB;
USE ProyectoFinalDB;
SET LANGUAGE us_english;

-- CREANDO TABLAS CATALOGO
CREATE TABLE TIPO_EMPLEADO(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE INSTITUCION_ESENCIAL(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE ENFERMEDAD_CRONICA(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL,
);

CREATE TABLE VACUNA(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE CENTRO_VACUNACION(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL
);

-- CREANDO TABLAS SIN FK
CREATE TABLE EFECTO_SECUNDARIO(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50) NOT NULL
);

CREATE TABLE CABINA(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NULL,
	telefono VARCHAR(8) NOT NULL,
	correo_electronico VARCHAR(100) NULL
);

-- CREANDO TABLAS CON FK
CREATE TABLE GESTOR(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR(50) NULL,
	nombre VARCHAR(50) NOT NULL,
	correo_institucional VARCHAR(100) NULL,
	usuario VARCHAR(50) NOT NULL,
	contraseña VARCHAR(8) NOT NULL,
	id_tipo_empleado INT NOT NULL
);

CREATE TABLE CITA_1(
	id INT PRIMARY KEY IDENTITY,
	fecha VARCHAR(10) NULL,
	hora VARCHAR(5) NULL,
	id_centro_vacunacion INT NOT NULL,
	id_gestor INT NOT NULL,
	id_ciudadano INT NOT NULL
);

CREATE TABLE CITA_2(
	id INT PRIMARY KEY IDENTITY,
	fecha VARCHAR(10) NULL,
	hora VARCHAR(5) NULL,
	id_centro_vacunacion INT NOT NULL,
	id_gestor INT NOT NULL,
	id_ciudadano INT NOT NULL
);

CREATE TABLE CIUDADANO(
	id INT PRIMARY KEY IDENTITY,
	DUI VARCHAR(10) NOT NULL,
	direccion VARCHAR(50) NULL,
	correo_electronico VARCHAR(100) NULL,
	nombre VARCHAR(50) NOT NULL,
	telefono VARCHAR(8) NOT NULL,
	id_enfermedad_cronica INT NULL,
	id_institucion_esencial INT NULL
);

CREATE TABLE DOSIS(
	id INT PRIMARY KEY IDENTITY,
	fecha_espera VARCHAR(10) NULL,
	hora_espera VARCHAR(5) NULL,
	fecha_vacunacion VARCHAR(10) NULL,
	hora_vacunacion VARCHAR(5) NULL,
	id_vacuna INT NOT NULL
);

-- TABLAS N:N
CREATE TABLE INICIO_SESION(
	id_gestor INT NOT NULL,
	id_cabina INT NOT NULL,
	fecha_y_hora VARCHAR(20) NOT NULL,
	CONSTRAINT PK_GestorxCabina PRIMARY KEY (id_gestor,id_cabina)
);

CREATE TABLE VACUNACION(
	id_ciudadano INT NOT NULL,
	id_dosis INT NOT NULL
	CONSTRAINT PK_VacunanorxVacuna PRIMARY KEY (id_ciudadano,id_dosis)
);

CREATE TABLE DOSISxEFECTO_SECUNDARIO(
	id_dosis INT NOT NULL,
	id_efecto_secundario INT NOT NULL,
	CONSTRAINT PK_VacunaxEfectoSecundario PRIMARY KEY(id_dosis, id_efecto_secundario)
);

-- CREANDO LLAVES FORANEAS (FK)
-- tipo_empleado -> gestor
ALTER TABLE GESTOR ADD FOREIGN KEY (id_tipo_empleado) REFERENCES TIPO_EMPLEADO(id);
-- centro_vacunacion -> cita_1
ALTER TABLE CITA_1 ADD FOREIGN KEY (id_centro_vacunacion) REFERENCES CENTRO_VACUNACION(id);
-- gestor -> cita_1
ALTER TABLE CITA_1 ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- ciudadano -> cita_1
ALTER TABLE CITA_1 ADD FOREIGN KEY (id_ciudadano) REFERENCES CIUDADANO(id);
-- centro_vacunacion -> cita_2
ALTER TABLE CITA_2 ADD FOREIGN KEY (id_centro_vacunacion) REFERENCES CENTRO_VACUNACION(id);
-- gestor -> cita_2
ALTER TABLE CITA_2 ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- ciudadano -> cita_2
ALTER TABLE CITA_2 ADD FOREIGN KEY (id_ciudadano) REFERENCES CIUDADANO(id);
-- enfermedad_cronica -> cuidadano
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_enfermedad_cronica) REFERENCES ENFERMEDAD_CRONICA(id);
-- institucion_esencial -> cuidadano
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_institucion_esencial) REFERENCES INSTITUCION_ESENCIAL(id);
-- vacuna -> dosis
ALTER TABLE DOSIS ADD FOREIGN KEY (id_vacuna) REFERENCES VACUNA(id);

-- gestor -> inicion_sesion
ALTER TABLE INICIO_SESION ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- cabina -> inicio_sesion
ALTER TABLE INICIO_SESION ADD FOREIGN KEY (id_cabina) REFERENCES CABINA(id);
-- ciudadano -> vacunacion
ALTER TABLE VACUNACION ADD FOREIGN KEY (id_ciudadano) REFERENCES CIUDADANO(id);
-- dosis -> vacunacion
ALTER TABLE VACUNACION ADD FOREIGN KEY (id_dosis) REFERENCES DOSIS(id);
-- dosis -> dosisxefecto_secundario
ALTER TABLE DOSISxEFECTO_SECUNDARIO ADD FOREIGN KEY (id_dosis) REFERENCES DOSIS(id);
-- efecto_secundario -> dosisxefecto_secundario
ALTER TABLE DOSISxEFECTO_SECUNDARIO ADD FOREIGN KEY (id_efecto_secundario) REFERENCES EFECTO_SECUNDARIO(id);


-- Insertando datos en institucion esencial
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Educacion');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Salud');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('PNC');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Fuerza Armada');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Periodismo');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Personal de gobierno');
INSERT INTO INSTITUCION_ESENCIAL VALUES ('Ninguna');

-- Insertando datos en enfermedad cronica
INSERT INTO ENFERMEDAD_CRONICA VALUES('Diabetes M');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Hipertension');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Cardiopatias');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Obesidad Morb');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Cancer');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Insuficiencia renal');
INSERT INTO ENFERMEDAD_CRONICA VALUES('Ninguna');

-- Insertando efectos secundarios
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor en el brazo');
INSERT INTO EFECTO_SECUNDARIO VALUES('Enrojecimiento en el brazo');
INSERT INTO EFECTO_SECUNDARIO VALUES('Hinchazon en el brazo');
INSERT INTO EFECTO_SECUNDARIO VALUES('Cansancio');
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor de cabeza');
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor muscular');
INSERT INTO EFECTO_SECUNDARIO VALUES('Escalofrios');
INSERT INTO EFECTO_SECUNDARIO VALUES('Fiebre');
INSERT INTO EFECTO_SECUNDARIO VALUES('Nauseas');
INSERT INTO EFECTO_SECUNDARIO VALUES('Ninguno');

-- Insertando datos de vacuna aplicada
INSERT INTO VACUNA VALUES ('AstraZeneca');
INSERT INTO VACUNA VALUES ('Pfizer');
INSERT INTO VACUNA VALUES ('Moderna');
INSERT INTO VACUNA VALUES ('J&J');
INSERT INTO VACUNA VALUES ('Sinovac');

-- Insertando datos de centro de vacunacion
INSERT INTO CENTRO_VACUNACION VALUES('Hospital El Salvador');
INSERT INTO CENTRO_VACUNACION VALUES('Autoservicio');
INSERT INTO CENTRO_VACUNACION VALUES('Unidad de salud');
INSERT INTO CENTRO_VACUNACION VALUES('Hospital');
INSERT INTO CENTRO_VACUNACION VALUES('Centro escolar');

-- Insertando datos en tipo de empleado
INSERT INTO TIPO_EMPLEADO VALUES('Soporte Tecnico');
INSERT INTO TIPO_EMPLEADO VALUES('Enfermeria');
INSERT INTO TIPO_EMPLEADO VALUES('Medico');

-- Insertando datos de gestor
INSERT INTO GESTOR VALUES ('Bo El Centro Av Anastasio Aquino','Anselmo Quinton Consuelo Holguín','anselmoq@gob.cov.sv','Anselmo Quinton','e6Jd4ZjD',1); 
INSERT INTO GESTOR VALUES ('Bo El Centro 4 Av Sur No 1-11','Roslyn Evelyn Sara Stephens','roslyne@gob.cov.sv','Roslyn Stephens','0YFlrYx6',3); 
INSERT INTO GESTOR VALUES ('Bo El Carmen Av Staben No 11','Ingram Velda Truman Reyes','ingramv@gob.cov.sv','Ingram Truman','UqLHmm9n',2); 
INSERT INTO GESTOR VALUES ('2 Av Sur No 3 San Juan Opico','Sonny Garfield Eleanor Hancock','sonnyg@gob.cov.sv','Sonny Hancock','alW4kOlV',3); 
INSERT INTO GESTOR VALUES ('Resid Pilarica 59 Av Sur No 1','Cory Jessica Georgina Samuel','coryj@gob.cov.sv','Cory Georgina','yAwqxFYi',1); 
INSERT INTO GESTOR VALUES ('Urb Jard De Vista Hermosa Av Bella Vista No 23','Suzan Etelvina Custodio Quixada','suzane@gob.cov.sv','Suzan Custodio','Z8ZBszEM',2); 
INSERT INTO GESTOR VALUES ('Col Layco 29 Cl Pte No 1119','Vanessa Máximo María White','vanessam@gob.cov.sv','Vanessa White','AYtEA9M4',1); 
INSERT INTO GESTOR VALUES ('Av Central Sur No 4 - 41, Atiquizaya','Esteban Vance Praise Knight','estebanv@gob.cov.sv','Esteban Praise','7Ios3vMm', 2); 
INSERT INTO GESTOR VALUES ('Col Jard De La Sabana I Polig 3-E Sda 6 No 31','Nohemi Ariel Renata Hollands','nohemia@gob.cov.sv','Nohemi Hollands','AG9TzZlm',3); 

-- Insertando datos de cabina
INSERT INTO CABINA VALUES ('Av El Boquerón Políg B-1 Jardines Del Volcán','22894966','elboqueron56@gob.cov.sv');
INSERT INTO CABINA VALUES ('8 Cl Ote Y 1 Av Sur Sta Tecla','22291784','ClOte45@gob.cov.sv');
INSERT INTO CABINA VALUES ('Col Jard De Merliot Cl Ayagualo No B-2 Cdad','22648550','jardDeMerliot55@gob.cov.sv');
INSERT INTO CABINA VALUES ('Cl San Antonio Abad No 1817','22254277','SanAntinioAbad34@gob.cov.sv');
INSERT INTO CABINA VALUES ('Col Escalón 91 Av Nte No 515','22515461','colEscalon89@gob.cov.sv');
INSERT INTO CABINA VALUES ('Col El Roble Cl 2 Av A Zona 9 No 133','23106614','elRoble23@gob.cov.sv');
INSERT INTO CABINA VALUES ('Autop Nte Col El Milagro No 4 Mejicanos','26542987','AutopElMila78@gob.cov.sv');
INSERT INTO CABINA VALUES ('Av Gregorio Melara No 14 Usulutan','22193122','MelaraGregorio98@gob.cov.sv');
INSERT INTO CABINA VALUES ('Ps Gral Escalón C C Galerías 3Er Nvl Loc 348-B','22161862','GralGalerias21@gob.cov.sv');
INSERT INTO CABINA VALUES ('Bo San Sebastián, 4 Av Sur No 11','24084558','SanSebas73@gob.cov.sv');

-- Consultas
SELECT * FROM INSTITUCION_ESENCIAL;
SELECT * FROM ENFERMEDAD_CRONICA;
SELECT * FROM EFECTO_SECUNDARIO;
SELECT * FROM CABINA;
SELECT * FROM GESTOR;
SELECT * FROM VACUNA;
SELECT * FROM EFECTO_SECUNDARIO;
