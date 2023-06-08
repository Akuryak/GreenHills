-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: greenhills
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id_client` int NOT NULL,
  `surname_client` varchar(50) NOT NULL,
  `name_client` varchar(50) NOT NULL,
  `patronymic_client` varchar(50) NOT NULL,
  `phone_client` varchar(40) NOT NULL,
  `password_client` varchar(50) NOT NULL,
  `requisites_client` varchar(50) NOT NULL,
  `email_client` varchar(50) NOT NULL,
  `role` int NOT NULL,
  PRIMARY KEY (`id_client`),
  KEY `role_idx` (`role`),
  CONSTRAINT `role` FOREIGN KEY (`role`) REFERENCES `role` (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Шакирова','Эвелина','Рустамовна','79273456789','ShakirovaClient','8067568745','evelina@gmail.com',4),(2,'Карасев','Кирилл','Даниилович','79875868565','Mur9D','3151452392','kirill@gmail.com',3),(3,'Кузнецова','София','Владимировна','79877647234','70hRS','7323788980','sofia@gmail.com',3),(4,'Потапова','Елизавета','Богдановна','79874210460','6mRoN','4352690856','elizaveta@gmail.com',3),(5,'Свиридова','Виктория','Ярославовна','79872024164','wUV2Q','9095149591','victoria@gmail.com',3),(6,'Хохлова','Милана','Михайловна','79874150807','8ayOo','6631569885','milana@gmail.com',3),(7,'Винокурова','Антонина','Яковлевна','79877120561','l35qK','9751977867','antonina@gmail.com',3),(8,'Некрасов','Александр','Артёмович','79878303910','as21F','1612568190','aleksandr@gmail.com',3),(9,'Ефремова','Милана','Фёдоровна','79871263910','fHn33','3916904072','milana@gmail.com',3),(10,'Николаева','Елена','Михайловна','79873641716','Dp8yE','7614867264','elena@gmail.com',3),(11,'Васильев','Артём','Владиславович','79873959669','2Tfr0','2340333269','artem@gmail.com',3),(12,'Лопатин','Фёдор','Павлович','79870089191','z1L7P','3273144691','fedor@gmail.com',3),(13,'Петрова','Ярослава','Вячеславовна','79872851965','H8vuy','2193730169','yaroslava@gmail.com',3),(14,'Виноградов','Матвей','Борисович','79872949114','88Ogb','1728588237','matvey@gmail.com',3),(15,'Гуров','Артём','Глебович','79870947632','45obR','9004425571','artem@gmail.com',3),(16,'Захарова','Мира','Георгиевна','79873064987','4WsXj','2637475570','mira@gmail.com',3),(17,'Баженова','Марьяна','Фёдоровна','79876336989','XAiS4','2611686280','mariana@gmail.com',3),(18,'Соловьева','Вероника','Матвеевна','79878319464','7Wl8q','6758834233','veronika@gmail.com',3),(19,'Калинина','Аделина','Матвеевна','79875822149','QTlS3','9244541281','adelina@gmail.com',3),(20,'Моисеева','Амина','Максимовна','79875694476','lPX4D','9331770063','amina@gmail.com',3),(21,'Попов','Матвей','Максимович','79870070862','3tPOz','1044256614','matvey@gmail.com',3),(22,'Дроздова','Кира','Матвеевна','79876453523','T0gUd','8115729247','kira@gmail.com',3),(23,'Захаров','Эмиль','Иванович','79879937062','dON77','7764338083','emil@gmail.com',3),(24,'Марков','Матвей','Егорович','79879389313','FDa2K','6949971967','matvey@gmail.com',3),(25,'Матвеева','Арина','Вячеславовна','79876504852','1pR1Y','4992107961','arina@gmail.com',3),(26,'Ефимов','Богдан','Тихонович','79870785022','7UcVR','1762015031','bogdan@gmail.com',3),(27,'Малахова','Полина','Марковна','79872672303','s6fBQ','5999105898','polina@gmail.com',4),(28,'Иванова','Ева','Григорьевна','79873217450','uM1tP','6373166585','eva@gmail.com',4),(29,'Кузьмин','Максим','Даниилович','79870048563','bCE3x','8945472737','maksim@gmail.com',4),(30,'Самсонова','Анна','Владимировна','79874214544','8zQYX','3756845727','anna@gmail.com',4);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contract`
--

DROP TABLE IF EXISTS `contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contract` (
  `id_contract` int NOT NULL,
  `idByer_contract` int NOT NULL,
  `idObject_contract` int NOT NULL,
  `idStaff_contract` int NOT NULL,
  `dateConclusion_contract` date NOT NULL,
  `validUntil_contract` date NOT NULL,
  `type_contract` int NOT NULL,
  PRIMARY KEY (`id_contract`),
  KEY `typecon_idx` (`type_contract`),
  KEY `idbyer_idx` (`idByer_contract`),
  KEY `idobjcon_idx` (`idObject_contract`),
  KEY `idstaffcon_idx` (`idStaff_contract`),
  CONSTRAINT `idbyer` FOREIGN KEY (`idByer_contract`) REFERENCES `client` (`id_client`),
  CONSTRAINT `idobjcon` FOREIGN KEY (`idObject_contract`) REFERENCES `object` (`id_object`),
  CONSTRAINT `idstaffcon` FOREIGN KEY (`idStaff_contract`) REFERENCES `staff` (`id_staff`),
  CONSTRAINT `typecon` FOREIGN KEY (`type_contract`) REFERENCES `typecontract` (`id_typeContract`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contract`
--

LOCK TABLES `contract` WRITE;
/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
INSERT INTO `contract` VALUES (1,27,40,3,'2023-04-12','2023-07-12',1),(2,28,39,3,'2023-05-13','2023-09-13',1),(3,29,38,3,'2023-02-02','2023-08-08',1),(4,30,37,4,'2023-03-01','2023-06-01',1),(5,1,36,4,'2023-03-21','2023-06-21',1),(6,2,35,5,'2023-04-25','2023-07-25',1),(7,3,34,5,'2023-04-05','2023-07-09',1),(8,4,33,6,'2023-03-18','2023-06-18',1),(9,5,32,6,'2023-05-16','2023-09-16',1),(10,6,31,7,'2023-06-01','2023-06-01',1),(11,7,30,7,'2023-06-02','2023-06-08',1),(12,8,29,7,'2023-06-06','2023-06-06',2),(13,9,28,7,'2023-05-24','2023-09-24',2),(14,10,27,8,'2023-05-18','2023-09-18',2),(15,11,26,9,'2023-02-16','2023-08-16',2),(16,13,25,10,'2023-03-21','2023-06-21',2),(17,14,24,11,'2023-04-23','2023-07-23',2),(18,15,23,12,'2023-04-27','2023-07-27',2),(19,16,22,13,'2023-05-24','2023-09-24',2),(20,20,21,14,'2023-05-18','2023-09-18',2);
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `object`
--

DROP TABLE IF EXISTS `object`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `object` (
  `id_object` int NOT NULL,
  `type_object` int NOT NULL,
  `price_object` decimal(19,2) NOT NULL,
  `numRooms_object` int DEFAULT NULL,
  `livingArea_object` varchar(40) DEFAULT NULL,
  `plotArea_object` varchar(40) DEFAULT NULL,
  `floor_object` int DEFAULT NULL,
  `idSob_object` int NOT NULL,
  `city_object` varchar(100) NOT NULL,
  `district_object` varchar(100) NOT NULL,
  `address_object` varchar(100) NOT NULL,
  `images_object` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_object`),
  KEY `sobobject_idx` (`idSob_object`),
  KEY `typeobject_idx` (`type_object`),
  CONSTRAINT `sobobject` FOREIGN KEY (`idSob_object`) REFERENCES `client` (`id_client`),
  CONSTRAINT `typeobject` FOREIGN KEY (`type_object`) REFERENCES `typeobject` (`id_typeObject`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `object`
--

LOCK TABLES `object` WRITE;
/*!40000 ALTER TABLE `object` DISABLE KEYS */;
INSERT INTO `object` VALUES (1,1,10000000.00,4,'137','',2,3,'Москва','Озерский','Новокузнецкая 36','object1.jpg'),(2,1,8000000.00,3,'140','',3,4,'Уфа','Советский','Проспект 80','object2.jpg'),(3,1,30000000.00,6,'300','',4,5,'Москва','Новый Арбат','Николопесковский переулок 13','object3.jpg'),(4,1,50000000.00,6,'400','',2,6,'Москва','Мещанский','Головин переулок 4','object4.jpg'),(5,1,40000000.00,5,'300','',3,7,'Москва','Озерский','Петроверигский переулок 104','object5.jpg'),(6,1,20000000.00,3,'120','',4,8,'Уфа','Советский','Рихарда Зорге 34','object6.jpg'),(7,1,35000000.00,4,'150','',5,9,'Москва','Мещанский','Кирова 56','object7.jpg'),(8,1,60000000.00,5,'280','',7,10,'Уфа','Советский','Ленина 43','object8.jpg'),(9,1,80000000.00,6,'450','',8,11,'Москва','Советский','Дружба 34','object9.jpg'),(10,1,72000000.00,6,'500','',9,12,'Москва','Новый Арбат','Ленинский проспект 145','object10.jpg'),(11,2,12000000.00,1,'123','',2,13,'Москва','Центральный','Школьная 23','object11.jpg'),(12,2,15000000.00,1,'143','',4,14,'Москва','Центральный','Ленинский проспект 14','object12.jpg'),(13,2,11000000.00,1,'110','',5,15,'Москва','Центральный','Проспект 67','object13.jpg'),(14,2,12500000.00,1,'100','',6,16,'Москва','Центральный','Ленина 5','object14.jpg'),(15,2,14000000.00,1,'80','',7,17,'Москва','Центральный','Дзержинского 87','object15.jpg'),(16,2,8000000.00,1,'90','',8,18,'Москва','Центральный','Советская 56','object16.jpg'),(17,2,9500000.00,1,'120','',9,19,'Москва','Центральный','Орджиникидзе 54','object17.jpg'),(18,2,54000000.00,1,'98','',7,20,'Москва','Мещанский','Кирова 45','object18.jpg'),(19,2,12000000.00,1,'76','',5,21,'Москва','Мещанский','Ленинский проспект 78','object19.jpg'),(20,2,6000000.00,1,'89','',4,22,'Москва','Мещанский','Проспект 12','object20.jpg'),(21,3,40000000.00,12,'500','200',2,23,'Москва','Мещанский','Ленина 78','object21.jpg'),(22,3,56000000.00,11,'600','300',2,24,'Москва','Мещанский','Дзержинского 90','object22.jpg'),(23,3,87000000.00,10,'700','400',2,25,'Москва','Новый Арбат','Советская 21','object23.jpg'),(24,3,32000000.00,13,'800','260',2,26,'Москва','Новый Арбат','Орджиникидзе 32','object24.jpg'),(25,3,89000000.00,12,'900','345',2,3,'Москва','Новый Арбат','Кирова 89','object25.jpg'),(26,3,76000000.00,9,'560','675',2,4,'Уфа','Демский','Новокузнецкая 123','object26.jpg'),(27,3,23000000.00,8,'657','345',2,5,'Уфа','Демский','Проспект 56','object27.jpg'),(28,3,78000000.00,15,'876','456',2,6,'Уфа','Демский','Николопесковский переулок 87','object28.jpg'),(29,3,98000000.00,9,'567','234',2,7,'Уфа','Демский','Головин переулок 5','object29.jpg'),(30,3,100000000.00,12,'468','256',2,8,'Уфа','Калининский','Петроверигский переулок 178','object30.jpg'),(31,4,3000000.00,0,'0','400',2,9,'Уфа','Калининский','Рихарда Зорге 89','object31.jpg'),(32,4,2000000.00,0,'0','500',2,10,'Уфа','Калининский','Кирова 25','object32.jpg'),(33,4,5000000.00,0,'0','678',2,11,'Уфа','Калининский','Ленина 76','object33.jpg'),(34,4,8000000.00,0,'0','789',2,12,'Уфа','Калининский','Дружба 33','object34.jpg'),(35,4,2000000.00,0,'0','987',2,13,'Уфа','Калининский','Орджиникидзе 145','object35.jpg'),(36,4,4500000.00,0,'0','987',2,14,'Уфа','Октябрьский','Кирова 83','object36.jpg'),(37,4,6500000.00,0,'0','678',2,15,'Уфа','Октябрьский','Ленинский проспект 34','object37.jpg'),(38,4,3200000.00,0,'0','657',2,16,'Уфа','Октябрьский','Проспект 65','object38.jpg'),(39,4,4000000.00,0,'0','568',2,17,'Уфа','Октябрьский','Ленина 25','object39.jpg'),(40,4,5000000.00,0,'0','678',2,18,'Уфа','Октябрьский','Дзержинского 126','object40.jpg');
/*!40000 ALTER TABLE `object` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `id_role` int NOT NULL,
  `name_role` varchar(50) NOT NULL,
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Администратор'),(2,'Риэлтор'),(3,'Собственник'),(4,'Покупатель');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `id_staff` int NOT NULL,
  `surname_staff` varchar(50) NOT NULL,
  `name_staff` varchar(50) NOT NULL,
  `patronymic_staff` varchar(50) NOT NULL,
  `phone_staff` decimal(19,0) unsigned NOT NULL,
  `password_staf` varchar(50) NOT NULL,
  `requisites_staff` varchar(50) NOT NULL,
  `email_staff` varchar(50) NOT NULL,
  `role_staff` int NOT NULL,
  PRIMARY KEY (`id_staff`),
  KEY `role_idx` (`role_staff`),
  CONSTRAINT `rolestaff` FOREIGN KEY (`role_staff`) REFERENCES `role` (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Шакирова','Эвелина','Рустамовна',89234567893,'ShakirovaStaff','7865943284','shakirova@gmail.com',1),(2,'Иванов','Степан','Даниилович',79870194136,'kUO0n','9498677016','stepan@gmail.com',1),(3,'Романова','Дарина','Николаевна',79876820321,'2XQnK','4345512268','darina@gmail.com',2),(4,'Баженова','Ксения','Саввична',79873528264,'ZCL0e','8656046595','ksenia@gmail.com',2),(5,'Щербакова','Алисия','Евгеньевна',79878513960,'x7vpK','9202748698','alisia@gmail.com',2),(6,'Артамонов','Иван','Максимович',79877049415,'QWF0u','1801225493','ivan@gmail.com',2),(7,'Мельников','Данил','Филиппович',79870804127,'NPVm5','2897202422','danil@gmail.com',2),(8,'Давыдова','Маргарита','Матвеевна',79877030677,'i7QmT','9879040617','margarita@gmail.com',2),(9,'Герасимов','Лев','Даниэльевич',79872982593,'E8Kjx','3558716214','lev@gmail.com',2),(10,'Смирнов','Макар','Даниилович',79870834085,'9EzKR','8350632577','makar@gmail.com',2),(11,'Скворцов','Георгий','Маркович',79877648823,'a7McY','2573992816','georgiy@gmail.com',2),(12,'Рожкова','Полина','Максимовна',79872669344,'wLeM5','5564404397','polina@gmail.com',2),(13,'Иванова','Анастасия','Ивановна',79876800126,'kPv2G','3000982929','anastasia@gmail.com',2),(14,'Соловьев','Артём','Михайлович',79877860808,'2wSN6','9462126978','artem@gmail.com',2),(15,'Лебедева','Арина','Львовна',79870465057,'db1IM','5619863875','arina@gmail.com',2),(16,'Агеева','Алина','Фёдоровна',79872769028,'4P4bW','4330756354','alina@gmail.com',2),(17,'Емельянов','Максим','Олегович',79870972144,'yW272','8812943875','maksim@gmail.com',2),(18,'Елисеева','Алёна','Степановна',79872090077,'c5P6l','1771516120','alena@gmail.com',2),(19,'Матвеев','Иван','Даниилович',79872363940,'m0F7L','4362464176','ivan@gmail.com',2),(20,'Антипова','Виктория','Глебовна',79871612999,'lB6v1','4337658956','victoria@gmail.com',2);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typecontract`
--

DROP TABLE IF EXISTS `typecontract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `typecontract` (
  `id_typeContract` int NOT NULL,
  `name_typeContract` varchar(50) NOT NULL,
  PRIMARY KEY (`id_typeContract`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typecontract`
--

LOCK TABLES `typecontract` WRITE;
/*!40000 ALTER TABLE `typecontract` DISABLE KEYS */;
INSERT INTO `typecontract` VALUES (1,'Договор купли'),(2,'Договор продажи');
/*!40000 ALTER TABLE `typecontract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typeobject`
--

DROP TABLE IF EXISTS `typeobject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `typeobject` (
  `id_typeObject` int NOT NULL,
  `name_typeObject` varchar(50) NOT NULL,
  PRIMARY KEY (`id_typeObject`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typeobject`
--

LOCK TABLES `typeobject` WRITE;
/*!40000 ALTER TABLE `typeobject` DISABLE KEYS */;
INSERT INTO `typeobject` VALUES (1,'Квартира'),(2,'Комната'),(3,'Дом'),(4,'Участок');
/*!40000 ALTER TABLE `typeobject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'greenhills'
--

--
-- Dumping routines for database 'greenhills'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-08 17:44:38
