CREATE DATABASE DBLANCHONETE;

CREATE USER 'admin'@'%' IDENTIFIED BY '123foxconn$';

GRANT ALL ON *.* TO 'admin'@'%' WITH GRANT OPTION;

flush privileges;

USE DBLANCHONETE;

/***** TABELA INGREDIENTES *****/
CREATE TABLE tb_ingredientes (
  id int auto_increment primary key,
  nome varchar(100) not null,
  preco decimal (10,2) not null,
  ativo int not null default 1
);
/*****************/

/***** TABELA LANCHES *****/
CREATE TABLE tb_lanches (
  id int auto_increment primary key,
  nome varchar(100) not null,
  preco decimal (10,2) not null,
  ativo int not null default 1	
);
/*****************/

/***** TABELA LANCHES/INGREDIENTES *****/
CREATE TABLE tb_lanches_ingredientes (
  id int auto_increment primary key,
  id_lanche int not null,	
  id_ingrediente int not null,

	FOREIGN KEY (id_lanche) REFERENCES tb_lanches(id),
	FOREIGN KEY (id_ingrediente) REFERENCES tb_ingredientes(id)
);
/*****************/

/***** TABELA VENDAS *****/
CREATE TABLE TB_VENDAS (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome varchar(255) NOT NULL,
    valor_total DECIMAL(10,2) NOT NULL,
    data_venda DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);
/*****************/

/***** TABELA VENDAS DETAIL *****/
CREATE TABLE TB_VENDAS_DETAIL (
	id INT AUTO_INCREMENT PRIMARY KEY,
    id_venda INT NOT NULL,
    id_lanche INT NOT NULL,
    id_ingrediente INT NOT NULL,
    
    FOREIGN KEY (id_venda) REFERENCES TB_VENDAS(id),
    FOREIGN KEY (id_lanche) REFERENCES TB_LANCHES(id),
	FOREIGN KEY (id_ingrediente) REFERENCES TB_INGREDIENTES(id)
);

/***** TABELA USUARIOS *****/
CREATE TABLE tb_app_user (
	id int auto_increment primary key,
    nome			varchar(100),
    usuario			varchar(255),
    senha			varchar(100),
    nivel_acesso	varchar(100)
    );
/*****************/    

/****** INSERT USUARIOS *******/
INSERT INTO TB_APP_USER
	(NOME, USUARIO, SENHA, NIVEL_ACESSO)
VALUES
	('Daniel Brienza', 'dbrienza', '123Cavalo$', 'Administrator');
INSERT INTO TB_APP_USER
	(NOME, USUARIO, SENHA, NIVEL_ACESSO)
VALUES
	('Thiago Pereira', 'tpereira', '123foxconn$', 'Vendedor');
COMMIT;