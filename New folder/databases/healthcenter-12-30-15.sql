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
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkup`
--

LOCK TABLES `checkup` WRITE;
/*!40000 ALTER TABLE `checkup` DISABLE KEYS */;
INSERT INTO `checkup` VALUES (1,2,'asdasd','12312awlsdfasdflksjdfjaioejfiasjdfkljasdlkfjaklsdf\nasdfasdlfkjasdf\nasdofjaslkdfjad\nfasokdjflaskjdf\n','2015-12-03','a',12323,'12321','232',NULL),(2,1,'awda12pota','awdaw1232as','2015-12-03','123',123,'323123','1231',NULL),(3,3,'potangina','asdasd24sds','2015-12-03',NULL,49,'6','60/120',NULL),(4,3,'wtfasd','wtffkyo','2015-12-03',NULL,123,'123','23',NULL),(5,3,'wtfqka','wtfa','2015-12-03',NULL,12,'232','23',NULL),(6,5,'askljdkaljdio','awidjlaskjd123as','2015-12-03',NULL,50,'5','70/120',NULL),(7,6,'moon','mooonsdasd','2015-12-19','potagina',50,'40','20',NULL),(8,6,'wtf','wtf','2015-12-04','',123123,'123','zsd',NULL),(9,6,'rakinrol','awdasdawd','2015-12-04','',123,'412','2',NULL),(10,1,'asda','dasdasda','2015-12-04','',2,'2','asd',NULL),(11,1,'awdad','asdwasd','2015-12-04','',12112,'12','12',NULL),(12,1,'wtfw','wtf13321','2015-12-15','',121,'23','asdw',NULL),(13,1,'asd','sdasd','2015-12-04','',12,'23','123',NULL),(14,1,'asasdf','fasdf','2015-12-04','',12,'121231233','123',NULL),(15,6,'asdfasdf','dfasdw','2015-12-04','',123,'231','123',NULL),(16,1,'fkyou','asfasdf','2015-12-04','',12,'123','123',NULL),(17,6,'yow','yowasdasd asd','2015-12-05','PRENATAL',50,'152','50/120',NULL),(18,6,'asdfas','fasdf','2015-12-05','GENERAL',12,'123','12/123',NULL),(19,19,'fwtwfwf','fwtwfwfwfw','2015-12-06','MEDICAL',50,'150','60/120','Paracetamol, box'),(20,1,'asdas','dasdasdsd','2015-12-06','MEDICAL',123,'23','23/23','Paracetamol, tablet'),(21,1,'asdas','dasdasdsd','2015-12-06','MEDICAL',123,'23','23/23','Paracetamol, tablet'),(22,1,'asdas','dasdasdsd','2015-12-06','MEDICAL',123,'23','23/23','Paracetamol, tablet'),(23,1,'dasdasd','dasd','2015-12-06','MEDICAL',231,'123','123/123','Paracetamol, tablet'),(24,1,'pota','pota','2015-12-11','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(25,1,'asdaw','dasdawd','2015-12-11','GENERAL',12,'12','12/12','Paracetamol, tablet'),(26,1,'asdaw','dasdawd','2015-12-11','GENERAL',12,'12','12/12','Paracetamol, tablet'),(27,1,'asdaw','dasdawd','2015-12-11','GENERAL',12,'12','12/12','Paracetamol, tablet'),(28,1,'poat','asdpakyo','2015-12-11','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(29,1,'as','sadf','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(30,1,'ASDF','SDFASDF','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(31,1,'ASDF','SDFASDF','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(32,1,'ASDF','SDFASDF','2015-12-11','GENERAL',12,'12','121/12','Paracetamol, tablet'),(33,1,'QQQQ','ASDASDFASDF','2015-12-11','MEDICAL',12,'12','12/12','Paracetamol, tablet'),(34,1,'awdasdwas','dawdsawd123','2015-12-14','GENERAL',12,'121','12/12','Paracetamol, tablet'),(35,41,'test','test','2015-12-14','MEDICAL',123,'123','121/12','none'),(36,41,'sakit ulo','tulog lang','2015-12-14','MEDICAL',50,'160','60/120','Paracetamol, tablet');
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
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Levi','dasd','asdas','2015-12-03','Male',231,'123','123123a','asda'),(2,'Levi','asdas','asdqda','2015-12-04','Male',21312,'12312','213','asdas'),(3,'johneilcarl','balboa','tagudin','2015-12-18','Male',1,'lanzones','davaocity','mintal'),(4,'levi','balboa','tagudin','2015-12-30','Male',123,'joasd','ijwdsj','basdw'),(5,'mar','mar','rosaroso','2015-12-25','Female',1,'juan luna','davao city','12-b'),(6,'juan','luna','moon','2015-12-18','Male',1,'','',''),(7,'awdasd','asdawd','asdaw','2015-12-04','Male',1,'as','aw','aw'),(8,'awds','daw','saw','2015-12-04','',1,'','',''),(9,'','','','2015-12-04','',12,'dada','',''),(10,'awddasd','sda','dasdw','2015-12-04','',12,'','',''),(11,'awds','12','awds','2015-12-04','',12,'wdsa','waw','awd'),(12,'asdasd','asdwa','daw','2015-12-04','Female',12,'awd','dawd','s'),(13,'FDFASDFASDF','ADA','sdfasdfasd','2015-12-04','',123123,'fasdfas','asfasdfadf','asdfa'),(14,'aa','asdfasdf','asdf','2015-12-04','',1123,'sadfasdfasdf','asdfasdfadsf','asdfasdfads'),(15,'asd','asdfa','fasdf','2015-12-04','',12323,'asd','asdf','asdw'),(16,'asdfa','sdfasd','fasdf','2015-12-05','Male',123,'fasdfasd','sadfasa','asdfasdf'),(17,'sdfsadf','awda','dawd','2015-12-05','Male',123,'asasd','fasdf','awdasd'),(18,'sdfasdfad','asdfasd','sdf','2015-12-05','Male',123123,'asd','asdfasd','sdf'),(19,'wtf','wtf','wtf','2015-12-05','Male',1232,'wtf','wtf','wtf'),(20,'johneilcarl ','balboa','tagudin','1996-10-31','Male',12,'small village','davao','mintal'),(21,'sadfafd','asdfasdf','asdfasdf','2015-12-05','Female',123,'asdawasd','wdas','wa'),(22,'asdfas','fasdf','asdfasdf','2015-12-05','Female',123,'asda','dasd','w'),(23,'asd','awd','asd','2015-12-05','Male',12,'asd','wa','wa'),(24,'sdf','sdfasd','asdf','2015-12-05','Male',12,'asda','awdaw','aw'),(25,'asdaf','sdfasdfsd','fasdf','2015-12-05','Male',12,'asd','dasd','asd'),(26,'asdf','dfasfa','dfasdf','2015-12-05','Male',12,'asd','awd','asd'),(27,'asdadsd','sdasd','asdasd','2015-12-05','Female',12,'asd','asdw','waw'),(28,'asdas','asdasdasd','asdasda','2015-12-05','Female',1212,'asdasd','asdasd','asd'),(29,'asdfa','fasdf','sdfasdfas','2015-12-05','Male',12,'asda','dasas','dsd'),(30,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(31,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(32,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(33,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(34,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(35,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(36,'asdfasdfasdf','asdf','asdfasd','2015-12-05','Male',12,'asdfasd','asdf','asdf'),(37,'asdfa','dfadf','asdfadsf','2015-12-05','Male',12,'asdfa','fas','asdf'),(38,'asdfa','dfadf','asdfadsf','2015-12-05','Male',12,'asdfa','fas','asdf'),(39,'ASD','ASDFA','FASDFASDF','2015-12-05','Male',12,'ASD','AWD','ASDW'),(40,'asdfasdfasdf','sdfasdfasdf','adfasdf','2015-12-05','Female',1212,'sdasdf','fasdfad','sdf'),(41,'test','test','test','2015-12-14','Male',1,'test','test','test'),(42,'fuck','fuck','fuck','2015-10-31','Male',123,'asdawd','asdawd','123asdsASD');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `issuance`
--

LOCK TABLES `issuance` WRITE;
/*!40000 ALTER TABLE `issuance` DISABLE KEYS */;
INSERT INTO `issuance` VALUES (1,'2015-12-30'),(2,'2015-12-30'),(3,'2015-12-30'),(4,'2015-12-30'),(5,'2015-12-30'),(6,'2015-12-30'),(7,'2015-12-30'),(8,'2015-12-30'),(9,'2015-12-30'),(10,'2015-12-30'),(11,'2015-12-30'),(12,'2015-12-30'),(13,'2015-12-30');
/*!40000 ALTER TABLE `issuance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `issuance_line`
--

DROP TABLE IF EXISTS `issuance_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `issuance_line` (
  `Medical_Supplies_Inventory_SupplyID` int(11) DEFAULT NULL,
  `Issuance_IssuanceID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `issuance_line`
--

LOCK TABLES `issuance_line` WRITE;
/*!40000 ALTER TABLE `issuance_line` DISABLE KEYS */;
INSERT INTO `issuance_line` VALUES (1,NULL,3,NULL),(3,NULL,3,NULL),(4,NULL,3,NULL),(5,NULL,3,NULL),(5,NULL,1,NULL),(5,NULL,1,NULL),(3,NULL,9,NULL),(1,NULL,4,NULL);
/*!40000 ALTER TABLE `issuance_line` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medical_staff`
--

DROP TABLE IF EXISTS `medical_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medical_staff` (
  `StaffID` int(11) NOT NULL,
  `LastName` varchar(100) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `StaffType` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`StaffID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medical_staff`
--

LOCK TABLES `medical_staff` WRITE;
/*!40000 ALTER TABLE `medical_staff` DISABLE KEYS */;
INSERT INTO `medical_staff` VALUES (1,'tagudin','johneilcarl','balboa','doctor'),(2,'delacruz','juan',NULL,'midwife'),(3,'forones','honeya',NULL,'mywife');
/*!40000 ALTER TABLE `medical_staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medical_supplies_inventory`
--

DROP TABLE IF EXISTS `medical_supplies_inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medical_supplies_inventory` (
  `SupplyID` int(11) NOT NULL,
  `MedicineName_idMedicineName` int(11) NOT NULL,
  PRIMARY KEY (`SupplyID`),
  KEY `fk_Medical Supplies Inventory_MedicineName1_idx` (`MedicineName_idMedicineName`),
  CONSTRAINT `fk_Medical Supplies Inventory_MedicineName1` FOREIGN KEY (`MedicineName_idMedicineName`) REFERENCES `medicine_name` (`idMedicineName`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medical_supplies_inventory`
--

LOCK TABLES `medical_supplies_inventory` WRITE;
/*!40000 ALTER TABLE `medical_supplies_inventory` DISABLE KEYS */;
/*!40000 ALTER TABLE `medical_supplies_inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicine_name`
--

DROP TABLE IF EXISTS `medicine_name`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medicine_name` (
  `idMedicineName` int(11) NOT NULL AUTO_INCREMENT,
  `MedicineName` varchar(45) DEFAULT NULL,
  `UnitType` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMedicineName`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicine_name`
--

LOCK TABLES `medicine_name` WRITE;
/*!40000 ALTER TABLE `medicine_name` DISABLE KEYS */;
INSERT INTO `medicine_name` VALUES (1,'Paracetamol','tablet'),(2,'Paracetamol','box'),(3,'Medicol','tablet'),(4,'bayojisik','capsule'),(5,'tambal','makaayo');
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
  `RefferalID` int(11) NOT NULL AUTO_INCREMENT,
  `CheckUp_PatientID` int(11) DEFAULT NULL,
  `RefferalDate` date DEFAULT NULL,
  `RefferalDescription` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`RefferalID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient_refferal`
--

LOCK TABLES `patient_refferal` WRITE;
/*!40000 ALTER TABLE `patient_refferal` DISABLE KEYS */;
INSERT INTO `patient_refferal` VALUES (1,1,'2015-12-11','aksjdwdasd'),(2,1,'2015-12-11','aksjdwdasd'),(3,1,'2015-12-11','asds'),(4,1,'2015-12-11','asdw'),(5,1,'2015-12-11','asdasdwdawd'),(6,1,'2015-12-11','asdasdwdawd'),(7,1,'2015-12-11','asd'),(8,1,'2015-12-11','ads'),(9,1,'2015-12-12','asdfaw'),(10,5,'2015-12-12','asdfawfasdfasdfasdfasdfasdf'),(11,5,'2015-12-12','asdfawfasdfasdfasdfasdfasdf'),(12,5,'2015-12-12','sadfasdfasdfasdf'),(15,13,'2016-02-19','askdfasjdfkjasd;klfjaklsdfasdfasdf'),(16,20,'2015-12-12','asdfasdfasdlkjfak;lsjdflkajsdklfjaklsdjfkasdfasdf12rfqfff1f1f1'),(17,1,'2015-12-12','asdfasdfasdf'),(18,1,'2015-12-12','asdfasdfasdfasdfadsf'),(19,1,'2015-12-12','asd'),(20,1,'2015-12-12','as'),(21,1,'2015-12-12','awda'),(22,1,'2015-12-12','asfouiwufuasdfuh\nasjdfasdhfuhsaduifhiauoiusodiu1oi2u3\niqwueoiqudoiuasioduiou1'),(23,3,'2015-12-12','sdfasdfsadfsadf'),(24,3,'2015-12-12','sdfasdfsadfsadfawda'),(25,3,'2015-12-12','sdfasdfsadfsadfawda123123'),(26,1,'2015-12-12','132123asdw'),(27,41,'2015-12-14','kailangan ko ng 1 kilo ng bigas!');
/*!40000 ALTER TABLE `patient_refferal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescription`
--

DROP TABLE IF EXISTS `prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescription` (
  `prescriptionId` int(11) NOT NULL AUTO_INCREMENT,
  `PrescriptionDetails` varchar(100) DEFAULT NULL,
  `PrescriptionDate` date DEFAULT NULL,
  `patientId` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`prescriptionId`),
  KEY `fk_Prescription_CheckUp1_idx` (`prescriptionId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescription`
--

LOCK TABLES `prescription` WRITE;
/*!40000 ALTER TABLE `prescription` DISABLE KEYS */;
INSERT INTO `prescription` VALUES (1,'asasdfasdf',NULL,NULL),(2,'jkldjaklsjdajwidjoiajsdw','2015-12-12','1'),(3,'l;sakdl;aksdopkwdopkasopdkpoakdpoawd','2015-12-12','3'),(5,'asdfasdfasdf','2015-12-12','10'),(6,';lasdk;j0i981290389aslkdjasd1','2015-12-25','3'),(7,'','2015-12-23','1'),(8,'asdfasdfasdf','2015-12-12','1'),(9,'12','2015-12-12','1'),(10,'sdfasdfasdfasdfaw','2015-12-13','3'),(11,'tags','2015-12-14','1');
/*!40000 ALTER TABLE `prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiving_line`
--

DROP TABLE IF EXISTS `receiving_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiving_line` (
  `Medical_Supplies_Inventory_SupplyID` int(11) DEFAULT NULL,
  `RecievingReport_idReceivingReport` int(11) DEFAULT NULL,
  `Quantity` varchar(45) DEFAULT NULL,
  `ExpirationDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiving_line`
--

LOCK TABLES `receiving_line` WRITE;
/*!40000 ALTER TABLE `receiving_line` DISABLE KEYS */;
INSERT INTO `receiving_line` VALUES (1,NULL,'','2015-12-30'),(1,NULL,'','2016-02-29'),(1,NULL,'','2016-02-29'),(2,NULL,'','2016-02-29'),(1,NULL,'5','2015-12-30'),(1,NULL,'10','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'4','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'5','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'6','2015-12-30'),(5,NULL,'2','2015-12-30'),(2,NULL,'2','2015-12-30'),(4,NULL,'2','2015-12-30'),(5,NULL,'2','2015-12-30'),(3,NULL,'10','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'','2015-12-30'),(5,NULL,'10','2015-12-30'),(1,NULL,'6','2015-12-30'),(4,NULL,'6','2015-12-30'),(1,NULL,'123','2015-12-30'),(1,NULL,'','2015-12-30'),(1,NULL,'13241324','2015-12-30');
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
  `Medical_Staff_StaffID` int(11) DEFAULT NULL,
  `DateOfReceive` date DEFAULT NULL,
  PRIMARY KEY (`idReceivingReport`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiving_report`
--

LOCK TABLES `receiving_report` WRITE;
/*!40000 ALTER TABLE `receiving_report` DISABLE KEYS */;
INSERT INTO `receiving_report` VALUES (1,1,'2015-12-30'),(2,1,'2015-12-30'),(3,1,'2015-12-30'),(4,3,'2015-12-30'),(5,1,'2015-12-30'),(6,1,'2015-12-30'),(7,1,'2015-12-30'),(8,1,'2015-12-30'),(9,1,'2015-12-30'),(10,1,'2015-12-30'),(11,1,'2015-12-30'),(12,1,'2015-12-30'),(13,1,'2015-12-30'),(14,1,'2015-12-30'),(15,1,'2015-12-30'),(16,1,'2015-12-30'),(17,1,'2015-12-30'),(18,1,'2015-12-17'),(19,1,'2016-01-08'),(20,1,'2016-01-08'),(21,1,'2016-01-08'),(22,1,'2016-01-08'),(23,1,'2015-12-30'),(24,1,'2015-12-30'),(25,1,'2015-12-30');
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
  `Medical_Staff_StaffID` int(11) DEFAULT NULL,
  `DateOfRequisition` date DEFAULT NULL,
  PRIMARY KEY (`idRequisition`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisition`
--

LOCK TABLES `requisition` WRITE;
/*!40000 ALTER TABLE `requisition` DISABLE KEYS */;
INSERT INTO `requisition` VALUES (10,1,'2015-12-30'),(11,2,'2015-12-30'),(12,3,'2015-12-30'),(13,3,'2015-12-30'),(14,1,'2015-12-30'),(15,1,'2015-12-30'),(16,1,'2015-12-30'),(17,1,'2015-12-30'),(18,1,'2015-12-30'),(19,1,'2015-12-30'),(20,1,'2015-12-30'),(21,1,'2015-12-30'),(22,1,'2015-12-30');
/*!40000 ALTER TABLE `requisition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requisition_line`
--

DROP TABLE IF EXISTS `requisition_line`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requisition_line` (
  `Medical_Supplies_Inventory_SupplyID` int(11) DEFAULT NULL,
  `Requisition_idRequisition` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `requisitionlineID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`requisitionlineID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisition_line`
--

LOCK TABLES `requisition_line` WRITE;
/*!40000 ALTER TABLE `requisition_line` DISABLE KEYS */;
INSERT INTO `requisition_line` VALUES (1,NULL,2,3),(3,NULL,5,4),(4,NULL,6,5),(4,NULL,6,6),(1,NULL,5,7),(1,NULL,12,8),(1,NULL,32,9),(1,NULL,31234,10);
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

-- Dump completed on 2015-12-30  4:00:21