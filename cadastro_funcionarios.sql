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
-- Table structure for table `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `funcionarios` (
  `codFuncionario` tinyint(4) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  `sobrenome` varchar(30) NOT NULL,
  `dataNasc` date NOT NULL,
  `CPF` varchar(13) DEFAULT NULL,
  `RG` varchar(13) DEFAULT NULL,
  `CTPS` varchar(15) NOT NULL,
  `serieCTPS` varchar(15) NOT NULL,
  `PIS` varchar(15) NOT NULL,
  `endereço` varchar(60) NOT NULL,
  `numero` varchar(5) NOT NULL,
  `bairro` varchar(40) NOT NULL,
  `cidade` varchar(40) NOT NULL,
  `estado` text NOT NULL,
  `CEP` varchar(60) NOT NULL,
  `telefone1` double NOT NULL,
  `telefone2` double DEFAULT NULL,
  `email` varchar(40) NOT NULL,
  `permissao` varchar(10) NOT NULL,
  `cargo` varchar(30) NOT NULL,
  `dataRegistro` date DEFAULT NULL,
  `salarioBase` double DEFAULT NULL,
  `horas` int(11) NOT NULL,
  `gerente` varchar(30) NOT NULL,
  `nomeUsuario` varchar(15) NOT NULL,
  `senha` varchar(12) NOT NULL,
  `observacao` tinytext,
  PRIMARY KEY (`codFuncionario`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionarios`
--

LOCK TABLES `funcionarios` WRITE;
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios` VALUES (1,'GUILHERME','OLIVEIRA','1998-12-15','46646969817','375957108','741963','456789','7410456','RUA TAMOYO','306','VILA MARIA','INDAIATUBA','48593265','SAO PAULO',48254407,NULL,'GUILHERME.CRUZ','REI','PROGRAMADOR','2019-05-27',5000,8,'JOSNEY','GUI','89653',''),(2,'HENRIQUE','CANDIDO','2019-05-27','40889652355','1254548784549','212545','155451','154215215','RUA DO GUILHERME','111','DOS VINGADORES','INDAIATUBA','13232154','SP',1158478965,NULL,'OI@OI.COM','1','ADM','2019-05-27',1500,40,'GUILHERME','HENRIQUE','123456','VAMBORA'),(3,'BRUNO','ZABONINI PROTONHERE','1999-07-16','45698237148','479685328','7410852','7412','789654231','RUA PAMONHA','45','MORADA DO SOL','INDAIATUBA','04696123','SÂO PAULO',991458699,NULL,'ZAMBONINOGOD@BOL.COM','FULL','DIRETOR EXECUTIVO','2019-06-05',5000,5,'--','ZAMBO','4589',''),(4,'ALEX','NICOLAU','1999-06-16','741963,85206','315987468','4589658','74589654','12365489','RUA CRAMUNHÃO','89','TIETE','SALTO','7412563','SÃO PAULO',45693251,NULL,'NICULAU@BOL.COM','BAIXA','ESCRAVO','2019-06-05',10,16,'ZAMBONINI','NICULAU','4212','');
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-07 20:17:40
