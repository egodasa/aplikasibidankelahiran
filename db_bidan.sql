-- Adminer 4.6.2 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `tbl_anc`;
CREATE TABLE `tbl_anc` (
  `id_periksa` int(11) NOT NULL,
  `id_anc` int(11) NOT NULL,
  `nm_suami` varchar(50) NOT NULL,
  `tinggi_bdn` varchar(11) NOT NULL,
  `berat_bdn` varchar(11) NOT NULL,
  `tekanan_drh` varchar(11) NOT NULL,
  `hpht` date NOT NULL,
  `htp` date NOT NULL,
  `diagnosa` varchar(11) NOT NULL,
  `umur_khmln` int(11) NOT NULL,
  `pemeriksaan` varchar(250) NOT NULL,
  PRIMARY KEY (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_bayi_lahir`;
CREATE TABLE `tbl_bayi_lahir` (
  `id_bayi` int(11) NOT NULL,
  `id_kelahiran` int(11) NOT NULL,
  `nm_bayi` varchar(100) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `berat_lahir` int(11) NOT NULL,
  `panjang_badan` int(11) NOT NULL,
  `lingkar_kepala` int(11) NOT NULL,
  `jk` varchar(30) NOT NULL,
  `asuhan_bayi_saat_lahit` text NOT NULL,
  `keterangan_tmbh` text NOT NULL,
  `kondisi_bayi` text NOT NULL,
  PRIMARY KEY (`id_bayi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_biaya_persalinan`;
CREATE TABLE `tbl_biaya_persalinan` (
  `id_kelahiran` int(11) NOT NULL,
  `persalinan` int(11) NOT NULL,
  `perawatan_kelas` int(11) NOT NULL,
  `perawatan_bayi` int(11) NOT NULL,
  `obat_obatan` int(11) NOT NULL,
  `cucian` int(11) NOT NULL,
  `akte_kelahiran` int(11) NOT NULL,
  `transportasi` int(11) NOT NULL,
  `lain-lain` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`id_kelahiran`)
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
  `id_kelahiran` int(11) NOT NULL,
  `tgl_kelahiran` date NOT NULL,
  `nm_suami` varchar(50) NOT NULL,
  `penolongan_persalinan` text NOT NULL,
  `cara_persalinan` text NOT NULL,
  `keadaan ibu` text NOT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_obat`;
CREATE TABLE `tbl_obat` (
  `id_obat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_obat` varchar(50) NOT NULL,
  `stok` int(11) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL DEFAULT 'Aktif',
  `id_jobat` int(11) NOT NULL,
  PRIMARY KEY (`id_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_obat` (`id_obat`, `nm_obat`, `stok`, `status`, `id_jobat`) VALUES
(1,	'ewe',	12,	'Aktif',	1),
(2,	'Ringan',	12,	'Aktif',	2);

DROP TABLE IF EXISTS `tbl_pasien`;
CREATE TABLE `tbl_pasien` (
  `no_pasien` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pasien` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk` varchar(30) NOT NULL,
  `pekerjaan` varchar(100) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_periksa`;
CREATE TABLE `tbl_periksa` (
  `id_periksa` int(11) NOT NULL,
  `tgl_periksa` datetime NOT NULL,
  `no_pasien` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `tensi` varchar(9) NOT NULL,
  `id_terapi` int(11) NOT NULL,
  PRIMARY KEY (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_periksa_kb`;
CREATE TABLE `tbl_periksa_kb` (
  `no_pasien` int(11) NOT NULL,
  `id_kb` int(11) NOT NULL,
  `nm_suami` varchar(50) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `haid_terakhir` date NOT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_terapi`;
CREATE TABLE `tbl_terapi` (
  `id_terapi` int(11) NOT NULL,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_periksa` int(11) NOT NULL,
  PRIMARY KEY (`id_terapi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- 2018-05-19 17:03:40
