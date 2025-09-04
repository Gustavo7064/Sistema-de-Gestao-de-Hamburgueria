-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDProjeto;

-- USANDO O BANCO DE DADOS
USE BDProjeto;

-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbPedido (
	codPedido int primary key auto_increment,
    valorLanche varchar(50),
    valorOpcao varchar(50),
    valorTotal varchar(50)
);

-- CONSULTANDO A TABELA DO BANCO DE DADOS

SELECT * FROM tbPedido;