CREATE DATABASE  IF NOT EXISTS `healthcenter` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `healthcenter`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: healthcenter
-- ------------------------------------------------------
-- Server version	5.5.46

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
-- Table structure for table `checkup`
--

DROP TABLE IF EXISTS `checkup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checkup` (
  `CheckupID` int(11) NOT NULL AUTO_INCREMENT,
  `PatientID` int(11) NOT NULL,
  `Complaint` varchar(255) DEFAULT NULL,
  `Treatment` varchar(255) DEFAULT NULL,
  `DateOfCheckUp` date DEFAULT NULL,
  `CheckUpType` varchar(45) DEFAULT NULL,
  `Weight` int(11) DEFAULT NULL,
  `Height` varchar(45) DEFAULT NULL,
  `BloodPressure` varchar(45) DEFAULT NULL,
  `Medication` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CheckupID`),
  KEY `fk_CheckUp_Client1_idx` (`PatientID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkup`
--

LOCK TABLES `checkup` WRITE;
/*!40000 ALTER TABLE `checkup` DISABLE KEYS */;
INSERT INTO `checkup` VALUES (1,2,'asdasd','12312awlsdfasdflksjdfjaioejfiasjdfkljasdlkfjaklsdf\nasdfasdlfkjasdf\nasdofjaslkdfjad\nfasokdjflaskjdf\n','2015-12-03','a',12323,'12321','232',NULL),(2,1,'a','awdaw1232as','2015-12-03','123',123,'323123','1231',NULL),(3,3,'potangina','asdasd24sds','2015-12-03',NULL,49,'6','60/120',NULL),(4,3,'wtfasd','wtffkyo','2015-12-03',NULL,123,'123','23',NULL),(5,3,'wtfqka','wtfa','2015-12-03',NULL,12,'232','23',NULL),(6,5,'askljdkaljdio','awidjlaskjd123as','2015-12-03',NULL,50,'5','70/120',NULL),(7,6,'moon','mooonsdasd','2015-12-19','potagina',50,'40','20',NULL),(8,6,'wtf','wtf','2015-12-04','',123123,'123','zsd',NULL),(9,6,'rakinrol','awdasdawd','2015-12-04','',123,'412','2',NULL),(10,1,'asda','dasdasda','2015-12-04','',2,'2','asd',NULL),(11,1,'awdad','asdwasd','2015-12-04','',12112,'12','12',NULL),(12,1,'wtfw','wtf13321','2015-12-15','',121,'23','asdw',NULL),(13,1,'asd','sdasd','2015-12-04','',12,'23','123',NULL),(14,1,'asasdf','fasdf','2015-12-04','',12,'121231233','123',NULL),(15,6,'asdfasdf','dfasdw','2015-12-04','',123,'231','123',NULL),(16,1,'fkyou','asfasdf','2015-12-04','',12,'123','123',NULL),(17,6,'yow','yowasdasd asd','2015-12-05','PRENATAL',50,'152','50/120',NULL),(18,6,'asdfas','fasdf','2015-12-05','GENERAL',12,'123','12/123',NULL),(19,19,'fwtwfwf','fwtwfwfwfw','2015-12-06','MEDICAL',50,'150','60/120','Paracetamol, box'),(20,1,'asdas','dasdasdsd','2015-12-06','MEDICAL',123,'23','23/23','Paracetamol, tablet'),(21,1,'asdas','dasdasdsd','2015-12-06','MEDICAL',123,'23','23/23','Paracetamol, tablet'),(22,1,'asdas','dasdasdsd','2015-12-06','MEDICAL',123,'23','23/23','Paracetamol, tablet'),(23,1,'dasdasd','dasd','2015-12-06','MEDICAL',231,'123','123/123','Paracetamol, tablet'),(24,1,'pota','pota','2015-12-11','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(25,1,'asdaw','dasdawd','2015-12-11','GENERAL',12,'12','12/12','Paracetamol, tablet'),(26,1,'asdaw','dasdawd','2015-12-11','GENERAL',12,'12','12/12','Paracetamol, tablet'),(27,1,'asdaw','dasdawd','2015-12-11','GENERAL',12,'12','12/12','Paracetamol, tablet'),(28,1,'poat','asdpakyo','2015-12-11','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(29,1,'as','sadf','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(30,1,'ASDF','SDFASDF','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(31,1,'ASDF','SDFASDF','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(32,1,'ASDF','SDFASDF','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(33,1,'QQQQ','ASDASDFASDF','2015-12-11','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(34,1,'awdasdwas','dawdsawd123','2015-12-14','GENERAL',12,'121','12/12','Paracetamol, tablet'),(35,41,'test','test','2015-12-14','MEDICAL',123,'123','121/12','none'),(36,41,'sakit ulo','tulog lang','2015-12-14','MEDICAL',50,'160','60/120','Paracetamol, tablet'),(37,1,'asdfawas','asdfwasd','2016-01-06','GENERAL',12,'12','321/12','Paracetamol, tablet'),(38,1,'asdfawas','asdfwasd','2016-01-06','GENERAL',12,'12','321/12','Paracetamol, tablet'),(39,1,'asdfawasSD','asdfwasd','2016-01-06','GENERAL',12,'12','321/12','paracetamol, tablet'),(40,1,'asdfawasSD','asdfwasd','2016-01-06','GENERAL',12,'12','12/12','paracetamol, tablet'),(41,1,'asdfawasSD','asdfwasd','2016-01-06','GENERAL',12,'12','12/12','paracetamol, tablet'),(42,1,'asdf','asdfasdf','2016-01-06','PRENATAL',12,'12','12/12','Paracetamol, tablet'),(43,1,'safdasd','asdfasdf','2016-01-06','GENERAL',12,'121','2/12','Paracetamol, tablet'),(44,3,'adfasdfas','asdfasdfasdfasdf','2016-01-06','GENERAL',12,'12','12/12','Paracetamol, tablet'),(45,1,'asdfas','dfasdfasdf','2016-01-06','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(46,1,'asdfas','dfasdfasdf','2016-01-06','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(47,1,'sdf','asdfasdf','2016-01-06','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(48,1,'asdfasdfasdf','sdfasdfasdf','2016-01-06','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(49,1,'asdfasdfasdf','sdfasdfasdfasdfasdasd','2016-01-06','MEDICAL',12,'212','121/12','Paracetamol, tablet'),(50,1,'sakit sa ulo','paracetamol','2016-01-07','MEDICAL',50,'56','50/160','Paracetamol, tablet'),(51,3,'asdfjasiodfjaspiodjfaiosdfipoajsdipfojasidojfioio\nasdfasdfasdlkfjiojwfioaosdfa\nsdfajsdiofioawjfiojasdfiasjdfioj2309812093890dasd asdf\nasdfjasdjfasdjfaalsdpaspdop sfjasdjfasdf','lkjadfjasdfjaoisdufiaosdf\n1873891728397219837987238dsfasdfa\nsdfalksdjfklajsdlfkjasldfas\ndfaksdjflkasdjflasd\nfasdfjalksdjfklasjdfkljaiowuioawjdasdw','2016-01-07','MEDICAL',121,'12','12/12','Paracetamol, tablet'),(52,3,'asdfjasiodfjaspiodjfaiosdfipoajsdipfojasidojfioio\nasdfasdfasdlkfjiojwfioaosdfa\nsdfajsdiofioawjfiojasdfiasjdfioj2309812093890dasd asdf\nasdfjasdjfasdjfaalsdpaspdop sfjasdjfasdf','lkjadfjasdfjaoisdufiaosdf\n1873891728397219837987238dsfasdfa\nsdfalksdjfklajsdlfkjasldfas\ndfaksdjflkasdjflasd\nfasdfjalksdjfklasjdfkljaiowuioawjdasdw','2016-01-07','MEDICAL',121,'12','12/12','Paracetamol, tablet'),(53,3,'asdfjasiodfjaspiodjfaiosdfipoajsdipfojasidojfioio\nasdfasdfasdlkfjiojwfioaosdfa\nsdfajsdiofioawjfiojasdfiasjdfioj2309812093890dasd asdf\nasdfjasdjfasdjfaalsdpaspdop sfjasdjfasdf','lkjadfjasdfjaoisdufiaosdf\n1873891728397219837987238dsfasdfa\nsdfalksdjfklajsdlfkjasldfas\ndfaksdjflkasdjflasd\nfasdfjalksdjfklasjdfkljaiowuioawjdasdw','2016-01-07','MEDICAL',121,'12','12/12','Paracetamol, tablet'),(54,3,'asdfjasiodfjaspiodjfaiosdfipoajsdipfojasidojfioio\nasdfasdfasdlkfjiojwfioaosdfa\nsdfajsdiofioawjfiojasdfiasjdfioj2309812093890dasd asdf\nasdfjasdjfasdjfaalsdpaspdop sfjasdjfasdf','lkjadfjasdfjaoisdufiaosdf\n1873891728397219837987238dsfasdfa\nsdfalksdjfklajsdlfkjasldfas\ndfaksdjflkasdjflasd\nfasdfjalksdjfklasjdfkljaiowuioawjdasdw','2016-01-07','MEDICAL',121,'12','12/12','Paracetamol, tablet'),(55,3,'asdfjasiodfjaspiodjfaiosdfipoajsdipfojasidojfioio\nasdfasdfasdlkfjiojwfioaosdfa\nsdfajsdiofioawjfiojasdfiasjdfioj2309812093890dasd asdf\nasdfjasdjfasdjfaalsdpaspdop sfjasdjfasdf','lkjadfjasdfjaoisdufiaosdf\n1873891728397219837987238dsfasdfa\nsdfalksdjfklajsdlfkjasldfas\ndfaksdjflkasdjflasd\nfasdfjalksdjfklasjdfkljaiowuioawjdasdw','2016-01-07','MEDICAL',121,'12','12/12','Paracetamol, tablet'),(56,43,'asdfasdf','adfasdfasdf','2016-01-22','MEDICAL',12,'32','12/12','Paracetamol, tablet');
/*!40000 ALTER TABLE `checkup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `PatientID` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) DEFAULT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Birthdate` date DEFAULT NULL,
  `Gender` varchar(45) DEFAULT NULL,
  `LotNumber` int(11) DEFAULT NULL,
  `Street` varchar(45) DEFAULT NULL,
  `City` varchar(45) DEFAULT NULL,
  `BarangayName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Levi','dasd','asdas','2015-12-03','Male',231,'123','123123a','asda'),(2,'Levi','asdas','asdqda','2015-12-04','Male',21312,'12312','213','asdas'),(3,'johneilcarl','balboa','tagudin','2015-12-18','Male',1,'lanzones','davaocity','mintal'),(4,'levi','balboa','tagudin','2015-12-30','Male',123,'joasd','ijwdsj','basdw'),(5,'mar','mar','rosaroso','2015-12-25','Female',1,'juan luna','davao city','12-b'),(6,'juan','luna','moon','2015-12-18','Male',1,'','',''),(7,'awdasd','asdawd','asdaw','2015-12-04','Male',1,'as','aw','aw'),(8,'awds','daw','saw','2015-12-04','',1,'','',''),(9,'','','','2015-12-04','',12,'dada','',''),(10,'awddasd','sda','dasdw','2015-12-04','',12,'','',''),(11,'awds','12','awds','2015-12-04','',12,'wdsa','waw','awd'),(12,'asdasd','asdwa','daw','2015-12-04','Female',12,'awd','dawd','s'),(13,'FDFASDFASDF','ADA','sdfasdfasd','2015-12-04','',123123,'fasdfas','asfasdfadf','asdfa'),(14,'aa','asdfasdf','asdf','2015-12-04','',1123,'sadfasdfasdf','asdfasdfadsf','asdfasdfads'),(15,'asd','asdfa','fasdf','2015-12-04','',12323,'asd','asdf','asdw'),(16,'asdfa','sdfasd','fasdf','2015-12-05','Male',123,'fasdfasd','sadfasa','asdfasdf'),(17,'sdfsadf','awda','dawd','2015-12-05','Male',123,'asasd','fasdf','awdasd'),(18,'sdfasdfad','asdfasd','sdf','2015-12-05','Male',123123,'asd','asdfasd','sdf'),(19,'wtf','wtf','wtf','2015-12-05','Male',1232,'wtf','wtf','wtf'),(20,'johneilcarl ','balboa','tagudin','1996-10-31','Male',12,'small village','davao','mintal'),(21,'sadfafd','asdfasdf','asdfasdf','2015-12-05','Female',123,'asdawasd','wdas','wa'),(22,'asdfas','fasdf','asdfasdf','2015-12-05','Female',123,'asda','dasd','w'),(23,'asd','awd','asd','2015-12-05','Male',12,'asd','wa','wa'),(24,'sdf','sdfasd','asdf','2015-12-05','Male',12,'asda','awdaw','aw'),(25,'asdaf','sdfasdfsd','fasdf','2015-12-05','Male',12,'asd','dasd','asd'),(26,'asdf','dfasfa','dfasdf','2015-12-05','Male',12,'asd','awd','asd'),(27,'asdadsd','sdasd','asdasd','2015-12-05','Female',12,'asd','asdw','waw'),(28,'asdas','asdasdasd','asdasda','2015-12-05','Female',1212,'asdasd','asdasd','asd'),(29,'asdfa','fasdf','sdfasdfas','2015-12-05','Male',12,'asda','dasas','dsd'),(30,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(31,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(32,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(33,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(34,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(35,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(36,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(37,'asdfa','dfadf','asdfadsf','2015-12-05','Male',12,'asdfa','fas','asdf'),(38,'asdfa','dfadf','asdfadsf','2015-12-05','Male',12,'asdfa','fas','asdf'),(39,'ASD','ASDFA','FASDFASDF','2015-12-05','Male',12,'ASD','AWD','ASDW'),(40,'asdfasdfasdf','sdfasdfasdf','adfasdf','2015-12-05','Female',1212,'sdasdf','fasdfad','sdf'),(41,'test','test','test','2015-12-14','Male',1,'test','test','test'),(42,'fuck','fuck','fuck','2015-10-31','Male',123,'asdawd','asdawd','123asdsASD'),(43,'alchie','balboa','tagudin','2016-01-22','Male',123,'small village','davao city','asdfasdf');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disposemedical_supplies`
--

DROP TABLE IF EXISTS `disposemedical_supplies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `disposemedical_supplies` (
  `idDisposeMedical` int(11) NOT NULL AUTO_INCREMENT,
  `date_of_dispose` date DEFAULT NULL,
  `medicineName` varchar(45) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  PRIMARY KEY (`idDisposeMedical`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disposemedical_supplies`
--

LOCK TABLES `disposemedical_supplies` WRITE;
/*!40000 ALTER TABLE `disposemedical_supplies` DISABLE KEYS */;
/*!40000 ALTER TABLE `disposemedical_supplies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `issuance`
--

DROP TABLE IF EXISTS `issuance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `issuance` (
  `IssuanceID` int(11) NOT NULL AUTO_INCREMENT,
  `DateOfIssuance` date DEFAULT NULL,
  PRIMARY KEY (`IssuanceID`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `issuance`
--

LOCK TABLES `issuance` WRITE;
/*!40000 ALTER TABLE `issuance` DISABLE KEYS */;
INSERT INTO `issuance` VALUES (1,'2015-12-30'),(2,'2015-12-30'),(3,'2015-12-30'),(4,'2015-12-30'),(5,'2015-12-30'),(6,'2015-12-30'),(7,'2015-12-30'),(8,'2015-12-30'),(9,'2015-12-30'),(10,'2015-12-30'),(11,'2015-12-30'),(12,'2015-12-30'),(13,'2015-12-30'),(14,'2016-01-03'),(15,'2016-01-03'),(16,'2016-01-03'),(17,'2016-01-03'),(18,'2016-01-03'),(19,'2016-01-03'),(20,'2016-01-03'),(21,'2016-01-03'),(22,'2016-01-03'),(23,'2016-01-03'),(24,'2016-01-03'),(25,'2016-01-03'),(26,'2016-01-03'),(27,'2016-01-03'),(28,'2016-01-03'),(29,'2016-01-03'),(30,'2016-01-03'),(31,'2016-01-03'),(32,'2016-01-03'),(33,'2016-01-03'),(34,'2016-01-03'),(35,'2016-01-03'),(36,'2016-01-03'),(37,'2016-01-03'),(38,'2016-01-03'),(39,'2016-01-03'),(40,'2016-01-03'),(41,'2016-01-03'),(42,'2016-01-03'),(43,'2016-01-03'),(44,'2016-01-30'),(45,'2016-01-03'),(46,'2016-01-03'),(47,'2016-01-03'),(48,'2016-01-03'),(49,'2016-01-03'),(50,'2016-01-03'),(51,'2016-01-03'),(52,'2016-01-03'),(53,'2016-01-04'),(54,'2016-01-04'),(55,'2016-01-05'),(56,'2016-01-05'),(57,'2016-01-05'),(58,'2016-01-05'),(59,'2016-01-05'),(60,'2016-01-05'),(61,'2016-01-05'),(62,'2016-01-05'),(63,'2016-01-05'),(64,'2016-01-05'),(65,'2016-01-05'),(66,'2016-01-05'),(67,'2016-01-05'),(68,'2016-01-05'),(69,'2016-01-05'),(70,'2016-01-05'),(71,'2016-01-05'),(72,'2016-01-05'),(73,'2016-01-05'),(74,'2016-01-05'),(75,'2016-01-05'),(76,'2016-01-05'),(77,'2016-01-05'),(78,'2016-01-06'),(79,'2016-01-14'),(80,'2016-01-14'),(81,'2016-01-14'),(82,'2016-01-14'),(83,'2016-01-14'),(84,'2016-01-14'),(85,'2016-01-14'),(86,'2016-01-14'),(87,'2016-01-14'),(88,'2016-01-14'),(89,'2016-01-14'),(90,'2016-01-14'),(91,'2016-01-14'),(92,'2016-01-14'),(93,'2016-01-14'),(94,'2016-01-14'),(95,'2016-01-14'),(96,'2016-01-14'),(97,'2016-01-14'),(98,'2016-01-14'),(99,'2016-01-14'),(100,'2016-01-14'),(101,'2016-01-14'),(102,'2016-01-14'),(103,'2016-01-14'),(104,'2016-01-14'),(105,'2016-01-14'),(106,'2016-01-14'),(107,'2016-01-14'),(108,'2016-01-14'),(109,'2016-01-14'),(110,'2016-01-17');
/*!40000 ALTER TABLE `issuance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `issuance_line`
--

DROP TABLE IF EXISTS `issuance_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `issuance_line` (
  `SupplyID` int(11) DEFAULT NULL,
  `IssuanceID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `issuance_line`
--

LOCK TABLES `issuance_line` WRITE;
/*!40000 ALTER TABLE `issuance_line` DISABLE KEYS */;
INSERT INTO `issuance_line` VALUES (1,NULL,3,NULL),(3,NULL,3,NULL),(4,NULL,3,NULL),(5,NULL,3,NULL),(5,NULL,1,NULL),(5,NULL,1,NULL),(3,NULL,9,NULL),(1,NULL,4,NULL),(5,18,5,NULL),(10,19,5,NULL),(15,20,5,NULL),(5,22,3,NULL),(1,23,8,NULL),(5,24,8,NULL),(5,25,9,NULL),(6,26,9,NULL),(1,27,9,NULL),(10,28,9,NULL),(15,29,9,NULL),(10,30,9,NULL),(9,31,9,NULL),(9,32,9,NULL),(9,33,9,NULL),(10,34,9,NULL),(9,35,9,NULL),(9,36,9,NULL),(6,39,3,NULL),(14,41,5,NULL),(1,42,8,NULL),(1,43,4,NULL),(1,47,6,'2016-03-12'),(1,48,8,'2051-03-17'),(1,49,9,'2016-01-03'),(1,50,9,'2016-01-03'),(1,51,2,'2016-01-03'),(14,52,8,'2016-01-03'),(1,53,9,'2016-01-04'),(1,54,1,'2016-01-04'),(1,62,11,'2016-01-05'),(6,63,10,'2016-01-05'),(6,64,1,'2016-01-05'),(1,65,1376,'2016-01-05'),(2,66,12,'2016-01-05'),(7,67,10,'2016-01-05'),(7,68,9,'2016-01-05'),(1,69,1376,'2016-01-05'),(1,70,1376,'2016-01-05'),(6,71,10,'2016-01-05'),(6,72,1,'2016-01-05'),(17,73,20,'2016-01-05'),(7,75,10,'2016-01-05'),(17,76,20,'2016-01-05'),(16,77,50,'2016-01-05'),(1,78,100,'2016-01-06'),(1,79,1380,'2016-01-14'),(1,80,4,'2016-01-14'),(1,81,3,'2016-01-14'),(1,82,5,'2016-01-14'),(2,83,2,'2016-01-14'),(6,84,2,'2016-01-14'),(6,85,2,'2016-01-14'),(2,86,3,'2016-01-14'),(1,87,1,'2016-01-14'),(2,88,5,'2016-01-14'),(6,89,1,'2016-01-14'),(1,90,10,'2016-01-14'),(1,91,10,'2016-01-14'),(6,92,3,'2016-01-14'),(10,93,3,'2016-01-14'),(1,94,6,'2016-01-14'),(7,95,4,'2016-01-14'),(7,96,10,'2016-01-14'),(17,97,17,'2016-01-14'),(17,98,3,'2016-01-14'),(17,99,6,'2016-01-14'),(17,100,4,'2016-01-14'),(1,101,120,'2016-01-14'),(1,102,10,'2016-01-14'),(2,103,20,'2016-01-14'),(1,104,10,'2016-01-14'),(1,105,10,'2016-01-14'),(2,106,4,'2016-01-14'),(2,107,6,'2016-01-14'),(6,108,3,'2016-01-14'),(6,109,10,'2016-01-14'),(15,110,10,'2016-01-17');
/*!40000 ALTER TABLE `issuance_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medical_staff`
--

DROP TABLE IF EXISTS `medical_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medical_staff` (
  `StaffID` int(11) NOT NULL AUTO_INCREMENT,
  `StaffType` varchar(100) DEFAULT NULL,
  `fullName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`StaffID`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medical_staff`
--

LOCK TABLES `medical_staff` WRITE;
/*!40000 ALTER TABLE `medical_staff` DISABLE KEYS */;
INSERT INTO `medical_staff` VALUES (1,'doctor',NULL),(2,'nurse',NULL),(3,'midwife',NULL),(4,NULL,'wtf'),(5,NULL,'johneil carl tagudin'),(6,NULL,'johneil carl tagudin'),(7,NULL,''),(8,NULL,'kajskldjaskldjaiojwid'),(9,NULL,''),(10,NULL,''),(11,NULL,''),(12,NULL,'asdfasdfawdawddw'),(13,NULL,''),(14,NULL,''),(15,NULL,''),(16,NULL,''),(17,NULL,''),(18,NULL,''),(19,NULL,'asdfasdfasdfsafafasfsdfasdf'),(20,NULL,'sdfasdfasdf'),(21,NULL,''),(22,NULL,''),(23,NULL,'asdfasdfasdfasdf'),(24,NULL,''),(25,NULL,''),(26,NULL,''),(27,NULL,''),(28,NULL,''),(29,NULL,''),(30,NULL,''),(31,NULL,''),(32,NULL,'12'),(33,NULL,'12'),(34,NULL,'12'),(35,NULL,''),(36,NULL,'Tagudin, Johneil Carl Balboa'),(37,NULL,''),(38,NULL,''),(39,NULL,''),(40,NULL,''),(41,NULL,''),(42,NULL,''),(43,NULL,''),(44,NULL,''),(45,NULL,'Tagudin, Joheil Carl'),(46,NULL,'johneiclarl'),(47,NULL,'johneiclarl'),(48,NULL,'asdfasdf'),(49,NULL,'kjaslkdjfaksdjfklajsdf'),(50,NULL,'tonight'),(51,NULL,'testing'),(52,NULL,'testing'),(53,NULL,'testing'),(54,NULL,'testing'),(55,NULL,'testing'),(56,NULL,'testing'),(57,NULL,'testtest'),(58,NULL,'testtest'),(59,NULL,'testtest');
/*!40000 ALTER TABLE `medical_staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medical_supplies_inventory`
--

DROP TABLE IF EXISTS `medical_supplies_inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medical_supplies_inventory` (
  `SupplyID` int(11) NOT NULL AUTO_INCREMENT,
  `idMedicineName` int(11) NOT NULL,
  `totalQuantity` int(11) DEFAULT '0',
  PRIMARY KEY (`SupplyID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medical_supplies_inventory`
--

LOCK TABLES `medical_supplies_inventory` WRITE;
/*!40000 ALTER TABLE `medical_supplies_inventory` DISABLE KEYS */;
INSERT INTO `medical_supplies_inventory` VALUES (1,100,87),(2,101,0),(3,102,50),(4,103,50),(5,104,80),(6,7758,77),(7,112415,-14),(8,112415,10),(9,312314,10),(10,110,7),(11,110,10),(12,321,10),(13,887,10),(14,8871,10),(15,44771008,0),(16,911,0),(17,119,0);
/*!40000 ALTER TABLE `medical_supplies_inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicine_name`
--

DROP TABLE IF EXISTS `medicine_name`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medicine_name` (
  `idMedicineName` int(11) DEFAULT NULL,
  `MedicineName` varchar(45) DEFAULT NULL,
  `UnitType` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicine_name`
--

LOCK TABLES `medicine_name` WRITE;
/*!40000 ALTER TABLE `medicine_name` DISABLE KEYS */;
INSERT INTO `medicine_name` VALUES (1,'Paracetamol','tablet'),(2,'Paracetamol','box'),(3,'Medicol','tablet'),(4,'bayojisik','capsule'),(5,'tambal','makaayo'),(100,'bullshit','tangina'),(101,'asdfasdf','asdfaw'),(7758,'tambal na makaayo','yeah'),(112415,'tambal na makaayo','yeah'),(112415,'bisagunsa','12323'),(110,'asdsadf','asdf'),(321,'asdsadf','asdf'),(887,'asdsadf','asdf'),(8871,'asdw','asdfdasdw'),(44771008,'wwddasw','aaswd1'),(911,'medicol','capsule'),(119,'paracetamol','tablet');
/*!40000 ALTER TABLE `medicine_name` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mother's_class`
--

DROP TABLE IF EXISTS `mother's_class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mother's_class` (
  `OrientationID` int(11) NOT NULL,
  `OrientationDate` date DEFAULT NULL,
  `OrientationTime` int(11) DEFAULT NULL,
  `MedicalSupply` int(11) NOT NULL,
  PRIMARY KEY (`OrientationID`),
  KEY `fk_Mother's_CLass_Issuance1_idx` (`MedicalSupply`),
  CONSTRAINT `fk_Mother's_CLass_Issuance1` FOREIGN KEY (`MedicalSupply`) REFERENCES `issuance` (`IssuanceID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mother's_class`
--

LOCK TABLES `mother's_class` WRITE;
/*!40000 ALTER TABLE `mother's_class` DISABLE KEYS */;
/*!40000 ALTER TABLE `mother's_class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participants`
--

DROP TABLE IF EXISTS `participants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participants` (
  `PatientID` int(11) NOT NULL,
  `OrientationID` int(11) NOT NULL,
  KEY `fk_Participants_Client1_idx` (`PatientID`),
  KEY `fk_Participants_Mother's CLass2_idx` (`OrientationID`),
  CONSTRAINT `fk_Participants_Client1` FOREIGN KEY (`PatientID`) REFERENCES `client` (`PatientID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Participants_Mother's CLass2` FOREIGN KEY (`OrientationID`) REFERENCES `mother's_class` (`OrientationID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participants`
--

LOCK TABLES `participants` WRITE;
/*!40000 ALTER TABLE `participants` DISABLE KEYS */;
/*!40000 ALTER TABLE `participants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient_refferal`
--

DROP TABLE IF EXISTS `patient_refferal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient_refferal` (
  `RefferalDate` date DEFAULT NULL,
  `RefferalDescription` varchar(255) DEFAULT NULL,
  `checkupID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient_refferal`
--

LOCK TABLES `patient_refferal` WRITE;
/*!40000 ALTER TABLE `patient_refferal` DISABLE KEYS */;
INSERT INTO `patient_refferal` VALUES ('2015-12-11','aksjdwdasd',NULL),('2015-12-11','aksjdwdasd',NULL),('2015-12-11','asds',NULL),('2015-12-11','asdw',NULL),('2015-12-11','asdasdwdawd',NULL),('2015-12-11','asdasdwdawd',NULL),('2015-12-11','asd',NULL),('2015-12-11','ads',NULL),('2015-12-12','asdfaw',NULL),('2015-12-12','asdfawfasdfasdfasdfasdfasdf',NULL),('2015-12-12','asdfawfasdfasdfasdfasdfasdf',NULL),('2015-12-12','sadfasdfasdfasdf',NULL),('2016-02-19','askdfasjdfkjasd;klfjaklsdfasdfasdf',NULL),('2015-12-12','asdfasdfasdlkjfak;lsjdflkajsdklfjaklsdjfkasdfasdf12rfqfff1f1f1',NULL),('2015-12-12','asdfasdfasdf',NULL),('2015-12-12','asdfasdfasdfasdfadsf',NULL),('2015-12-12','asd',NULL),('2015-12-12','as',NULL),('2015-12-12','awda',NULL),('2015-12-12','asfouiwufuasdfuh\nasjdfasdhfuhsaduifhiauoiusodiu1oi2u3\niqwueoiqudoiuasioduiou1',NULL),('2015-12-12','sdfasdfsadfsadf',NULL),('2015-12-12','sdfasdfsadfsadfawda',NULL),('2015-12-12','sdfasdfsadfsadfawda123123',NULL),('2015-12-12','132123asdw',NULL),('2015-12-14','kailangan ko ng 1 kilo ng bigas!',NULL),('2016-01-06','',NULL),('2016-01-06','2134asdfasdf',NULL),('2016-01-06','asdfasd',48),('2016-01-06','',49),('2016-01-07','testtesttst',50),('2016-01-07','sdhfjasdhfjasdfhkajsdhfjkasdhfkjasdhfkjasdhfauisdyfuiawyduiawydiuaywduiawyduiawyduiawyduiyawduidyawuidyawdaiwudawdawdawdawdawdawdawdawdaadwdwaadwdadawdwaadwdawadwadwdawadwawdadwadwadwadwadwadwadw',55),('2016-01-22','',56);
/*!40000 ALTER TABLE `patient_refferal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescription`
--

DROP TABLE IF EXISTS `prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescription` (
  `PrescriptionDetails` varchar(255) DEFAULT NULL,
  `PrescriptionDate` date DEFAULT NULL,
  `checkupID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescription`
--

LOCK TABLES `prescription` WRITE;
/*!40000 ALTER TABLE `prescription` DISABLE KEYS */;
INSERT INTO `prescription` VALUES ('asasdfasdf',NULL,NULL),('jkldjaklsjdajwidjoiajsdw','2015-12-12',NULL),('l;sakdl;aksdopkwdopkasopdkpoakdpoawd','2015-12-12',NULL),('asdfasdfasdf','2015-12-12',NULL),(';lasdk;j0i981290389aslkdjasd1','2015-12-25',NULL),('','2015-12-23',NULL),('asdfasdfasdf','2015-12-12',NULL),('12','2015-12-12',NULL),('sdfasdfasdfasdfaw','2015-12-13',NULL),('tags','2015-12-14',NULL),('','2016-01-06',NULL),('asdw','2016-01-06',NULL),('asdw','2016-01-06',NULL),('asdw','2016-01-06',NULL),('asdwASDF','2016-01-06',NULL),('','2016-01-06',NULL),('','2016-01-06',NULL),('asdfasdfsawa','2016-01-06',NULL),('asdf','2016-01-06',48),('','2016-01-06',49),('testestest','2016-01-07',50),('','2016-01-07',52),('','2016-01-07',53),('','2016-01-07',54),('sdhfjasdhfjasdfhkajsdhfjkasdhfkjasdhfkjasdhfauisdyfuiawyduiawydiuaywduiawyduiawyduiawyduiyawduidyawuidyawdaiwudawdawdawdawdawdawdawdawdaadwdwaadwdadawdwaadwdawadwadwdawadwawdadwadwadwadwadwadwadw\n','2016-01-07',55),('','2016-01-22',56);
/*!40000 ALTER TABLE `prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiving_line`
--

DROP TABLE IF EXISTS `receiving_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiving_line` (
  `SupplyID` int(11) DEFAULT NULL,
  `idReceivingReport` int(11) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiving_line`
--

LOCK TABLES `receiving_line` WRITE;
/*!40000 ALTER TABLE `receiving_line` DISABLE KEYS */;
INSERT INTO `receiving_line` VALUES (1,NULL,'','2015-12-30'),(1,NULL,'','2016-02-29'),(1,NULL,'','2016-02-29'),(2,NULL,'','2016-02-29'),(1,NULL,'5','2015-12-30'),(1,NULL,'10','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'4','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'5','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'6','2015-12-30'),(5,NULL,'2','2015-12-30'),(2,NULL,'2','2015-12-30'),(4,NULL,'2','2015-12-30'),(5,NULL,'2','2015-12-30'),(3,NULL,'10','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'','2015-12-30'),(5,NULL,'10','2015-12-30'),(1,NULL,'6','2015-12-30'),(4,NULL,'6','2015-12-30'),(1,NULL,'123','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'13241324','2015-12-30'),(NULL,25,NULL,NULL),(1,26,'10','2016-01-03'),(1,27,'10','2016-01-03'),(5,28,'10','2016-01-03'),(NULL,28,NULL,NULL),(5,29,'10','2016-01-03'),(5,30,'12','2016-01-03'),(9,31,'32','2016-01-03'),(5,32,'2321','2016-05-20'),(1,33,'','2016-01-03'),(1,34,'1232','2016-01-03'),(9,35,'1232','2016-01-03'),(14,36,'1232','2016-01-03'),(14,37,'1232','2016-01-03'),(15,38,'1232','2016-01-03'),(7,39,'1232','2016-01-03'),(9,40,'12','2016-01-03'),(10,41,'12','2016-01-03'),(1,42,'23','2016-01-03'),(1,43,'11','2016-01-03'),(1,44,'10','2016-01-22'),(1,45,'10','2016-01-22'),(1,46,'10','2016-02-19'),(2,47,'10','2016-01-04'),(2,48,'10','2016-01-04'),(2,49,'10','2016-01-04'),(1,50,'10','2016-01-04'),(1,51,'3215454121324','2016-01-04'),(2,52,'104','2016-01-04'),(1,53,'11','2016-01-04'),(15,54,'11','2016-01-04'),(15,55,'12','2016-01-04'),(15,56,'1','2016-01-04'),(1,57,'1','2016-01-04'),(2,58,'1','2016-01-04'),(2,59,'11','2016-01-04'),(6,60,'10','2016-01-04'),(1,61,'123','2016-01-04'),(10,62,'123','2016-01-04'),(1,63,'','2016-01-04'),(1,64,'123','2016-01-04'),(15,65,'123','2016-01-04'),(16,66,'50','2016-01-04'),(17,67,'50','2016-01-27'),(10,68,'','2016-01-04'),(10,69,'10','2016-01-04'),(1,70,'121','2016-01-07'),(1,71,'','2016-01-22'),(1,72,'12','2016-01-24'),(1,73,'1','2016-01-23'),(1,74,'1','2016-01-22'),(1,75,'1','2016-01-21'),(1,76,'1','2016-01-20'),(1,77,'1','2016-01-19'),(1,78,'1','2016-01-18'),(1,79,'23','2016-01-31'),(1,80,'23','2016-02-01'),(1,81,'23','2016-02-02');
/*!40000 ALTER TABLE `receiving_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiving_report`
--

DROP TABLE IF EXISTS `receiving_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiving_report` (
  `idReceivingReport` int(11) NOT NULL AUTO_INCREMENT,
  `StaffID` int(11) DEFAULT NULL,
  `DateOfReceive` date DEFAULT NULL,
  PRIMARY KEY (`idReceivingReport`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiving_report`
--

LOCK TABLES `receiving_report` WRITE;
/*!40000 ALTER TABLE `receiving_report` DISABLE KEYS */;
INSERT INTO `receiving_report` VALUES (1,1,'2015-12-30'),(2,1,'2015-12-30'),(3,1,'2015-12-30'),(4,3,'2015-12-30'),(5,1,'2015-12-30'),(6,1,'2015-12-30'),(7,1,'2015-12-30'),(8,1,'2015-12-30'),(9,1,'2015-12-30'),(10,1,'2015-12-30'),(11,1,'2015-12-30'),(12,1,'2015-12-30'),(13,1,'2015-12-30'),(14,1,'2015-12-30'),(15,1,'2015-12-30'),(16,1,'2015-12-30'),(17,1,'2015-12-30'),(18,1,'2015-12-17'),(19,1,'2016-01-08'),(20,1,'2016-01-08'),(21,1,'2016-01-08'),(22,1,'2016-01-08'),(23,1,'2015-12-30'),(24,1,'2015-12-30'),(25,1,'2015-12-30'),(26,1,'2016-01-03'),(27,1,'2016-01-03'),(28,1,'2016-01-03'),(29,1,'2016-01-03'),(30,1,'2016-01-03'),(31,2,'2016-01-03'),(32,1,'2016-01-03'),(33,1,'2016-01-03'),(34,1,'2016-01-03'),(35,1,'2016-01-03'),(36,1,'2016-01-03'),(37,1,'2016-01-03'),(38,1,'2016-01-03'),(39,1,'2016-01-03'),(40,1,'2016-01-03'),(41,1,'2016-01-03'),(42,1,'2016-01-03'),(43,1,'2016-01-03'),(44,1,'2016-01-03'),(45,1,'2016-01-03'),(46,1,'2016-01-04'),(47,1,'2016-01-04'),(48,1,'2016-01-04'),(49,1,'2016-01-04'),(50,1,'2016-01-04'),(51,3,'2016-01-04'),(52,3,'2016-01-04'),(53,1,'2016-01-04'),(54,1,'2016-01-04'),(55,3,'2016-01-04'),(56,2,'2016-01-04'),(57,2,'2016-01-04'),(58,2,'2016-01-04'),(59,2,'2016-01-04'),(60,1,'2016-01-04'),(61,1,'2016-01-04'),(62,1,'2016-01-04'),(63,1,'2016-01-04'),(64,1,'2016-01-04'),(65,1,'2016-01-04'),(66,1,'2016-01-04'),(67,3,'2016-01-04'),(68,1,'2016-01-04'),(69,1,'2016-01-04'),(70,6,'2016-01-07'),(71,49,'2016-01-22'),(72,50,'2016-01-24'),(73,51,'2016-01-24'),(74,52,'2016-01-24'),(75,53,'2016-01-24'),(76,54,'2016-01-24'),(77,55,'2016-01-24'),(78,56,'2016-01-24'),(79,57,'2016-01-24'),(80,58,'2016-01-24'),(81,59,'2016-01-24');
/*!40000 ALTER TABLE `receiving_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requisition`
--

DROP TABLE IF EXISTS `requisition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requisition` (
  `idRequisition` int(11) NOT NULL AUTO_INCREMENT,
  `StaffID` int(11) DEFAULT NULL,
  `DateOfRequisition` date DEFAULT NULL,
  PRIMARY KEY (`idRequisition`)
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisition`
--

LOCK TABLES `requisition` WRITE;
/*!40000 ALTER TABLE `requisition` DISABLE KEYS */;
INSERT INTO `requisition` VALUES (10,1,'2015-12-30'),(11,2,'2015-12-30'),(12,3,'2015-12-30'),(13,3,'2015-12-30'),(14,1,'2015-12-30'),(15,1,'2015-12-30'),(16,1,'2015-12-30'),(17,1,'2015-12-30'),(18,1,'2015-12-30'),(19,1,'2015-12-30'),(20,1,'2015-12-30'),(21,1,'2015-12-30'),(22,1,'2015-12-30'),(23,1,'2016-01-03'),(24,1,'2016-01-27'),(25,1,'2016-01-27'),(26,3,'2016-01-27'),(27,1,'2016-01-03'),(28,1,'2016-01-03'),(29,1,'2016-01-03'),(30,1,'2016-01-03'),(31,1,'2016-01-03'),(32,2,'2016-01-03'),(33,1,'2016-01-03'),(34,1,'2016-01-03'),(35,1,'2016-01-03'),(36,1,'2016-01-03'),(37,1,'2016-01-03'),(38,1,'2016-01-03'),(39,1,'2016-01-03'),(40,1,'2016-01-03'),(41,1,'2016-01-03'),(42,1,'2016-01-03'),(43,1,'2016-01-03'),(44,3,'2016-01-03'),(45,1,'2016-01-03'),(46,1,'2016-01-03'),(47,1,'2016-01-03'),(48,1,'2016-01-03'),(49,1,'2016-01-03'),(50,1,'2016-01-03'),(51,1,'2016-01-03'),(52,1,'2016-01-03'),(53,3,'2016-01-03'),(54,2,'2016-01-03'),(55,2,'2016-01-03'),(56,2,'2016-01-03'),(57,3,'2016-01-03'),(58,1,'2016-01-03'),(59,1,'2016-01-03'),(60,1,'2016-01-03'),(61,1,'2016-01-03'),(62,1,'2016-01-03'),(63,1,'2016-01-03'),(64,1,'2016-01-03'),(65,3,'2016-01-03'),(66,3,'2016-01-03'),(67,3,'2016-01-03'),(68,3,'2016-01-03'),(69,1,'2016-01-03'),(70,3,'2016-01-03'),(71,1,'2016-01-03'),(72,1,'2016-01-03'),(73,1,'2016-01-03'),(74,1,'2016-01-03'),(75,1,'2016-01-03'),(76,1,'2016-01-29'),(77,1,'2016-01-02'),(78,1,'2016-01-02'),(79,1,'2016-01-03'),(80,1,'2016-01-03'),(81,4,'2016-01-06'),(82,5,'2016-01-07'),(83,7,'2016-01-07'),(84,8,'2016-01-07'),(85,9,'2016-01-07'),(86,10,'2016-01-07'),(87,11,'2016-01-07'),(88,12,'2016-01-07'),(89,13,'2016-01-07'),(90,14,'2016-01-07'),(91,15,'2016-01-08'),(92,16,'2016-01-08'),(93,17,'2016-01-08'),(94,18,'2016-01-08'),(95,19,'2016-01-08'),(96,20,'2016-01-08'),(97,21,'2016-01-08'),(98,22,'2016-01-08'),(99,23,'2016-01-08'),(100,24,'2016-01-09'),(101,25,'2016-01-09'),(102,26,'2016-01-09'),(103,27,'2016-01-09'),(104,28,'2016-01-09'),(105,29,'2016-01-09'),(106,30,'2016-01-09'),(107,31,'2016-01-09'),(108,32,'2016-01-09'),(109,33,'2016-01-09'),(110,34,'2016-01-09'),(111,35,'2016-01-09'),(112,36,'2016-01-09'),(113,37,'2016-01-09'),(114,38,'2016-01-09'),(115,39,'2016-01-09'),(116,40,'2016-01-09'),(117,41,'2016-01-09'),(118,42,'2016-01-09'),(119,43,'2016-01-09'),(120,44,'2016-01-09'),(121,45,'2016-01-09'),(122,46,'2016-01-09'),(123,47,'2016-01-09'),(124,48,'2016-01-09');
/*!40000 ALTER TABLE `requisition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requisition_line`
--

DROP TABLE IF EXISTS `requisition_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requisition_line` (
  `SupplyID` int(11) DEFAULT NULL,
  `Requisition_idRequisition` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `listMed` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisition_line`
--

LOCK TABLES `requisition_line` WRITE;
/*!40000 ALTER TABLE `requisition_line` DISABLE KEYS */;
INSERT INTO `requisition_line` VALUES (1,NULL,2,NULL),(3,NULL,5,NULL),(4,NULL,6,NULL),(4,NULL,6,NULL),(1,NULL,5,NULL),(1,NULL,12,NULL),(1,NULL,32,NULL),(1,NULL,31234,NULL),(NULL,22,NULL,NULL),(NULL,22,NULL,NULL),(2,23,10,NULL),(4,24,20,NULL),(1,25,30,NULL),(1,26,30,NULL),(5,29,1,NULL),(110,30,10,NULL),(7758,31,10,NULL),(1,32,113,NULL),(112415,33,447815198,NULL),(312314,34,121321,NULL),(100,35,11,NULL),(1,36,11,NULL),(1,37,11,NULL),(1,38,11,NULL),(1,39,12,NULL),(1,40,13,NULL),(1,41,14,NULL),(2,42,14,NULL),(4,43,15,NULL),(1,44,167,NULL),(14,45,7,NULL),(10,46,111,NULL),(14,47,10,NULL),(15,48,22,NULL),(9,49,33,NULL),(10,50,5,NULL),(9,51,22,NULL),(2,52,24,NULL),(7,53,24,NULL),(2,54,12,NULL),(5,55,1242,NULL),(5,56,12422323,NULL),(5,57,3232,NULL),(14,58,1121,NULL),(15,59,3,NULL),(15,60,37,NULL),(15,61,371,NULL),(15,62,3713,NULL),(15,63,3713,NULL),(15,64,37135,NULL),(10,65,371355,NULL),(10,66,371355,NULL),(6,67,371355,NULL),(2,68,371355,NULL),(5,69,1232,NULL),(5,70,143,NULL),(14,71,1232,NULL),(5,72,3213,NULL),(5,73,422,NULL),(5,75,123,NULL),(1,76,220,NULL),(1,78,10,NULL),(1,79,10,NULL),(1,81,12,NULL),(1,82,121,NULL),(1,83,10,''),(6,84,112,''),(1,85,12,'System.Windows.Forms.ListBox+SelectedObjectCollection'),(1,86,1212,'System.Windows.Forms.ListBox+SelectedObjectCollection'),(15,87,12,''),(17,88,12,'System.Windows.Forms.ListBox+ObjectCollection'),(1,89,12,'bullshit, tangina, 12'),(10,90,1212,'bullshit, tangina, 12'),(1,92,12,NULL),(1,93,10,NULL),(1,94,10,NULL),(6,95,12,NULL),(6,96,3,NULL),(1,98,12,NULL),(7,101,12,NULL),(1,103,12,NULL),(1,106,12,NULL),(16,110,12,'asdfasdf, asdfaw, 	12\nasdfasdf, asdfaw, 	3\nasdfasdf, asdfaw, 	4\nbullshit, tangina, 	1\nparacetamol, tablet, 	50\nmedicol, capsule, 	1\n'),(NULL,111,NULL,'bullshit, tangina, 	12\nbullshit, tangina, 	3\nbullshit, tangina, 	5\nparacetamol, tablet, 	6\nwwddasw, aaswd1, 	7\nasdsadf, asdf, 	1\n'),(NULL,112,NULL,''),(NULL,113,NULL,''),(NULL,114,NULL,''),(NULL,115,NULL,''),(NULL,116,NULL,'bullshit, tangina, 	 	 	12\nbullshit, tangina, 	 	 	1\nbullshit, tangina, 	 	 	3\nparacetamol, tablet, 	 	 	4\n'),(NULL,117,NULL,'bullshit, tangina, 	 	 	12\nbullshit, tangina, 	 	 	34\nbullshit, tangina, 	 	 	45\nbullshit, tangina, 	 	 	56\ntambal na makaayo, yeah, 	 	 	67\ntambal na makaayo, yeah, 	 	 	78\nbisagunsa, 12323, 	 	 	89\nparacetamol, tablet, 	 	 	12\n'),(NULL,118,NULL,''),(NULL,119,NULL,'bullshit, tangina, 	 	 	12\nbullshit, tangina, 	 	 	23\nbullshit, tangina, 	 	 	34\nbullshit, tangina, 	 	 	45\nbullshit, tangina, 	 	 	56\nparacetamol, tablet, 	 	 	34\nasdsadf, asdf, 	 	 	12\nasdsadf, asdf, 	 	 	45\n'),(NULL,120,NULL,''),(NULL,121,NULL,'bisagunsa, 12323, 	 	 	10\nasdsadf, asdf, 	 	 	10\nbullshit, tangina, 	 	 	10\n'),(NULL,122,NULL,'bullshit, tangina, 	 	 	12\n'),(NULL,123,NULL,''),(NULL,124,NULL,'bullshit, tangina, 	 	 	12\nbullshit, tangina, 	 	 	12\n');
/*!40000 ALTER TABLE `requisition_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'healthcenter'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-01-25  0:04:52
