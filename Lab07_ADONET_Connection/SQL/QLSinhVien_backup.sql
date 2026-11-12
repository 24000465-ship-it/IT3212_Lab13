-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: localhost    Database: qlsinhvien
-- ------------------------------------------------------
-- Server version	8.0.44

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
-- Current Database: `qlsinhvien`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `qlsinhvien` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `qlsinhvien`;

--
-- Table structure for table `dangky`
--

DROP TABLE IF EXISTS `dangky`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dangky` (
  `MaSV` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaHP` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `HocKy` int NOT NULL,
  `NgayDangKy` date NOT NULL DEFAULT (curdate()),
  `Diem` decimal(4,2) DEFAULT NULL,
  PRIMARY KEY (`MaSV`,`MaHP`),
  KEY `FK_DangKy_HocPhan` (`MaHP`),
  CONSTRAINT `FK_DangKy_HocPhan` FOREIGN KEY (`MaHP`) REFERENCES `hocphan` (`MaHP`),
  CONSTRAINT `FK_DangKy_SinhVien` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`),
  CONSTRAINT `CK_DangKy_HocKy` CHECK ((`HocKy` between 1 and 3)),
  CONSTRAINT `dangky_chk_1` CHECK ((`Diem` between 0 and 10))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dangky`
--

LOCK TABLES `dangky` WRITE;
/*!40000 ALTER TABLE `dangky` DISABLE KEYS */;
INSERT INTO `dangky` VALUES ('SV001','HP001',1,'2026-10-28',8.50),('SV001','HP002',1,'2026-10-28',9.00),('SV002','HP001',1,'2026-10-28',7.50),('SV002','HP003',1,'2026-10-28',8.00),('SV003','HP001',2,'2026-10-28',9.50),('SV003','HP004',2,'2026-10-28',8.80),('SV004','HP002',1,'2026-10-28',6.50),('SV004','HP005',1,'2026-10-28',7.00),('SV005','HP003',2,'2026-10-28',8.00),('SV005','HP005',2,'2026-10-28',7.50),('SV006','HP001',1,'2026-10-28',8.50),('SV006','HP004',1,'2026-10-28',9.00),('SV007','HP002',2,'2026-10-28',6.80),('SV007','HP003',2,'2026-10-28',7.20),('SV008','HP001',1,'2026-10-28',9.20),('SV008','HP005',1,'2026-10-28',8.50),('SV009','HP003',2,'2026-10-28',7.50),('SV009','HP004',2,'2026-10-28',8.00),('SV010','HP002',1,'2026-10-28',9.00),('SV010','HP005',1,'2026-10-28',8.80);
/*!40000 ALTER TABLE `dangky` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hocphan`
--

DROP TABLE IF EXISTS `hocphan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hocphan` (
  `MaHP` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenHP` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `SoTinChi` int NOT NULL,
  PRIMARY KEY (`MaHP`),
  CONSTRAINT `hocphan_chk_1` CHECK ((`SoTinChi` between 1 and 6))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hocphan`
--

LOCK TABLES `hocphan` WRITE;
/*!40000 ALTER TABLE `hocphan` DISABLE KEYS */;
INSERT INTO `hocphan` VALUES ('HP001','Cơ sở dữ liệu',3),('HP002','Lập trình C#',4),('HP003','Mạng máy tính',3),('HP004','Cấu trúc dữ liệu',3),('HP005','Phân tích thiết kế',2);
/*!40000 ALTER TABLE `hocphan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khoa`
--

DROP TABLE IF EXISTS `khoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khoa` (
  `MaKhoa` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenKhoa` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaKhoa`),
  UNIQUE KEY `TenKhoa` (`TenKhoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khoa`
--

LOCK TABLES `khoa` WRITE;
/*!40000 ALTER TABLE `khoa` DISABLE KEYS */;
INSERT INTO `khoa` VALUES ('CNTT','Công Nghệ Thông Tin'),('DL','Du Lịch'),('MKT','Marketing');
/*!40000 ALTER TABLE `khoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sinhvien`
--

DROP TABLE IF EXISTS `sinhvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sinhvien` (
  `MaSV` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `HoTen` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `NgaySinh` date NOT NULL,
  `GioiTinh` bit(1) NOT NULL,
  `MaKhoa` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `DiemTB` decimal(4,2) NOT NULL DEFAULT '0.00',
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`MaSV`),
  UNIQUE KEY `UQ_SinhVien_Email` (`Email`),
  KEY `FK_SinhVien_Khoa` (`MaKhoa`),
  CONSTRAINT `FK_SinhVien_Khoa` FOREIGN KEY (`MaKhoa`) REFERENCES `khoa` (`MaKhoa`),
  CONSTRAINT `CK_SinhVien_Diem` CHECK ((`DiemTB` between 0 and 10))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sinhvien`
--

LOCK TABLES `sinhvien` WRITE;
/*!40000 ALTER TABLE `sinhvien` DISABLE KEYS */;
INSERT INTO `sinhvien` VALUES ('SV001','Nguyễn Văn An','2005-01-15',_binary '','CNTT',8.50,'sv001@gmail.com'),('SV002','Trần Thị Bình','2005-03-20',_binary '\0','CNTT',7.80,'sv002@gmail.com'),('SV003','Lê Văn Cường','2004-07-10',_binary '','CNTT',9.00,'sv003@gmail.com'),('SV004','Phạm Thị Dung','2005-11-05',_binary '\0','CNTT',6.50,'sv004@gmail.com'),('SV005','Hoàng Văn Em','2005-06-25',_binary '','DL',7.00,'sv005@gmail.com'),('SV006','Đỗ Thị Hoa','2004-09-12',_binary '\0','DL',8.20,'sv006@gmail.com'),('SV007','Bùi Văn Hùng','2005-02-18',_binary '','DL',6.80,'sv007@gmail.com'),('SV008','Vũ Thị Lan','2005-08-30',_binary '\0','MKT',9.20,'sv008@gmail.com'),('SV009','Đặng Văn Minh','2004-12-01',_binary '','MKT',7.50,'sv009@gmail.com'),('SV010','Nguyễn Thị Ngọc','2005-04-14',_binary '\0','MKT',8.70,'sv010@gmail.com');
/*!40000 ALTER TABLE `sinhvien` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-28 20:31:38
