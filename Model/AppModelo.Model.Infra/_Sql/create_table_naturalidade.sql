CREATE TABLE naturalidade (
	id int NOT NULL AUTO_INCREMENT,
	descricao VARCHAR(100) NOT NULL,
	dataCriacao DATETIME NOT NULL,
	dataAlteracao DATETIME NOT NULL,
	ativo BOOLEAN NOT NULL,
	CONSTRAINT pk_naturalidade_id PRIMARY KEY (id)
);