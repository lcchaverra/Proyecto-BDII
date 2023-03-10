CREATE DATABASE  IF NOT EXISTS `ludb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ludb`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: ludb
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `factura` (
  `id_fac` int(11) NOT NULL,
  `cedula` text NOT NULL,
  `nombres` text NOT NULL,
  `apellidos` text NOT NULL,
  `telefono` text NOT NULL,
  `regimen` text NOT NULL,
  `edad` text NOT NULL,
  `medicamentos` text NOT NULL,
  `cantidad` text NOT NULL,
  `precio` text NOT NULL,
  `total` text NOT NULL,
  `fecha_factura` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
INSERT INTO `factura` VALUES (517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','Acetaminofen 500mg','45','1000','45000','06/05/2020 18:50:30'),(517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','Naproxeno 150mg','5','700','3500','06/05/2020 18:50:30'),(517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','Amoxacilina 300mg','90','1500','135000','06/05/2020 18:50:30'),(517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','Simvastatina 10 mg','4','650','2600','06/05/2020 18:50:30'),(517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','Metilprednisolona vial de 8 mg/2 ml, 20 mg /2 ml y 40 mg/2 ml','15','9000','135000','06/05/2020 18:50:30'),(517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','Meperidina Ampolla 100 mg/2 ml (50 mg/ml)','12','3500','42000','06/05/2020 18:50:30'),(517,'1193223824','Luis Carlos','Chaverra Córdoba','32348546','subsidiado','19','','','','','06/05/2020 18:50:30');
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-11 11:49:25
