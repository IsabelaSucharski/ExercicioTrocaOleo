create database troca_oleo
go

use troca_oleo
go

create table usuario
(
	cod_usuario int primary key,
	email varchar(100),
	senha varchar(15)
)

create table cliente
(
	cod_cliente int primary key,
	nome varchar(50),
	veiculo varchar(50),
	placa varchar(15),
	email varchar(100)
)

create table oleo
(
	cod_oleo int primary key,
	nome varchar(50),
	categoria varchar(50),
	tipo_oleo varchar(50),
	fabricante varchar(50),
	valor decimal (8,2)
)

create table servico_troca_oleo
(
	cod_servico int primary key,
	data_servico datetime default getdate(),
	cod_cliente int references cliente (cod_cliente),
	cod_oleo int references oleo(cod_oleo),
	qtde_litro int
)

--bulk insert usuario
--from 'D:\Documents\GitHub\ExercicioTrocaOleo\usuarios.txt'
--with (codepage='ACP')

--bulk insert cliente
--from 'D:\Documents\GitHub\ExercicioTrocaOleo\Clientes.txt'
--with (codepage='ACP')

--bulk insert oleo
--from 'D:\Documents\GitHub\ExercicioTrocaOleo\Oleos.txt'
--with (codepage='ACP')




