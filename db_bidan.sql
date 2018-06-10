-- Adminer 4.6.2 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP VIEW IF EXISTS `daftar_kelahiran`;
CREATE TABLE `daftar_kelahiran` (`No_Pasien` int(11), `Nama_Pasien` varchar(100), `Alamat` varchar(250), `Id_Kelahiran` varchar(50), `Tanggal_Kelahiran` datetime, `Nama_Suami` varchar(100), `Penolongan_Persalinan` text, `Cara_Persalinan` text, `Keadaan_Ibu` text, `Umur_Kehamilan` varchar(42), `Biaya_Persalinan` int(11), `Biaya_Perawatan` int(11), `Biaya_Perawatan_Bayi` int(11), `Biaya_Obat_Obatan` int(11), `Biaya_Cucian` int(11), `Biaya_Akte` int(11), `Biaya_Transportasi` int(11), `Biaya_Lain` int(11));


DROP VIEW IF EXISTS `daftar_obat`;
CREATE TABLE `daftar_obat` (`Id_Obat` int(11), `Nama_Obat` varchar(50), `Stok` int(11), `Id_Jobat` int(11), `Jenis_Obat` varchar(50), `Id_Sat_Obat` int(11), `Satuan` varchar(30), `Harga_Obat` int(11));


DROP VIEW IF EXISTS `daftar_obat_beli`;
CREATE TABLE `daftar_obat_beli` (`Id_Terapi` int(11), `Id_Obat` int(11), `Id_Periksa` varchar(50), `Nama_Obat` varchar(50), `Jumlah` decimal(32,0), `Harga_Obat` int(11), `Total_Harga` decimal(42,0));


DROP VIEW IF EXISTS `daftar_pasien`;
CREATE TABLE `daftar_pasien` (`No_Pasien` int(11), `Nama_Pasien` varchar(100), `Tanggal_Lahir` varchar(10), `Jenis_Kelamin` enum('Laki-laki','Perempuan'), `Pekerjaan` varchar(100), `Alamat` varchar(250));


DROP VIEW IF EXISTS `daftar_satuan`;
CREATE TABLE `daftar_satuan` (`Id_Sat` int(11), `Nama_Satuan` varchar(30), `Id_Jsat` int(11), `Nama_Jenis_Satuan` varchar(30));


DROP VIEW IF EXISTS `laporan_anc`;
CREATE TABLE `laporan_anc` (`Id_Anc` int(11), `Id_Periksa` varchar(50), `Nama_Suami` varchar(100), `Tinggi_Badan` varchar(37), `Berat_Badan` varchar(37), `hpht` date, `htp` date, `Umur_Kehamilan` varchar(42), `KB_Terakhir` date);


DROP VIEW IF EXISTS `laporan_bayi_lahir`;
CREATE TABLE `laporan_bayi_lahir` (`Id_Kelahiran` varchar(50), `Tanggal_Kelahiran` datetime, `No_Pasien` int(11), `Nama_Pasien` varchar(100), `Nama_Bayi` varchar(100), `Waktu_Lahir` datetime, `Anak_Ke` int(11), `Berat_Lahir` varchar(42), `Panjang_Badan` varchar(42), `Lingkar_Kepala` varchar(42), `Jenis_Kelamin` varchar(30), `Asuhan_Bayi_Saat_Lahir` text, `Keterangan` text, `Kondisi Bayi` text);


DROP VIEW IF EXISTS `laporan_kb`;
CREATE TABLE `laporan_kb` (`No_Pasien` int(11), `Nama_Pasien` varchar(100), `Tanggal_Lahir` date, `Tanggal_Periksa` timestamp, `Anak_Ke` int(11), `Haid_Terakhir` date, `Berat_Badan` varchar(42), `Id_Sat_Berat` int(11), `Tensi` varchar(40), `Id_Sat_Tensi` int(11), `Nama_Obat` varchar(50), `Jumlah` varchar(42));


DROP VIEW IF EXISTS `laporan_pemasukan`;
CREATE TABLE `laporan_pemasukan` (`id_terapi` int(11), `id_periksa` varchar(50), `nm_obat` varchar(50), `jumlah` decimal(32,0), `total_bayar` decimal(42,0));


DROP VIEW IF EXISTS `laporan_rekap_pasien`;
CREATE TABLE `laporan_rekap_pasien` (`Id_Periksa` varchar(50), `Nama_Pasien` varchar(100), `Tanggal_Periksa` timestamp, `No_Pasien` int(11), `Tinggi_Badan` varchar(37), `Berat_Badan` varchar(37), `Keluhan/Diagnosa` varchar(215), `Tensi` varchar(40));


DROP VIEW IF EXISTS `laporan_terapi`;
CREATE TABLE `laporan_terapi` (`Id_Periksa` varchar(50), `Id_Obat` int(11), `Nama_Obat` varchar(50), `Harga_Obat` int(11), `Jumlah` int(11), `Total` bigint(21), `Satuan` varchar(30));


DROP TABLE IF EXISTS `tbl_anc`;
CREATE TABLE `tbl_anc` (
  `id_periksa` varchar(50) NOT NULL,
  `id_anc` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suami` varchar(100) NOT NULL,
  `tinggi_bdn` smallint(6) NOT NULL,
  `id_sat_tinggi` int(11) NOT NULL DEFAULT '12',
  `berat_bdn` smallint(6) NOT NULL,
  `id_sat_berat` varchar(3) NOT NULL DEFAULT '1',
  `hpht` date NOT NULL,
  `htp` date NOT NULL,
  `umur_khmln` int(11) NOT NULL,
  `id_sat_umur` int(11) NOT NULL DEFAULT '18',
  `kb_terakhir` date NOT NULL,
  PRIMARY KEY (`id_anc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_anc` (`id_periksa`, `id_anc`, `nm_suami`, `tinggi_bdn`, `id_sat_tinggi`, `berat_bdn`, `id_sat_berat`, `hpht`, `htp`, `umur_khmln`, `id_sat_umur`, `kb_terakhir`) VALUES
('0806181056441169',	1,	'sad',	110,	12,	33,	'1',	'2018-06-08',	'2018-06-08',	19,	18,	'2018-06-08'),
('0806181057142787',	2,	'dedeeded',	21,	9,	21,	'6',	'2018-06-08',	'2018-06-08',	21,	16,	'2018-06-08'),
('0806181100300645',	3,	'adssa',	22,	12,	500,	'1',	'2018-06-08',	'2018-06-08',	221,	18,	'2018-06-08'),
('1006180513065195',	4,	'Suami dia',	36,	12,	26,	'1',	'2018-06-13',	'2018-06-15',	30,	18,	'2018-06-10')
ON DUPLICATE KEY UPDATE `id_periksa` = VALUES(`id_periksa`), `id_anc` = VALUES(`id_anc`), `nm_suami` = VALUES(`nm_suami`), `tinggi_bdn` = VALUES(`tinggi_bdn`), `id_sat_tinggi` = VALUES(`id_sat_tinggi`), `berat_bdn` = VALUES(`berat_bdn`), `id_sat_berat` = VALUES(`id_sat_berat`), `hpht` = VALUES(`hpht`), `htp` = VALUES(`htp`), `umur_khmln` = VALUES(`umur_khmln`), `id_sat_umur` = VALUES(`id_sat_umur`), `kb_terakhir` = VALUES(`kb_terakhir`);

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
(4,	'Imunisasi HBO')
ON DUPLICATE KEY UPDATE `id_asuhan` = VALUES(`id_asuhan`), `nm_asuhan` = VALUES(`nm_asuhan`);

DROP TABLE IF EXISTS `tbl_bayi_lahir`;
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
  PRIMARY KEY (`id_bayi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_bayi_lahir` (`id_bayi`, `id_kelahiran`, `nm_bayi`, `waktu_lahir`, `anak_ke`, `berat_lahir`, `id_sat_berat`, `panjang_badan`, `id_sat_panjang`, `lingkar_kepala`, `id_sat_lingkar`, `jk`, `asuhan_bayi_saat_lahir`, `keterangan`, `kondisi_bayi`) VALUES
(1,	'K636641802237027678',	'111',	NULL,	111,	11,	4,	11,	12,	11,	12,	'Laki-laki',	'Menangis beberapa saat\r\n',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n',	'ffdsds'),
(2,	'K636641809038929219',	'11',	NULL,	11,	11,	4,	11,	12,	11,	12,	'Laki-laki',	'Segera menangis\r\nMenangis beberapa saat\r\n',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n',	'cdcddc'),
(3,	'K636641809038929219',	'222',	NULL,	22,	22,	4,	1,	10,	1,	10,	'Laki-laki',	'Segera \\n menangis\r\nMenangis beberapa saat\r\nSegera menangis\r\nMenangis beberapa saat\r\n',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\nInisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n',	''),
(4,	'K636642335804933123',	'Bayi Pertama',	NULL,	1,	20,	4,	30,	12,	20,	12,	'Laki-laki',	'',	'',	''),
(5,	'K636642335804933123',	'Bayi Keduia',	NULL,	2,	23,	4,	27,	12,	24,	12,	'Perempuan',	'',	'',	'')
ON DUPLICATE KEY UPDATE `id_bayi` = VALUES(`id_bayi`), `id_kelahiran` = VALUES(`id_kelahiran`), `nm_bayi` = VALUES(`nm_bayi`), `waktu_lahir` = VALUES(`waktu_lahir`), `anak_ke` = VALUES(`anak_ke`), `berat_lahir` = VALUES(`berat_lahir`), `id_sat_berat` = VALUES(`id_sat_berat`), `panjang_badan` = VALUES(`panjang_badan`), `id_sat_panjang` = VALUES(`id_sat_panjang`), `lingkar_kepala` = VALUES(`lingkar_kepala`), `id_sat_lingkar` = VALUES(`id_sat_lingkar`), `jk` = VALUES(`jk`), `asuhan_bayi_saat_lahir` = VALUES(`asuhan_bayi_saat_lahir`), `keterangan` = VALUES(`keterangan`), `kondisi_bayi` = VALUES(`kondisi_bayi`);

DROP TABLE IF EXISTS `tbl_jenis_obat`;
CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jenis_obat` (`id_jobat`, `nm_jobat`) VALUES
(1,	'KB'),
(2,	'Ringan'),
(3,	'Keras'),
(4,	'Suplemen')
ON DUPLICATE KEY UPDATE `id_jobat` = VALUES(`id_jobat`), `nm_jobat` = VALUES(`nm_jobat`);

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
(5,	'Tekanan')
ON DUPLICATE KEY UPDATE `id_jsat` = VALUES(`id_jsat`), `nm_jsat` = VALUES(`nm_jsat`);

DROP TABLE IF EXISTS `tbl_kelahiran`;
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
  `biaya_persalinan` int(11) NOT NULL,
  `biaya_perawatan_kelas` int(11) NOT NULL,
  `biaya_perawatan_bayi` int(11) NOT NULL,
  `biaya_obat_obatan` int(11) NOT NULL,
  `biaya_cucian` int(11) NOT NULL,
  `biaya_akte_kelahiran` int(11) NOT NULL,
  `biaya_transportasi` int(11) NOT NULL,
  `biaya_lain` int(11) NOT NULL,
  PRIMARY KEY (`id_kelahiran`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_kelahiran` (`no_pasien`, `id_kelahiran`, `tgl_kelahiran`, `nm_suami`, `penolongan_persalinan`, `cara_persalinan`, `keadaan_ibu`, `umur_kehamilan`, `id_sat_umur`, `biaya_persalinan`, `biaya_perawatan_kelas`, `biaya_perawatan_bayi`, `biaya_obat_obatan`, `biaya_cucian`, `biaya_akte_kelahiran`, `biaya_transportasi`, `biaya_lain`) VALUES
(4,	'K636641809038929219',	'2018-06-09 10:41:00',	'ewewde',	'weed',	'dee',	'sde',	6,	18,	250000,	250000,	250000,	250000,	375000,	375000,	375000,	250000),
(4,	'K636642335804933123',	'2018-06-10 01:19:00',	'SUami DIa',	'Pernolongan',	'Persalinan',	'Keadaan Ibu',	30,	18,	250000,	250000,	750000,	500000,	500000,	375000,	125000,	125000),
(4,	'K636642478710899943',	'2018-06-10 05:17:00',	'Suami Ku',	'Penolongnya adalah',	'Cara persalinan',	'Keadaan Ibu',	42,	18,	625000,	625000,	625000,	625000,	750000,	625000,	750000,	750000),
(4,	'K636642482685807961',	'2018-06-10 05:24:00',	'asds',	'saddsa',	'asdas',	'asdssd',	3,	18,	250000,	250000,	250000,	250000,	250000,	250000,	250000,	250000),
(4,	'K636642486790273536',	'2018-06-10 05:31:00',	'Suami Ku',	'dadw',	'ddasdas',	'assasa',	21,	18,	375000,	375000,	375000,	375000,	375000,	375000,	375000,	375000)
ON DUPLICATE KEY UPDATE `no_pasien` = VALUES(`no_pasien`), `id_kelahiran` = VALUES(`id_kelahiran`), `tgl_kelahiran` = VALUES(`tgl_kelahiran`), `nm_suami` = VALUES(`nm_suami`), `penolongan_persalinan` = VALUES(`penolongan_persalinan`), `cara_persalinan` = VALUES(`cara_persalinan`), `keadaan_ibu` = VALUES(`keadaan_ibu`), `umur_kehamilan` = VALUES(`umur_kehamilan`), `id_sat_umur` = VALUES(`id_sat_umur`), `biaya_persalinan` = VALUES(`biaya_persalinan`), `biaya_perawatan_kelas` = VALUES(`biaya_perawatan_kelas`), `biaya_perawatan_bayi` = VALUES(`biaya_perawatan_bayi`), `biaya_obat_obatan` = VALUES(`biaya_obat_obatan`), `biaya_cucian` = VALUES(`biaya_cucian`), `biaya_akte_kelahiran` = VALUES(`biaya_akte_kelahiran`), `biaya_transportasi` = VALUES(`biaya_transportasi`), `biaya_lain` = VALUES(`biaya_lain`);

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
(8,	'Meninggal')
ON DUPLICATE KEY UPDATE `id_kondisi` = VALUES(`id_kondisi`), `nm_kondisi` = VALUES(`nm_kondisi`);

DROP TABLE IF EXISTS `tbl_obat`;
CREATE TABLE `tbl_obat` (
  `id_obat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_obat` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `id_jobat` int(11) NOT NULL,
  `hrg_obat` int(11) NOT NULL,
  `id_sat_obat` int(11) NOT NULL DEFAULT '25',
  PRIMARY KEY (`id_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_obat` (`id_obat`, `nm_obat`, `stok`, `status`, `id_jobat`, `hrg_obat`, `id_sat_obat`) VALUES
(1,	'Kabe',	8,	'Aktif',	1,	10000,	25),
(2,	'Ringan',	2,	'Aktif',	2,	1800,	25),
(8,	'Suntik',	4,	'Aktif',	1,	9000,	25),
(9,	'Parasetamol',	7,	'Aktif',	2,	1100,	25),
(10,	'STM',	5,	'Aktif',	2,	1000,	25),
(11,	'Promag',	30,	'Aktif',	2,	2000,	25),
(12,	'Amoxilin',	40,	'Aktif',	2,	3000,	25),
(13,	'Vitamin C',	12,	'Aktif',	2,	12000,	25),
(14,	'sitrizin',	20,	'Aktif',	2,	12000,	23)
ON DUPLICATE KEY UPDATE `id_obat` = VALUES(`id_obat`), `nm_obat` = VALUES(`nm_obat`), `stok` = VALUES(`stok`), `status` = VALUES(`status`), `id_jobat` = VALUES(`id_jobat`), `hrg_obat` = VALUES(`hrg_obat`), `id_sat_obat` = VALUES(`id_sat_obat`);

DROP TABLE IF EXISTS `tbl_pasien`;
CREATE TABLE `tbl_pasien` (
  `no_pasien` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pasien` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk` enum('Laki-laki','Perempuan') NOT NULL,
  `pekerjaan` varchar(100) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pasien` (`no_pasien`, `nm_pasien`, `tgl_lahir`, `jk`, `pekerjaan`, `alamat`) VALUES
(4,	'Wanita Pasien',	'1971-05-28',	'Perempuan',	'Sebuah Pekerjaan',	'Alamat rumah contoh'),
(5,	'Pasien Laki',	'1990-08-01',	'Laki-laki',	'Tukang Angkek',	'Perumahan ')
ON DUPLICATE KEY UPDATE `no_pasien` = VALUES(`no_pasien`), `nm_pasien` = VALUES(`nm_pasien`), `tgl_lahir` = VALUES(`tgl_lahir`), `jk` = VALUES(`jk`), `pekerjaan` = VALUES(`pekerjaan`), `alamat` = VALUES(`alamat`);

DROP TABLE IF EXISTS `tbl_periksa`;
CREATE TABLE `tbl_periksa` (
  `id_periksa` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `no_pasien` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `tensi` varchar(9) NOT NULL,
  `id_sat_tensi` int(11) NOT NULL DEFAULT '26',
  PRIMARY KEY (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_periksa` (`id_periksa`, `tgl_periksa`, `no_pasien`, `keluhan`, `tensi`, `id_sat_tensi`) VALUES
('0806180527561954',	'2018-06-08 10:29:06',	4,	'Anu',	'120/80',	26),
('0806180919427822',	'2018-06-08 14:20:11',	4,	'Sakik',	'90/120',	26),
('0806180921596370',	'2018-06-08 14:22:16',	4,	'sasddasaw',	'30/40',	26),
('0806181052199757',	'2018-06-08 15:53:09',	4,	'vfffvf',	'30/40',	26),
('0806181053098524',	'2018-06-08 15:54:08',	4,	'ffrrdfes',	'60/80',	26),
('0806181056441169',	'2018-06-08 15:57:13',	4,	'njjnj',	'30/40',	26),
('0806181057142787',	'2018-06-08 15:57:50',	4,	'',	'60/80',	26),
('0806181100072920',	'2018-06-08 16:00:29',	4,	'sadsad',	'30/40',	26),
('0806181100300645',	'2018-06-08 16:01:09',	4,	'ss',	'60/80',	26),
('1006180513065195',	'2018-06-10 10:15:22',	4,	'Periksa baruak',	'60/80',	26)
ON DUPLICATE KEY UPDATE `id_periksa` = VALUES(`id_periksa`), `tgl_periksa` = VALUES(`tgl_periksa`), `no_pasien` = VALUES(`no_pasien`), `keluhan` = VALUES(`keluhan`), `tensi` = VALUES(`tensi`), `id_sat_tensi` = VALUES(`id_sat_tensi`);

DROP TABLE IF EXISTS `tbl_periksa_kb`;
CREATE TABLE `tbl_periksa_kb` (
  `no_pasien` int(11) NOT NULL,
  `id_kb` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `nm_suami` varchar(100) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `haid_terakhir` date NOT NULL,
  `berat_badan` int(11) NOT NULL,
  `id_sat_berat` int(11) NOT NULL DEFAULT '1',
  `tensi` varchar(9) NOT NULL,
  `id_sat_tensi` int(11) NOT NULL DEFAULT '26',
  PRIMARY KEY (`id_kb`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_periksa_kb` (`no_pasien`, `id_kb`, `tgl_periksa`, `nm_suami`, `anak_ke`, `haid_terakhir`, `berat_badan`, `id_sat_berat`, `tensi`, `id_sat_tensi`) VALUES
(4,	'090620180322333361',	'2018-06-09 08:23:37',	'dwd',	1,	'2018-06-09',	90,	1,	'90/80',	26),
(4,	'090620180403187563',	'2018-06-09 09:04:18',	'dede',	2,	'2018-06-09',	32,	1,	'81/61',	26),
(4,	'090620180406371070',	'2018-06-09 09:07:16',	'dewwe',	3,	'2018-06-09',	1200,	1,	'30/40',	26),
(4,	'090620180408310460',	'2018-06-09 09:08:52',	'',	1,	'2018-06-09',	12,	4,	'90/80',	26),
(4,	'100620180516301406',	'2018-06-10 10:17:32',	'Suami Ku',	1,	'2018-06-10',	33,	1,	'120/120',	26)
ON DUPLICATE KEY UPDATE `no_pasien` = VALUES(`no_pasien`), `id_kb` = VALUES(`id_kb`), `tgl_periksa` = VALUES(`tgl_periksa`), `nm_suami` = VALUES(`nm_suami`), `anak_ke` = VALUES(`anak_ke`), `haid_terakhir` = VALUES(`haid_terakhir`), `berat_badan` = VALUES(`berat_badan`), `id_sat_berat` = VALUES(`id_sat_berat`), `tensi` = VALUES(`tensi`), `id_sat_tensi` = VALUES(`id_sat_tensi`);

DROP TABLE IF EXISTS `tbl_satuan`;
CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  `id_jsat` int(11) NOT NULL,
  PRIMARY KEY (`id_sat`),
  KEY `id_jsat` (`id_jsat`),
  CONSTRAINT `tbl_satuan_ibfk_1` FOREIGN KEY (`id_jsat`) REFERENCES `tbl_jsatuan` (`id_jsat`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_satuan` (`id_sat`, `nm_sat`, `id_jsat`) VALUES
(1,	'Kg',	1),
(2,	'Hg',	1),
(3,	'Dag',	1),
(4,	'Gr',	1),
(5,	'Cg',	1),
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
(22,	'Pcs',	4),
(23,	'Lembar',	4),
(24,	'Tablet',	4),
(25,	'Buah',	4),
(26,	'MMHG',	5)
ON DUPLICATE KEY UPDATE `id_sat` = VALUES(`id_sat`), `nm_sat` = VALUES(`nm_sat`), `id_jsat` = VALUES(`id_jsat`);

DROP TABLE IF EXISTS `tbl_terapi`;
CREATE TABLE `tbl_terapi` (
  `id_terapi` int(11) NOT NULL AUTO_INCREMENT,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_periksa` varchar(50) NOT NULL,
  PRIMARY KEY (`id_terapi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_terapi` (`id_terapi`, `id_obat`, `jumlah`, `id_periksa`) VALUES
(41,	1,	1,	'300520181126079965'),
(42,	1,	1,	'300520181131455272'),
(44,	9,	10,	'3005181120014255'),
(45,	2,	10,	'3005181122144613'),
(49,	1,	0,	'0606181001353198'),
(50,	1,	0,	'0606181012172804'),
(53,	10,	5,	'806180527561954'),
(54,	9,	3,	'0806180927344748'),
(55,	1,	2,	'090620180322333361'),
(56,	1,	1,	'090620180403187563'),
(57,	8,	2,	'090620180406371070'),
(58,	1,	1,	'090620180408310460'),
(62,	8,	3,	'100620180516301406')
ON DUPLICATE KEY UPDATE `id_terapi` = VALUES(`id_terapi`), `id_obat` = VALUES(`id_obat`), `jumlah` = VALUES(`jumlah`), `id_periksa` = VALUES(`id_periksa`);

DELIMITER ;;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_terapi` FOR EACH ROW
update tbl_obat set stok = stok - new.jumlah where id_obat = new.id_obat;;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_terapi` FOR EACH ROW
update tbl_obat set stok = stok + OLD.jumlah where id_obat = OLD.id_obat;;

DELIMITER ;

DROP TABLE IF EXISTS `daftar_kelahiran`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_kelahiran` AS select `a`.`no_pasien` AS `No_Pasien`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`b`.`Alamat` AS `Alamat`,`a`.`id_kelahiran` AS `Id_Kelahiran`,`a`.`tgl_kelahiran` AS `Tanggal_Kelahiran`,`a`.`nm_suami` AS `Nama_Suami`,`a`.`penolongan_persalinan` AS `Penolongan_Persalinan`,`a`.`cara_persalinan` AS `Cara_Persalinan`,`a`.`keadaan_ibu` AS `Keadaan_Ibu`,concat(`a`.`umur_kehamilan`,' ',`c`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`biaya_persalinan` AS `Biaya_Persalinan`,`a`.`biaya_perawatan_kelas` AS `Biaya_Perawatan`,`a`.`biaya_perawatan_bayi` AS `Biaya_Perawatan_Bayi`,`a`.`biaya_obat_obatan` AS `Biaya_Obat_Obatan`,`a`.`biaya_cucian` AS `Biaya_Cucian`,`a`.`biaya_akte_kelahiran` AS `Biaya_Akte`,`a`.`biaya_transportasi` AS `Biaya_Transportasi`,`a`.`biaya_lain` AS `Biaya_Lain` from ((`tbl_kelahiran` `a` join `daftar_pasien` `b` on((`a`.`no_pasien` = `b`.`No_Pasien`))) join `daftar_satuan` `c` on((`a`.`id_sat_umur` = `c`.`Id_Sat`)));

DROP TABLE IF EXISTS `daftar_obat`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat` AS select `a`.`id_obat` AS `Id_Obat`,`a`.`nm_obat` AS `Nama_Obat`,`a`.`stok` AS `Stok`,`b`.`id_jobat` AS `Id_Jobat`,`b`.`nm_jobat` AS `Jenis_Obat`,`a`.`id_sat_obat` AS `Id_Sat_Obat`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_obat` AS `Harga_Obat` from ((`tbl_obat` `a` join `tbl_jenis_obat` `b` on((`a`.`id_jobat` = `b`.`id_jobat`))) join `daftar_satuan` `c` on((`a`.`id_sat_obat` = `c`.`Id_Sat`)));

DROP TABLE IF EXISTS `daftar_obat_beli`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat_beli` AS select `a`.`id_terapi` AS `Id_Terapi`,`a`.`id_obat` AS `Id_Obat`,`a`.`id_periksa` AS `Id_Periksa`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_periksa`,`a`.`id_obat`;

DROP TABLE IF EXISTS `daftar_pasien`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_pasien` AS select `tbl_pasien`.`no_pasien` AS `No_Pasien`,`tbl_pasien`.`nm_pasien` AS `Nama_Pasien`,date_format(`tbl_pasien`.`tgl_lahir`,'%d/%m/%Y') AS `Tanggal_Lahir`,`tbl_pasien`.`jk` AS `Jenis_Kelamin`,`tbl_pasien`.`pekerjaan` AS `Pekerjaan`,`tbl_pasien`.`alamat` AS `Alamat` from `tbl_pasien`;

DROP TABLE IF EXISTS `daftar_satuan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_jsatuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));

DROP TABLE IF EXISTS `laporan_anc`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_anc` AS select `a`.`id_anc` AS `Id_Anc`,`a`.`id_periksa` AS `Id_Periksa`,`a`.`nm_suami` AS `Nama_Suami`,concat(`a`.`tinggi_bdn`,' ',`sat_tinggi`.`Nama_Satuan`) AS `Tinggi_Badan`,concat(`a`.`berat_bdn`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Badan`,`a`.`hpht` AS `hpht`,`a`.`htp` AS `htp`,concat(`a`.`umur_khmln`,' ',`sat_umur`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`kb_terakhir` AS `KB_Terakhir` from (((`tbl_anc` `a` join `daftar_satuan` `sat_tinggi` on((`a`.`id_sat_tinggi` = `sat_tinggi`.`Id_Sat`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_umur` on((`a`.`id_sat_umur` = `sat_umur`.`Id_Sat`)));

DROP TABLE IF EXISTS `laporan_bayi_lahir`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_bayi_lahir` AS select `b`.`Id_Kelahiran` AS `Id_Kelahiran`,`b`.`Tanggal_Kelahiran` AS `Tanggal_Kelahiran`,`b`.`No_Pasien` AS `No_Pasien`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`nm_bayi` AS `Nama_Bayi`,`a`.`waktu_lahir` AS `Waktu_Lahir`,`a`.`anak_ke` AS `Anak_Ke`,concat(`a`.`berat_lahir`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Lahir`,concat(`a`.`panjang_badan`,' ',`sat_panjang`.`Nama_Satuan`) AS `Panjang_Badan`,concat(`a`.`lingkar_kepala`,' ',`sat_lingkar`.`Nama_Satuan`) AS `Lingkar_Kepala`,`a`.`jk` AS `Jenis_Kelamin`,`a`.`asuhan_bayi_saat_lahir` AS `Asuhan_Bayi_Saat_Lahir`,`a`.`keterangan` AS `Keterangan`,`a`.`kondisi_bayi` AS `Kondisi Bayi` from ((((`tbl_bayi_lahir` `a` join `daftar_kelahiran` `b` on((`a`.`id_kelahiran` = `b`.`Id_Kelahiran`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_panjang` on((`a`.`id_sat_panjang` = `sat_panjang`.`Id_Sat`))) join `daftar_satuan` `sat_lingkar` on((`a`.`id_sat_lingkar` = `sat_lingkar`.`Id_Sat`)));

DROP TABLE IF EXISTS `laporan_kb`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_kb` AS select `a`.`no_pasien` AS `No_Pasien`,`c`.`nm_pasien` AS `Nama_Pasien`,`c`.`tgl_lahir` AS `Tanggal_Lahir`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`anak_ke` AS `Anak_Ke`,`a`.`haid_terakhir` AS `Haid_Terakhir`,concat(`a`.`berat_badan`,' ',`d`.`Nama_Satuan`) AS `Berat_Badan`,`a`.`id_sat_berat` AS `Id_Sat_Berat`,concat(`a`.`tensi`,' ',`e`.`Nama_Satuan`) AS `Tensi`,`a`.`id_sat_tensi` AS `Id_Sat_Tensi`,`b`.`Nama_Obat` AS `Nama_Obat`,concat(`b`.`Jumlah`,' ',`b`.`Satuan`) AS `Jumlah` from ((((`tbl_periksa_kb` `a` join `laporan_terapi` `b` on((`a`.`id_kb` = `b`.`Id_Periksa`))) join `tbl_pasien` `c` on((`a`.`no_pasien` = `c`.`no_pasien`))) join `daftar_satuan` `d` on((`a`.`id_sat_berat` = `d`.`Id_Sat`))) join `daftar_satuan` `e` on((`a`.`id_sat_tensi` = `e`.`Id_Sat`)));

DROP TABLE IF EXISTS `laporan_pemasukan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_pemasukan` AS select `a`.`id_terapi` AS `id_terapi`,`a`.`id_periksa` AS `id_periksa`,`b`.`nm_obat` AS `nm_obat`,sum(`a`.`jumlah`) AS `jumlah`,sum((`a`.`jumlah` * `b`.`hrg_obat`)) AS `total_bayar` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_periksa`;

DROP TABLE IF EXISTS `laporan_rekap_pasien`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_rekap_pasien` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`no_pasien` AS `No_Pasien`,`e`.`Tinggi_Badan` AS `Tinggi_Badan`,`e`.`Berat_Badan` AS `Berat_Badan`,concat('Waktu HPHT ',`e`.`hpht`,'\r\nHTP ',`e`.`htp`,'\r\nUmur Kehamilan ',`e`.`Umur_Kehamilan`,'\r\nDiagnosa Tambahan',`a`.`keluhan`) AS `Keluhan/Diagnosa`,concat(`a`.`tensi`,' ',`sat`.`Nama_Satuan`) AS `Tensi` from (((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id_Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No_Pasien`))) left join `laporan_anc` `e` on((`a`.`id_periksa` = `e`.`Id_Periksa`)));

DROP TABLE IF EXISTS `laporan_terapi`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_terapi` AS select `a`.`id_periksa` AS `Id_Periksa`,`a`.`id_obat` AS `Id_Obat`,`b`.`Nama_Obat` AS `Nama_Obat`,`b`.`Harga_Obat` AS `Harga_Obat`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_Obat`) AS `Total`,`b`.`Satuan` AS `Satuan` from (`tbl_terapi` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id_Obat`)));

-- 2018-06-10 10:45:56
