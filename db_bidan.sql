-- Adminer 4.6.2 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

CREATE TABLE `daftar_obat` (`Id Obat` int(11), `Nama Obat` varchar(50), `Stok` int(11), `Id Jobat` int(11), `Jenis Obat` varchar(50), `Id Sat Obat` int(11), `Satuan` varchar(30), `Harga Obat` int(11));


CREATE TABLE `daftar_obat_beli` (`Id Terapi` int(11), `Id Obat` int(11), `Id Periksa` varchar(50), `Nama Obat` varchar(50), `Jumlah` decimal(32,0), `Harga Obat` int(11), `Total Harga` decimal(42,0));


CREATE TABLE `daftar_pasien` (`No Pasien` int(11), `Nama Pasien` varchar(100), `Tanggal Lahir` varchar(10), `Jenis Kelamin` enum('Laki-laki','Perempuan'), `Pekerjaan` varchar(100), `Alamat` varchar(250));


CREATE TABLE `daftar_satuan` (`Id Sat` int(11), `Nama Satuan` varchar(30), `Id Jsat` int(11), `Nama Jenis Satuan` varchar(30));


CREATE TABLE `laporan_kb` (`No Pasien` int(11), `Nama Pasien` varchar(100), `Tanggal Lahir` date, `Tanggal Periksa` timestamp, `Anak Ke` int(11), `Haid Terakhir` date, `Berat Badan` int(11), `Id Sat Berat` int(11), `Satuan Berat` varchar(30), `Tensi` varchar(9), `Id Sat Tensi` int(11), `Satuan Tensi` varchar(30), `Nama Obat` varchar(50));


CREATE TABLE `laporan_pemasukan` (`id_terapi` int(11), `id_periksa` varchar(50), `nm_obat` varchar(50), `jumlah` decimal(32,0), `total_bayar` decimal(42,0));


CREATE TABLE `laporan_rekap_pasien` (`Id Periksa` varchar(50), `Nama Pasien` varchar(100), `Tanggal Periksa` timestamp, `No Pasien` int(11), `Keluhan/Diagnosa` varchar(100), `Tensi` varchar(40));


CREATE TABLE `laporan_terapi` (`Id Periksa` varchar(50), `Id Obat` int(11), `Nama Obat` varchar(50), `Harga Obat` int(11), `Jumlah` int(11), `Total` bigint(21), `Satuan` varchar(30));


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


CREATE TABLE `tbl_asuhan_bayi` (
  `id_asuhan` int(11) NOT NULL AUTO_INCREMENT,
  `nm_asuhan` text NOT NULL,
  PRIMARY KEY (`id_asuhan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `tbl_bayi_lahir` (
  `id_bayi` int(11) NOT NULL AUTO_INCREMENT,
  `id_kelahiran` varchar(50) NOT NULL,
  `nm_bayi` varchar(100) NOT NULL,
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


CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `tbl_jsatuan` (
  `id_jsat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jsat` varchar(30) NOT NULL,
  PRIMARY KEY (`id_jsat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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


CREATE TABLE `tbl_kondisi_lahir` (
  `id_kondisi` int(11) NOT NULL AUTO_INCREMENT,
  `nm_kondisi` text NOT NULL,
  PRIMARY KEY (`id_kondisi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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


CREATE TABLE `tbl_pasien` (
  `no_pasien` int(11) NOT NULL AUTO_INCREMENT,
  `nm_pasien` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk` enum('Laki-laki','Perempuan') NOT NULL,
  `pekerjaan` varchar(100) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  PRIMARY KEY (`no_pasien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `tbl_periksa` (
  `id_periksa` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `no_pasien` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `tensi` varchar(9) NOT NULL,
  `id_sat_tensi` int(11) NOT NULL DEFAULT '26',
  PRIMARY KEY (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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


CREATE TABLE `tbl_satuan` (
  `id_sat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_sat` varchar(30) NOT NULL,
  `id_jsat` int(11) NOT NULL,
  PRIMARY KEY (`id_sat`),
  KEY `id_jsat` (`id_jsat`),
  CONSTRAINT `tbl_satuan_ibfk_1` FOREIGN KEY (`id_jsat`) REFERENCES `tbl_jsatuan` (`id_jsat`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `tbl_terapi` (
  `id_terapi` int(11) NOT NULL AUTO_INCREMENT,
  `id_obat` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `id_periksa` varchar(50) NOT NULL,
  PRIMARY KEY (`id_terapi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DELIMITER ;;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_terapi` FOR EACH ROW
update tbl_obat set stok = stok - new.jumlah where id_obat = new.id_obat;;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_terapi` FOR EACH ROW
update tbl_obat set stok = stok + OLD.jumlah where id_obat = OLD.id_obat;;

DELIMITER ;

DROP TABLE IF EXISTS `daftar_obat`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat` AS select `a`.`id_obat` AS `Id Obat`,`a`.`nm_obat` AS `Nama Obat`,`a`.`stok` AS `Stok`,`b`.`id_jobat` AS `Id Jobat`,`b`.`nm_jobat` AS `Jenis Obat`,`a`.`id_sat_obat` AS `Id Sat Obat`,`c`.`Nama Satuan` AS `Satuan`,`a`.`hrg_obat` AS `Harga Obat` from ((`tbl_obat` `a` join `tbl_jenis_obat` `b` on((`a`.`id_jobat` = `b`.`id_jobat`))) join `daftar_satuan` `c` on((`a`.`id_sat_obat` = `c`.`Id Sat`)));

DROP TABLE IF EXISTS `daftar_obat_beli`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_obat_beli` AS select `a`.`id_terapi` AS `Id Terapi`,`a`.`id_obat` AS `Id Obat`,`a`.`id_periksa` AS `Id Periksa`,`b`.`nm_obat` AS `Nama Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total Harga` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_periksa`,`a`.`id_obat`;

DROP TABLE IF EXISTS `daftar_pasien`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_pasien` AS select `tbl_pasien`.`no_pasien` AS `No Pasien`,`tbl_pasien`.`nm_pasien` AS `Nama Pasien`,date_format(`tbl_pasien`.`tgl_lahir`,'%d/%m/%Y') AS `Tanggal Lahir`,`tbl_pasien`.`jk` AS `Jenis Kelamin`,`tbl_pasien`.`pekerjaan` AS `Pekerjaan`,`tbl_pasien`.`alamat` AS `Alamat` from `tbl_pasien`;

DROP TABLE IF EXISTS `daftar_satuan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id Sat`,`a`.`nm_sat` AS `Nama Satuan`,`a`.`id_jsat` AS `Id Jsat`,`b`.`nm_jsat` AS `Nama Jenis Satuan` from (`tbl_satuan` `a` join `tbl_jsatuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));

DROP TABLE IF EXISTS `laporan_kb`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_kb` AS select `a`.`no_pasien` AS `No Pasien`,`c`.`nm_pasien` AS `Nama Pasien`,`c`.`tgl_lahir` AS `Tanggal Lahir`,`a`.`tgl_periksa` AS `Tanggal Periksa`,`a`.`anak_ke` AS `Anak Ke`,`a`.`haid_terakhir` AS `Haid Terakhir`,`a`.`berat_badan` AS `Berat Badan`,`a`.`id_sat_berat` AS `Id Sat Berat`,`d`.`Nama Satuan` AS `Satuan Berat`,`a`.`tensi` AS `Tensi`,`a`.`id_sat_tensi` AS `Id Sat Tensi`,`d`.`Nama Satuan` AS `Satuan Tensi`,`b`.`Nama Obat` AS `Nama Obat` from (((`tbl_periksa_kb` `a` join `laporan_terapi` `b` on((`a`.`id_kb` = `b`.`Id Periksa`))) join `tbl_pasien` `c` on((`a`.`no_pasien` = `c`.`no_pasien`))) join `daftar_satuan` `d` on(((`a`.`id_sat_berat` = `d`.`Id Sat`) and (`a`.`id_sat_tensi` = `d`.`Id Sat`))));

DROP TABLE IF EXISTS `laporan_pemasukan`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_pemasukan` AS select `a`.`id_terapi` AS `id_terapi`,`a`.`id_periksa` AS `id_periksa`,`b`.`nm_obat` AS `nm_obat`,sum(`a`.`jumlah`) AS `jumlah`,sum((`a`.`jumlah` * `b`.`hrg_obat`)) AS `total_bayar` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_periksa`;

DROP TABLE IF EXISTS `laporan_rekap_pasien`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_rekap_pasien` AS select `a`.`id_periksa` AS `Id Periksa`,`c`.`Nama Pasien` AS `Nama Pasien`,`a`.`tgl_periksa` AS `Tanggal Periksa`,`a`.`no_pasien` AS `No Pasien`,`a`.`keluhan` AS `Keluhan/Diagnosa`,concat(`a`.`tensi`,' ',`sat`.`Nama Satuan`) AS `Tensi` from ((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No Pasien`)));

DROP TABLE IF EXISTS `laporan_terapi`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_terapi` AS select `a`.`id_periksa` AS `Id Periksa`,`a`.`id_obat` AS `Id Obat`,`b`.`Nama Obat` AS `Nama Obat`,`b`.`Harga Obat` AS `Harga Obat`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga Obat`) AS `Total`,`b`.`Satuan` AS `Satuan` from (`tbl_terapi` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id Obat`)));

-- 2018-06-08 14:08:34
