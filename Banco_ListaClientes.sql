create database bdClientes;
use bdClientes;

CREATE TABLE clientes (

Id INT NOT NULL AUTO_INCREMENT,

Nome VARCHAR(100) NOT NULL,

Email VARCHAR(150) NOT NULL,

IsDeleted TINYINT(1) NOT NULL DEFAULT 0, 

DeletedAt DATETIME NULL,

PRIMARY KEY (Id)

);

INSERT INTO clientes (Nome, Email, IsDeleted, DeletedAt) VALUES
('Ana Souza', 'ana.souza@email.com', 0, NULL),
('Bruno Lima', 'bruno.lima@email.com', 0, NULL),
('Carla Mendes', 'carla.mendes@email.com', 0, NULL),
('Diego Oliveira', 'diego.oliveira@email.com', 0, NULL),
('Eduarda Silva', 'eduarda.silva@email.com', 0, NULL),
('Felipe Santos', 'felipe.santos@email.com', 0, NULL),
('Gabriela Costa', 'gabriela.costa@email.com', 0, NULL),
('Henrique Rocha', 'henrique.rocha@email.com', 0, NULL),
('Isabela Pereira', 'isabela.pereira@email.com', 0, NULL),
('João Carvalho', 'joao.carvalho@email.com', 0, NULL);