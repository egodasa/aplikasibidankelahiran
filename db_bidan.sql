DROP TABLE IF EXISTS `tbl_anc`;
CREATE TABLE `tbl_anc` (
  `id_periksa` varchar(50) NOT NULL,
  `id_anc` int(11) NOT NULL AUTO_INCREMENT,
  `nm_suami` varchar(100) NOT NULL,
  `tinggi_bdn` smallint(6) NOT NULL,
  `berat_bdn` smallint(6) NOT NULL,
  `hpht` date NOT NULL,
  `htp` date NOT NULL,
  `diagnosa` varchar(11) NOT NULL,
  `umur_khmln` int(11) NOT NULL,
  `kb_terakhir` date NOT NULL,
  PRIMARY KEY (`id_anc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_asuhan_bayi`;
CREATE TABLE `tbl_asuhan_bayi` (
  `id_asuhan` int(11) NOT NULL AUTO_INCREMENT,
  `nm_asuhan` text NOT NULL,
  PRIMARY KEY (`id_asuhan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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


DROP TABLE IF EXISTS `tbl_jenis_obat`;
CREATE TABLE `tbl_jenis_obat` (
  `id_jobat` int(11) NOT NULL AUTO_INCREMENT,
  `nm_jobat` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jobat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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


DROP TABLE IF EXISTS `tbl_kondisi_lahir`;
CREATE TABLE `tbl_kondisi_lahir` (
  `id_kondisi` int(11) NOT NULL AUTO_INCREMENT,
  `nm_kondisi` text NOT NULL,
  PRIMARY KEY (`id_kondisi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


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


DROP TABLE IF EXISTS `tbl_periksa`;
CREATE TABLE `tbl_periksa` (
  `id_periksa` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `no_pasien` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `tensi` varchar(9) NOT NULL,
  PRIMARY KEY (`id_periksa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_periksa_kb`;
CREATE TABLE `tbl_periksa_kb` (
  `no_pasien` int(11) NOT NULL,
  `id_kb` varchar(50) NOT NULL,
  `tgl_periksa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `nm_suami` varchar(100) NOT NULL,
  `anak_ke` int(11) NOT NULL,
  `haid_terakhir` date NOT NULL,
  `berat_badan` int(11) NOT NULL,
  `tensi` varchar(9) NOT NULL,
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

CREATE VIEW `laporan_kb` AS select `a`.`no_pasien` AS `no_pasien`,`c`.`nm_pasien` AS `nm_pasien`,`c`.`tgl_lahir` AS `tgl_lahir`,`a`.`tgl_periksa` AS `tgl_periksa`,`a`.`anak_ke` AS `anak_ke`,`a`.`haid_terakhir` AS `haid_terakhir`,`a`.`berat_badan` AS `berat_badan`,`a`.`tensi` AS `tensi`,`b`.`nm_obat` AS `nm_obat` from ((`tbl_periksa_kb` `a` join `laporan_terapi` `b` on((`a`.`id_kb` = `b`.`id_periksa`))) join `tbl_pasien` `c` on((`a`.`no_pasien` = `c`.`no_pasien`)));

CREATE VIEW `laporan_pemasukan` AS select `a`.`id_terapi` AS `id_terapi`,`a`.`id_periksa` AS `id_periksa`,`b`.`nm_obat` AS `nm_obat`,sum(`a`.`jumlah`) AS `jumlah`,sum((`a`.`jumlah` * `b`.`hrg_obat`)) AS `total_bayar` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_periksa`;

CREATE VIEW `laporan_terapi` AS select `a`.`id_periksa` AS `id_periksa`,`a`.`id_obat` AS `id_obat`,`b`.`nm_obat` AS `nm_obat`,`b`.`hrg_obat` AS `hrg_obat`,`a`.`jumlah` AS `jumlah`,(`a`.`jumlah` * `b`.`hrg_obat`) AS `total` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`)));

-- 2018-05-30 04:58:47
