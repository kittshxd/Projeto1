-- CRIANDO O BANCO DE DADOS

CREATE DATABASE BDProjeto;

-- USANDO O BANCO DE DADOS

USE BDProjeto;

-- CRIANDO AS TABELAS DO BANCO DE DADOS

CREATE TABLE tbLogin(
codLogin int primary key auto_increment,
usuario varchar(40),
senha varchar(40)
); 

-- CONSULTANDO A TABELAS DO BANCO

SELECT*FROM tbLogin;

-- INSERINDO DADOS NA TABELA
insert into tbLogin(usuario, senha) values ('cidade','city@2025');