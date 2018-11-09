-- MySQL dump 10.16  Distrib 10.1.31-MariaDB, for Linux (x86_64)
--
-- Cara dump : ./mysqldump -u root db_bidan --single-transaction --quick --lock-tables=false --routines > /home/mandan/db_bidan.sql
-- Host: localhost    Database: db_bidan
-- ------------------------------------------------------
-- Server version	10.1.31-MariaDB

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
-- Temporary table structure for view `daftar_kelahiran`
--

DROP TABLE IF EXISTS `daftar_kelahiran`;
/*!50001 DROP VIEW IF EXISTS `daftar_kelahiran`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `daftar_kelahiran` (
  `No_Pasien` tinyint NOT NULL,
  `bulan` tinyint NOT NULL,
  `umur` tinyint NOT NULL,
  `tensi` tinyint NOT NULL,
  `Nama_Pasien` tinyint NOT NULL,
  `Alamat` tinyint NOT NULL,
  `Id_Kelahiran` tinyint NOT NULL,
  `Tanggal_Kelahiran` tinyint NOT NULL,
  `Nama_Suami` tinyint NOT NULL,
  `Penolongan_Persalinan` tinyint NOT NULL,
  `Cara_Persalinan` tinyint NOT NULL,
  `Keadaan_Ibu` tinyint NOT NULL,
  `Umur_Kehamilan` tinyint NOT NULL,
  `Biaya_Persalinan` tinyint NOT NULL,
  `Biaya_Perawatan` tinyint NOT NULL,
  `Biaya_Perawatan_Bayi` tinyint NOT NULL,
  `Biaya_Obat_Obatan` tinyint NOT NULL,
  `Biaya_Cucian` tinyint NOT NULL,
  `Biaya_Akte` tinyint NOT NULL,
  `Biaya_Transportasi` tinyint NOT NULL,
  `Biaya_Lain` tinyint NOT NULL,
  `Total_Bayar` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `daftar_obat`
--

DROP TABLE IF EXISTS `daftar_obat`;
/*!50001 DROP VIEW IF EXISTS `daftar_obat`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `daftar_obat` (
  `Id_Obat` tinyint NOT NULL,
  `Nama_Obat` tinyint NOT NULL,
  `Stok` tinyint NOT NULL,
  `Id_Jobat` tinyint NOT NULL,
  `Jenis_Obat` tinyint NOT NULL,
  `Id_Sat_Obat` tinyint NOT NULL,
  `Satuan` tinyint NOT NULL,
  `Harga_Obat` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `daftar_obat_beli`
--

DROP TABLE IF EXISTS `daftar_obat_beli`;
/*!50001 DROP VIEW IF EXISTS `daftar_obat_beli`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `daftar_obat_beli` (
  `Id_Terapi` tinyint NOT NULL,
  `Id_Obat` tinyint NOT NULL,
  `Id_Periksa` tinyint NOT NULL,
  `Tgl_Periksa` tinyint NOT NULL,
  `Nama_Obat` tinyint NOT NULL,
  `Jumlah` tinyint NOT NULL,
  `Harga_Obat` tinyint NOT NULL,
  `Total_Harga` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `daftar_pasien`
--

DROP TABLE IF EXISTS `daftar_pasien`;
/*!50001 DROP VIEW IF EXISTS `daftar_pasien`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `daftar_pasien` (
  `No_Pasien` tinyint NOT NULL,
  `Nama_Pasien` tinyint NOT NULL,
  `umur` tinyint NOT NULL,
  `Tanggal_Lahir` tinyint NOT NULL,
  `Jenis_Kelamin` tinyint NOT NULL,
  `Pekerjaan` tinyint NOT NULL,
  `Alamat` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `daftar_satuan`
--

DROP TABLE IF EXISTS `daftar_satuan`;
/*!50001 DROP VIEW IF EXISTS `daftar_satuan`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `daftar_satuan` (
  `Id_Sat` tinyint NOT NULL,
  `Nama_Satuan` tinyint NOT NULL,
  `Id_Jsat` tinyint NOT NULL,
  `Nama_Jenis_Satuan` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_anc`
--

DROP TABLE IF EXISTS `laporan_anc`;
/*!50001 DROP VIEW IF EXISTS `laporan_anc`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_anc` (
  `Id_Anc` tinyint NOT NULL,
  `tgl_periksa` tinyint NOT NULL,
  `keluhan` tinyint NOT NULL,
  `no_pasien` tinyint NOT NULL,
  `anak_ke` tinyint NOT NULL,
  `tensi` tinyint NOT NULL,
  `nm_pasien` tinyint NOT NULL,
  `Id_Periksa` tinyint NOT NULL,
  `Nama_Suami` tinyint NOT NULL,
  `umur` tinyint NOT NULL,
  `alamat` tinyint NOT NULL,
  `Tinggi_Badan` tinyint NOT NULL,
  `Berat_Badan` tinyint NOT NULL,
  `diagnosa_anc` tinyint NOT NULL,
  `Umur_Kehamilan` tinyint NOT NULL,
  `KB_Terakhir` tinyint NOT NULL,
  `Obat` tinyint NOT NULL,
  `Total_Bayar` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_bayi_lahir`
--

DROP TABLE IF EXISTS `laporan_bayi_lahir`;
/*!50001 DROP VIEW IF EXISTS `laporan_bayi_lahir`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_bayi_lahir` (
  `Id_Kelahiran` tinyint NOT NULL,
  `Tanggal_Kelahiran` tinyint NOT NULL,
  `No_Pasien` tinyint NOT NULL,
  `Nama_Pasien` tinyint NOT NULL,
  `Nama_Bayi` tinyint NOT NULL,
  `Waktu_Lahir` tinyint NOT NULL,
  `Anak_Ke` tinyint NOT NULL,
  `Berat_Lahir` tinyint NOT NULL,
  `Panjang_Badan` tinyint NOT NULL,
  `Lingkar_Kepala` tinyint NOT NULL,
  `Jenis_Kelamin` tinyint NOT NULL,
  `Asuhan_Bayi_Saat_Lahir` tinyint NOT NULL,
  `Keterangan` tinyint NOT NULL,
  `Kondisi Bayi` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_berobat_umum`
--

DROP TABLE IF EXISTS `laporan_berobat_umum`;
/*!50001 DROP VIEW IF EXISTS `laporan_berobat_umum`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_berobat_umum` (
  `Id_Periksa` tinyint NOT NULL,
  `Nama_Pasien` tinyint NOT NULL,
  `Alamat` tinyint NOT NULL,
  `Tanggal_Periksa` tinyint NOT NULL,
  `No_Pasien` tinyint NOT NULL,
  `umur` tinyint NOT NULL,
  `Tinggi_Badan` tinyint NOT NULL,
  `Berat_Badan` tinyint NOT NULL,
  `Keluhan` tinyint NOT NULL,
  `Diagnosa ANC` tinyint NOT NULL,
  `Tensi` tinyint NOT NULL,
  `obat` tinyint NOT NULL,
  `Total_Bayar` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_bulanan`
--

DROP TABLE IF EXISTS `laporan_bulanan`;
/*!50001 DROP VIEW IF EXISTS `laporan_bulanan`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_bulanan` (
  `Tgl_Periksa` tinyint NOT NULL,
  `Total_harga` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_harian`
--

DROP TABLE IF EXISTS `laporan_harian`;
/*!50001 DROP VIEW IF EXISTS `laporan_harian`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_harian` (
  `Tgl_Periksa` tinyint NOT NULL,
  `hari` tinyint NOT NULL,
  `Nama_Obat` tinyint NOT NULL,
  `Jumlah` tinyint NOT NULL,
  `Total_harga` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_kb`
--

DROP TABLE IF EXISTS `laporan_kb`;
/*!50001 DROP VIEW IF EXISTS `laporan_kb`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_kb` (
  `Id_Periksa` tinyint NOT NULL,
  `Nama_Pasien` tinyint NOT NULL,
  `nm_suami` tinyint NOT NULL,
  `Tanggal_Periksa` tinyint NOT NULL,
  `No_Pasien` tinyint NOT NULL,
  `Tinggi_Badan` tinyint NOT NULL,
  `Alamat` tinyint NOT NULL,
  `umur` tinyint NOT NULL,
  `Berat_Badan` tinyint NOT NULL,
  `Keluhan` tinyint NOT NULL,
  `Tensi` tinyint NOT NULL,
  `Anak_Ke` tinyint NOT NULL,
  `Haid_Terakhir` tinyint NOT NULL,
  `Id_Sat_Berat` tinyint NOT NULL,
  `Nama_Obat` tinyint NOT NULL,
  `Jumlah` tinyint NOT NULL,
  `Total_Bayar` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_pemasukan`
--

DROP TABLE IF EXISTS `laporan_pemasukan`;
/*!50001 DROP VIEW IF EXISTS `laporan_pemasukan`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_pemasukan` (
  `Id_Terapi` tinyint NOT NULL,
  `Id_Obat` tinyint NOT NULL,
  `Id_Periksa` tinyint NOT NULL,
  `Tgl_Periksa` tinyint NOT NULL,
  `Nama_Obat` tinyint NOT NULL,
  `Jumlah` tinyint NOT NULL,
  `Harga_Obat` tinyint NOT NULL,
  `Total_Harga` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_rekap_pasien`
--

DROP TABLE IF EXISTS `laporan_rekap_pasien`;
/*!50001 DROP VIEW IF EXISTS `laporan_rekap_pasien`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_rekap_pasien` (
  `Id_Periksa` tinyint NOT NULL,
  `Nama_Pasien` tinyint NOT NULL,
  `Alamat` tinyint NOT NULL,
  `Tanggal_Periksa` tinyint NOT NULL,
  `No_Pasien` tinyint NOT NULL,
  `umur` tinyint NOT NULL,
  `Tinggi_Badan` tinyint NOT NULL,
  `Berat_Badan` tinyint NOT NULL,
  `Keluhan` tinyint NOT NULL,
  `Diagnosa ANC` tinyint NOT NULL,
  `Tensi` tinyint NOT NULL,
  `obat` tinyint NOT NULL,
  `Total_Bayar` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_tahunan`
--

DROP TABLE IF EXISTS `laporan_tahunan`;
/*!50001 DROP VIEW IF EXISTS `laporan_tahunan`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_tahunan` (
  `Tgl_Periksa` tinyint NOT NULL,
  `Total_harga` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `laporan_terapi`
--

DROP TABLE IF EXISTS `laporan_terapi`;
/*!50001 DROP VIEW IF EXISTS `laporan_terapi`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `laporan_terapi` (
  `Id_Periksa` tinyint NOT NULL,
  `Tgl_Periksa` tinyint NOT NULL,
  `Id_Obat` tinyint NOT NULL,
  `Nama_Obat` tinyint NOT NULL,
  `Harga_Obat` tinyint NOT NULL,
  `Jumlah` tinyint NOT NULL,
  `Total` tinyint NOT NULL,
  `Satuan` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `pemasukan_berobat`
--

DROP TABLE IF EXISTS `pemasukan_berobat`;
/*!50001 DROP VIEW IF EXISTS `pemasukan_berobat`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `pemasukan_berobat` (
  `Tanggal_Berobat` tinyint NOT NULL,
  `Total_Pemasukan_Berobat` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `pemasukan_kb`
--

DROP TABLE IF EXISTS `pemasukan_kb`;
/*!50001 DROP VIEW IF EXISTS `pemasukan_kb`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `pemasukan_kb` (
  `Tanggal_Kb` tinyint NOT NULL,
  `Total_Pemasukan_Kb` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `pemasukan_kelahiran`
--

DROP TABLE IF EXISTS `pemasukan_kelahiran`;
/*!50001 DROP VIEW IF EXISTS `pemasukan_kelahiran`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `pemasukan_kelahiran` (
  `Tanggal_Kelahiran` tinyint NOT NULL,
  `Total_Pemasukan_Kelahiran` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tbl_anc`
--

DROP TABLE IF EXISTS `tbl_anc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_anc` (
  `id_periksa` varchar(50) NOT NULL,
  `id_anc` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suami` varchar(100) NOT NULL,
  `tinggi_bdn` smallint(6) NOT NULL,
  `id_sat_tinggi` int(11) NOT NULL DEFAULT '12',
  `berat_bdn` smallint(6) NOT NULL,
  `id_sat_berat` int(11) NOT NULL DEFAULT '1',
  `hpht` date NOT NULL,
  `htp` date NOT NULL,
  `umur_khmln` int(11) NOT NULL,
  `id_sat_umur` int(11) NOT NULL DEFAULT '18',
  `kb_terakhir` date NOT NULL,
  `anak_ke` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_anc`),
  KEY `id_periksa` (`id_periksa`),
  KEY `id_sat_tinggi` (`id_sat_tinggi`),
  KEY `id_sat_berat` (`id_sat_berat`),
  KEY `id_sat_umur` (`id_sat_umur`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_anc`
--

LOCK TABLES `tbl_anc` WRITE;
/*!40000 ALTER TABLE `tbl_anc` DISABLE KEYS */;
INSERT INTO `tbl_anc` VALUES ('2406181221466191',1,'Suami ku',190,12,70,1,'2018-06-25','2019-04-02',22,18,'2018-06-24',1);
/*!40000 ALTER TABLE `tbl_anc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_asuhan_bayi`
--

DROP TABLE IF EXISTS `tbl_asuhan_bayi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_asuhan_bayi` (
  `id_asuhan` int(11) NOT NULL AUTO_INCREMENT,
  `nm_asuhan` text NOT NULL,
  PRIMARY KEY (`id_asuhan`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_asuhan_bayi`
--

LOCK TABLES `tbl_asuhan_bayi` WRITE;
/*!40000 ALTER TABLE `tbl_asuhan_bayi` DISABLE KEYS */;
INSERT INTO `tbl_asuhan_bayi` VALUES (1,'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama'),(2,'Suntikan Vitamin K1'),(3,'Salep mata antibiotika profilaksis'),(4,'Imunisasi HBO');
/*!40000 ALTER TABLE `tbl_asuhan_bayi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bayi_lahir`
--

DROP TABLE IF EXISTS `tbl_bayi_lahir`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bayi_lahir` (
  `id_bayi` int(11) NOT NULL AUTO_INCREMENT,
  `id_kelahiran` varchar(50) NOT NULL,
  `nm_bayi` varchar(100) NOT NULL,
  `waktu_lahir` datetime DEFAULT NULL,
  `anak_ke` int(11) NOT NULL,
  `berat_lahir` int(11) NOT NULL,
  `id_sat_berat` int(11) NOT NULL DEFAULT '4',
  `panjang_badan` int(11) NOT NULL,
  `id_sat_panjang` int(11) NOT NULL DEFAULT '12',
  `lingkar_kepala` int(11) NOT NULL,
  `id_sat_lingkar` int(11) NOT NULL DEFAULT '12',
  `jk` varchar(30) NOT NULL,
  `asuhan_bayi_saat_lahir` text NOT NULL,
  `keterangan` text NOT NULL,
  `kondisi_bayi` text NOT NULL,
  PRIMARY KEY (`id_bayi`),
  KEY `id_kelahiran` (`id_kelahiran`),
  KEY `id_sat_berat` (`id_sat_berat`),
  KEY `id_sat_panjang` (`id_sat_panjang`),
  KEY `id_sat_lingkar` (`id_sat_lingkar`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bayi_lahir`
--

LOCK TABLES `tbl_bayi_lahir` WRITE;
/*!40000 ALTER TABLE `tbl_bayi_lahir` DISABLE KEYS */;
INSERT INTO `tbl_bayi_lahir` VALUES (1,'K636642690558369157','Bayi Pertama','2018-06-10 01:10:57',1,20,1,104,12,20,12,'Laki-laki','Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n','Keterangan Bayi Pertama','Segera menangis\r\nMenangis beberapa saat\r\n'),(2,'K636642690558369157','Bayi Kedua','2018-06-10 11:11:49',2,14,4,107,12,23,12,'Laki-laki','Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\nSalep mata antibiotika profilaksis\r\nImunisasi HBO\r\n','Keterangan Bayi Kedua','Segera menangis\r\nMenangis beberapa saat\r\n'),(3,'K636642691775120029','Bayi Lain 1','2018-06-10 11:12:22',2,22,4,12,12,21,12,'Laki-laki','','',''),(4,'K636642691775120029','Bayi Lain','2018-06-10 11:14:24',32,21,4,12,12,12,12,'Laki-laki','','',''),(5,'K636656199511148552','111','2018-06-26 02:25:52',1,12,4,12,12,12,12,'Laki-laki','Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n','czxzc','Segera menangis\r\n');
/*!40000 ALTER TABLE `tbl_bayi_lahir` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_jenis_obat`
--

DROP TABLE IF EXISTS `tbl_jenis_obat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_jenis_obat`
--

LOCK TABLES `tbl_jenis_obat` WRITE;
/*!40000 ALTER TABLE `tbl_jenis_obat` DISABLE KEYS */;
INSERT INTO `tbl_jenis_obat` VALUES (1,'KB'),(2,'Ringan'),(3,'Keras'),(4,'Suplemen');
/*!40000 ALTER TABLE `tbl_jenis_obat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_jsatuan`
--

DROP TABLE IF EXISTS `tbl_jsatuan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_jsatuan` (
  `id_jsat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jsat` varchar(30) NOT NULL,
  PRIMARY KEY (`id_jsat`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_jsatuan`
--

LOCK TABLES `tbl_jsatuan` WRITE;
/*!40000 ALTER TABLE `tbl_jsatuan` DISABLE KEYS */;
INSERT INTO `tbl_jsatuan` VALUES (1,'Berat'),(2,'Panjang'),(3,'Waktu'),(4,'Banyak'),(5,'Tekanan');
/*!40000 ALTER TABLE `tbl_jsatuan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_kelahiran`
--

DROP TABLE IF EXISTS `tbl_kelahiran`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_kelahiran` (
  `no_pasien` int(11) NOT NULL,
  `id_kelahiran` varchar(50) NOT NULL,
  `tgl_kelahiran` datetime NOT NULL,
  `nm_suami` varchar(100) NOT NULL,
  `penolongan_persalinan` text NOT NULL,
  `cara_persalinan` text NOT NULL,
  `keadaan_ibu` text NOT NULL,
  `umur_kehamilan` int(11) NOT NULL,
  `id_sat_umur` int(11) NOT NULL DEFAULT '18',
  `bulan` int(11) NOT NULL DEFAULT '10',
  `tensi` varchar(7) NOT NULL DEFAULT '120/80',
  `biaya_persalinan` int(11) NOT NULL,
  `biaya_perawatan_kelas` int(11) NOT NULL,
  `biaya_perawatan_bayi` int(11) NOT NULL,
  `biaya_obat_obatan` int(11) NOT NULL,
  `biaya_cucian` int(11) NOT NULL,
  `biaya_akte_kelahiran` int(11) NOT NULL,
  `biaya_transportasi` int(11) NOT NULL,
  `biaya_lain` int(11) NOT NULL,
  PRIMARY KEY (`id_kelahiran`),
  KEY `no_pasien` (`no_pasien`),
  KEY `id_sat_umur` (`id_sat_umur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_kelahiran`
--

LOCK TABLES `tbl_kelahiran` WRITE;
/*!40000 ALTER TABLE `tbl_kelahiran` DISABLE KEYS */;
INSERT INTO `tbl_kelahiran` VALUES (4,'K636642690558369157','2018-06-10 11:10:00','Suami Ku','Pertolongan','Cara','Keadaan',25,18,10,'120/80',625000,625000,500000,375000,750000,500000,0,500000),(4,'K636642691775120029','2018-06-10 11:10:00','Suami Dia','ded','sedse','seede',33,18,10,'120/80',750000,875000,375000,500000,625000,375000,0,625000),(4,'K636656199511148552','2018-06-26 02:25:00','sdeeed','dede','sdsad','sadasd',12,18,10,'120/80',500000,500000,500000,500000,500000,500000,500000,500000);
/*!40000 ALTER TABLE `tbl_kelahiran` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_kondisi_lahir`
--

DROP TABLE IF EXISTS `tbl_kondisi_lahir`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_kondisi_lahir` (
  `id_kondisi` int(11) NOT NULL AUTO_INCREMENT,
  `nm_kondisi` text NOT NULL,
  PRIMARY KEY (`id_kondisi`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_kondisi_lahir`
--

LOCK TABLES `tbl_kondisi_lahir` WRITE;
/*!40000 ALTER TABLE `tbl_kondisi_lahir` DISABLE KEYS */;
INSERT INTO `tbl_kondisi_lahir` VALUES (1,'Segera menangis'),(2,'Menangis beberapa saat'),(3,'Tidak menangis'),(4,'Seluruh tubuh kemerahan'),(5,'Anggota gerak kebiruan'),(6,'Seluruh tubuh biru'),(7,'Kelainan bawaan'),(8,'Meninggal');
/*!40000 ALTER TABLE `tbl_kondisi_lahir` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_obat`
--

DROP TABLE IF EXISTS `tbl_obat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_obat` (
  `id_obat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_obat` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `id_jobat` int(11) NOT NULL,
  `hrg_obat` int(11) NOT NULL,
  `id_sat_obat` int(11) NOT NULL DEFAULT '25',
  PRIMARY KEY (`id_obat`),
  KEY `id_jobat` (`id_jobat`),
  KEY `id_sat_obat` (`id_sat_obat`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_obat`
--

LOCK TABLES `tbl_obat` WRITE;
/*!40000 ALTER TABLE `tbl_obat` DISABLE KEYS */;
INSERT INTO `tbl_obat` VALUES (1,'Kabe',1,'Aktif',1,10000,25),(2,'Ringan',2,'Aktif',2,1800,25),(8,'Suntik',3,'Aktif',1,9000,25),(9,'Parasetamol',5,'Aktif',2,1100,25),(10,'STM',0,'Aktif',2,1000,25),(11,'Promag',6,'Aktif',2,2000,25),(12,'Amoxilin',37,'Aktif',2,3000,25),(13,'Vitamin C',10,'Aktif',2,12000,25),(14,'sitrizin',20,'Aktif',2,12000,23);
/*!40000 ALTER TABLE `tbl_obat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pasien`
--

DROP TABLE IF EXISTS `tbl_pasien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_pasien` (
  `no_pasien` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pasien` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk` enum('Laki-laki','Perempuan') NOT NULL,
  `pekerjaan` varchar(100) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pasien`
--

LOCK TABLES `tbl_pasien` WRITE;
/*!40000 ALTER TABLE `tbl_pasien` DISABLE KEYS */;
INSERT INTO `tbl_pasien` VALUES (4,'Wanita Pasien','1971-05-28','Perempuan','Sebuah Pekerjaan','Alamat rumah contoh'),(5,'Pasien Laki','1990-08-01','Laki-laki','Tukang Angkek','Perumahan '),(6,'Pasien tes','2018-06-24','Laki-laki','pekerjaan','pekerjaan');
/*!40000 ALTER TABLE `tbl_pasien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_periksa`
--

DROP TABLE IF EXISTS `tbl_periksa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_periksa` (
  `id_periksa` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `no_pasien` int(11) NOT NULL,
  `keluhan` text,
  `tensi` varchar(9) NOT NULL,
  `id_sat_tensi` int(11) NOT NULL DEFAULT '26',
  PRIMARY KEY (`id_periksa`),
  KEY `id_sat_tensi` (`id_sat_tensi`),
  KEY `no_pasien` (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_periksa`
--

LOCK TABLES `tbl_periksa` WRITE;
/*!40000 ALTER TABLE `tbl_periksa` DISABLE KEYS */;
INSERT INTO `tbl_periksa` VALUES ('2306180331476494','2018-06-23 01:33:04',4,'xzcdccdcdcd','120/80',26),('2306180333049771','2018-06-23 01:34:23',4,'knfkdsnkfnksnfjewf','120/80',26),('2406181221466191','2018-06-23 22:22:44',4,'Keluhan panjang...\r\nG 2\r\nA 2\r\nD 2,','120/80',26),('2606180220310811','2018-06-26 00:22:53',4,'sakik kaposdasas\r\ndsassa\r\nasdsad','/',26),('2706180200450315','2018-06-27 00:01:03',4,'daasas','90/120',26),('2706181039150928','2018-06-26 20:39:52',4,'dasdasdadww','90/120',26),('270620180513365982','2018-06-27 03:14:01',4,'Pemeriksaan/Pemasangan KB','60/120',26);
/*!40000 ALTER TABLE `tbl_periksa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_periksa_kb`
--

DROP TABLE IF EXISTS `tbl_periksa_kb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_periksa_kb` (
  `id_periksa_kb` int(11) NOT NULL AUTO_INCREMENT,
  `id_periksa` varchar(50) NOT NULL,
  `nm_suami` varchar(100) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `haid_terakhir` date NOT NULL,
  `berat_badan` int(11) NOT NULL,
  `id_sat_berat` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_periksa_kb`),
  KEY `id_sat_berat` (`id_sat_berat`),
  KEY `id_periksa` (`id_periksa`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_periksa_kb`
--

LOCK TABLES `tbl_periksa_kb` WRITE;
/*!40000 ALTER TABLE `tbl_periksa_kb` DISABLE KEYS */;
INSERT INTO `tbl_periksa_kb` VALUES (1,'270620180513365982','Suami dia',2,'2018-06-27',20,1);
/*!40000 ALTER TABLE `tbl_periksa_kb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_satuan`
--

DROP TABLE IF EXISTS `tbl_satuan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  `id_jsat` int(11) NOT NULL,
  PRIMARY KEY (`id_sat`),
  KEY `id_jsat` (`id_jsat`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_satuan`
--

LOCK TABLES `tbl_satuan` WRITE;
/*!40000 ALTER TABLE `tbl_satuan` DISABLE KEYS */;
INSERT INTO `tbl_satuan` VALUES (1,'Kg',1),(2,'Hg',1),(3,'Dag',1),(4,'Gr',1),(5,'Cg',1),(6,'Mg',1),(7,'Km',2),(8,'Hm',2),(9,'Dam',2),(10,'M',2),(11,'Dm',2),(12,'Cm',2),(13,'Mm',2),(14,'Detik',3),(15,'Menit',3),(16,'Jam',3),(17,'Hari',3),(18,'Minggu',3),(19,'Bulan',3),(20,'Tahun',3),(21,'Dg',1),(22,'Pcs',4),(23,'Lembar',4),(24,'Tablet',4),(25,'Buah',4),(26,'MMHG',5),(27,'Botol',4),(28,'Sachet',4);
/*!40000 ALTER TABLE `tbl_satuan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_terapi`
--

DROP TABLE IF EXISTS `tbl_terapi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_terapi` (
  `id_terapi` int(11) NOT NULL AUTO_INCREMENT,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_periksa` varchar(50) NOT NULL,
  PRIMARY KEY (`id_terapi`),
  KEY `id_obat` (`id_obat`),
  KEY `id_periksa` (`id_periksa`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_terapi`
--

LOCK TABLES `tbl_terapi` WRITE;
/*!40000 ALTER TABLE `tbl_terapi` DISABLE KEYS */;
INSERT INTO `tbl_terapi` VALUES (1,1,3,'100620181115456348'),(5,10,2,'1006181122392383'),(6,1,2,'110620181206354178'),(7,8,1,'110620181214334910'),(8,13,2,'1106181056409573'),(9,10,2,'1106181056409573'),(10,10,1,'2606180220310811'),(11,11,20,'2606180220310811'),(12,9,2,'2706181039150928'),(13,12,3,'2706181039150928'),(14,11,4,'2706180200450315'),(15,1,2,'270620180513365982');
/*!40000 ALTER TABLE `tbl_terapi` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_terapi` FOR EACH ROW update tbl_obat set stok = stok - new.jumlah where id_obat = new.id_obat */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `reset_stok` AFTER DELETE ON `tbl_terapi` FOR EACH ROW update tbl_obat set stok = stok + OLD.jumlah where id_obat = OLD.id_obat */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `jenis` enum('Admin','Bidan','Pemilik') NOT NULL,
  `nama` varchar(50) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (1,'admin','21232f297a57a5a743894a0e4a801fc3','Admin','Admin'),(2,'bidan','cc274f4730ce350f1cf60e73f4172d67','Bidan','bidan'),(3,'pimpinan','90973652b88fe07d05a4304f0a945de8','Pemilik','pimpinan');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_bidan'
--
/*!50003 DROP PROCEDURE IF EXISTS `getLaporanPemasukan` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getLaporanPemasukan`(IN `tg_lap` tinyint)
select distinct a.tg, b.tot tot1, c.tot tot2, d.tot tot3 from 
(select distinct Tanggal_Berobat tg from pemasukan_berobat union all 
select distinct Tanggal_Kb tg from pemasukan_kb union all 
select distinct Tanggal_Kelahiran tg from pemasukan_kelahiran) a left join
(select Tanggal_Berobat tg, sum(Total_Pemasukan_Berobat) tot from pemasukan_berobat group by Tanggal_Berobat) b on b.tg=a.tg left join 
(select Tanggal_Kb tg, sum(Total_Pemasukan_Kb) tot from pemasukan_kb group by Tanggal_Kb) c on c.tg=a.tg left join 
(select Tanggal_Kelahiran tg, sum(Total_Pemasukan_Kelahiran) tot from pemasukan_kelahiran group by Tanggal_Kelahiran) d on d.tg=a.tg ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `daftar_kelahiran`
--

/*!50001 DROP TABLE IF EXISTS `daftar_kelahiran`*/;
/*!50001 DROP VIEW IF EXISTS `daftar_kelahiran`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `daftar_kelahiran` AS select `a`.`no_pasien` AS `No_Pasien`,`a`.`bulan` AS `bulan`,`b`.`umur` AS `umur`,concat(`a`.`tensi`,' MMHG') AS `tensi`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`b`.`Alamat` AS `Alamat`,`a`.`id_kelahiran` AS `Id_Kelahiran`,`a`.`tgl_kelahiran` AS `Tanggal_Kelahiran`,`a`.`nm_suami` AS `Nama_Suami`,`a`.`penolongan_persalinan` AS `Penolongan_Persalinan`,`a`.`cara_persalinan` AS `Cara_Persalinan`,`a`.`keadaan_ibu` AS `Keadaan_Ibu`,concat(`a`.`umur_kehamilan`,' ',`c`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`biaya_persalinan` AS `Biaya_Persalinan`,`a`.`biaya_perawatan_kelas` AS `Biaya_Perawatan`,`a`.`biaya_perawatan_bayi` AS `Biaya_Perawatan_Bayi`,`a`.`biaya_obat_obatan` AS `Biaya_Obat_Obatan`,`a`.`biaya_cucian` AS `Biaya_Cucian`,`a`.`biaya_akte_kelahiran` AS `Biaya_Akte`,`a`.`biaya_transportasi` AS `Biaya_Transportasi`,`a`.`biaya_lain` AS `Biaya_Lain`,(((((((`a`.`biaya_persalinan` + `a`.`biaya_perawatan_kelas`) + `a`.`biaya_perawatan_bayi`) + `a`.`biaya_obat_obatan`) + `a`.`biaya_cucian`) + `a`.`biaya_akte_kelahiran`) + `a`.`biaya_transportasi`) + `a`.`biaya_lain`) AS `Total_Bayar` from ((`tbl_kelahiran` `a` join `daftar_pasien` `b` on((`a`.`no_pasien` = `b`.`No_Pasien`))) join `daftar_satuan` `c` on((`a`.`id_sat_umur` = `c`.`Id_Sat`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `daftar_obat`
--

/*!50001 DROP TABLE IF EXISTS `daftar_obat`*/;
/*!50001 DROP VIEW IF EXISTS `daftar_obat`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `daftar_obat` AS select `a`.`id_obat` AS `Id_Obat`,`a`.`nm_obat` AS `Nama_Obat`,`a`.`stok` AS `Stok`,`b`.`id_jobat` AS `Id_Jobat`,`b`.`nm_jobat` AS `Jenis_Obat`,`a`.`id_sat_obat` AS `Id_Sat_Obat`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_obat` AS `Harga_Obat` from ((`tbl_obat` `a` join `tbl_jenis_obat` `b` on((`a`.`id_jobat` = `b`.`id_jobat`))) join `daftar_satuan` `c` on((`a`.`id_sat_obat` = `c`.`Id_Sat`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `daftar_obat_beli`
--

/*!50001 DROP TABLE IF EXISTS `daftar_obat_beli`*/;
/*!50001 DROP VIEW IF EXISTS `daftar_obat_beli`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `daftar_obat_beli` AS select `a`.`id_terapi` AS `Id_Terapi`,`a`.`id_obat` AS `Id_Obat`,`a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from ((`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) left join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) group by `a`.`id_periksa`,`a`.`id_obat` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `daftar_pasien`
--

/*!50001 DROP TABLE IF EXISTS `daftar_pasien`*/;
/*!50001 DROP VIEW IF EXISTS `daftar_pasien`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `daftar_pasien` AS select `tbl_pasien`.`no_pasien` AS `No_Pasien`,`tbl_pasien`.`nm_pasien` AS `Nama_Pasien`,timestampdiff(YEAR,`tbl_pasien`.`tgl_lahir`,now()) AS `umur`,`tbl_pasien`.`tgl_lahir` AS `Tanggal_Lahir`,`tbl_pasien`.`jk` AS `Jenis_Kelamin`,`tbl_pasien`.`pekerjaan` AS `Pekerjaan`,`tbl_pasien`.`alamat` AS `Alamat` from `tbl_pasien` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `daftar_satuan`
--

/*!50001 DROP TABLE IF EXISTS `daftar_satuan`*/;
/*!50001 DROP VIEW IF EXISTS `daftar_satuan`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_jsatuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_anc`
--

/*!50001 DROP TABLE IF EXISTS `laporan_anc`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_anc`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_anc` AS select `a`.`id_anc` AS `Id_Anc`,`c`.`tgl_periksa` AS `tgl_periksa`,`c`.`keluhan` AS `keluhan`,`c`.`no_pasien` AS `no_pasien`,`a`.`anak_ke` AS `anak_ke`,`c`.`tensi` AS `tensi`,`d`.`Nama_Pasien` AS `nm_pasien`,`a`.`id_periksa` AS `Id_Periksa`,`a`.`nm_suami` AS `Nama_Suami`,`d`.`umur` AS `umur`,`d`.`Alamat` AS `alamat`,concat(`a`.`tinggi_bdn`,' ',`sat_tinggi`.`Nama_Satuan`) AS `Tinggi_Badan`,concat(`a`.`berat_bdn`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Badan`,concat('HPHT ',`a`.`hpht`,', HTP ',`a`.`htp`) AS `diagnosa_anc`,concat(`a`.`umur_khmln`,' ',`sat_umur`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`kb_terakhir` AS `KB_Terakhir`,(select group_concat(`daftar_obat_beli`.`Nama_Obat`,'\n' separator ',') from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`)) AS `Obat`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((((`tbl_anc` `a` join `daftar_satuan` `sat_tinggi` on((`a`.`id_sat_tinggi` = `sat_tinggi`.`Id_Sat`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_umur` on((`a`.`id_sat_umur` = `sat_umur`.`Id_Sat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) join `daftar_pasien` `d` on((`c`.`no_pasien` = `d`.`No_Pasien`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_bayi_lahir`
--

/*!50001 DROP TABLE IF EXISTS `laporan_bayi_lahir`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_bayi_lahir`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_bayi_lahir` AS select `b`.`Id_Kelahiran` AS `Id_Kelahiran`,`b`.`Tanggal_Kelahiran` AS `Tanggal_Kelahiran`,`b`.`No_Pasien` AS `No_Pasien`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`nm_bayi` AS `Nama_Bayi`,`a`.`waktu_lahir` AS `Waktu_Lahir`,`a`.`anak_ke` AS `Anak_Ke`,concat(`a`.`berat_lahir`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Lahir`,concat(`a`.`panjang_badan`,' ',`sat_panjang`.`Nama_Satuan`) AS `Panjang_Badan`,concat(`a`.`lingkar_kepala`,' ',`sat_lingkar`.`Nama_Satuan`) AS `Lingkar_Kepala`,`a`.`jk` AS `Jenis_Kelamin`,`a`.`asuhan_bayi_saat_lahir` AS `Asuhan_Bayi_Saat_Lahir`,`a`.`keterangan` AS `Keterangan`,`a`.`kondisi_bayi` AS `Kondisi Bayi` from ((((`tbl_bayi_lahir` `a` join `daftar_kelahiran` `b` on((`a`.`id_kelahiran` = `b`.`Id_Kelahiran`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_panjang` on((`a`.`id_sat_panjang` = `sat_panjang`.`Id_Sat`))) join `daftar_satuan` `sat_lingkar` on((`a`.`id_sat_lingkar` = `sat_lingkar`.`Id_Sat`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_berobat_umum`
--

/*!50001 DROP TABLE IF EXISTS `laporan_berobat_umum`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_berobat_umum`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_berobat_umum` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`Nama_Pasien` AS `Nama_Pasien`,`c`.`Alamat` AS `Alamat`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`no_pasien` AS `No_Pasien`,timestampdiff(YEAR,`c`.`Tanggal_Lahir`,now()) AS `umur`,`e`.`Tinggi_Badan` AS `Tinggi_Badan`,`e`.`Berat_Badan` AS `Berat_Badan`,`a`.`keluhan` AS `Keluhan`,concat(`e`.`diagnosa_anc`,'\nUmur Kehamilan ',`e`.`Umur_Kehamilan`) AS `Diagnosa ANC`,concat(`a`.`tensi`,' ',`sat`.`Nama_Satuan`) AS `Tensi`,(select group_concat(`daftar_obat_beli`.`Nama_Obat`,' ',`daftar_obat_beli`.`Jumlah`,'\n' separator ',') from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`)) AS `obat`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id_Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No_Pasien`))) left join `laporan_anc` `e` on((`a`.`id_periksa` = `e`.`Id_Periksa`))) where (`a`.`keluhan` <> 'Pemeriksaan/Pemasangan KB') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_bulanan`
--

/*!50001 DROP TABLE IF EXISTS `laporan_bulanan`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_bulanan`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_bulanan` AS select `laporan_pemasukan`.`Tgl_Periksa` AS `Tgl_Periksa`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_harga` from `laporan_pemasukan` where ((month(`laporan_pemasukan`.`Tgl_Periksa`) = month(now())) and (year(`laporan_pemasukan`.`Tgl_Periksa`) = year(now()))) group by dayofmonth(`laporan_pemasukan`.`Tgl_Periksa`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_harian`
--

/*!50001 DROP TABLE IF EXISTS `laporan_harian`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_harian`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_harian` AS select `laporan_pemasukan`.`Tgl_Periksa` AS `Tgl_Periksa`,dayofmonth(`laporan_pemasukan`.`Tgl_Periksa`) AS `hari`,`laporan_pemasukan`.`Nama_Obat` AS `Nama_Obat`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_harga` from `laporan_pemasukan` group by `laporan_pemasukan`.`Tgl_Periksa`,`laporan_pemasukan`.`Nama_Obat` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_kb`
--

/*!50001 DROP TABLE IF EXISTS `laporan_kb`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_kb`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_kb` AS select `f`.`Id_Periksa` AS `Id_Periksa`,`f`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`nm_suami` AS `nm_suami`,`f`.`Tanggal_Periksa` AS `Tanggal_Periksa`,`f`.`No_Pasien` AS `No_Pasien`,`f`.`Tinggi_Badan` AS `Tinggi_Badan`,`f`.`Alamat` AS `Alamat`,`f`.`umur` AS `umur`,concat(`a`.`berat_badan`,' ',`d`.`Nama_Satuan`) AS `Berat_Badan`,`f`.`Keluhan` AS `Keluhan`,`f`.`Tensi` AS `Tensi`,`a`.`anak_ke` AS `Anak_Ke`,`a`.`haid_terakhir` AS `Haid_Terakhir`,`a`.`id_sat_berat` AS `Id_Sat_Berat`,`b`.`Nama_Obat` AS `Nama_Obat`,concat(`b`.`Jumlah`,' ',`b`.`Satuan`) AS `Jumlah`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((`tbl_periksa_kb` `a` left join `laporan_rekap_pasien` `f` on((`a`.`id_periksa` = `f`.`Id_Periksa`))) join `laporan_terapi` `b` on((`a`.`id_periksa` = `b`.`Id_Periksa`))) join `daftar_satuan` `d` on((`a`.`id_sat_berat` = `d`.`Id_Sat`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_pemasukan`
--

/*!50001 DROP TABLE IF EXISTS `laporan_pemasukan`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_pemasukan`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_pemasukan` AS select `a`.`id_terapi` AS `Id_Terapi`,`a`.`id_obat` AS `Id_Obat`,`a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from ((`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) group by `a`.`id_periksa`,`a`.`id_obat` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_rekap_pasien`
--

/*!50001 DROP TABLE IF EXISTS `laporan_rekap_pasien`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_rekap_pasien`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_rekap_pasien` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`Nama_Pasien` AS `Nama_Pasien`,`c`.`Alamat` AS `Alamat`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`no_pasien` AS `No_Pasien`,timestampdiff(YEAR,`c`.`Tanggal_Lahir`,now()) AS `umur`,`e`.`Tinggi_Badan` AS `Tinggi_Badan`,`e`.`Berat_Badan` AS `Berat_Badan`,`a`.`keluhan` AS `Keluhan`,concat(`e`.`diagnosa_anc`,'\nUmur Kehamilan ',`e`.`Umur_Kehamilan`) AS `Diagnosa ANC`,concat(`a`.`tensi`,' ',`sat`.`Nama_Satuan`) AS `Tensi`,(select group_concat(`daftar_obat_beli`.`Nama_Obat`,' ',`daftar_obat_beli`.`Jumlah`,'\n' separator ',') from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`)) AS `obat`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id_Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No_Pasien`))) left join `laporan_anc` `e` on((`a`.`id_periksa` = `e`.`Id_Periksa`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_tahunan`
--

/*!50001 DROP TABLE IF EXISTS `laporan_tahunan`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_tahunan`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_tahunan` AS select `laporan_pemasukan`.`Tgl_Periksa` AS `Tgl_Periksa`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_harga` from `laporan_pemasukan` where (year(`laporan_pemasukan`.`Tgl_Periksa`) = year(now())) group by month(`laporan_pemasukan`.`Tgl_Periksa`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `laporan_terapi`
--

/*!50001 DROP TABLE IF EXISTS `laporan_terapi`*/;
/*!50001 DROP VIEW IF EXISTS `laporan_terapi`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `laporan_terapi` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`a`.`id_obat` AS `Id_Obat`,`b`.`Nama_Obat` AS `Nama_Obat`,`b`.`Harga_Obat` AS `Harga_Obat`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_Obat`) AS `Total`,`b`.`Satuan` AS `Satuan` from ((`tbl_terapi` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id_Obat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pemasukan_berobat`
--

/*!50001 DROP TABLE IF EXISTS `pemasukan_berobat`*/;
/*!50001 DROP VIEW IF EXISTS `pemasukan_berobat`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pemasukan_berobat` AS select cast(`laporan_berobat_umum`.`Tanggal_Periksa` as date) AS `Tanggal_Berobat`,sum(`laporan_berobat_umum`.`Total_Bayar`) AS `Total_Pemasukan_Berobat` from `laporan_berobat_umum` group by dayofmonth(`laporan_berobat_umum`.`Tanggal_Periksa`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pemasukan_kb`
--

/*!50001 DROP TABLE IF EXISTS `pemasukan_kb`*/;
/*!50001 DROP VIEW IF EXISTS `pemasukan_kb`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pemasukan_kb` AS select cast(`laporan_kb`.`Tanggal_Periksa` as date) AS `Tanggal_Kb`,sum(`laporan_kb`.`Total_Bayar`) AS `Total_Pemasukan_Kb` from `laporan_kb` group by dayofmonth(`laporan_kb`.`Tanggal_Periksa`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pemasukan_kelahiran`
--

/*!50001 DROP TABLE IF EXISTS `pemasukan_kelahiran`*/;
/*!50001 DROP VIEW IF EXISTS `pemasukan_kelahiran`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pemasukan_kelahiran` AS select cast(`daftar_kelahiran`.`Tanggal_Kelahiran` as date) AS `Tanggal_Kelahiran`,sum(`daftar_kelahiran`.`Total_Bayar`) AS `Total_Pemasukan_Kelahiran` from `daftar_kelahiran` group by dayofmonth(`daftar_kelahiran`.`Tanggal_Kelahiran`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-09 17:11:01
