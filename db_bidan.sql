-- Adminer 4.6.2 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP VIEW IF EXISTS `laporan_kb`;
CREATE TABLE `laporan_kb` (`Tanggal Periksa` timestamp, `Anak ke` int(11), `Haid Terakhir` date, `Berat Badan` int(11), `Tekanan Darah` varchar(12), `Nama Obat` varchar(50), `No Pasien` int(11), `Nama Suami` varchar(100));


DROP TABLE IF EXISTS `tbl_anc`;
CREATE TABLE `tbl_anc` (
  `id_periksa` varchar(50) NOT NULL,
  `id_anc` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suami` varchar(100) NOT NULL,
  `tinggi_bdn` smallint(6) NOT NULL,
  `berat_bdn` smallint(6) NOT NULL,
  `tekanan_drh` varchar(11) NOT NULL,
  `hpht` date NOT NULL,
  `htp` date NOT NULL,
  `diagnosa` varchar(11) NOT NULL,
  `umur_khmln` int(11) NOT NULL,
  `kb_terakhir` date NOT NULL,
  PRIMARY KEY (`id_periksa`),
  UNIQUE KEY `id_anc` (`id_anc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_anc` (`id_periksa`, `id_anc`, `nm_suami`, `tinggi_bdn`, `berat_bdn`, `tekanan_drh`, `hpht`, `htp`, `diagnosa`, `umur_khmln`, `kb_terakhir`) VALUES
('636624983391686106',	1,	'suami',	120,	90,	'21',	'0000-00-00',	'0000-00-00',	'diagnosa',	23,	'0000-00-00'),
('636625008178251722',	2,	'zsx',	12,	12,	'21',	'2018-05-01',	'2018-05-01',	'asdw',	12,	'2018-05-01');

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
  `nm_bayi` varchar(100) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `berat_lahir` int(11) NOT NULL,
  `panjang_badan` int(11) NOT NULL,
  `lingkar_kepala` int(11) NOT NULL,
  `jk` varchar(30) NOT NULL,
  `asuhan_bayi_saat_lahir` text NOT NULL,
  `keterangan` text NOT NULL,
  `kondisi_bayi` text NOT NULL,
  PRIMARY KEY (`id_bayi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_bayi_lahir` (`id_bayi`, `id_kelahiran`, `nm_bayi`, `anak_ke`, `berat_lahir`, `panjang_badan`, `lingkar_kepala`, `jk`, `asuhan_bayi_saat_lahir`, `keterangan`, `kondisi_bayi`) VALUES
(1,	'K636626024418012944',	'bayi 1',	1,	1,	1,	1,	'Laki-laki',	'Tidak menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\nSuntikan vitamin K1\r\nSalep mata antibiotika profilaksis\r\n',	'ket 1'),
(2,	'K636626034700041715',	'bayi 1',	1,	1,	1,	1,	'Perempuan',	'Segera menangis\r\nSeluruh tubuh kemerahan\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\nSuntikan vitamin K1\r\n',	'ket 1'),
(3,	'K636626034700041715',	'bayi 2',	2,	2,	2,	2,	'Perempuan',	'Tidak menangis\r\n',	'Salep mata antibiotika profilaksis\r\n',	'ket 2'),
(4,	'K636626037756358950',	'bayi 1',	1,	1,	1,	1,	'Laki-laki',	'Segera menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\n',	'ket 1'),
(5,	'K636626037756358950',	'bayi 2',	2,	2,	2,	2,	'Perempuan',	'Segera menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\n',	'ket 2'),
(6,	'K636626701432874592',	'1',	1,	1,	1,	1,	'Laki-laki',	'Segera menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\n',	'1'),
(7,	'K636626708339780923',	'1',	1,	1,	1,	1,	'Laki-laki',	'Segera menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\n',	'1'),
(8,	'K636626712671539557',	'1',	1,	1,	1,	1,	'Perempuan',	'Segera menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\n',	'1'),
(9,	'K636626715288000558',	'2',	2,	2,	2,	2,	'Laki-laki',	'Segera menangis\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\n',	'sasaw'),
(10,	'K636626716808926525',	'1',	1,	1,	1,	1,	'1',	'Segera menangis\r\nMenangis beberapa saat\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\nSalep mata antibiotika profilaksis\r\n',	'sazaaz'),
(11,	'K636626716808926525',	'2',	12,	2,	2,	2,	'Laki-laki',	'Segera menangis\r\nMenangis beberapa saat\r\n',	'Inisiasi menyusu dini (IMD) dalam 1 jam pertama kelahiran bayi\r\nSalep mata antibiotika profilaksis\r\n',	'2');

DROP TABLE IF EXISTS `tbl_biaya_persalinan`;
CREATE TABLE `tbl_biaya_persalinan` (
  `id_kelahiran` int(11) NOT NULL,
  `id_biaya_persalinan` int(11) NOT NULL AUTO_INCREMENT,
  `perawatan_kelas` int(11) NOT NULL,
  `perawatan_bayi` int(11) NOT NULL,
  `obat_obatan` int(11) NOT NULL,
  `cucian` int(11) NOT NULL,
  `akte_kelahiran` int(11) NOT NULL,
  `transportasi` int(11) NOT NULL,
  `lain-lain` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_kelahiran`),
  UNIQUE KEY `id_biaya_persalinan` (`id_biaya_persalinan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_jenis_kb`;
CREATE TABLE `tbl_jenis_kb` (
  `id_jkb` int(11) NOT NULL,
  `nm_kb` varchar(50) NOT NULL,
  `harga` int(11) NOT NULL,
  PRIMARY KEY (`id_jkb`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_jenis_obat`;
CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jenis_obat` (`id_jobat`, `nm_jobat`) VALUES
(1,	'KB'),
(2,	'Ringan'),
(3,	'Keras');

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
  PRIMARY KEY (`id_kelahiran`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_kelahiran` (`no_pasien`, `id_kelahiran`, `tgl_kelahiran`, `nm_suami`, `penolongan_persalinan`, `cara_persalinan`, `keadaan_ibu`, `umur_kehamilan`) VALUES
(2,	'K636625865186634675',	'2018-05-24 12:00:00',	'',	'cara1',	'cara2',	'cara3',	12),
(2,	'K636626024418012944',	'2018-05-24 12:00:00',	'suami',	'penolong',	'ara',	'ibu',	12),
(2,	'K636626031673124412',	'2018-05-24 12:00:00',	'suami',	'penolong',	'persalinan',	'keadaan',	12),
(2,	'K636626034700041715',	'2018-05-24 12:00:00',	'suami',	'persalinan',	'cara',	'ibuk',	12),
(2,	'K636626037756358950',	'2018-05-24 12:00:00',	'suami',	'penolongan',	'persalinan',	'ibu',	12),
(2,	'K636626701432874592',	'2018-05-24 12:00:00',	'edw',	'wws',	'wxw',	'dsds',	12),
(2,	'K636626708339780923',	'2018-05-24 12:00:00',	'asds',	'2',	'2',	'2',	2),
(2,	'K636626711569698288',	'2018-05-24 12:00:00',	'',	'1',	'1',	'1',	1),
(2,	'K636626712252167763',	'2018-05-24 12:00:00',	'ssww',	'1',	'1',	'1',	1),
(2,	'K636626712671539557',	'2018-05-24 12:00:00',	'sdssdaas',	'1',	'1',	'1',	1),
(2,	'K636626715288000558',	'2018-05-24 12:00:00',	'wsws',	'2',	'2',	'2',	2),
(2,	'K636626716808926525',	'2018-05-24 12:00:00',	'wswsw',	'1',	'1',	'1',	1);

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
  PRIMARY KEY (`id_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_obat` (`id_obat`, `nm_obat`, `stok`, `status`, `id_jobat`, `hrg_obat`) VALUES
(1,	'Kabe',	12,	'Aktif',	1,	10000),
(2,	'Ringan',	12,	'Aktif',	2,	1800),
(8,	'Suntik',	9,	'Aktif',	1,	9000),
(9,	'Parasetamol',	20,	'Aktif',	2,	1100),
(10,	'STM',	10,	'Aktif',	2,	1000),
(11,	'Promag',	30,	'Aktif',	2,	2000),
(12,	'Amoxilin',	40,	'Aktif',	2,	3000);

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
(2,	'weq',	'2018-05-24',	'Laki-laki',	'qwewqw',	'sqws'),
(3,	'Ketuas',	'2018-05-19',	'Perempuan',	'Pekerjaans',	'Pekerjaans');

DROP TABLE IF EXISTS `tbl_periksa`;
CREATE TABLE `tbl_periksa` (
  `id_periksa` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `no_pasien` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `tensi` varchar(9) NOT NULL,
  PRIMARY KEY (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_periksa` (`id_periksa`, `tgl_periksa`, `no_pasien`, `keluhan`, `tensi`) VALUES
('636627861827088598',	'2018-05-24 12:16:42',	2,	'Sakik',	'120'),
('636627862878327626',	'2018-05-24 12:18:27',	2,	'Sakik lo liak',	'110');

DROP TABLE IF EXISTS `tbl_periksa_kb`;
CREATE TABLE `tbl_periksa_kb` (
  `no_pasien` int(11) NOT NULL,
  `id_kb` int(11) NOT NULL AUTO_INCREMENT,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `nm_suami` varchar(100) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `haid_terakhir` date NOT NULL,
  `id_obat` int(11) NOT NULL,
  `berat_badan` int(11) NOT NULL,
  `tekanan_darah` varchar(12) NOT NULL,
  PRIMARY KEY (`id_kb`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_terapi`;
CREATE TABLE `tbl_terapi` (
  `id_terapi` int(11) NOT NULL AUTO_INCREMENT,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_periksa` varchar(50) NOT NULL,
  PRIMARY KEY (`id_terapi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_terapi` (`id_terapi`, `id_obat`, `jumlah`, `id_periksa`) VALUES
(13,	9,	2,	'636627861827088598'),
(14,	9,	2,	'636627861827088598'),
(15,	10,	1,	'636627862878327626'),
(16,	10,	1,	'636627862878327626'),
(17,	11,	2,	'636627948554609933');

DROP TABLE IF EXISTS `laporan_kb`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_kb` AS select `a`.`tgl_periksa` AS `Tanggal Periksa`,`a`.`anak_ke` AS `Anak ke`,`a`.`haid_terakhir` AS `Haid Terakhir`,`a`.`berat_badan` AS `Berat Badan`,`a`.`tekanan_darah` AS `Tekanan Darah`,`b`.`nm_obat` AS `Nama Obat`,`a`.`no_pasien` AS `No Pasien`,`a`.`nm_suami` AS `Nama Suami` from (`tbl_periksa_kb` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`)));

-- 2018-05-26 06:03:24
create view `laporan_kb` AS select `a`.`tgl_periksa` AS `Tanggal Periksa`,`a`.`anak_ke` AS `Anak ke`,`a`.`haid_terakhir` AS `Haid Terakhir`,`a`.`berat_badan` AS `Berat Badan`,`a`.`tekanan_darah` AS `Tekanan Darah`,`b`.`nm_obat` AS `Nama Obat`,`a`.`no_pasien` AS `No Pasien`,`a`.`nm_suami` AS `Nama Suami` from (`tbl_periksa_kb` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`)))
