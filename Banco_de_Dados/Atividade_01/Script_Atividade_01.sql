CREATE TABLE tb_contatos (
	
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(45) NOT NULL,
    email VARCHAR(45) NOT NULL,
    celular VARCHAR(14) NOT NULL

);

INSERT INTO tb_contatos (nome, email, celular) VALUES 
("João", "joao@gmail.com", "99999"),
("Pedro", "pedro@gmail.com", "88888"),
("Maria", "maria@gmail.com", "77777");

SELECT * FROM tb_contatos;

CREATE TABLE tb_locais (
	
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(45) NOT NULL,
    rua VARCHAR(45) NOT NULL,
    numero INT NOT NULL

);

INSERT INTO tb_locais (nome, rua, numero) VALUES 
("Proway", "Rua 7 de Setembro", 44),
("Shopping", "Rua 7 de Setembro", 55),
("Santos Dumont", "Rua Amazonas", 77);

SELECT * FROM tb_locais;

CREATE TABLE tb_compromisso (

	id INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR(45) NOT NULL,
    data date NOT NULL,
    hora time NOT NULL,
    id_locais INT NOT NULL,
    FOREIGN KEY (id_locais) REFERENCES tb_locais(id)
    
    
);

INSERT INTO tb_compromisso (descricao, data, hora, id_locais) VALUES 
("Ir ao Shopping", "2023-10-02", "09:00:00", 2),
("Ir à escola", "2023-09-02", "08:00:00", 3),
("Ir à escola de programação", "2023-08-02", "13:00:00", 1);


SELECT * FROM tb_compromisso;

CREATE TABLE tb_associativa_entre_compromissos_e_contatos (
	id_compromisso INT,
    id_contato INT,
    
    FOREIGN KEY (id_compromisso) REFERENCES tb_compromisso(id),
	FOREIGN KEY (id_contato) REFERENCES tb_contatos(id)
);

INSERT INTO tb_associativa_entre_compromissos_e_contatos(id_compromisso, id_contato) VALUES 
(1, 1),
(2, 2),
(3, 3);

SELECT * FROM tb_associativa_entre_compromissos_e_contatos;
