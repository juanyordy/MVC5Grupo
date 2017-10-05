create database dbPersona
use dbPersona

create table tPesonaJuridica(
ruc int primary key,
nombre varchar (50),
direccion varchar(50),
telefono varchar(10),
correoElectronico varchar(50),
urlPaginaWeb varchar (50)
)

create table tPesonaNatural(
dni int primary key,
nombre varchar (50),
apellido varchar(50),
direccion varchar(50),
telefono varchar(10),
correoElectronico varchar(50),
fechaNacimiento datetime,
Sexo bit
)