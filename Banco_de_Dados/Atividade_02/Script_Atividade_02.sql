CREATE TABLE tb_categorias (

	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR (45) NOT NULL 

);

INSERT INTO tb_categorias (nome) VALUES
("Frutas"),
("Refrigerantes"),
("Chocolate");

SELECT * FROM tb_categorias;

CREATE TABLE tb_produtos(
	
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(45) NOT NULL,
    quantidade INT NOT NULL,
	id_categoria INT NOT NULL,


	FOREIGN KEY (id_categoria) REFERENCES tb_categorias(id)
);

INSERT INTO tb_produtos (nome, quantidade, id_categoria) VALUES
("Laranja", 50, 1),
("Nestle", 70, 3),
("Coca-Cola", 100, 2);

SELECT * FROM tb_produtos;

CREATE TABLE tb_fornecedores (

	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(45) NOT NULL

);

INSERT INTO tb_fornecedores(nome) VALUES
("Refrigerantes BNU"),
("Frutas SP"),
("Chocolates RJ");

SELECT * FROM tb_fornecedores;

CREATE TABLE tb_associativa_tb_forncedor_tb_produtos_COMPRAS (
	id INT PRIMARY KEY AUTO_INCREMENT,
	id_fornecedor INT NOT NULL,
    id_produto INT NOT NULL,
    preco_produto DOUBLE NOT NULL,
    quantidade INT NOT NULL,
    
    FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id),
    FOREIGN KEY (id_produto) REFERENCES tb_produtos(id)
	

);

INSERT INTO tb_associativa_tb_forncedor_tb_produtos_COMPRAS (id_fornecedor, id_produto, preco_produto, quantidade) VALUES
(1, 3, 3.00, 2),
(2, 1, 2.00, 1),
(3, 2, 1.00, 4);


SELECT * FROM tb_associativa_tb_forncedor_tb_produtos_COMPRAS;

CREATE TABLE tb_clientes (

	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(45) NOT NULL

);

INSERT INTO tb_clientes (nome) VALUES
("Biden"),
("Breno"),
("Sidney");

SELECT * FROM tb_clientes;

CREATE TABLE tb_associativa_tb_clientes_tb_produtos_VENDAS (
	
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    id_produto INT NOT NULL,
    quantidade INT NOT NULL,
    preco_produto DOUBLE NOT NULL,

    FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id),
    FOREIGN KEY (id_produto) REFERENCES tb_produtos(id)

);

INSERT INTO tb_associativa_tb_clientes_tb_produtos_VENDAS (id_cliente, id_produto, quantidade, preco_produto) VALUES
(3, 1, 1, 3.00),
(2, 2, 4, 2.00),
(1, 3, 5, 1.00);

SELECT * FROM tb_associativa_tb_clientes_tb_produtos_VENDAS;