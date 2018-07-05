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
	id_troca	integer primary key identity(1,1),
	data		varchar(50),
	cliente		varchar(50),
	oleo		varchar(50),
	categoria	varchar(50),
	tipo		varchar(50),
	fabricante	varchar(50),
	valor_litro	decimal(8,2),
	qtde		int,
	valor_total decimal(8,2),
	email		varchar(50)
)
drop table servico_troca_oleo
bulk insert usuario
from 'D:\Documents\GitHub\ExercicioTrocaOleo\usuarios.txt'
with (codepage='ACP', fieldterminator = ';')

bulk insert cliente
from 'D:\Documents\GitHub\ExercicioTrocaOleo\Clientes.txt'
with (codepage='ACP', fieldterminator = ';')

bulk insert oleo
from 'D:\Documents\GitHub\ExercicioTrocaOleo\Oleos.txt'
with (codepage='ACP', fieldterminator = ';')

--SELECT*FROM usuario

--SELECT * FROM CLIENTE
select * from oleo

--SELECT * FROM servico_troca_oleo