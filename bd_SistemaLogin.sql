create database if not exists bd_SistemaLogin;

use bd_SistemaLogin;

create table Usuarios(
Id int primary key not null auto_increment,
Email varchar(100) not null,
Senha varchar(50) not null default "0000"
);

insert into Usuarios
(Email, Senha)
Values
("lucas4162007@gmail.com",md5("claudio5566"));

select * from Usuarios;




DROP DATABASE sistemalogin;