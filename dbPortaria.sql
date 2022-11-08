CREATE DATABASE dbPortaria;

create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100),
email varchar(100),
cpf char(14) not null unique,
ctps char(8) not null unique,
telCel char(10),
primary key(codFunc)
);


create table tbUsuarios(
codUsu int not null auto_increment,                         
nome varchar(50),
senha varchar(50),
codFunc int not null,
primary key(codUsu),
foreign key(codFunc)references tbFuncionarios(codFunc)
);