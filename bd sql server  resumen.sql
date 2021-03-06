CREATE DATABASE  Recursos_H;

CREATE TABLE empresa(
id_empresa int PRIMARY KEY IDENTITY(1,1),
nombre_empresa varchar(50),
NIT_empresa int,
Pais varchar(50),
poblacion varchar(30),
domicilio varchar(50),
telefono int,
correo varchar(50)
);



CREATE TABLE jornada(
id_jornada int PRIMARY KEY IDENTITY(1,1),
tipo_jornadal varchar(30),
hora_jornada time
);

CREATE TABLE salario(
id_salario int PRIMARY KEY IDENTITY(1,1),
tipo_salario varchar(30),
cantidad_salario int
);



CREATE TABLE departamento(
id_departamento int PRIMARY KEY IDENTITY(1,1),
nombre_dep varchar(45) not null,
funcion_dep varchar(45) not null,
);



CREATE TABLE puesto(
id_puesto int PRIMARY KEY IDENTITY(1,1),
nombre_puesto varchar(35) not null
);




CREATE TABLE empleado(
id_empleado int PRIMARY KEY IDENTITY(1,1) ,
nombre varchar(30) not null,
apellido varchar(30) not null,
dpi VARCHAR(15) not null,
nit int,
edad int not null,
nacionalidad varchar(45),
fecha_nacimiento date,
telefono int,
sexo varchar(9) not null,
estado_civil varchar(7),

id_jornada int,

id_salario int,
id_departamento int,
id_empresa int,
id_puesto int,


FOREIGN KEY(id_empresa) REFERENCES empresa(id_empresa),
FOREIGN KEY(id_departamento) REFERENCES departamento(id_departamento),
FOREIGN key(id_puesto) REFERENCES puesto(id_puesto),
FOREIGN key(id_jornada) REFERENCES jornada(id_jornada),
FOREIGN KEY(id_salario) REFERENCES salario(id_salario)
);


CREATE TABLE usuario(
id_usuario int PRIMARY KEY IDENTITY(1,1),
usser varchar(30),
pass varchar(50),
rol_usuario varchar(50),
id_empleado int,
FOREIGN KEY(id_empleado) REFERENCES empleado(id_empleado)
);



CREATE TABLE nomina(
id_nomina int PRIMARY KEY IDENTITY(1,1),
ejercicio_fiscal varchar(30),
mes date,
numeroOrden int,
id_empleado int,
FOREIGN KEY(id_empleado) REFERENCES empleado(id_empleado)
);

CREATE TABLE Asignaciones(
  id_asignaciones int PRIMARY KEY IDENTITY(1,1),
  dias_trabaj int,
  prima int,
  bono int,
  otros_asig int,
  total_asig float,
  id_nomina int,
  FOREIGN KEY(id_nomina) REFERENCES nomina(id_nomina)
);

CREATE TABLE deducciones(
  id_deducciones int PRIMARY KEY IDENTITY(1,1),
   SSO int,
   REP int,
   FAOV int,
   otros_deduc int,
   total_deduc float,

  id_nomina int,
  FOREIGN KEY(id_nomina) REFERENCES nomina(id_nomina)
);


-- insertar departamento
insert into departamento(nombre_dep,funcion_dep) values('Marketing','Anunciar');
insert into departamento(nombre_dep,funcion_dep) values('Venta','Vender los productos');
insert into departamento(nombre_dep,funcion_dep) values('Administracion','Administrar la empresa');
insert into departamento(nombre_dep,funcion_dep) values('Finanzas','Control de dinero');
insert into departamento(nombre_dep,funcion_dep) values('Gerencia','Gerenciar la empresa');
insert into departamento(nombre_dep,funcion_dep) values('Comprar','Comprar productos');
insert into departamento(nombre_dep,funcion_dep) values('Produccion','Producir mas productos');
insert into departamento(nombre_dep,funcion_dep) values('Control Gestion','Gestionar');


-- insert puesto 
insert into puesto (nombre_puesto) values('Tecnico');
insert into puesto (nombre_puesto) values('Gerente');
insert into puesto (nombre_puesto) values('Secretaria');
insert into puesto (nombre_puesto) values('Conserje');
insert into puesto (nombre_puesto) values('Administrador');
insert into puesto (nombre_puesto) values('Mensajero');
insert into puesto (nombre_puesto) values('Alamacenero');
insert into puesto (nombre_puesto) values('Ejecutivo');
insert into puesto (nombre_puesto) values('Consultor');
insert into puesto (nombre_puesto) values('Seguridad');

-- insert jornadas
insert into jornada(tipo_jornadal,hora_jornada) values('Nocturno','6:30');
insert into jornada(tipo_jornadal,hora_jornada) values('Parcial','6:00');
insert into jornada(tipo_jornadal,hora_jornada) values('Especial','12:30');
insert into jornada(tipo_jornadal,hora_jornada) values('Extraordinaria','8:00');


-- insert salario 
insert into salario(tipo_salario,cantidad_salario) values('Minimo',3000);
insert into salario(tipo_salario,cantidad_salario) values('Especial',5000);
insert into salario(tipo_salario,cantidad_salario) values('Supersalario',9000);


-- insert empresa
insert into empresa(nombre_empresa,NIT_empresa,Pais,poblacion,domicilio,telefono,correo) values('PEPSI',32323,'Guatemala','Samayac','Canton',454554,'pepsi_2018@gmail.com');


