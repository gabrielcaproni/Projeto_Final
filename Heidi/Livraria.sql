-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.10-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para livraria2si
DROP DATABASE IF EXISTS `livraria2si`;
CREATE DATABASE IF NOT EXISTS `livraria2si` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `livraria2si`;

-- Copiando estrutura para tabela livraria2si.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `codCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`codCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.categoria: ~0 rows (aproximadamente)
DELETE FROM `categoria`;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` (`codCategoria`, `nome`) VALUES
	(1, 'Suspense');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

-- Copiando estrutura para tabela livraria2si.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `dataNascimento` varchar(100) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `uf` char(2) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `email` varchar(200) NOT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.cliente: ~5 rows (aproximadamente)
DELETE FROM `cliente`;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`codCliente`, `nome`, `dataNascimento`, `cpf`, `uf`, `endereco`, `bairro`, `cidade`, `cep`, `email`) VALUES
	(2, 'Jailson Mendes ', '2001-02-28', '123.034.469-65', 'SP', 'Rua Marcolino ', 'Zona Leste ', 'São Paulo', '12369-000', 'JailsonMendes@gmail.com'),
	(3, 'Gabriel Pegoraro', '2003-11-29', '123.034.496-93', 'MG', 'Rua das Posses', 'Peróbas', 'Carvalhópolis', '37760-000', 'Gabrielcaproni09@gmail.com'),
	(4, 'Ryan Mendes ', '2004-03-28', '123.369.589-65', 'MG', 'Rua da Fé ', 'Santo Amaro ', 'Machado ', '37550-000', 'RyanMendes@gmail.com'),
	(5, 'Osvaldo', '0000-00-00', '123.639.587-58', 'SP', 'Rua da Fé', 'Bairro das Flores', 'São Paulo', '123.639.587-58', 'Osvaldo321@gmail.com'),
	(6, '', '', '', '', '', '', '', '', '');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- Copiando estrutura para procedure livraria2si.consultaLogin
DROP PROCEDURE IF EXISTS `consultaLogin`;
DELIMITER //
CREATE PROCEDURE `consultaLogin`(usuario varchar(100), senha varchar(100))
BEGIN
Select * from usuarios where usuarios.nome = usuario and usuarios.senha = senha;
END//
DELIMITER ;

-- Copiando estrutura para tabela livraria2si.editora
DROP TABLE IF EXISTS `editora`;
CREATE TABLE IF NOT EXISTS `editora` (
  `codEditora` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  PRIMARY KEY (`codEditora`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.editora: ~4 rows (aproximadamente)
DELETE FROM `editora`;
/*!40000 ALTER TABLE `editora` DISABLE KEYS */;
INSERT INTO `editora` (`codEditora`, `nome`) VALUES
	(2, 'Loyola'),
	(4, 'Rocco'),
	(5, 'Aleph'),
	(6, 'Suma');
/*!40000 ALTER TABLE `editora` ENABLE KEYS */;

-- Copiando estrutura para procedure livraria2si.insere_cliente
DROP PROCEDURE IF EXISTS `insere_cliente`;
DELIMITER //
CREATE PROCEDURE `insere_cliente`(in nome varchar(200), dataNascimento varchar(100), cpf varchar(20), uf varchar(2), endereco varchar(100), bairro varchar(100), cidade varchar(45), cep varchar(20), email varchar(200))
BEGIN
	insert into cliente values (null,nome, dataNascimento, cpf, uf, endereco, bairro, cidade, cep, email);
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.insere_editora
DROP PROCEDURE IF EXISTS `insere_editora`;
DELIMITER //
CREATE PROCEDURE `insere_editora`(in novoNome varchar(200))
BEGIN
	insert into editora(nome) values (novoNome);
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.insere_produto
DROP PROCEDURE IF EXISTS `insere_produto`;
DELIMITER //
CREATE PROCEDURE `insere_produto`(in novoNome varchar(200),in precoVenda Varchar(100),in precoCusto varchar(100),in qtdestoque varchar(10),in dataLancamento varchar(10))
BEGIN
	insert into produto(
		novoNome, 
        precoVenda, 
        precoCusto, 
        quantidadeEstoque, 
        dataLancamento, 
        EDITORA_codEditora,
		VENDA_codVenda, 
        VENDA_CLIENTE_codCliente, 
        CATEGORIA_codCategoria)
        values(
            nome, 
            precoVenda, 
            precoCusto, 
            qtdEstoque, 
            dataLancamento, 
            codEditora,
			codvenda, 
            codCliente,
            codcategoria);
		
END//
DELIMITER ;

-- Copiando estrutura para tabela livraria2si.itemvenda
DROP TABLE IF EXISTS `itemvenda`;
CREATE TABLE IF NOT EXISTS `itemvenda` (
  `PRODUTO_codProduto` int(11) NOT NULL,
  `VENDA_codVenda` int(11) NOT NULL,
  `quantidadeLivros` int(11) NOT NULL,
  PRIMARY KEY (`PRODUTO_codProduto`,`VENDA_codVenda`),
  KEY `fk_PRODUTO_has_VENDA_VENDA1_idx` (`VENDA_codVenda`),
  KEY `fk_PRODUTO_has_VENDA_PRODUTO1_idx` (`PRODUTO_codProduto`),
  CONSTRAINT `fk_PRODUTO_has_VENDA_PRODUTO1` FOREIGN KEY (`PRODUTO_codProduto`) REFERENCES `produto` (`codProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_has_VENDA_VENDA1` FOREIGN KEY (`VENDA_codVenda`) REFERENCES `venda` (`codVenda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.itemvenda: ~0 rows (aproximadamente)
DELETE FROM `itemvenda`;
/*!40000 ALTER TABLE `itemvenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemvenda` ENABLE KEYS */;

-- Copiando estrutura para procedure livraria2si.lista_cliente
DROP PROCEDURE IF EXISTS `lista_cliente`;
DELIMITER //
CREATE PROCEDURE `lista_cliente`()
BEGIN
	SELECT 
    `cliente`.`nome`,
    `cliente`.`dataNascimento`,
    `cliente`.`cpf`,
    `cliente`.`uf`,
    `cliente`.`endereco`,
    `cliente`.`bairro`,
    `cliente`.`cidade`,
    `cliente`.`cep`,
    `cliente`.`email`
FROM `livraria2si`.`cliente`;

END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.Lista_Editora
DROP PROCEDURE IF EXISTS `Lista_Editora`;
DELIMITER //
CREATE PROCEDURE `Lista_Editora`()
BEGIN
	select * from editora;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.Lista_Produto
DROP PROCEDURE IF EXISTS `Lista_Produto`;
DELIMITER //
CREATE PROCEDURE `Lista_Produto`()
BEGIN
SELECT `produto`.`codProduto`,
    `produto`.`nome`,
    `produto`.`precoVenda`,
    `produto`.`precoCusto`,
    `produto`.`quantidadeEstoque`,
    `produto`.`dataLancamento`,
    `produto`.`EDITORA_codEditora`,
    `produto`.`VENDA_codVenda`,
    `produto`.`VENDA_CLIENTE_codCliente`,
    `produto`.`CATEGORIA_codCategoria`
FROM `livraria2si`.`produto`;

END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_alteraCategoria
DROP PROCEDURE IF EXISTS `proc_alteraCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCategoria`(in codCate int, in novoNome varchar (100))
BEGIN
	update categoria set nome = novoNome where codCategoria = codCate;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_alteraCliente
DROP PROCEDURE IF EXISTS `proc_alteraCliente`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCliente`(in novoNome varchar(200),novaData date,novoUf varchar(2),novoEnd varchar(100) , novoBairro varchar(100), novaCity varchar(45), novoCep varchar(20), novoEmail varchar(200), in codigo int)
BEGIN
	update cliente set nome = novoNome, dataNascimento = novaData , uf = novoUf, endereco = novoEnd, bairro = novoBairro, cidade = novaCity, cep = novoCep, email = novoEmail where codCliente = codigo; 
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_alteraEditora
DROP PROCEDURE IF EXISTS `proc_alteraEditora`;
DELIMITER //
CREATE PROCEDURE `proc_alteraEditora`(in codigo int, in novoNome varchar(200), plataforma varchar(100))
BEGIN
	update editora set nome = novoNome, plataformaLancamento = plataforma where codEditora = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_alteraProduto
DROP PROCEDURE IF EXISTS `proc_alteraProduto`;
DELIMITER //
CREATE PROCEDURE `proc_alteraProduto`(in codigoProduto int, in novoNome varchar(100), in precoProd decimal(10,0), in precoCus decimal(10,0), in quantidadeEst int(11), 
	in dataLanc date, in codEditora int, in codVenda int, in codCliente int, in codCategoria int)
BEGIN
	update produto set  nome = novoNome, 
        precoProd = precoVenda,
        precoCus = precoCusto,
        quantidadeEst = quantidadeEstoque,
        dataLanc = dataLancamento,
        codEditora = EDITORA_codEditora,
        cod_Venda = VENDA_codVenda,
        codCliente = VENDA_CLIENTE_codCliente,
        codCategoria = CATEGORIA_codCategoria 
        where 
        codigoProduto = codProduto;
			
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_alteraVenda
DROP PROCEDURE IF EXISTS `proc_alteraVenda`;
DELIMITER //
CREATE PROCEDURE `proc_alteraVenda`(in codigoVenda int, in novaData date, desco decimal(4,2), tipo enum('À Vista', 'Cartão Débito', 'Cartão Crédito', 'PIX'), in codCliente int)
BEGIN
	update venda set novaData = dataHora,
    desco = desconto,
    tipo = tipovenda
    where
    codCliente = CLIENTE_codCliente;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_deleteCategoria
DROP PROCEDURE IF EXISTS `proc_deleteCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_deleteCategoria`(in codExcluir int)
BEGIN
	delete from categoria where codCategoria = codExcluir;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_deleteCliente
DROP PROCEDURE IF EXISTS `proc_deleteCliente`;
DELIMITER //
CREATE PROCEDURE `proc_deleteCliente`(in codExcluir int)
BEGIN
	delete from cliente where codCliente = codExcluir;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_deleteEditora
DROP PROCEDURE IF EXISTS `proc_deleteEditora`;
DELIMITER //
CREATE PROCEDURE `proc_deleteEditora`(in codExcluir int)
BEGIN
	delete from editora where codEditora = codExcluir;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_deleteProduto
DROP PROCEDURE IF EXISTS `proc_deleteProduto`;
DELIMITER //
CREATE PROCEDURE `proc_deleteProduto`( in codExcluir int)
BEGIN
	delete from produto where codProduto = codExcluir;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_deleteVenda
DROP PROCEDURE IF EXISTS `proc_deleteVenda`;
DELIMITER //
CREATE PROCEDURE `proc_deleteVenda`( in codExcluir int)
BEGIN
	delete from itemvenda where codVenda = codExcluir;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_insereCategoria
DROP PROCEDURE IF EXISTS `proc_insereCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_insereCategoria`(in novoNome varchar(100))
BEGIN
	insert into categoria(nome) values (novoNome);
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_insereCliente
DROP PROCEDURE IF EXISTS `proc_insereCliente`;
DELIMITER //
CREATE PROCEDURE `proc_insereCliente`(in nome varchar(200), dataNascimento date, cpf varchar(20), uf char(2), endereco varchar(100), bairro varchar(100), cidade varchar(45), cep varchar(20), email varchar(200))
BEGIN
	insert into cliente values (null, nome, dataNascimento, cpf, uf, endereco, bairro, cidade, cep, email);
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_insereEditora
DROP PROCEDURE IF EXISTS `proc_insereEditora`;
DELIMITER //
CREATE PROCEDURE `proc_insereEditora`(in novoNome varchar(200), Plataforma varchar(100) )
BEGIN
	insert into editora(nome,plataformaLancamento) values (novoNome,Plataforma);
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_insereProduto
DROP PROCEDURE IF EXISTS `proc_insereProduto`;
DELIMITER //
CREATE PROCEDURE `proc_insereProduto`(in novoNome varchar(200),in precoVenda decimal(10,0),in precoCusto decimal(10,0),in qtdestoque int(11),in dataLancamento date,in codEditora int,in codVenda int,in codCliente int,in codcategoria int)
BEGIN
	insert into produto(
		novoNome, 
        precoVenda, 
        precoCusto, 
        quantidadeEstoque, 
        dataLancamento, 
        EDITORA_codEditora, 
        VENDA_codVenda, 
        VENDA_CLIENTE_codCliente, 
        CATEGORIA_codCategoria) 
        values(
			NULL, 
            nome, 
            precoVenda, 
            precoCusto, 
            qtdEstoque, 
            dataLancamento, 
            codEditora, 
            codvenda, 
            codCliente,
            codcategoria
		);
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria2si.proc_insereVenda
DROP PROCEDURE IF EXISTS `proc_insereVenda`;
DELIMITER //
CREATE PROCEDURE `proc_insereVenda`(in novaData date, in desco decimal(4,2), in tipoVenda enum('À Vista', 'Cartão Débito', 'Cartão Crédito', 'PIX'), codCliente int)
BEGIN
	insert into venda(
    codVenda,
    dataHora,
    desconto,
    tipoVenda,
    CLIENTE_codCliente
    )
    values(
    null,
    novaData,
    desco,
    tipoVenda,
    codcliente
    );
END//
DELIMITER ;

-- Copiando estrutura para tabela livraria2si.produto
DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `codProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `precoVenda` decimal(10,0) NOT NULL,
  `precoCusto` decimal(10,0) NOT NULL,
  `quantidadeEstoque` int(11) NOT NULL,
  `dataLancamento` date NOT NULL,
  `EDITORA_codEditora` int(11) NOT NULL,
  `VENDA_codVenda` int(11) NOT NULL,
  `VENDA_CLIENTE_codCliente` int(11) NOT NULL,
  `CATEGORIA_codCategoria` int(11) NOT NULL,
  PRIMARY KEY (`codProduto`,`EDITORA_codEditora`,`VENDA_codVenda`,`VENDA_CLIENTE_codCliente`,`CATEGORIA_codCategoria`),
  KEY `fk_PRODUTO_EDITORA_idx` (`EDITORA_codEditora`),
  KEY `fk_PRODUTO_VENDA1_idx` (`VENDA_codVenda`,`VENDA_CLIENTE_codCliente`),
  KEY `fk_PRODUTO_CATEGORIA1_idx` (`CATEGORIA_codCategoria`),
  CONSTRAINT `fk_PRODUTO_CATEGORIA1` FOREIGN KEY (`CATEGORIA_codCategoria`) REFERENCES `categoria` (`codCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_EDITORA` FOREIGN KEY (`EDITORA_codEditora`) REFERENCES `editora` (`codEditora`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_VENDA1` FOREIGN KEY (`VENDA_codVenda`, `VENDA_CLIENTE_codCliente`) REFERENCES `venda` (`codVenda`, `CLIENTE_codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.produto: ~0 rows (aproximadamente)
DELETE FROM `produto`;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`codProduto`, `nome`, `precoVenda`, `precoCusto`, `quantidadeEstoque`, `dataLancamento`, `EDITORA_codEditora`, `VENDA_codVenda`, `VENDA_CLIENTE_codCliente`, `CATEGORIA_codCategoria`) VALUES
	(1, 'Crônicas de Tandandan', 50, 30, 100, '1989-03-25', 2, 1, 2, 1);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;

-- Copiando estrutura para tabela livraria2si.usuarios
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `idusuarios` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  PRIMARY KEY (`idusuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.usuarios: ~1 rows (aproximadamente)
DELETE FROM `usuarios`;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`idusuarios`, `nome`, `senha`) VALUES
	(4, 'adm', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Copiando estrutura para tabela livraria2si.venda
DROP TABLE IF EXISTS `venda`;
CREATE TABLE IF NOT EXISTS `venda` (
  `codVenda` int(11) NOT NULL AUTO_INCREMENT,
  `dataHora` date NOT NULL,
  `desconto` decimal(4,2) NOT NULL,
  `tipoVenda` enum('À vista','Cartão Débito','Cartão Crédito','PIX') NOT NULL,
  `CLIENTE_codCliente` int(11) NOT NULL,
  PRIMARY KEY (`codVenda`,`CLIENTE_codCliente`),
  KEY `fk_VENDA_CLIENTE1_idx` (`CLIENTE_codCliente`),
  CONSTRAINT `fk_VENDA_CLIENTE1` FOREIGN KEY (`CLIENTE_codCliente`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela livraria2si.venda: ~0 rows (aproximadamente)
DELETE FROM `venda`;
/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
INSERT INTO `venda` (`codVenda`, `dataHora`, `desconto`, `tipoVenda`, `CLIENTE_codCliente`) VALUES
	(1, '2022-08-28', 0.05, 'À vista', 2),
	(2, '2021-02-23', 0.00, 'Cartão Crédito', 3);
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
