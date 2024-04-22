CREATE DATABASE  IF NOT EXISTS `app_database` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `app_database`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: app_database
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `account_status`
--

DROP TABLE IF EXISTS `account_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account_status` (
  `status_id` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(50) NOT NULL,
  PRIMARY KEY (`status_id`),
  UNIQUE KEY `status_name` (`status_name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account_status`
--

LOCK TABLES `account_status` WRITE;
/*!40000 ALTER TABLE `account_status` DISABLE KEYS */;
INSERT INTO `account_status` VALUES (1,'active'),(3,'banned'),(2,'suspended');
/*!40000 ALTER TABLE `account_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comments`
--

DROP TABLE IF EXISTS `comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comments` (
  `comment_id` int NOT NULL AUTO_INCREMENT,
  `forum_id` int NOT NULL,
  `user_id` int NOT NULL,
  `comment_text` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`comment_id`),
  KEY `forum_id` (`forum_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `comments_ibfk_1` FOREIGN KEY (`forum_id`) REFERENCES `forums` (`forum_id`) ON DELETE CASCADE,
  CONSTRAINT `comments_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`id_user`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=142 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comments`
--

LOCK TABLES `comments` WRITE;
/*!40000 ALTER TABLE `comments` DISABLE KEYS */;
INSERT INTO `comments` VALUES (7,2,38,'adwadaw','2024-04-15 15:20:24'),(8,2,38,'asdawdaw','2024-04-15 15:20:27'),(19,3,38,'ahij','2024-04-15 20:38:52'),(28,3,39,'adada','2024-04-16 20:19:04'),(112,19,1,'haha','2024-04-21 15:33:57'),(113,22,2,'haha','2024-04-21 15:34:13'),(114,21,2,'haha','2024-04-21 15:34:16'),(115,20,2,'haha','2024-04-21 15:34:20'),(116,19,2,'hahah','2024-04-21 15:34:22'),(118,22,1,'film\r\n','2024-04-21 19:38:32'),(119,22,1,'ahoj lidi jak se mate?','2024-04-21 19:38:39'),(120,22,1,'co delate?\r\n','2024-04-21 19:38:43'),(121,22,2,'cau lidi','2024-04-21 19:40:58'),(122,19,2,'cau lidi jak se mate?','2024-04-21 19:41:06'),(123,23,2,'ahoj lidi','2024-04-21 19:41:42'),(124,24,3,'how to start?','2024-04-21 19:42:55'),(125,22,3,'Hello Guys','2024-04-21 19:43:20'),(126,19,3,'test test','2024-04-21 19:43:25'),(128,25,3,'hello','2024-04-22 06:31:10'),(129,25,1,'could you guys help me as well?','2024-04-22 06:31:38'),(130,25,3,'haha','2024-04-22 06:42:21'),(131,25,3,'i cant help you \r\n','2024-04-22 06:42:33'),(132,25,3,'it is really hard for me sorry :<','2024-04-22 06:42:48'),(134,26,3,'hi','2024-04-22 08:47:31'),(135,26,3,'hi','2024-04-22 08:52:27'),(136,24,2,'awdawd','2024-04-22 08:55:11'),(137,21,2,'awdawdawda','2024-04-22 08:55:14'),(138,26,2,'awdawd','2024-04-22 08:57:10'),(139,26,1,'dawdaw','2024-04-22 08:59:53'),(140,26,1,'test','2024-04-22 09:01:18'),(141,24,2,'hi','2024-04-22 09:01:53');
/*!40000 ALTER TABLE `comments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `forums`
--

DROP TABLE IF EXISTS `forums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `forums` (
  `forum_id` int NOT NULL AUTO_INCREMENT,
  `forum_name` varchar(100) NOT NULL,
  `forum_description` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `creator_user_id` int DEFAULT NULL,
  PRIMARY KEY (`forum_id`),
  UNIQUE KEY `forum_name_UNIQUE` (`forum_name`),
  KEY `forums_ibfk_1` (`creator_user_id`),
  CONSTRAINT `forums_ibfk_1` FOREIGN KEY (`creator_user_id`) REFERENCES `users` (`id_user`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `forums`
--

LOCK TABLES `forums` WRITE;
/*!40000 ALTER TABLE `forums` DISABLE KEYS */;
INSERT INTO `forums` VALUES (19,'zkouska','','2024-04-21 15:33:29',1),(20,'zkouska123','','2024-04-21 15:33:33',1),(21,'spse jecna','','2024-04-21 15:33:36',1),(22,'hahaha','','2024-04-21 15:33:39',1),(23,'Fotbal','Premier League','2024-04-21 19:41:33',2),(24,'Programming forum','how to begin?','2024-04-21 19:42:45',3),(25,'How to make spaghetti','I am hungry','2024-04-21 23:27:58',1),(26,'Text mee','','2024-04-22 08:47:18',2);
/*!40000 ALTER TABLE `forums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notifications`
--

DROP TABLE IF EXISTS `notifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notifications` (
  `notificaiton_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `other_user_id` int NOT NULL,
  `message` varchar(255) NOT NULL,
  `Timestamp` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `isRead` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`notificaiton_id`),
  KEY `user_id` (`user_id`),
  KEY `other_user_id` (`other_user_id`),
  CONSTRAINT `notifications_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id_user`),
  CONSTRAINT `notifications_ibfk_2` FOREIGN KEY (`other_user_id`) REFERENCES `users` (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notifications`
--

LOCK TABLES `notifications` WRITE;
/*!40000 ALTER TABLE `notifications` DISABLE KEYS */;
INSERT INTO `notifications` VALUES (1,1,2,'ahoj','2024-04-22 08:50:25',0),(2,2,1,'test','2024-04-22 09:01:19',0),(3,3,2,'hi','2024-04-22 09:01:55',0);
/*!40000 ALTER TABLE `notifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_roles`
--

DROP TABLE IF EXISTS `user_roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_roles` (
  `role_id` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`role_id`),
  UNIQUE KEY `role_name` (`role_name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_roles`
--

LOCK TABLES `user_roles` WRITE;
/*!40000 ALTER TABLE `user_roles` DISABLE KEYS */;
INSERT INTO `user_roles` VALUES (2,'admin'),(1,'user');
/*!40000 ALTER TABLE `user_roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_user_roles`
--

DROP TABLE IF EXISTS `user_user_roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_user_roles` (
  `user_id` int NOT NULL,
  `role_id` int NOT NULL,
  PRIMARY KEY (`user_id`,`role_id`),
  KEY `role_id` (`role_id`),
  CONSTRAINT `user_user_roles_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id_user`) ON DELETE CASCADE,
  CONSTRAINT `user_user_roles_ibfk_2` FOREIGN KEY (`role_id`) REFERENCES `user_roles` (`role_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_user_roles`
--

LOCK TABLES `user_user_roles` WRITE;
/*!40000 ALTER TABLE `user_user_roles` DISABLE KEYS */;
/*!40000 ALTER TABLE `user_user_roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id_user` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `display_name` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT 'unkown_user',
  `password_hash` varchar(255) NOT NULL,
  `email` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `bio` text DEFAULT (_utf8mb4'empty'),
  `role_id` int NOT NULL,
  `account_status_id` int NOT NULL,
  `date_of_birth` date NOT NULL,
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `username` (`username`),
  UNIQUE KEY `email` (`email`),
  KEY `users_ibfk_1` (`role_id`),
  KEY `users_ibfk_2` (`account_status_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `user_roles` (`role_id`) ON DELETE CASCADE,
  CONSTRAINT `users_ibfk_2` FOREIGN KEY (`account_status_id`) REFERENCES `account_status` (`status_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin','0afb00138d8e73348ec1fe41fd3d3a8fcbd90156b263bfa5791ba0e095f42cfc','admin@admin.cz','2024-04-18 14:56:07','ahoj',2,1,'1930-01-01'),(2,'aisuru','Noob','571b22ad5b6bc4fd21377187d237acf6ca5edce92a81e89240b8f67289fc96f3','konecnemamridicak@gmail.com','2024-04-18 20:38:51','empty',1,1,'1952-06-10'),(3,'demo','demo','792708630185e516089d682849224d4f271eaf9127ae3b917cb677ff47bb754a','demo123@gmail.com','2024-04-20 15:13:24','hello guys',1,1,'2005-01-01'),(4,'mcdonald','xoxoxo','49fe07d0f041bced9ba827a10c2cd31b2089229d4b4e3a63b074ed7a4370e88f','mcdonald@seznam.cz','2024-04-20 21:20:03','empty',1,1,'2002-05-29');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-22 11:10:31
