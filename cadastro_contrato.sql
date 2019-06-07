-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: cadastro
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `contrato`
--

DROP TABLE IF EXISTS `contrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `contrato` (
  `codContrato` tinyint(4) NOT NULL AUTO_INCREMENT,
  `codCliente` tinyint(4) NOT NULL,
  `codFuncionario` tinyint(4) NOT NULL,
  `codEspaco` tinyint(4) NOT NULL,
  `codplano` tinyint(4) NOT NULL,
  `dataCadastro` date NOT NULL,
  `datainicio` date NOT NULL,
  `datafim` date NOT NULL,
  `valorTotal` int(11) NOT NULL,
  `formaPagamento` text,
  `quantidadeParcelas` int(11) NOT NULL,
  `quantidadeImpressoes` int(11) DEFAULT NULL,
  `observacoes` tinytext,
  PRIMARY KEY (`codContrato`),
  KEY `codCliente` (`codCliente`),
  KEY `codFuncionario` (`codFuncionario`),
  KEY `codEspaco` (`codEspaco`),
  KEY `codplano` (`codplano`),
  CONSTRAINT `codCliente` FOREIGN KEY (`codCliente`) REFERENCES `clientes` (`codCliente`),
  CONSTRAINT `codEspaco` FOREIGN KEY (`codEspaco`) REFERENCES `espaco` (`codEspaco`),
  CONSTRAINT `codFuncionario` FOREIGN KEY (`codFuncionario`) REFERENCES `funcionarios` (`codFuncionario`),
  CONSTRAINT `codplano` FOREIGN KEY (`codplano`) REFERENCES `plano` (`codPlano`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contrato`
--

LOCK TABLES `contrato` WRITE;
/*!40000 ALTER TABLE `contrato` DISABLE KEYS */;
INSERT INTO `contrato` VALUES (2,7,2,1,2,'2019-06-02','2019-06-02','2019-08-01',880,'A VISTA',1,50,''),(3,8,2,1,2,'2019-06-02','2019-06-02','2020-02-01',880,'A VISTA',1,50,''),(4,9,1,1,2,'2019-06-03','2019-06-03','2019-06-03',880,'A VISTA',1,250,''),(5,10,2,1,2,'2019-06-03','2019-06-03','2020-01-01',880,'A VISTA',1,500,''),(6,11,1,1,2,'2019-06-03','2019-06-03','2020-01-03',880,'A VISTA',1,50,''),(7,13,1,1,2,'2019-06-06','2019-06-06','2020-01-01',880,'A VISTA',1,30,'');
/*!40000 ALTER TABLE `contrato` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-07 20:17:37
