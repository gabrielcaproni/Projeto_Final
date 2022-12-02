-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.20-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


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

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela livraria2si.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `dataNascimento` date NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `uf` char(2) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `email` varchar(200) NOT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela livraria2si.editora
DROP TABLE IF EXISTS `editora`;
CREATE TABLE IF NOT EXISTS `editora` (
  `codEditora` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `plataformaLancamento` varchar(100) NOT NULL,
  PRIMARY KEY (`codEditora`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure livraria2si.insere_cliente
DROP PROCEDURE IF EXISTS `insere_cliente`;
DELIMITER //
CREATE PROCEDURE `insere_cliente`(in nome varchar(200), dataNascimento date, cpf varchar(20), uf varchar(2), endereco varchar(100), bairro varchar(100), cidade varchar(45), cep varchar(20), email varchar(200))
BEGIN
	insert into cliente values (null, nome, dataNascimento, cpf, uf, endereco, bairro, cidade, cep, email);
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

-- Exportação de dados foi desmarcado.

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

-- Copiando estrutura para procedure livraria2si.proc_insereEditora
DROP PROCEDURE IF EXISTS `proc_insereEditora`;
DELIMITER //
CREATE PROCEDURE `proc_insereEditora`(in novoNome varchar(200), Plataforma varchar(100) )
BEGIN
	insert into editora(nome,plataformaLancamento) values (novoNome,Plataforma);
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
  `codProduto` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `precoVenda` varchar(100) NOT NULL,
  `precoCusto` varchar(100) DEFAULT NULL,
  `quantidadeEstoque` varchar(10) DEFAULT NULL,
  `dataLancamento` varchar(10) NOT NULL,
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

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

-- Exportação de dados foi desmarcado.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
