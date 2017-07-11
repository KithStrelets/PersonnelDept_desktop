CREATE DATABASE  IF NOT EXISTS `personnel` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `personnel`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: personnel
-- ------------------------------------------------------
-- Server version	5.5.23

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
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `iddept` char(36) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `joblist` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`iddept`),
  UNIQUE KEY `idworker_UNIQUE` (`iddept`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `job`
--

DROP TABLE IF EXISTS `job`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `job` (
  `idjob` char(36) CHARACTER SET utf8 NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `jobrank` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  `workerslist` varchar(1000) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`idjob`),
  UNIQUE KEY `idjob_UNIQUE` (`idjob`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job`
--

LOCK TABLES `job` WRITE;
/*!40000 ALTER TABLE `job` DISABLE KEYS */;
INSERT INTO `job` VALUES ('1f71992d-776b-40c8-b68f-ad8e68133696','kek','Senior',10000,''),('5427369d-2b18-44ed-a1be-b65865280517','Janitor','Junior',1000,''),('57f66a83-a71f-4337-a9f5-0836d50cc2b1','Assisstant','Junior',282,''),('5f49d247-bdac-469a-8160-0b7ede69f1ab','Manager','Senior',22000,''),('7c823840-f7bb-4807-b0b8-4e24b86ca285','Admin','Senior',11000,''),('d9893d5e-e920-4140-815f-cb0dc1e55a33','Programmer','Junior',1111,'');
/*!40000 ALTER TABLE `job` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `person` (
  `idperson` char(36) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `birthdate` date DEFAULT NULL,
  `married` tinyint(4) DEFAULT NULL,
  `photo` varchar(100) DEFAULT NULL,
  `fk_department` char(36) DEFAULT NULL,
  `fk_job` char(36) DEFAULT NULL,
  `isfired` tinyint(4) DEFAULT NULL,
  `archive` varchar(1000) DEFAULT NULL,
  `fk_workerschedule` char(36) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idperson`),
  UNIQUE KEY `idperson_UNIQUE` (`idperson`),
  KEY `fk_department_idx` (`fk_department`),
  KEY `fk_job_idx` (`fk_job`),
  KEY `fk_workerschedule_idx` (`fk_workerschedule`),
  CONSTRAINT `fk_department` FOREIGN KEY (`fk_department`) REFERENCES `department` (`iddept`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_job` FOREIGN KEY (`fk_job`) REFERENCES `job` (`idjob`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_workerschedule` FOREIGN KEY (`fk_workerschedule`) REFERENCES `schedule` (`idschedule`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedule` (
  `idschedule` char(36) NOT NULL,
  `fk_department` char(36) DEFAULT NULL,
  `fk_job` char(36) DEFAULT NULL,
  `fmonday` varchar(45) DEFAULT NULL,
  `ftuesday` varchar(45) DEFAULT NULL,
  `fwednesday` varchar(45) DEFAULT NULL,
  `fthursday` varchar(45) DEFAULT NULL,
  `ffriday` varchar(45) DEFAULT NULL,
  `fsaturday` varchar(45) DEFAULT NULL,
  `fsunday` varchar(45) DEFAULT NULL,
  `smonday` varchar(45) DEFAULT NULL,
  `stuesday` varchar(45) DEFAULT NULL,
  `swednesday` varchar(45) DEFAULT NULL,
  `sthursday` varchar(45) DEFAULT NULL,
  `sfriday` varchar(45) DEFAULT NULL,
  `ssaturday` varchar(45) DEFAULT NULL,
  `ssunday` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idschedule`),
  UNIQUE KEY `idschedule_UNIQUE` (`idschedule`),
  KEY `fk_scheddepartment_idx` (`fk_department`),
  KEY `fk_schedjob_idx` (`fk_job`),
  CONSTRAINT `fk_schedjob` FOREIGN KEY (`fk_job`) REFERENCES `job` (`idjob`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_scheddepartment` FOREIGN KEY (`fk_department`) REFERENCES `department` (`iddept`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'personnel'
--

--
-- Dumping routines for database 'personnel'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-23  8:20:26
