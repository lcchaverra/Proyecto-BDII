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
-- Table structure for table `medicamentos`
--

DROP TABLE IF EXISTS `medicamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicamentos` (
  `id_med` int(11) NOT NULL,
  `nombre` text NOT NULL,
  `precio` int(11) NOT NULL,
  PRIMARY KEY (`id_med`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicamentos`
--

LOCK TABLES `medicamentos` WRITE;
/*!40000 ALTER TABLE `medicamentos` DISABLE KEYS */;
INSERT INTO `medicamentos` VALUES (1,'Acetaminofen 500mg',1000),(2,'Naproxeno 150mg',700),(3,'Amoxacilina 300mg',1500),(4,'Paracetamol 400mg',1200),(5,'Amlodipino',2100),(6,'Simvastatina 10 mg',650),(7,'Aspirina 150 mg',700),(8,'Omeprazol 20 mg',1200),(9,'Levotiroxina sódica 100 mg',900),(10,'Ramipril 10 mg',300),(11,'Lansoprazol 30 mg',450),(12,'Verapamilo Ampolla 5 mg/2 ml (2,5 mg/ml)',1200),(13,'Valproato Sódico Ampolla 400 mg/4 ml (100 mg/ml)',3000),(14,'Tramadol (Clorhidrato) Ampolla 100 mg/2 ml (50 mg/ml)',2000),(15,'Tiapride Ampolla 100 mg/2 ml (50 mg/ml)',5000),(16,'Sulfato de Magnesio Ampolla 1,5 gr/10 ml (150 mg/ml)',6000),(17,'Succinilcolina Ampolla 500 mg/10 ml (50 mg/ml)',7000),(18,'Somatostatina Vial 3 mg/2 ml (1,5 mg/ml)',8000),(19,'Salbutamol Solución para respirador 50 mg/10 ml (5 mg/ml)',5000),(20,'Ranitidina Ampolla 50 mg /5 ml (10 mg/ml)',3400),(21,'Propofol Ampolla 200 mg/10 ml (20 mg/ml)',4650),(22,'Propafenona Ampolla 70 mg/20 ml (3,5 mg/ml)',6485),(23,'Noradrenalina Vial de 50 mg en 5 ml (10 mg/ml)',987),(24,'Nitropusiato Sódico Vial 50 mg/5 ml (10 mg/ml)',6000),(25,'Nitroglicerina Ampolla 50 mg / 10 ml (5 mg/ml)',5000),(26,'Nimodipino Ampolla 10 mg/50 ml (0,2 mg/ml)',6500),(27,'Naloxona Ampolla 0,4 mg/1 ml (0,4 mg/ml)',3200),(28,'Morfina Ampolla 1% 10 mg/1 ml (10 mg/ml)',1500),(29,'Metoclopramida Ampolla 10 mg/2 ml (5 mg/ml)',1700),(30,'Metilprednisolona vial de 8 mg/2 ml, 20 mg /2 ml y 40 mg/2 ml',9000),(31,'Metamizol Magnésico Ampolla 2 gr/5 ml (0,4 gr/ml)',120000),(32,'Meperidina Ampolla 100 mg/2 ml (50 mg/ml)',3500),(33,'Manitol Viaflex al 20%: 50 g/250 ml (0,2 g/ml)',4700),(34,'Lidocaina Lidocaína 5%: Ampolla 500 mg/10 ml (50 mg/ml)',6200),(35,'Ketorolaco Ampolla 30 mg/1 ml',8500),(36,'Isoprotenerol Ampolla 0,2 mg/1 ml (0,2 mg/ml)',7300),(37,'Insulina Rápida Vial 1000 UI/10 ml (100 UI/ml)',9500),(38,'Hidrocortisona Vial de 100 mg/ml y 500 mg/5ml (100 mg/ml)',10000),(39,'Haloperidol Ampolla 5 mg/1 ml (5 mg/ml)',110000),(40,'Glucosa Ampolla 33%: 3,3 gr/10 ml (0,33 gr/ml)',5000),(41,'Glucobionato de Calcio Ampolla 10 ml/1,375 g (90 mg de calcio elemento)',6000),(42,'Glucagón Vial 1 mg + jeringa agua 1 ml (1mg/ml)',7000),(43,'Furosemida ampolla 20 mg/2 ml2',5000),(44,'Flumazenilo Ampolla de 0,5 mg/5 ml (0,1 mg/ml)',4000),(45,'Fentanilo Ampolla 0,15 mg/3 ml (0,05 mg/ml)',3000),(46,'Etomidato Ampolla 2,5 gr/10 ml (250 mg/ml) para perfusión',20000),(47,'Enalaprilato Ampolla 1 mg/1 ml (1 mg/ml)',1000),(48,'Edrofonio Ampolla 25 mg/2 ml (12,5 mg/ml)',15000),(49,'Dopamina Ampolla 200 mg/5 ml (40 mg/ml)',451000),(50,'Dobutamina Ampolla 250 mg/20 ml (12,5 mg/ml)',9896),(51,'Difenilhidantiína Ampolla 250 mg/5 ml (50 mg/ml)',7456),(52,'Diazepam Ampolla de 10 mg/2 ml (5 mg/ml)',5632),(53,'Dexclorferinamina Ampolla 5 mg/ml (5 mg/ml)',64000),(54,'Dexametasona Ampolla de 4 mg / 1 ml (4 mg / ml)',8500),(55,'Cloruro Potásico Ampolla (14,9% 2M) 10 mEq / 5 ml (2 mEq /ml)',7845),(56,'Butilbromuro de Hioscina Ampolla 20 mg/ ml',9986),(57,'Bicarbonato Sódico Suero 1/6 M: 41 mEq /250 ml (1 mEq/6 ml)',6452),(58,'Atropina Ampolla 1 mg / 1 ml (1 mg/ml)',7452),(59,'ATP (Adenosina Triposfato) Vial 100 mg + disolvente 10 ml (10 mg/ml)',85462),(60,'Amiodarona Ampolla 150 mg/3 ml (50 mg/ml)',4625),(61,'Adrenalina Ampolla 1 mg/1 ml (1 mg/ml)',3200),(62,'Acetilsalicicato de Lisina Vial 900 mg + 5 ml de agua (180 mg/ml)',45000),(63,'Acetilcisteína Vial 2 g /10 ml (200 mg/ml)',4000);
/*!40000 ALTER TABLE `medicamentos` ENABLE KEYS */;
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
