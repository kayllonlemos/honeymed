create database honeymed;

use honeymed;

create table tb_contas (
id_conta int identity(100,1) not null primary key,
nome_funcionario varchar(60),
tipo_conta varchar(60),
email varchar(60),
senha varchar(60),
status_conta varchar(60),
foto varchar(255),
fone varchar(20))

create table tb_clientes (
id_cliente int identity(1,1) not null primary key,
cpf varchar(14),
sexo varchar(60),
fone varchar(20),
nome varchar(60),
data_nasc varchar(60),
tipo_plano varchar(60),
email varchar(60),
foto varchar(255))

create table tb_prestadores (
    id int primary key identity,
    nome varchar(60),
    email varchar(60),
    tipo_prestador varchar(60),
    endereco varchar(200),
    fone varchar(20))

create table tb_especialidades (
    id int primary key identity,
    id_prestador int foreign key references tb_prestadores(id),
    especialidade varchar(60))

CREATE TABLE tb_agendamentos (
    id_agendamento   INT PRIMARY KEY IDENTITY(1,1),
    id_cliente       INT NOT NULL,
    id_prestador     INT NOT NULL,
    id_especialidade INT NOT NULL,
    data_agendamento VARCHAR(20) NOT NULL,
    horario          VARCHAR(5)  NOT NULL,

    CONSTRAINT fk_agend_cliente       FOREIGN KEY (id_cliente)       REFERENCES tb_clientes(id_cliente),
    CONSTRAINT fk_agend_prestador     FOREIGN KEY (id_prestador)     REFERENCES tb_prestadores(id),
    CONSTRAINT fk_agend_especialidade FOREIGN KEY (id_especialidade) REFERENCES tb_especialidades(id)
)

select * from tb_contas;
select * from tb_clientes;
select * from tb_prestadores;
select * from tb_especialidades;
select * from tb_agendamentos;