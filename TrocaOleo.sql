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
	valor_total	varchar(50),
	email		varchar(50)
)

bulk insert usuario
from 'C:\Users\Aluno\Documents\GitHub\ExercicioTrocaOleo\usuarios.txt'
with (codepage='ACP', fieldterminator = ';')

bulk insert cliente
from 'C:\Users\Aluno\Documents\GitHub\ExercicioTrocaOleo\Clientes.txt'
with (codepage='ACP', fieldterminator = ';')

bulk insert oleo
from 'C:\Users\Aluno\Documents\GitHub\ExercicioTrocaOleo\Oleos.txt'
with (codepage='ACP', fieldterminator = ';')
