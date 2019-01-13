-- Adminer 4.6.2 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DELIMITER ;;

DROP PROCEDURE IF EXISTS `getLaporanPemasukan`;;
CREATE PROCEDURE `getLaporanPemasukan`(IN `tg_lap` tinyint)
select distinct a.tg, ifnull(b.tot, 0) tot1, ifnull(c.tot, 0) tot2, ifnull(d.tot, 0) tot3, ifnull(e.tot, 0) tot4 from 
(select distinct Tanggal_Berobat tg from pemasukan_berobat union all 
select distinct Tanggal_Kb tg from pemasukan_kb union all 
select distinct tgl_periksa ta from pemasukan_anc union all 
select distinct Tanggal_Kelahiran tg from pemasukan_kelahiran) a left join
(select Tanggal_Berobat tg, sum(Total_Pemasukan_Berobat) tot from pemasukan_berobat group by Tanggal_Berobat) b on b.tg=a.tg left join 
(select Tanggal_Kb tg, sum(Total_Pemasukan_Kb) tot from pemasukan_kb group by Tanggal_Kb) c on c.tg=a.tg left join 
(select tgl_periksa ta, sum(total_pemasukan) tot from pemasukan_anc group by tgl_periksa) e on e.ta=a.tg left join 
(select Tanggal_Kelahiran tg, sum(Total_Pemasukan_Kelahiran) tot from pemasukan_kelahiran group by Tanggal_Kelahiran) d on d.tg=a.tg;;

DELIMITER ;

DROP VIEW IF EXISTS `daftar_kelahiran`;
CREATE TABLE `daftar_kelahiran` (`No_Pasien` int(11), `bulan` int(11), `umur` bigint(21), `tensi` varchar(12), `Nama_Pasien` varchar(50), `Alamat` varchar(50), `Id_Kelahiran` varchar(50), `Tanggal_Kelahiran` datetime, `Nama_Suami` varchar(50), `Penolongan_Persalinan` text, `Cara_Persalinan` text, `Keadaan_Ibu` text, `Umur_Kehamilan` varchar(42), `Biaya_Persalinan` int(11), `Biaya_Perawatan` int(11), `Biaya_Perawatan_Bayi` int(11), `Biaya_Obat_Obatan` int(11), `Biaya_Cucian` int(11), `Biaya_Akte` int(11), `Biaya_Transportasi` int(11), `Biaya_Lain` int(11), `Total_Bayar` bigint(18), `nm_bidan` varchar(50));


DROP VIEW IF EXISTS `daftar_obat`;
CREATE TABLE `daftar_obat` (`Id_Obat` int(11), `Nama_Obat` varchar(50), `Stok` int(11), `Id_Jobat` int(11), `Jenis_Obat` varchar(50), `Id_Sat_Obat` int(11), `Tanggal` date, `Satuan` varchar(30), `Harga_Obat` int(11));


DROP VIEW IF EXISTS `daftar_obat_beli`;
CREATE TABLE `daftar_obat_beli` (`Id_Terapi` int(11), `Id_Obat` int(11), `Id_Periksa` varchar(50), `Tgl_Periksa` timestamp, `Nama_Obat` varchar(50), `Jumlah` decimal(32,0), `Harga_Obat` int(11), `Total_Harga` decimal(42,0));


DROP VIEW IF EXISTS `daftar_pasien`;
CREATE TABLE `daftar_pasien` (`No_Pasien` int(11), `Nama_Pasien` varchar(50), `umur` bigint(21), `Tanggal_Lahir` date, `Jenis_Kelamin` enum('Laki-laki','Perempuan'), `Pekerjaan` varchar(50), `Alamat` varchar(50));


DROP VIEW IF EXISTS `daftar_pasien_revisi`;
CREATE TABLE `daftar_pasien_revisi` (`no_reg` int(11), `tgl_daftar` timestamp, `Nama_Pasien` varchar(50), `umur` bigint(21), `Tanggal_Lahir` date, `Jenis_Kelamin` enum('Laki-laki','Perempuan'), `Pekerjaan` varchar(50), `Alamat` varchar(50));


DROP VIEW IF EXISTS `daftar_satuan`;
CREATE TABLE `daftar_satuan` (`Id_Sat` int(11), `Nama_Satuan` varchar(30), `Id_Jsat` int(11), `Nama_Jenis_Satuan` varchar(30));


DROP VIEW IF EXISTS `laporan_anc`;
CREATE TABLE `laporan_anc` (`haid_terakhir` date, `Id_Anc` int(11), `tgl_periksa` timestamp, `keluhan` text, `no_pasien` int(11), `anak_ke` int(11), `tensi` varchar(9), `nm_pasien` varchar(50), `Id_Periksa` varchar(50), `Nama_Suami` varchar(50), `umur` bigint(21), `alamat` varchar(50), `Tinggi_Badan` varchar(37), `Berat_Badan` varchar(37), `diagnosa_anc` varchar(31), `Umur_Kehamilan` varchar(42), `KB_Terakhir` date, `Obat` text, `Total_Bayar` decimal(64,0));


DROP VIEW IF EXISTS `laporan_bayi_lahir`;
CREATE TABLE `laporan_bayi_lahir` (`Id_Kelahiran` varchar(50), `Tanggal_Kelahiran` datetime, `No_Pasien` int(11), `Nama_Pasien` varchar(50), `Nama_Bayi` varchar(50), `Waktu_Lahir` datetime, `Anak_Ke` int(11), `Berat_Lahir` varchar(42), `Panjang_Badan` varchar(42), `Lingkar_Kepala` varchar(42), `Jenis_Kelamin` varchar(30), `Asuhan_Bayi_Saat_Lahir` text, `Keterangan` text, `Kondisi Bayi` text, `nm_bidan` varchar(50));


DROP VIEW IF EXISTS `laporan_berobat_umum`;
CREATE TABLE `laporan_berobat_umum` (`Id_Periksa` varchar(50), `Nama_Pasien` varchar(50), `Alamat` varchar(50), `Tanggal_Periksa` timestamp, `No_Pasien` int(11), `umur` bigint(21), `Tinggi_Badan` varchar(37), `Berat_Badan` varchar(37), `Keluhan` text, `Diagnosa ANC` varchar(31), `Tensi` varchar(40), `obat` text, `Total_Bayar` decimal(64,0));


DROP VIEW IF EXISTS `laporan_bulanan`;
CREATE TABLE `laporan_bulanan` (`Tgl_Periksa` timestamp, `Total_harga` decimal(64,0));


DROP VIEW IF EXISTS `laporan_harian`;
CREATE TABLE `laporan_harian` (`Tgl_Periksa` timestamp, `hari` int(2), `Nama_Obat` varchar(50), `Jumlah` decimal(54,0), `Total_harga` decimal(64,0));


DROP VIEW IF EXISTS `laporan_kb`;
CREATE TABLE `laporan_kb` (`Id_Periksa` varchar(50), `Nama_Pasien` varchar(50), `nm_suami` varchar(50), `Tanggal_Periksa` timestamp, `No_Pasien` int(11), `Tinggi_Badan` varchar(37), `Alamat` varchar(50), `umur` bigint(21), `Berat_Badan` varchar(42), `Keluhan` text, `Tensi` varchar(40), `Anak_Ke` int(11), `Haid_Terakhir` date, `Id_Sat_Berat` int(11), `Nama_Obat` varchar(50), `Jumlah` varchar(42), `Total_Bayar` decimal(64,0));


DROP VIEW IF EXISTS `laporan_pemasukan`;
CREATE TABLE `laporan_pemasukan` (`Id_Terapi` int(11), `Id_Obat` int(11), `Id_Periksa` varchar(50), `Tgl_Periksa` timestamp, `Nama_Obat` varchar(50), `Jumlah` decimal(32,0), `Harga_Obat` int(11), `Total_Harga` decimal(42,0));


DROP VIEW IF EXISTS `laporan_pemasukan_anc`;
CREATE TABLE `laporan_pemasukan_anc` (`id_periksa` varchar(50), `biaya_periksa` int(11), `tgl_periksa` timestamp);


DROP VIEW IF EXISTS `laporan_rekap_pasien`;
CREATE TABLE `laporan_rekap_pasien` (`Id_Periksa` varchar(50), `Nama_Bidan` varchar(50), `Nama_Pasien` varchar(50), `Alamat` varchar(50), `Tanggal_Periksa` timestamp, `No_Pasien` int(11), `umur` bigint(21), `Tinggi_Badan` varchar(37), `Berat_Badan` varchar(37), `Keluhan` text, `Diagnosa ANC` varchar(31), `Tensi` varchar(40), `obat` text, `Total_Bayar` decimal(64,0));


DROP VIEW IF EXISTS `laporan_tahunan`;
CREATE TABLE `laporan_tahunan` (`Tgl_Periksa` timestamp, `Total_harga` decimal(64,0));


DROP VIEW IF EXISTS `laporan_terapi`;
CREATE TABLE `laporan_terapi` (`Id_Periksa` varchar(50), `Tgl_Periksa` timestamp, `Id_Obat` int(11), `Nama_Obat` varchar(50), `Harga_Obat` int(11), `Jumlah` int(11), `Total` bigint(21), `Satuan` varchar(30));


DROP VIEW IF EXISTS `pemasukan_anc`;
CREATE TABLE `pemasukan_anc` (`Id_Periksa` varchar(50), `tgl_periksa` timestamp, `total_pemasukan` decimal(65,0));


DROP VIEW IF EXISTS `pemasukan_berobat`;
CREATE TABLE `pemasukan_berobat` (`Tanggal_Berobat` date, `Total_Pemasukan_Berobat` decimal(65,0));


DROP VIEW IF EXISTS `pemasukan_kb`;
CREATE TABLE `pemasukan_kb` (`Tanggal_Kb` date, `Total_Pemasukan_Kb` decimal(65,0));


DROP VIEW IF EXISTS `pemasukan_kelahiran`;
CREATE TABLE `pemasukan_kelahiran` (`Tanggal_Kelahiran` date, `Total_Pemasukan_Kelahiran` decimal(41,0));


DROP TABLE IF EXISTS `tbl_anc`;
CREATE TABLE `tbl_anc` (
  `id_periksa` varchar(50) NOT NULL,
  `id_anc` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suami` varchar(50) NOT NULL,
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
  `haid_terakhir` date NOT NULL,
  `biaya_periksa` int(11) NOT NULL,
  PRIMARY KEY (`id_anc`),
  KEY `id_periksa` (`id_periksa`),
  KEY `id_sat_tinggi` (`id_sat_tinggi`),
  KEY `id_sat_berat` (`id_sat_berat`),
  KEY `id_sat_umur` (`id_sat_umur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_anc` (`id_periksa`, `id_anc`, `nm_suami`, `tinggi_bdn`, `id_sat_tinggi`, `berat_bdn`, `id_sat_berat`, `hpht`, `htp`, `umur_khmln`, `id_sat_umur`, `kb_terakhir`, `anak_ke`, `haid_terakhir`, `biaya_periksa`) VALUES
('0212180408514738',	1,	'riki',	157,	12,	52,	1,	'2018-03-18',	'2018-12-25',	9,	19,	'2018-12-02',	1,	'0000-00-00',	0),
('2312180237309645',	2,	'afdal',	150,	12,	50,	1,	'2018-12-25',	'2019-10-01',	12,	18,	'2018-12-23',	1,	'2018-12-01',	0),
('2312180248505043',	3,	'david',	150,	12,	50,	1,	'2018-12-27',	'2019-10-03',	12,	18,	'2018-12-23',	1,	'2018-12-18',	20000),
('2512180957082975',	4,	'udin',	156,	12,	56,	1,	'2018-12-12',	'2019-09-19',	9,	18,	'2018-12-25',	1,	'2018-12-01',	20000),
('2512180211454442',	5,	'afdal',	160,	12,	56,	1,	'2018-12-04',	'2019-09-11',	10,	18,	'2018-12-25',	1,	'2018-12-01',	20000);

DROP TABLE IF EXISTS `tbl_asuhan_bayi`;
CREATE TABLE `tbl_asuhan_bayi` (
  `id_asuhan` int(11) NOT NULL AUTO_INCREMENT,
  `nm_asuhan` text NOT NULL,
  PRIMARY KEY (`id_asuhan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_asuhan_bayi` (`id_asuhan`, `nm_asuhan`) VALUES
(1,	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama'),
(2,	'Suntikan Vitamin K1'),
(3,	'Salep mata antibiotika profilaksis'),
(4,	'Imunisasi HBO');

DROP TABLE IF EXISTS `tbl_bayi_lahir`;
CREATE TABLE `tbl_bayi_lahir` (
  `id_bayi` int(11) NOT NULL AUTO_INCREMENT,
  `id_kelahiran` varchar(50) NOT NULL,
  `nm_bayi` varchar(50) NOT NULL,
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_bayi_lahir` (`id_bayi`, `id_kelahiran`, `nm_bayi`, `waktu_lahir`, `anak_ke`, `berat_lahir`, `id_sat_berat`, `panjang_badan`, `id_sat_panjang`, `lingkar_kepala`, `id_sat_lingkar`, `jk`, `asuhan_bayi_saat_lahir`, `keterangan`, `kondisi_bayi`) VALUES
(1,	'K636793640819359454',	'sintia dewi',	'2018-11-26 04:14:43',	4,	500,	4,	49,	12,	34,	12,	'Perempuan',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama \r\nSuntikan Vitamin K1 \r\nSalep mata antibiotika profilaksis \r\nImunisasi HBO \r\n',	'',	'Segera menangis \r\nSeluruh tubuh kemerahan \r\n'),
(2,	'K636793807693117541',	'arif permana',	'2018-12-02 08:52:50',	1,	500,	4,	57,	12,	24,	12,	'Laki-laki',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama \r\nSuntikan Vitamin K1 \r\nSalep mata antibiotika profilaksis \r\nImunisasi HBO \r\n',	'',	'Segera menangis \r\nSeluruh tubuh kemerahan \r\n'),
(3,	'K636813462385756964',	'aliudin',	'2018-12-25 02:50:39',	1,	3500,	4,	45,	12,	39,	12,	'Laki-laki',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama \r\nSuntikan Vitamin K1 \r\nSalep mata antibiotika profilaksis \r\nImunisasi HBO \r\n',	'',	'Segera menangis \r\nMenangis beberapa saat \r\nTidak menangis \r\nSeluruh tubuh kemerahan \r\n'),
(4,	'K636813462385756964',	'zainudin',	'2018-12-25 02:57:11',	2,	3000,	4,	45,	12,	35,	12,	'Laki-laki',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama \r\nSuntikan Vitamin K1 \r\nSalep mata antibiotika profilaksis \r\nImunisasi HBO \r\n',	'',	'Segera menangis \r\nMenangis beberapa saat \r\nTidak menangis \r\nSeluruh tubuh kemerahan \r\n');

DROP TABLE IF EXISTS `tbl_jenis_obat`;
CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jenis_obat` (`id_jobat`, `nm_jobat`) VALUES
(1,	'KB'),
(4,	'Suplemen'),
(7,	'obat luka'),
(8,	'Tambah darah'),
(9,	'mirasiic'),
(10,	'kalsi'),
(11,	'syirup');

DROP TABLE IF EXISTS `tbl_jsatuan`;
CREATE TABLE `tbl_jsatuan` (
  `id_jsat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jsat` varchar(30) NOT NULL,
  PRIMARY KEY (`id_jsat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jsatuan` (`id_jsat`, `nm_jsat`) VALUES
(1,	'Berat'),
(2,	'Panjang'),
(3,	'Waktu'),
(4,	'Banyak'),
(5,	'Tekanan');

DROP TABLE IF EXISTS `tbl_kelahiran`;
CREATE TABLE `tbl_kelahiran` (
  `no_pasien` int(11) NOT NULL,
  `id_kelahiran` varchar(50) NOT NULL,
  `tgl_kelahiran` datetime NOT NULL,
  `nm_suami` varchar(50) NOT NULL,
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
  `nm_bidan` varchar(50) NOT NULL,
  PRIMARY KEY (`id_kelahiran`),
  KEY `no_pasien` (`no_pasien`),
  KEY `id_sat_umur` (`id_sat_umur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_kelahiran` (`no_pasien`, `id_kelahiran`, `tgl_kelahiran`, `nm_suami`, `penolongan_persalinan`, `cara_persalinan`, `keadaan_ibu`, `umur_kehamilan`, `id_sat_umur`, `bulan`, `tensi`, `biaya_persalinan`, `biaya_perawatan_kelas`, `biaya_perawatan_bayi`, `biaya_obat_obatan`, `biaya_cucian`, `biaya_akte_kelahiran`, `biaya_transportasi`, `biaya_lain`, `nm_bidan`) VALUES
(3,	'K636793640819359454',	'2018-11-26 04:14:00',	'adit',	'bidan',	'normal',	'baik',	10,	19,	0,	'110/70',	600000,	200000,	150000,	250000,	90000,	15000,	40000,	50000,	''),
(5,	'K636793807693117541',	'2018-12-02 08:52:00',	'david',	'bidan',	'normal',	'baik',	10,	19,	0,	'110/20',	600000,	240000,	150000,	85000,	90000,	15000,	75000,	40000,	''),
(1,	'K636813457542329935',	'2018-12-25 02:42:00',	'afdal',	'bidan',	'normal',	'sehat',	12,	18,	0,	'120/10',	1000000,	350000,	200000,	80000,	100000,	20000,	340000,	5000,	''),
(5,	'K636813462385756964',	'2018-12-25 02:50:00',	'gilang',	'bidan',	'normal',	'sehat',	12,	18,	0,	'120/10',	1000000,	340000,	200000,	100000,	75000,	20000,	250000,	5000,	''),
(1,	'K636813467604265445',	'2018-12-25 02:50:00',	'david',	'bidan',	'normal',	'sehat',	11,	18,	12,	'120/10',	1000000,	340000,	200000,	100000,	75000,	20000,	250000,	5000,	'');

DROP TABLE IF EXISTS `tbl_kondisi_lahir`;
CREATE TABLE `tbl_kondisi_lahir` (
  `id_kondisi` int(11) NOT NULL AUTO_INCREMENT,
  `nm_kondisi` text NOT NULL,
  PRIMARY KEY (`id_kondisi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_kondisi_lahir` (`id_kondisi`, `nm_kondisi`) VALUES
(1,	'Segera menangis'),
(2,	'Menangis beberapa saat'),
(3,	'Tidak menangis'),
(4,	'Seluruh tubuh kemerahan'),
(5,	'Anggota gerak kebiruan'),
(6,	'Seluruh tubuh biru'),
(7,	'Kelainan bawaan'),
(8,	'Meninggal');

DROP TABLE IF EXISTS `tbl_obat`;
CREATE TABLE `tbl_obat` (
  `id_obat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_obat` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `id_jobat` int(11) NOT NULL,
  `hrg_obat` int(11) NOT NULL,
  `id_sat_obat` int(11) NOT NULL DEFAULT '25',
  `tgl_masuk` date NOT NULL,
  PRIMARY KEY (`id_obat`),
  KEY `id_jobat` (`id_jobat`),
  KEY `id_sat_obat` (`id_sat_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_obat` (`id_obat`, `nm_obat`, `stok`, `status`, `id_jobat`, `hrg_obat`, `id_sat_obat`, `tgl_masuk`) VALUES
(2,	'caviplex',	4,	'Aktif',	4,	10000,	25,	'0000-00-00'),
(3,	'vitonal-f',	7,	'Aktif',	8,	10000,	25,	'0000-00-00'),
(4,	'etabion',	9,	'Aktif',	4,	10000,	25,	'0000-00-00'),
(5,	'andalan pil KB',	5,	'Aktif',	1,	15000,	25,	'0000-00-00'),
(6,	'cylofem (suntik)',	9,	'Aktif',	1,	20000,	23,	'0000-00-00'),
(7,	'zetamol(pcl)',	49,	'Aktif',	9,	10000,	22,	'0000-00-00'),
(8,	'paracetamol',	18,	'Aktif',	9,	15000,	25,	'0000-00-00'),
(9,	'vitamin C',	8,	'Aktif',	4,	2000,	22,	'0000-00-00'),
(10,	'dapyrin(pcl)',	10,	'Aktif',	11,	15000,	27,	'0000-00-00'),
(11,	'roverton',	10,	'Aktif',	11,	15000,	27,	'0000-00-00'),
(12,	'guanistreep',	10,	'Aktif',	11,	15000,	27,	'0000-00-00');

DROP TABLE IF EXISTS `tbl_pasien`;
CREATE TABLE `tbl_pasien` (
  `no_pasien` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pasien` varchar(50) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk` enum('Laki-laki','Perempuan') NOT NULL,
  `pekerjaan` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `tgl_daftar` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pasien` (`no_pasien`, `nm_pasien`, `tgl_lahir`, `jk`, `pekerjaan`, `alamat`, `tgl_daftar`) VALUES
(1,	'yuli',	'1993-12-09',	'Perempuan',	'rumah tangga',	'buluh kasok',	'2018-12-16 08:12:29'),
(2,	'david',	'1995-02-09',	'Laki-laki',	'mahasiswa',	'padang sago',	'2018-12-16 08:12:29'),
(3,	'dewi',	'1990-04-12',	'Perempuan',	'pegawai negri',	'bisati',	'2018-12-16 08:12:29'),
(4,	'budi',	'1994-12-08',	'Laki-laki',	'wiraswasta',	'sungai sariak',	'2018-12-16 08:12:29'),
(5,	'melda',	'1992-09-17',	'Perempuan',	'wirausaha',	'balaibaru',	'2018-12-16 08:12:29'),
(6,	'ojanjaya',	'1996-03-16',	'Laki-laki',	'mahasiswa',	'pariaman',	'2018-12-21 02:24:56'),
(7,	'afdal',	'1995-09-23',	'Laki-laki',	'mahasiswa',	'padang',	'2018-12-23 07:14:48');

DROP TABLE IF EXISTS `tbl_periksa`;
CREATE TABLE `tbl_periksa` (
  `id_periksa` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `no_pasien` int(11) NOT NULL,
  `keluhan` text,
  `tensi` varchar(9) NOT NULL,
  `id_sat_tensi` int(11) NOT NULL DEFAULT '26',
  `nm_bidan` varchar(50) NOT NULL,
  PRIMARY KEY (`id_periksa`),
  KEY `id_sat_tensi` (`id_sat_tensi`),
  KEY `no_pasien` (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_periksa` (`id_periksa`, `tgl_periksa`, `no_pasien`, `keluhan`, `tensi`, `id_sat_tensi`, `nm_bidan`) VALUES
('0212180408514738',	'2018-12-02 09:13:34',	1,	'ibu G:2P:0A:1',	'100/60',	26,	''),
('0212180851300262',	'2018-12-02 13:52:37',	4,	'batuk, demam, sakit kepala',	'100/10',	26,	''),
('021220180850155389',	'2018-12-02 13:51:14',	3,	'Pemeriksaan/Pemasangan KB',	'110/20',	26,	''),
('2312180233586143',	'2018-12-23 07:34:37',	1,	'',	'120/10',	26,	''),
('2312180237309645',	'2018-12-23 07:38:29',	1,	'',	'120/10',	26,	''),
('2312180248505043',	'2018-12-23 07:50:04',	1,	'',	'120/20',	26,	''),
('2512180211454442',	'2018-12-25 07:21:33',	1,	'mual-mual\r\nG:2 P:0 A:1',	'130/10',	26,	''),
('2512180957082975',	'2018-12-25 03:00:23',	3,	'mual-mual\r\n',	'120/20',	26,	'');

DROP TABLE IF EXISTS `tbl_periksa_kb`;
CREATE TABLE `tbl_periksa_kb` (
  `id_periksa_kb` int(11) NOT NULL AUTO_INCREMENT,
  `id_periksa` varchar(50) NOT NULL,
  `nm_suami` varchar(50) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `haid_terakhir` date NOT NULL,
  `berat_badan` int(11) NOT NULL,
  `id_sat_berat` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_periksa_kb`),
  KEY `id_sat_berat` (`id_sat_berat`),
  KEY `id_periksa` (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_periksa_kb` (`id_periksa_kb`, `id_periksa`, `nm_suami`, `anak_ke`, `haid_terakhir`, `berat_badan`, `id_sat_berat`) VALUES
(1,	'021220180850155389',	'ari',	2,	'2018-11-19',	54,	1);

DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  `id_jsat` int(11) NOT NULL,
  PRIMARY KEY (`id_sat`),
  KEY `id_jsat` (`id_jsat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_satuan` (`id_sat`, `nm_sat`, `id_jsat`) VALUES
(1,	'Kg',	1),
(2,	'Hg',	1),
(3,	'Dag',	1),
(4,	'Gr',	1),
(6,	'Mg',	1),
(7,	'Km',	2),
(8,	'Hm',	2),
(9,	'Dam',	2),
(10,	'M',	2),
(11,	'Dm',	2),
(12,	'Cm',	2),
(13,	'Mm',	2),
(14,	'Detik',	3),
(15,	'Menit',	3),
(16,	'Jam',	3),
(17,	'Hari',	3),
(18,	'Minggu',	3),
(19,	'Bulan',	3),
(20,	'Tahun',	3),
(21,	'Dg',	1),
(22,	'kaplet',	4),
(23,	'vial',	4),
(25,	'strip',	4),
(26,	'MMHG',	5),
(27,	'Botol',	4),
(28,	'Sachet',	4),
(29,	'tablet',	0),
(32,	'tablet',	0),
(33,	'tablet',	0),
(34,	'tablet',	0);

DROP TABLE IF EXISTS `tbl_terapi`;
CREATE TABLE `tbl_terapi` (
  `id_terapi` int(11) NOT NULL AUTO_INCREMENT,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_periksa` varchar(50) NOT NULL,
  PRIMARY KEY (`id_terapi`),
  KEY `id_obat` (`id_obat`),
  KEY `id_periksa` (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_terapi` (`id_terapi`, `id_obat`, `jumlah`, `id_periksa`) VALUES
(1,	3,	1,	'0212180408514738'),
(2,	2,	1,	'0212180408514738'),
(3,	6,	1,	'021220180850155389'),
(4,	7,	1,	'0212180851300262'),
(5,	9,	2,	'0212180851300262'),
(6,	2,	1,	'0212180851300262'),
(7,	2,	2,	'2312180233586143'),
(8,	3,	2,	'2312180237309645'),
(9,	4,	1,	'2312180248505043'),
(10,	8,	2,	'2512180957082975'),
(12,	2,	2,	'2512180211454442');

DELIMITER ;;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_terapi` FOR EACH ROW
update tbl_obat set stok = stok - new.jumlah where id_obat = new.id_obat;;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_terapi` FOR EACH ROW
update tbl_obat set stok = stok + OLD.jumlah where id_obat = OLD.id_obat;;

DELIMITER ;

DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `jenis` enum('Admin','Bidan','Pemilik') NOT NULL,
  `nama` varchar(50) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_user` (`id_user`, `username`, `password`, `jenis`, `nama`) VALUES
(1,	'admin',	'21232f297a57a5a743894a0e4a801fc3',	'Admin',	'Admin'),
(2,	'bidan',	'cc274f4730ce350f1cf60e73f4172d67',	'Bidan',	'bidan'),
(3,	'pimpinan',	'90973652b88fe07d05a4304f0a945de8',	'Pemilik',	'pimpinan');

DROP TABLE IF EXISTS `daftar_kelahiran`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_kelahiran` AS select `a`.`no_pasien` AS `No_Pasien`,`a`.`bulan` AS `bulan`,`b`.`umur` AS `umur`,concat(`a`.`tensi`,' MMHG') AS `tensi`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`b`.`Alamat` AS `Alamat`,`a`.`id_kelahiran` AS `Id_Kelahiran`,`a`.`tgl_kelahiran` AS `Tanggal_Kelahiran`,`a`.`nm_suami` AS `Nama_Suami`,`a`.`penolongan_persalinan` AS `Penolongan_Persalinan`,`a`.`cara_persalinan` AS `Cara_Persalinan`,`a`.`keadaan_ibu` AS `Keadaan_Ibu`,concat(`a`.`umur_kehamilan`,' ',`c`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`biaya_persalinan` AS `Biaya_Persalinan`,`a`.`biaya_perawatan_kelas` AS `Biaya_Perawatan`,`a`.`biaya_perawatan_bayi` AS `Biaya_Perawatan_Bayi`,`a`.`biaya_obat_obatan` AS `Biaya_Obat_Obatan`,`a`.`biaya_cucian` AS `Biaya_Cucian`,`a`.`biaya_akte_kelahiran` AS `Biaya_Akte`,`a`.`biaya_transportasi` AS `Biaya_Transportasi`,`a`.`biaya_lain` AS `Biaya_Lain`,(((((((`a`.`biaya_persalinan` + `a`.`biaya_perawatan_kelas`) + `a`.`biaya_perawatan_bayi`) + `a`.`biaya_obat_obatan`) + `a`.`biaya_cucian`) + `a`.`biaya_akte_kelahiran`) + `a`.`biaya_transportasi`) + `a`.`biaya_lain`) AS `Total_Bayar`,`a`.`nm_bidan` AS `nm_bidan` from ((`tbl_kelahiran` `a` join `daftar_pasien` `b` on((`a`.`no_pasien` = `b`.`No_Pasien`))) join `daftar_satuan` `c` on((`a`.`id_sat_umur` = `c`.`Id_Sat`)));

DROP TABLE IF EXISTS `daftar_obat`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat` AS select `a`.`id_obat` AS `Id_Obat`,`a`.`nm_obat` AS `Nama_Obat`,`a`.`stok` AS `Stok`,`b`.`id_jobat` AS `Id_Jobat`,`b`.`nm_jobat` AS `Jenis_Obat`,`a`.`id_sat_obat` AS `Id_Sat_Obat`,`a`.`tgl_masuk` AS `Tanggal`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_obat` AS `Harga_Obat` from ((`tbl_obat` `a` join `tbl_jenis_obat` `b` on((`a`.`id_jobat` = `b`.`id_jobat`))) join `daftar_satuan` `c` on((`a`.`id_sat_obat` = `c`.`Id_Sat`)));

DROP TABLE IF EXISTS `daftar_obat_beli`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat_beli` AS select `a`.`id_terapi` AS `Id_Terapi`,`a`.`id_obat` AS `Id_Obat`,`a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from ((`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) left join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) group by `a`.`id_periksa`,`a`.`id_obat`;

DROP TABLE IF EXISTS `daftar_pasien`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_pasien` AS select `tbl_pasien`.`no_pasien` AS `No_Pasien`,`tbl_pasien`.`nm_pasien` AS `Nama_Pasien`,timestampdiff(YEAR,`tbl_pasien`.`tgl_lahir`,now()) AS `umur`,`tbl_pasien`.`tgl_lahir` AS `Tanggal_Lahir`,`tbl_pasien`.`jk` AS `Jenis_Kelamin`,`tbl_pasien`.`pekerjaan` AS `Pekerjaan`,`tbl_pasien`.`alamat` AS `Alamat` from `tbl_pasien`;

DROP TABLE IF EXISTS `daftar_pasien_revisi`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_pasien_revisi` AS select `tbl_pasien`.`no_pasien` AS `no_reg`,`tbl_pasien`.`tgl_daftar` AS `tgl_daftar`,`tbl_pasien`.`nm_pasien` AS `Nama_Pasien`,timestampdiff(YEAR,`tbl_pasien`.`tgl_lahir`,now()) AS `umur`,`tbl_pasien`.`tgl_lahir` AS `Tanggal_Lahir`,`tbl_pasien`.`jk` AS `Jenis_Kelamin`,`tbl_pasien`.`pekerjaan` AS `Pekerjaan`,`tbl_pasien`.`alamat` AS `Alamat` from `tbl_pasien`;

DROP TABLE IF EXISTS `daftar_satuan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_jsatuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));

DROP TABLE IF EXISTS `laporan_anc`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_anc` AS select `a`.`haid_terakhir` AS `haid_terakhir`,`a`.`id_anc` AS `Id_Anc`,`c`.`tgl_periksa` AS `tgl_periksa`,`c`.`keluhan` AS `keluhan`,`c`.`no_pasien` AS `no_pasien`,`a`.`anak_ke` AS `anak_ke`,`c`.`tensi` AS `tensi`,`d`.`Nama_Pasien` AS `nm_pasien`,`a`.`id_periksa` AS `Id_Periksa`,`a`.`nm_suami` AS `Nama_Suami`,`d`.`umur` AS `umur`,`d`.`Alamat` AS `alamat`,concat(`a`.`tinggi_bdn`,' ',`sat_tinggi`.`Nama_Satuan`) AS `Tinggi_Badan`,concat(`a`.`berat_bdn`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Badan`,concat('HPHT ',`a`.`hpht`,', HTP ',`a`.`htp`) AS `diagnosa_anc`,concat(`a`.`umur_khmln`,' ',`sat_umur`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`kb_terakhir` AS `KB_Terakhir`,(select group_concat(`daftar_obat_beli`.`Nama_Obat`,'\n' separator ',') from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`)) AS `Obat`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((((`tbl_anc` `a` join `daftar_satuan` `sat_tinggi` on((`a`.`id_sat_tinggi` = `sat_tinggi`.`Id_Sat`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_umur` on((`a`.`id_sat_umur` = `sat_umur`.`Id_Sat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) join `daftar_pasien` `d` on((`c`.`no_pasien` = `d`.`No_Pasien`)));

DROP TABLE IF EXISTS `laporan_bayi_lahir`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_bayi_lahir` AS select `b`.`Id_Kelahiran` AS `Id_Kelahiran`,`b`.`Tanggal_Kelahiran` AS `Tanggal_Kelahiran`,`b`.`No_Pasien` AS `No_Pasien`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`nm_bayi` AS `Nama_Bayi`,`a`.`waktu_lahir` AS `Waktu_Lahir`,`a`.`anak_ke` AS `Anak_Ke`,concat(`a`.`berat_lahir`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Lahir`,concat(`a`.`panjang_badan`,' ',`sat_panjang`.`Nama_Satuan`) AS `Panjang_Badan`,concat(`a`.`lingkar_kepala`,' ',`sat_lingkar`.`Nama_Satuan`) AS `Lingkar_Kepala`,`a`.`jk` AS `Jenis_Kelamin`,`a`.`asuhan_bayi_saat_lahir` AS `Asuhan_Bayi_Saat_Lahir`,`a`.`keterangan` AS `Keterangan`,`a`.`kondisi_bayi` AS `Kondisi Bayi`,`b`.`nm_bidan` AS `nm_bidan` from ((((`tbl_bayi_lahir` `a` join `daftar_kelahiran` `b` on((`a`.`id_kelahiran` = `b`.`Id_Kelahiran`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_panjang` on((`a`.`id_sat_panjang` = `sat_panjang`.`Id_Sat`))) join `daftar_satuan` `sat_lingkar` on((`a`.`id_sat_lingkar` = `sat_lingkar`.`Id_Sat`)));

DROP TABLE IF EXISTS `laporan_berobat_umum`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_berobat_umum` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`Nama_Pasien` AS `Nama_Pasien`,`c`.`Alamat` AS `Alamat`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`no_pasien` AS `No_Pasien`,timestampdiff(YEAR,`c`.`Tanggal_Lahir`,now()) AS `umur`,`e`.`Tinggi_Badan` AS `Tinggi_Badan`,`e`.`Berat_Badan` AS `Berat_Badan`,`a`.`keluhan` AS `Keluhan`,`e`.`diagnosa_anc` AS `Diagnosa ANC`,concat(`a`.`tensi`,' ',`sat`.`Nama_Satuan`) AS `Tensi`,(select group_concat(`daftar_obat_beli`.`Nama_Obat`,' ',`daftar_obat_beli`.`Jumlah`,'\n' separator ',') from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`)) AS `obat`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id_Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No_Pasien`))) left join `laporan_anc` `e` on((`a`.`id_periksa` = `e`.`Id_Periksa`))) where (`a`.`keluhan` <> 'Pemeriksaan/Pemasangan KB');

DROP TABLE IF EXISTS `laporan_bulanan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_bulanan` AS select `laporan_pemasukan`.`Tgl_Periksa` AS `Tgl_Periksa`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_harga` from `laporan_pemasukan` where ((month(`laporan_pemasukan`.`Tgl_Periksa`) = month(now())) and (year(`laporan_pemasukan`.`Tgl_Periksa`) = year(now()))) group by dayofmonth(`laporan_pemasukan`.`Tgl_Periksa`);

DROP TABLE IF EXISTS `laporan_harian`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_harian` AS select `laporan_pemasukan`.`Tgl_Periksa` AS `Tgl_Periksa`,dayofmonth(`laporan_pemasukan`.`Tgl_Periksa`) AS `hari`,`laporan_pemasukan`.`Nama_Obat` AS `Nama_Obat`,sum(`laporan_pemasukan`.`Jumlah`) AS `Jumlah`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_harga` from `laporan_pemasukan` group by `laporan_pemasukan`.`Tgl_Periksa`,`laporan_pemasukan`.`Nama_Obat`;

DROP TABLE IF EXISTS `laporan_kb`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_kb` AS select `f`.`Id_Periksa` AS `Id_Periksa`,`f`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`nm_suami` AS `nm_suami`,`f`.`Tanggal_Periksa` AS `Tanggal_Periksa`,`f`.`No_Pasien` AS `No_Pasien`,`f`.`Tinggi_Badan` AS `Tinggi_Badan`,`f`.`Alamat` AS `Alamat`,`f`.`umur` AS `umur`,concat(`a`.`berat_badan`,' ',`d`.`Nama_Satuan`) AS `Berat_Badan`,`f`.`Keluhan` AS `Keluhan`,`f`.`Tensi` AS `Tensi`,`a`.`anak_ke` AS `Anak_Ke`,`a`.`haid_terakhir` AS `Haid_Terakhir`,`a`.`id_sat_berat` AS `Id_Sat_Berat`,`b`.`Nama_Obat` AS `Nama_Obat`,concat(`b`.`Jumlah`,' ',`b`.`Satuan`) AS `Jumlah`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((`tbl_periksa_kb` `a` left join `laporan_rekap_pasien` `f` on((convert(`a`.`id_periksa` using utf8) = convert(`f`.`Id_Periksa` using utf8)))) join `laporan_terapi` `b` on((convert(`a`.`id_periksa` using utf8) = convert(`b`.`Id_Periksa` using utf8)))) join `daftar_satuan` `d` on((`a`.`id_sat_berat` = `d`.`Id_Sat`)));

DROP TABLE IF EXISTS `laporan_pemasukan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_pemasukan` AS select `a`.`id_terapi` AS `Id_Terapi`,`a`.`id_obat` AS `Id_Obat`,`a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from ((`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) group by `a`.`id_periksa`,`a`.`id_obat`;

DROP TABLE IF EXISTS `laporan_pemasukan_anc`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_pemasukan_anc` AS select `a`.`id_periksa` AS `id_periksa`,`b`.`biaya_periksa` AS `biaya_periksa`,`a`.`tgl_periksa` AS `tgl_periksa` from (`tbl_anc` `b` left join `tbl_periksa` `a` on((`a`.`id_periksa` = `b`.`id_periksa`)));

DROP TABLE IF EXISTS `laporan_rekap_pasien`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_rekap_pasien` AS select `a`.`id_periksa` AS `Id_Periksa`,`a`.`nm_bidan` AS `Nama_Bidan`,`c`.`Nama_Pasien` AS `Nama_Pasien`,`c`.`Alamat` AS `Alamat`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`no_pasien` AS `No_Pasien`,timestampdiff(YEAR,`c`.`Tanggal_Lahir`,now()) AS `umur`,`e`.`Tinggi_Badan` AS `Tinggi_Badan`,`e`.`Berat_Badan` AS `Berat_Badan`,`a`.`keluhan` AS `Keluhan`,`e`.`diagnosa_anc` AS `Diagnosa ANC`,concat(`a`.`tensi`,' ',`sat`.`Nama_Satuan`) AS `Tensi`,(select group_concat(`daftar_obat_beli`.`Nama_Obat`,' ',`daftar_obat_beli`.`Jumlah`,'\n' separator ',') from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`)) AS `obat`,(select sum(`daftar_obat_beli`.`Total_Harga`) from `daftar_obat_beli` where (`daftar_obat_beli`.`Id_Periksa` = `a`.`id_periksa`) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`)) AS `Total_Bayar` from (((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id_Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No_Pasien`))) left join `laporan_anc` `e` on((`a`.`id_periksa` = `e`.`Id_Periksa`)));

DROP TABLE IF EXISTS `laporan_tahunan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_tahunan` AS select `laporan_pemasukan`.`Tgl_Periksa` AS `Tgl_Periksa`,sum(`laporan_pemasukan`.`Total_Harga`) AS `Total_harga` from `laporan_pemasukan` where (year(`laporan_pemasukan`.`Tgl_Periksa`) = year(now())) group by month(`laporan_pemasukan`.`Tgl_Periksa`);

DROP TABLE IF EXISTS `laporan_terapi`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_terapi` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`a`.`id_obat` AS `Id_Obat`,`b`.`Nama_Obat` AS `Nama_Obat`,`b`.`Harga_Obat` AS `Harga_Obat`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_Obat`) AS `Total`,`b`.`Satuan` AS `Satuan` from ((`tbl_terapi` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id_Obat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`)));

DROP TABLE IF EXISTS `pemasukan_anc`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `pemasukan_anc` AS select `aa`.`Id_Periksa` AS `Id_Periksa`,`bb`.`tgl_periksa` AS `tgl_periksa`,sum((`aa`.`Total_Harga` + `bb`.`biaya_periksa`)) AS `total_pemasukan` from (`laporan_pemasukan_anc` `bb` left join `laporan_pemasukan` `aa` on((`aa`.`Id_Periksa` = `bb`.`id_periksa`))) group by `aa`.`Id_Periksa`;

DROP TABLE IF EXISTS `pemasukan_berobat`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `pemasukan_berobat` AS select cast(`laporan_berobat_umum`.`Tanggal_Periksa` as date) AS `Tanggal_Berobat`,sum(`laporan_berobat_umum`.`Total_Bayar`) AS `Total_Pemasukan_Berobat` from `laporan_berobat_umum` group by dayofmonth(`laporan_berobat_umum`.`Tanggal_Periksa`);

DROP TABLE IF EXISTS `pemasukan_kb`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `pemasukan_kb` AS select cast(`laporan_kb`.`Tanggal_Periksa` as date) AS `Tanggal_Kb`,sum(`laporan_kb`.`Total_Bayar`) AS `Total_Pemasukan_Kb` from `laporan_kb` group by dayofmonth(`laporan_kb`.`Tanggal_Periksa`);

DROP TABLE IF EXISTS `pemasukan_kelahiran`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `pemasukan_kelahiran` AS select cast(`daftar_kelahiran`.`Tanggal_Kelahiran` as date) AS `Tanggal_Kelahiran`,sum(`daftar_kelahiran`.`Total_Bayar`) AS `Total_Pemasukan_Kelahiran` from `daftar_kelahiran` group by dayofmonth(`daftar_kelahiran`.`Tanggal_Kelahiran`);

-- 2019-01-13 11:06:36
