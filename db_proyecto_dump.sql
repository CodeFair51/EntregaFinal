-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: db_proyecto
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `campeonato`
--

DROP TABLE IF EXISTS `campeonato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campeonato` (
  `nomCampeonato` varchar(30) NOT NULL,
  `region` varchar(20) DEFAULT NULL,
  `cantFechas` tinyint unsigned DEFAULT NULL,
  `modalidad` enum('liga','gruposEliminatorias') NOT NULL,
  `nomDeporte` varchar(15) NOT NULL,
  PRIMARY KEY (`nomCampeonato`),
  KEY `nomDeporte` (`nomDeporte`),
  CONSTRAINT `campeonato_ibfk_1` FOREIGN KEY (`nomDeporte`) REFERENCES `deporte` (`nomDeporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campeonato`
--

LOCK TABLES `campeonato` WRITE;
/*!40000 ALTER TABLE `campeonato` DISABLE KEYS */;
INSERT INTO `campeonato` VALUES ('NBA','Estados Unidos',60,'liga','Basketball'),('UEFA Champions League','Europa',60,'gruposEliminatorias','Soccer');
/*!40000 ALTER TABLE `campeonato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campeonato_equipo`
--

DROP TABLE IF EXISTS `campeonato_equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campeonato_equipo` (
  `nomCampeonato` varchar(30) NOT NULL,
  `nomEquipo` varchar(20) NOT NULL,
  `posicion` tinyint DEFAULT NULL,
  `puntos` tinyint DEFAULT NULL,
  `partidosJugados` tinyint DEFAULT NULL,
  PRIMARY KEY (`nomCampeonato`,`nomEquipo`),
  KEY `nomEquipo` (`nomEquipo`),
  CONSTRAINT `campeonato_equipo_ibfk_1` FOREIGN KEY (`nomCampeonato`) REFERENCES `campeonato` (`nomCampeonato`),
  CONSTRAINT `campeonato_equipo_ibfk_2` FOREIGN KEY (`nomEquipo`) REFERENCES `equipo` (`nomEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campeonato_equipo`
--

LOCK TABLES `campeonato_equipo` WRITE;
/*!40000 ALTER TABLE `campeonato_equipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `campeonato_equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campeonato_jugadorindividual`
--

DROP TABLE IF EXISTS `campeonato_jugadorindividual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campeonato_jugadorindividual` (
  `nomCampeonato` varchar(30) NOT NULL,
  `idJugadorInd` int unsigned NOT NULL,
  `posicion` tinyint DEFAULT NULL,
  `puntos` tinyint DEFAULT NULL,
  `partidosJugados` tinyint DEFAULT NULL,
  PRIMARY KEY (`nomCampeonato`,`idJugadorInd`),
  KEY `idJugadorInd` (`idJugadorInd`),
  CONSTRAINT `campeonato_jugadorindividual_ibfk_1` FOREIGN KEY (`nomCampeonato`) REFERENCES `campeonato` (`nomCampeonato`),
  CONSTRAINT `campeonato_jugadorindividual_ibfk_2` FOREIGN KEY (`idJugadorInd`) REFERENCES `jugadorindividual` (`idJugadorInd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campeonato_jugadorindividual`
--

LOCK TABLES `campeonato_jugadorindividual` WRITE;
/*!40000 ALTER TABLE `campeonato_jugadorindividual` DISABLE KEYS */;
/*!40000 ALTER TABLE `campeonato_jugadorindividual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campeonatogruposeliminatorias`
--

DROP TABLE IF EXISTS `campeonatogruposeliminatorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campeonatogruposeliminatorias` (
  `nomCampeonato` varchar(30) NOT NULL,
  `idaYvueltaGrupos` bit(1) NOT NULL,
  PRIMARY KEY (`nomCampeonato`),
  CONSTRAINT `campeonatogruposeliminatorias_ibfk_1` FOREIGN KEY (`nomCampeonato`) REFERENCES `campeonato` (`nomCampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campeonatogruposeliminatorias`
--

LOCK TABLES `campeonatogruposeliminatorias` WRITE;
/*!40000 ALTER TABLE `campeonatogruposeliminatorias` DISABLE KEYS */;
INSERT INTO `campeonatogruposeliminatorias` VALUES ('UEFA Champions League',_binary '');
/*!40000 ALTER TABLE `campeonatogruposeliminatorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deporte`
--

DROP TABLE IF EXISTS `deporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deporte` (
  `nomDeporte` varchar(15) NOT NULL,
  `modalidad` enum('equipo','individual') NOT NULL,
  PRIMARY KEY (`nomDeporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deporte`
--

LOCK TABLES `deporte` WRITE;
/*!40000 ALTER TABLE `deporte` DISABLE KEYS */;
INSERT INTO `deporte` VALUES ('basketball','equipo'),('handball','equipo'),('soccer','equipo'),('tennis','individual'),('volleyball','equipo');
/*!40000 ALTER TABLE `deporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipo` (
  `nomEquipo` varchar(20) NOT NULL,
  `pais` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`nomEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES ('Angeles Lakers','Estados Unidos'),('Barcelona','España'),('Boston Celtics','Estados Unidos'),('Chicago Bulls','Estados Unidos'),('New York Knicks','Estados Unidos'),('Real Madrid','España');
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugador`
--

DROP TABLE IF EXISTS `jugador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugador` (
  `idJugador` int unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `nacionalidad` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idJugador`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugador`
--

LOCK TABLES `jugador` WRITE;
/*!40000 ALTER TABLE `jugador` DISABLE KEYS */;
INSERT INTO `jugador` VALUES (1,'Lionel','Messi','Argentina'),(2,'Rafael','Nadal','España');
/*!40000 ALTER TABLE `jugador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugadorequipo`
--

DROP TABLE IF EXISTS `jugadorequipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugadorequipo` (
  `idJugadorEq` int unsigned NOT NULL AUTO_INCREMENT,
  `anotaciones` int unsigned DEFAULT NULL,
  PRIMARY KEY (`idJugadorEq`),
  CONSTRAINT `jugadorequipo_ibfk_1` FOREIGN KEY (`idJugadorEq`) REFERENCES `jugador` (`idJugador`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugadorequipo`
--

LOCK TABLES `jugadorequipo` WRITE;
/*!40000 ALTER TABLE `jugadorequipo` DISABLE KEYS */;
INSERT INTO `jugadorequipo` VALUES (1,700);
/*!40000 ALTER TABLE `jugadorequipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugadorequipo_equipo`
--

DROP TABLE IF EXISTS `jugadorequipo_equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugadorequipo_equipo` (
  `idJugadorEq` int unsigned NOT NULL,
  `nomEquipo` varchar(20) NOT NULL,
  `nroCamiseta` tinyint unsigned DEFAULT NULL,
  `anotaciones` int unsigned DEFAULT NULL,
  PRIMARY KEY (`idJugadorEq`,`nomEquipo`),
  KEY `nomEquipo` (`nomEquipo`),
  CONSTRAINT `jugadorequipo_equipo_ibfk_1` FOREIGN KEY (`idJugadorEq`) REFERENCES `jugadorequipo` (`idJugadorEq`),
  CONSTRAINT `jugadorequipo_equipo_ibfk_2` FOREIGN KEY (`nomEquipo`) REFERENCES `equipo` (`nomEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugadorequipo_equipo`
--

LOCK TABLES `jugadorequipo_equipo` WRITE;
/*!40000 ALTER TABLE `jugadorequipo_equipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `jugadorequipo_equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugadorindividual`
--

DROP TABLE IF EXISTS `jugadorindividual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugadorindividual` (
  `idJugadorInd` int unsigned NOT NULL AUTO_INCREMENT,
  `ranking` int unsigned DEFAULT NULL,
  PRIMARY KEY (`idJugadorInd`),
  UNIQUE KEY `ranking` (`ranking`),
  CONSTRAINT `jugadorindividual_ibfk_1` FOREIGN KEY (`idJugadorInd`) REFERENCES `jugador` (`idJugador`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugadorindividual`
--

LOCK TABLES `jugadorindividual` WRITE;
/*!40000 ALTER TABLE `jugadorindividual` DISABLE KEYS */;
INSERT INTO `jugadorindividual` VALUES (2,1);
/*!40000 ALTER TABLE `jugadorindividual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partido`
--

DROP TABLE IF EXISTS `partido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partido` (
  `idPartido` int unsigned NOT NULL AUTO_INCREMENT,
  `estadio` varchar(20) DEFAULT NULL,
  `duracion` int unsigned DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `anotacionLocal` tinyint unsigned DEFAULT NULL,
  `anotacionVisitante` tinyint unsigned DEFAULT NULL,
  `nomDeporte` varchar(15) NOT NULL,
  PRIMARY KEY (`idPartido`),
  KEY `nomDeporte` (`nomDeporte`),
  CONSTRAINT `partido_ibfk_1` FOREIGN KEY (`nomDeporte`) REFERENCES `deporte` (`nomDeporte`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partido`
--

LOCK TABLES `partido` WRITE;
/*!40000 ALTER TABLE `partido` DISABLE KEYS */;
INSERT INTO `partido` VALUES (1,'Santiago Bernabeu',NULL,'2022-09-02','18:00:00',NULL,NULL,'Soccer'),(2,'Crypto.com Arena',NULL,'2022-09-02','15:00:00',NULL,NULL,'Basketball'),(3,'TD Garden',NULL,'2022-09-02','17:00:00',NULL,NULL,'Basketball'),(4,'Crypto.com Arena',NULL,'2022-09-02','16:30:00',NULL,NULL,'Basketball'),(5,'United Arena',NULL,'2022-09-02','20:40:00',NULL,NULL,'Basketball'),(6,'Madison Square',NULL,'2022-09-02','14:30:00',NULL,NULL,'Basketball');
/*!40000 ALTER TABLE `partido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partido_campeonato`
--

DROP TABLE IF EXISTS `partido_campeonato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partido_campeonato` (
  `idPartido` int unsigned NOT NULL,
  `nomCampeonato` varchar(30) NOT NULL,
  `nroFecha` tinyint DEFAULT NULL,
  PRIMARY KEY (`idPartido`),
  KEY `nomCampeonato` (`nomCampeonato`),
  CONSTRAINT `partido_campeonato_ibfk_1` FOREIGN KEY (`idPartido`) REFERENCES `partido` (`idPartido`),
  CONSTRAINT `partido_campeonato_ibfk_2` FOREIGN KEY (`nomCampeonato`) REFERENCES `campeonato` (`nomCampeonato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partido_campeonato`
--

LOCK TABLES `partido_campeonato` WRITE;
/*!40000 ALTER TABLE `partido_campeonato` DISABLE KEYS */;
INSERT INTO `partido_campeonato` VALUES (1,'UEFA Champions League',1),(2,'NBA',1),(3,'NBA',1),(4,'NBA',1),(5,'NBA',1),(6,'NBA',1);
/*!40000 ALTER TABLE `partido_campeonato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partidoequipo`
--

DROP TABLE IF EXISTS `partidoequipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partidoequipo` (
  `idPartidoEq` int unsigned NOT NULL,
  `alineacionLocal` varchar(7) DEFAULT NULL,
  `alineacionVisitante` varchar(7) DEFAULT NULL,
  `nomEquipoLocal` varchar(20) DEFAULT NULL,
  `nomEquipoVisitante` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idPartidoEq`),
  KEY `nomEquipoLocal` (`nomEquipoLocal`),
  KEY `nomEquipoVisitante` (`nomEquipoVisitante`),
  CONSTRAINT `partidoequipo_ibfk_2` FOREIGN KEY (`nomEquipoLocal`) REFERENCES `equipo` (`nomEquipo`),
  CONSTRAINT `partidoequipo_ibfk_3` FOREIGN KEY (`nomEquipoVisitante`) REFERENCES `equipo` (`nomEquipo`),
  CONSTRAINT `partidoequipo_ibfk_5` FOREIGN KEY (`idPartidoEq`) REFERENCES `partido` (`idPartido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidoequipo`
--

LOCK TABLES `partidoequipo` WRITE;
/*!40000 ALTER TABLE `partidoequipo` DISABLE KEYS */;
INSERT INTO `partidoequipo` VALUES (1,NULL,NULL,'Real Madrid','Barcelona'),(2,NULL,NULL,'Angeles Lakers','Chicago Bulls'),(3,NULL,NULL,'Boston Celtics','New York Knicks'),(4,NULL,NULL,'Angeles Lakers','Boston Celtics'),(5,NULL,NULL,'Chicago Bulls','Boston Celtics'),(6,NULL,NULL,'New York Knicks','Chicago Bulls');
/*!40000 ALTER TABLE `partidoequipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partidoequipo_jugadorequipo`
--

DROP TABLE IF EXISTS `partidoequipo_jugadorequipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partidoequipo_jugadorequipo` (
  `idPartidoEq` int unsigned NOT NULL,
  `idJugadorEq` int unsigned NOT NULL,
  `anotaciones` tinyint unsigned DEFAULT NULL,
  `posicion` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idPartidoEq`,`idJugadorEq`),
  KEY `idJugadorEq` (`idJugadorEq`),
  CONSTRAINT `partidoequipo_jugadorequipo_ibfk_1` FOREIGN KEY (`idPartidoEq`) REFERENCES `partidoequipo` (`idPartidoEq`),
  CONSTRAINT `partidoequipo_jugadorequipo_ibfk_2` FOREIGN KEY (`idJugadorEq`) REFERENCES `jugadorequipo` (`idJugadorEq`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidoequipo_jugadorequipo`
--

LOCK TABLES `partidoequipo_jugadorequipo` WRITE;
/*!40000 ALTER TABLE `partidoequipo_jugadorequipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `partidoequipo_jugadorequipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partidoindividual`
--

DROP TABLE IF EXISTS `partidoindividual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partidoindividual` (
  `idPartidoInd` int unsigned NOT NULL,
  `idJugadorLocal` int unsigned DEFAULT NULL,
  `idJugadorVisitante` int unsigned DEFAULT NULL,
  PRIMARY KEY (`idPartidoInd`),
  KEY `idJugadorLocal` (`idJugadorLocal`),
  KEY `idJugadorVisitante` (`idJugadorVisitante`),
  CONSTRAINT `partidoindividual_ibfk_2` FOREIGN KEY (`idJugadorLocal`) REFERENCES `jugadorindividual` (`idJugadorInd`),
  CONSTRAINT `partidoindividual_ibfk_3` FOREIGN KEY (`idJugadorVisitante`) REFERENCES `jugadorindividual` (`idJugadorInd`),
  CONSTRAINT `partidoindividual_ibfk_5` FOREIGN KEY (`idPartidoInd`) REFERENCES `partido` (`idPartido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidoindividual`
--

LOCK TABLES `partidoindividual` WRITE;
/*!40000 ALTER TABLE `partidoindividual` DISABLE KEYS */;
/*!40000 ALTER TABLE `partidoindividual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarjeta`
--

DROP TABLE IF EXISTS `tarjeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tarjeta` (
  `numero` bigint unsigned NOT NULL,
  `titular` varchar(41) NOT NULL,
  `cvc` int unsigned NOT NULL,
  `banco` varchar(20) NOT NULL,
  `procesador` varchar(15) NOT NULL,
  PRIMARY KEY (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarjeta`
--

LOCK TABLES `tarjeta` WRITE;
/*!40000 ALTER TABLE `tarjeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tarjeta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `nomUsuario` varchar(20) NOT NULL,
  `email` varchar(40) NOT NULL,
  `contra` varchar(25) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `pais` varchar(15) DEFAULT NULL,
  `pago` bit(1) NOT NULL,
  `tipo` enum('cliente','admin') NOT NULL,
  PRIMARY KEY (`nomUsuario`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('MatiGreppi','matigreppi12@gmail.com','matiti12','Matias','Greppi','Uruguay',_binary '','admin'),('Ricardo','rica@gmail.com','rica1234','Ricardo','Montaner','Venezuela',_binary '','cliente');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_deporte`
--

DROP TABLE IF EXISTS `usuario_deporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario_deporte` (
  `nomUsuario` varchar(20) NOT NULL,
  `nomDeporte` varchar(15) NOT NULL,
  PRIMARY KEY (`nomUsuario`,`nomDeporte`),
  KEY `nomDeporte` (`nomDeporte`),
  CONSTRAINT `usuario_deporte_ibfk_1` FOREIGN KEY (`nomUsuario`) REFERENCES `usuario` (`nomUsuario`),
  CONSTRAINT `usuario_deporte_ibfk_2` FOREIGN KEY (`nomDeporte`) REFERENCES `deporte` (`nomDeporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_deporte`
--

LOCK TABLES `usuario_deporte` WRITE;
/*!40000 ALTER TABLE `usuario_deporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_deporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_tarjeta`
--

DROP TABLE IF EXISTS `usuario_tarjeta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario_tarjeta` (
  `nomUsuario` varchar(20) NOT NULL,
  `numero` bigint unsigned NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`nomUsuario`,`numero`),
  KEY `numero` (`numero`),
  CONSTRAINT `usuario_tarjeta_ibfk_1` FOREIGN KEY (`nomUsuario`) REFERENCES `usuario` (`nomUsuario`),
  CONSTRAINT `usuario_tarjeta_ibfk_2` FOREIGN KEY (`numero`) REFERENCES `tarjeta` (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_tarjeta`
--

LOCK TABLES `usuario_tarjeta` WRITE;
/*!40000 ALTER TABLE `usuario_tarjeta` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_tarjeta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-11  8:44:12
