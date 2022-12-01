-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: livraria2si
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.35-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `codProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `precoVenda` varchar(100) NOT NULL,
  `precoCusto` varchar(100) NOT NULL,
  `quantidadeEstoque` varchar(10) NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (1,'Crônicas de Tandandan','50','30','100','1989-03-25',2,1,2,1);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-01 11:05:21
