create database troca_oleo

use troca_oleo

create table usuario
(
	cod_usuario int identity(1,1) primary key,
	email varchar(100),
	senha varchar(15)
)

create table cliente
(
	cod_cliente int identity(1,1) primary key,
	nome varchar(50),
	veiculo varchar(50),
	placa varchar(15),
	email varchar(100)
)

create table oleo
(
	cod_oleo int identity(1,1) primary key,
	nome varchar(50),
	categoria varchar(50),
	tipo_oleo varchar(50),
	fabricante varchar(50),
	valor decimal (8,2)
)

create table servico_troca_oleo
(
	cod_servico int identity(1,1) primary key,
	data_servico datetime default getdate(),
	cod_cliente int references cliente (cod_cliente),
	cod_oleo int references oleo(cod_oleo),
	qtde_litro int
)

bulk insert usuario




