CREATE DATABASE  IF NOT EXISTS `hospital` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `hospital`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: hospital
-- ------------------------------------------------------
-- Server version	5.5.29

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `EmployeeID` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES (NULL),(NULL),(21),(25),(26),(31),(5),(8);
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessment`
--

DROP TABLE IF EXISTS `assessment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assessment` (
  `AssessmentID` int(3) NOT NULL AUTO_INCREMENT,
  `PatientID` int(3) DEFAULT NULL,
  `FeeID` int(3) DEFAULT NULL,
  PRIMARY KEY (`AssessmentID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assessment`
--

LOCK TABLES `assessment` WRITE;
/*!40000 ALTER TABLE `assessment` DISABLE KEYS */;
/*!40000 ALTER TABLE `assessment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cashier`
--

DROP TABLE IF EXISTS `cashier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cashier` (
  `EmployeeID` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cashier`
--

LOCK TABLES `cashier` WRITE;
/*!40000 ALTER TABLE `cashier` DISABLE KEYS */;
INSERT INTO `cashier` VALUES (NULL),(22),(27),(32),(6),(9);
/*!40000 ALTER TABLE `cashier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor`
--

DROP TABLE IF EXISTS `doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctor` (
  `Specialty` varchar(20) DEFAULT NULL,
  `FeeID` int(3) DEFAULT NULL,
  `EmployeeID` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor`
--

LOCK TABLES `doctor` WRITE;
/*!40000 ALTER TABLE `doctor` DISABLE KEYS */;
INSERT INTO `doctor` VALUES ('12',16,NULL),('12',17,NULL),('adfsdfsd',18,NULL),('fsdf',41,23),('Physician',43,28),('Physician',44,29),('sdfsdfs',50,33),('Physician',50,1),('Physician',54,2),('Physician',54,3),('Surgeon',58,10);
/*!40000 ALTER TABLE `doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drug`
--

DROP TABLE IF EXISTS `drug`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drug` (
  `DrugID` int(3) NOT NULL AUTO_INCREMENT,
  `DrugName` varchar(20) DEFAULT NULL,
  `FeeID` int(10) DEFAULT NULL,
  PRIMARY KEY (`DrugID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drug`
--

LOCK TABLES `drug` WRITE;
/*!40000 ALTER TABLE `drug` DISABLE KEYS */;
INSERT INTO `drug` VALUES (1,'Shabu',46),(3,'Marijuana',48),(4,'Ecstacy',49),(5,'Muriatic Acid',50);
/*!40000 ALTER TABLE `drug` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `EmployeeID` int(5) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `ContactNumber` varchar(11) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `HireDate` date DEFAULT NULL,
  `ManagerID` int(3) DEFAULT NULL,
  `EmployeeType` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Gerald Martin','Conanan','Madarang','2015-05-05','12345678907','Male','dsfsd','2015-05-05',1,'Doctor'),(2,'Nashreen Yusuf','Balono','Pandita','2015-05-05','12345678907','Male','dsfsd','2015-05-05',1,'Doctor'),(3,'Joan','Mary','Filosopo','2015-05-05','12345678907','Female','dsfsd','2015-05-05',1,'Doctor'),(4,'Dan ','Angelo','Vicente','2015-05-05','42342342424','Male','sdfsdf','2015-05-05',1,'Nurse'),(5,'Bernie','M','Jereza','2015-03-10','09202491207','Male','Davao City','2015-03-03',NULL,'Admin'),(6,'Alexandra','B','Udinov','2015-03-14','32423423424','Female','Davao City','2013-10-14',NULL,'Cashier'),(7,'Christel','Ann','Lingaya','2015-03-14','35345346346','Female','Davao City','2015-03-14',NULL,'Nurse'),(8,'Nikita','Miles','Myers','2015-03-16','97089000899','Female','Cebu City','2015-03-16',NULL,'Admin'),(9,'Therese','Cinnamon','Binabon','2015-03-16','34354353464','Female','Cebu City','2015-03-16',NULL,'Cashier'),(10,'Alessandra','de','Mitra','2015-03-16','45646324234','Female','Davao City','2015-03-16',NULL,'Doctor'),(11,'Joy','Melet','Nurse','2015-03-16','34234234242','Female','Davao City','2015-03-16',NULL,'Nurse');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fee`
--

DROP TABLE IF EXISTS `fee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fee` (
  `FeeID` int(3) NOT NULL AUTO_INCREMENT,
  `FeeAmount` double DEFAULT NULL,
  PRIMARY KEY (`FeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fee`
--

LOCK TABLES `fee` WRITE;
/*!40000 ALTER TABLE `fee` DISABLE KEYS */;
INSERT INTO `fee` VALUES (1,200.5),(2,234),(3,12),(4,24),(5,24),(6,23),(7,23),(8,23),(9,23),(10,23),(11,23),(12,34),(13,3),(14,34),(15,32423),(16,12),(17,12),(18,123),(19,123),(20,234),(21,234),(22,13124),(23,342),(24,43),(25,23423),(26,3),(27,232),(28,34324),(29,500),(30,2000),(31,300.5),(32,800.76),(33,34.234),(34,450.5),(35,645.75),(36,23.43),(37,34.453),(38,34.53),(39,23.43),(40,34.533333),(41,123.123),(42,13213),(43,10000),(44,10000),(45,213123),(46,100.1221),(47,23.23),(48,123.43),(49,2342),(50,5000),(51,234234),(52,234),(53,12.12),(54,7000),(55,5000),(56,50.5),(57,500),(58,6000),(59,8000);
/*!40000 ALTER TABLE `fee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inpatient`
--

DROP TABLE IF EXISTS `inpatient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inpatient` (
  `PatientID` int(3) NOT NULL,
  `RoomID` int(3) DEFAULT NULL,
  `DateOfDischarge` date DEFAULT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inpatient`
--

LOCK TABLES `inpatient` WRITE;
/*!40000 ALTER TABLE `inpatient` DISABLE KEYS */;
INSERT INTO `inpatient` VALUES (1,NULL,'2015-03-16'),(2,NULL,NULL);
/*!40000 ALTER TABLE `inpatient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `labtest`
--

DROP TABLE IF EXISTS `labtest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `labtest` (
  `LabTestID` int(3) NOT NULL AUTO_INCREMENT,
  `LabTestName` varchar(20) DEFAULT NULL,
  `LabTestDescription` varchar(300) DEFAULT NULL,
  `FeeID` int(3) DEFAULT NULL,
  PRIMARY KEY (`LabTestID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `labtest`
--

LOCK TABLES `labtest` WRITE;
/*!40000 ALTER TABLE `labtest` DISABLE KEYS */;
INSERT INTO `labtest` VALUES (6,'Blood Test','BloodTest',29),(7,'Urinalysis','Urine exam',30),(8,'Glucose','sdfsdfsd',31),(9,'Fecalysis','Poop',32),(11,'Eye Test','Eye Eye',34),(12,'Drug Test','Drugs',35);
/*!40000 ALTER TABLE `labtest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `labtestcontent`
--

DROP TABLE IF EXISTS `labtestcontent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `labtestcontent` (
  `LabTestContentID` int(3) NOT NULL AUTO_INCREMENT,
  `LabTestID` int(3) DEFAULT NULL,
  `LabTestResult` varchar(20) DEFAULT NULL,
  `LabTestDate` date DEFAULT NULL,
  `PatientID` int(3) DEFAULT NULL,
  PRIMARY KEY (`LabTestContentID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `labtestcontent`
--

LOCK TABLES `labtestcontent` WRITE;
/*!40000 ALTER TABLE `labtestcontent` DISABLE KEYS */;
INSERT INTO `labtestcontent` VALUES (1,8,'Okay','2015-03-09',1),(2,12,'Okay','2015-03-08',2),(3,11,'Okay','2015-03-07',3),(4,11,'Okay','2015-03-07',1),(5,8,'Positive','2015-03-11',1),(6,6,'Positive','2015-03-11',1),(7,7,'Positive','2015-03-11',2),(8,12,'Positive','2015-03-11',3),(9,9,'Positive','2015-03-11',2),(10,7,'Negative','2015-03-11',3),(14,6,'Clear','2015-03-14',1),(15,11,'Has Malignant Tumor','2015-03-16',5);
/*!40000 ALTER TABLE `labtestcontent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nurse`
--

DROP TABLE IF EXISTS `nurse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nurse` (
  `FeeID` int(3) DEFAULT NULL,
  `EmployeeID` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nurse`
--

LOCK TABLES `nurse` WRITE;
/*!40000 ALTER TABLE `nurse` DISABLE KEYS */;
INSERT INTO `nurse` VALUES (19,NULL),(42,24),(45,30),(51,34),(57,7),(59,11);
/*!40000 ALTER TABLE `nurse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `outpatient`
--

DROP TABLE IF EXISTS `outpatient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `outpatient` (
  `PatientID` int(3) NOT NULL,
  `CheckBackDate` date DEFAULT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `outpatient`
--

LOCK TABLES `outpatient` WRITE;
/*!40000 ALTER TABLE `outpatient` DISABLE KEYS */;
INSERT INTO `outpatient` VALUES (3,NULL);
/*!40000 ALTER TABLE `outpatient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `PatientID` int(5) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `ContactNumber` varchar(11) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `BloodType` varchar(5) DEFAULT NULL,
  `RegistrationDate` date DEFAULT NULL,
  `Symptoms` varchar(100) DEFAULT NULL,
  `Disease` varchar(100) DEFAULT NULL,
  `EmployeeID` int(5) DEFAULT NULL,
  `PatientType` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`PatientID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'Edward','Full','Metal','Davao City','2015-03-04','12312312312','Male','a','2015-03-04','asdasd','dasdasdas',1,'Inpatient'),(2,'Elsa','Mars','White','Davao City','2015-03-05','02394092340','Female','A','2015-03-05','ffgd','dfgdfg',1,'InPatient'),(3,'Jack','Ice','Frost','Davao City','2015-03-05','09200320302','Male','A','2015-03-06','ffgd','dfgdfg',2,'Outpatient'),(5,'Johnson','B','Jaurigue','Davao City','2015-03-16','34234234242','Male','B','2015-03-16','Mild Colds, Rashes','Chicken Pox',3,'Outpatient');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patienthistory`
--

DROP TABLE IF EXISTS `patienthistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patienthistory` (
  `PatientHistoryID` int(3) NOT NULL AUTO_INCREMENT,
  `PatientID` int(3) DEFAULT NULL,
  `DoctorID` int(3) DEFAULT NULL,
  `DateAdmitted` date DEFAULT NULL,
  `DateDischarged` date DEFAULT NULL,
  `RegistrationDate` date DEFAULT NULL,
  `Symptoms` varchar(50) DEFAULT NULL,
  `Disease` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PatientHistoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patienthistory`
--

LOCK TABLES `patienthistory` WRITE;
/*!40000 ALTER TABLE `patienthistory` DISABLE KEYS */;
INSERT INTO `patienthistory` VALUES (1,5,3,NULL,NULL,'2015-03-16','Mild Colds, Rashes','Chicken Pox');
/*!40000 ALTER TABLE `patienthistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `PaymentID` int(3) NOT NULL AUTO_INCREMENT,
  `PatientID` int(3) DEFAULT NULL,
  `PaymentDate` date DEFAULT NULL,
  `AmountPaid` int(10) DEFAULT NULL,
  PRIMARY KEY (`PaymentID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,1,'2015-03-04',501),(2,2,'2015-03-04',200),(3,1,'2015-03-05',1000),(4,1,'2015-02-01',20000),(5,1,'2015-03-15',98),(6,3,'2015-03-15',50),(7,1,'2015-03-15',1),(8,1,'2015-03-16',100),(9,5,'2015-03-16',500);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `room` (
  `RoomID` int(3) NOT NULL AUTO_INCREMENT,
  `RoomDescription` varchar(50) DEFAULT NULL,
  `FeeID` int(3) DEFAULT NULL,
  `NumOfAvailable` int(50) DEFAULT NULL,
  PRIMARY KEY (`RoomID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` VALUES (5,'Private Room',53,100),(6,'Presidential Suite',43,5),(7,'ICU',55,2);
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomassigned`
--

DROP TABLE IF EXISTS `roomassigned`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roomassigned` (
  `RoomAssignedID` int(3) NOT NULL AUTO_INCREMENT,
  `RoomID` int(3) DEFAULT NULL,
  `CheckInDate` date DEFAULT NULL,
  `CheckOutDate` date DEFAULT NULL,
  `PatientID` int(3) DEFAULT NULL,
  `RoomRatePerDay` double DEFAULT NULL,
  PRIMARY KEY (`RoomAssignedID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomassigned`
--

LOCK TABLES `roomassigned` WRITE;
/*!40000 ALTER TABLE `roomassigned` DISABLE KEYS */;
INSERT INTO `roomassigned` VALUES (1,5,'2015-03-04','2015-03-16',1,12.12),(2,6,'2015-03-05','2015-03-06',2,10000),(3,5,'2015-03-05',NULL,3,12.12),(4,5,'2015-03-05','2015-03-16',1,12.12);
/*!40000 ALTER TABLE `roomassigned` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomtogovern`
--

DROP TABLE IF EXISTS `roomtogovern`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roomtogovern` (
  `RoomToGovernID` int(3) NOT NULL AUTO_INCREMENT,
  `RoomID` int(3) DEFAULT NULL,
  `GovernDate` date DEFAULT NULL,
  `EmployeeID` int(5) DEFAULT NULL,
  PRIMARY KEY (`RoomToGovernID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomtogovern`
--

LOCK TABLES `roomtogovern` WRITE;
/*!40000 ALTER TABLE `roomtogovern` DISABLE KEYS */;
INSERT INTO `roomtogovern` VALUES (2,5,'2015-03-14',4),(3,7,'2015-03-14',7);
/*!40000 ALTER TABLE `roomtogovern` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `treatment`
--

DROP TABLE IF EXISTS `treatment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `treatment` (
  `PatientID` int(3) DEFAULT NULL,
  `DrugID` int(3) DEFAULT NULL,
  `TreatmentResult` varchar(20) DEFAULT NULL,
  `TreatmentDate` date DEFAULT NULL,
  `TreatmentTime` varchar(10) DEFAULT NULL,
  `EmployeeID` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `treatment`
--

LOCK TABLES `treatment` WRITE;
/*!40000 ALTER TABLE `treatment` DISABLE KEYS */;
INSERT INTO `treatment` VALUES (1,1,'Okay','2015-03-04','MWF 9:00',1),(2,1,'Okay','2015-03-04','MWF 9:00',1),(2,5,'Okay','2015-03-05','TTh 4:55',2),(2,5,'Ok','2015-03-05','TTh 6:54',2),(2,5,'Ok','2015-03-05','TTh 6:54',2),(1,1,'cvxcvcx','0001-01-01','vxcvxcv',1),(1,1,'gfgdf','0001-01-01','fdgfdgf',1),(1,1,'','2015-03-16','',1);
/*!40000 ALTER TABLE `treatment` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-01-05 18:38:17
