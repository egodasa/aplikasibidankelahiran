DROP TABLE IF EXISTS `tbl_anc`;
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
  PRIMARY KEY (`id_anc`),
  KEY `id_periksa` (`id_periksa`),
  KEY `id_sat_tinggi` (`id_sat_tinggi`),
  KEY `id_sat_berat` (`id_sat_berat`),
  KEY `id_sat_umur` (`id_sat_umur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_anc` (`id_periksa`, `id_anc`, `nm_suami`, `tinggi_bdn`, `id_sat_tinggi`, `berat_bdn`, `id_sat_berat`, `hpht`, `htp`, `umur_khmln`, `id_sat_umur`, `kb_terakhir`) VALUES
('2406181221466191',	1,	'Suami ku',	190,	12,	70,	1,	'2018-06-25',	'2019-04-02',	22,	18,	'2018-06-24');

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
(1,	'K636642690558369157',	'Bayi Pertama',	'2018-06-10 01:10:57',	1,	20,	1,	104,	12,	20,	12,	'Laki-laki',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n',	'Keterangan Bayi Pertama',	'Segera menangis\r\nMenangis beberapa saat\r\n'),
(2,	'K636642690558369157',	'Bayi Kedua',	'2018-06-10 11:11:49',	2,	14,	4,	107,	12,	23,	12,	'Laki-laki',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\nSalep mata antibiotika profilaksis\r\nImunisasi HBO\r\n',	'Keterangan Bayi Kedua',	'Segera menangis\r\nMenangis beberapa saat\r\n'),
(3,	'K636642691775120029',	'Bayi Lain 1',	'2018-06-10 11:12:22',	2,	22,	4,	12,	12,	21,	12,	'Laki-laki',	'',	'',	''),
(4,	'K636642691775120029',	'Bayi Lain',	'2018-06-10 11:14:24',	32,	21,	4,	12,	12,	12,	12,	'Laki-laki',	'',	'',	''),
(5,	'K636656199511148552',	'111',	'2018-06-26 02:25:52',	1,	12,	4,	12,	12,	12,	12,	'Laki-laki',	'Inisasi Menyusu Dini (IMD) dalam 1 jam pertama\r\nSuntikan Vitamin K1\r\n',	'czxzc',	'Segera menangis\r\n');

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
(4,	'Suplemen');

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
  PRIMARY KEY (`id_kelahiran`),
  KEY `no_pasien` (`no_pasien`),
  KEY `id_sat_umur` (`id_sat_umur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_kelahiran` (`no_pasien`, `id_kelahiran`, `tgl_kelahiran`, `nm_suami`, `penolongan_persalinan`, `cara_persalinan`, `keadaan_ibu`, `umur_kehamilan`, `id_sat_umur`, `biaya_persalinan`, `biaya_perawatan_kelas`, `biaya_perawatan_bayi`, `biaya_obat_obatan`, `biaya_cucian`, `biaya_akte_kelahiran`, `biaya_transportasi`, `biaya_lain`) VALUES
(4,	'K636642690558369157',	'2018-06-10 11:10:00',	'Suami Ku',	'Pertolongan',	'Cara',	'Keadaan',	25,	18,	625000,	625000,	500000,	375000,	750000,	500000,	0,	500000),
(4,	'K636642691775120029',	'2018-06-10 11:10:00',	'Suami Dia',	'ded',	'sedse',	'seede',	33,	18,	750000,	875000,	375000,	500000,	625000,	375000,	0,	625000),
(4,	'K636656199511148552',	'2018-06-26 02:25:00',	'sdeeed',	'dede',	'sdsad',	'sadasd',	12,	18,	500000,	500000,	500000,	500000,	500000,	500000,	500000,	500000);

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
  PRIMARY KEY (`id_obat`),
  KEY `id_jobat` (`id_jobat`),
  KEY `id_sat_obat` (`id_sat_obat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_obat` (`id_obat`, `nm_obat`, `stok`, `status`, `id_jobat`, `hrg_obat`, `id_sat_obat`) VALUES
(1,	'Kabe',	1,	'Aktif',	1,	10000,	25),
(2,	'Ringan',	2,	'Aktif',	2,	1800,	25),
(8,	'Suntik',	3,	'Aktif',	1,	9000,	25),
(9,	'Parasetamol',	5,	'Aktif',	2,	1100,	25),
(10,	'STM',	0,	'Aktif',	2,	1000,	25),
(11,	'Promag',	6,	'Aktif',	2,	2000,	25),
(12,	'Amoxilin',	37,	'Aktif',	2,	3000,	25),
(13,	'Vitamin C',	10,	'Aktif',	2,	12000,	25),
(14,	'sitrizin',	20,	'Aktif',	2,	12000,	23);

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
(5,	'Pasien Laki',	'1990-08-01',	'Laki-laki',	'Tukang Angkek',	'Perumahan '),
(6,	'Pasien tes',	'2018-06-24',	'Laki-laki',	'pekerjaan',	'pekerjaan');

DROP TABLE IF EXISTS `tbl_periksa`;
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

INSERT INTO `tbl_periksa` (`id_periksa`, `tgl_periksa`, `no_pasien`, `keluhan`, `tensi`, `id_sat_tensi`) VALUES
('2306180331476494',	'2018-06-23 08:33:04',	4,	'xzcdccdcdcd',	'120/80',	26),
('2306180333049771',	'2018-06-23 08:34:23',	4,	'knfkdsnkfnksnfjewf',	'120/80',	26),
('2406181221466191',	'2018-06-24 05:22:44',	4,	'Keluhan panjang...\r\nG 2\r\nA 2\r\nD 2,',	'120/80',	26),
('2606180220310811',	'2018-06-26 07:22:53',	4,	'sakik kaposdasas\r\ndsassa\r\nasdsad',	'/',	26),
('2706180200450315',	'2018-06-27 07:01:03',	4,	'daasas',	'90/120',	26),
('2706181039150928',	'2018-06-27 03:39:52',	4,	'dasdasdadww',	'90/120',	26),
('270620180513365982',	'2018-06-27 10:14:01',	4,	'Pemeriksaan/Pemasangan KB',	'60/120',	26);

DROP TABLE IF EXISTS `tbl_periksa_kb`;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_periksa_kb` (`id_periksa_kb`, `id_periksa`, `nm_suami`, `anak_ke`, `haid_terakhir`, `berat_badan`, `id_sat_berat`) VALUES
(1,	'270620180513365982',	'Suami dia',	2,	'2018-06-27',	20,	1);

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
(26,	'MMHG',	5),
(27,	'Botol',	4),
(28,	'Sachet',	4);

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
(1,	1,	3,	'100620181115456348'),
(5,	10,	2,	'1006181122392383'),
(6,	1,	2,	'110620181206354178'),
(7,	8,	1,	'110620181214334910'),
(8,	13,	2,	'1106181056409573'),
(9,	10,	2,	'1106181056409573'),
(10,	10,	1,	'2606180220310811'),
(11,	11,	20,	'2606180220310811'),
(12,	9,	2,	'2706181039150928'),
(13,	12,	3,	'2706181039150928'),
(14,	11,	4,	'2706180200450315'),
(15,	1,	2,	'270620180513365982');

DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `jenis` enum('Bidan','Pemilik') NOT NULL,
  `nama` varchar(50) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tbl_terapi` FOR EACH ROW update tbl_obat set stok = stok - new.jumlah where id_obat = new.id_obat;

CREATE TRIGGER `reset_stok` AFTER DELETE ON `tbl_terapi` FOR EACH ROW update tbl_obat set stok = stok + OLD.jumlah where id_obat = OLD.id_obat;

CREATE VIEW `daftar_pasien` AS select `tbl_pasien`.`no_pasien` AS `No_Pasien`,`tbl_pasien`.`nm_pasien` AS `Nama_Pasien`,date_format(`tbl_pasien`.`tgl_lahir`,'%d/%m/%Y') AS `Tanggal_Lahir`,`tbl_pasien`.`jk` AS `Jenis_Kelamin`,`tbl_pasien`.`pekerjaan` AS `Pekerjaan`,`tbl_pasien`.`alamat` AS `Alamat` from `tbl_pasien`;
CREATE VIEW `daftar_satuan` AS select `a`.`id_sat` AS `Id_Sat`,`a`.`nm_sat` AS `Nama_Satuan`,`a`.`id_jsat` AS `Id_Jsat`,`b`.`nm_jsat` AS `Nama_Jenis_Satuan` from (`tbl_satuan` `a` join `tbl_jsatuan` `b` on((`a`.`id_jsat` = `b`.`id_jsat`)));
CREATE VIEW `daftar_obat` AS select `a`.`id_obat` AS `Id_Obat`,`a`.`nm_obat` AS `Nama_Obat`,`a`.`stok` AS `Stok`,`b`.`id_jobat` AS `Id_Jobat`,`b`.`nm_jobat` AS `Jenis_Obat`,`a`.`id_sat_obat` AS `Id_Sat_Obat`,`c`.`Nama_Satuan` AS `Satuan`,`a`.`hrg_obat` AS `Harga_Obat` from ((`tbl_obat` `a` join `tbl_jenis_obat` `b` on((`a`.`id_jobat` = `b`.`id_jobat`))) join `daftar_satuan` `c` on((`a`.`id_sat_obat` = `c`.`Id_Sat`)));
CREATE VIEW `daftar_obat_beli` AS select `a`.`id_terapi` AS `Id_Terapi`,`a`.`id_obat` AS `Id_Obat`,`a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`b`.`nm_obat` AS `Nama_Obat`,sum(`a`.`jumlah`) AS `Jumlah`,`b`.`hrg_obat` AS `Harga_Obat`,sum((`b`.`hrg_obat` * `a`.`jumlah`)) AS `Total_Harga` from ((`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`))) group by `a`.`id_periksa`,`a`.`id_obat`;
CREATE VIEW `laporan_anc` AS select `a`.`id_anc` AS `Id_Anc`,`a`.`id_periksa` AS `Id_Periksa`,`a`.`nm_suami` AS `Nama_Suami`,concat(`a`.`tinggi_bdn`,' ',`sat_tinggi`.`Nama_Satuan`) AS `Tinggi_Badan`,concat(`a`.`berat_bdn`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Badan`,`a`.`hpht` AS `hpht`,`a`.`htp` AS `htp`,concat(`a`.`umur_khmln`,' ',`sat_umur`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`kb_terakhir` AS `KB_Terakhir` from (((`tbl_anc` `a` join `daftar_satuan` `sat_tinggi` on((`a`.`id_sat_tinggi` = `sat_tinggi`.`Id_Sat`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_umur` on((`a`.`id_sat_umur` = `sat_umur`.`Id_Sat`)));
CREATE VIEW `laporan_terapi` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`tgl_periksa` AS `Tgl_Periksa`,`a`.`id_obat` AS `Id_Obat`,`b`.`Nama_Obat` AS `Nama_Obat`,`b`.`Harga_Obat` AS `Harga_Obat`,`a`.`jumlah` AS `Jumlah`,(`a`.`jumlah` * `b`.`Harga_Obat`) AS `Total`,`b`.`Satuan` AS `Satuan` from ((`tbl_terapi` `a` join `daftar_obat` `b` on((`a`.`id_obat` = `b`.`Id_Obat`))) join `tbl_periksa` `c` on((`a`.`id_periksa` = `c`.`id_periksa`)));
CREATE VIEW `laporan_rekap_pasien` AS select `a`.`id_periksa` AS `Id_Periksa`,`c`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`tgl_periksa` AS `Tanggal_Periksa`,`a`.`no_pasien` AS `No_Pasien`,`e`.`Tinggi_Badan` AS `Tinggi_Badan`,`e`.`Berat_Badan` AS `Berat_Badan`,`a`.`keluhan` AS `Keluhan/Diagnosa`,concat('Waktu HPHT ',`e`.`hpht`,'\r\nHTP ',`e`.`htp`,'\r\nUmur Kehamilan ',`e`.`Umur_Kehamilan`,'\r\nDiagnosa Tambahan',`a`.`keluhan`) AS `Diagnosa ANC`,concat(`a`.`tensi`,' ',`sat`.`Nama_Satuan`) AS `Tensi` from (((`tbl_periksa` `a` join `daftar_satuan` `sat` on((`a`.`id_sat_tensi` = `sat`.`Id_Sat`))) join `daftar_pasien` `c` on((`a`.`no_pasien` = `c`.`No_Pasien`))) left join `laporan_anc` `e` on((`a`.`id_periksa` = `e`.`Id_Periksa`)));
CREATE VIEW `daftar_kelahiran` AS select `a`.`no_pasien` AS `No_Pasien`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`b`.`Alamat` AS `Alamat`,`a`.`id_kelahiran` AS `Id_Kelahiran`,`a`.`tgl_kelahiran` AS `Tanggal_Kelahiran`,`a`.`nm_suami` AS `Nama_Suami`,`a`.`penolongan_persalinan` AS `Penolongan_Persalinan`,`a`.`cara_persalinan` AS `Cara_Persalinan`,`a`.`keadaan_ibu` AS `Keadaan_Ibu`,concat(`a`.`umur_kehamilan`,' ',`c`.`Nama_Satuan`) AS `Umur_Kehamilan`,`a`.`biaya_persalinan` AS `Biaya_Persalinan`,`a`.`biaya_perawatan_kelas` AS `Biaya_Perawatan`,`a`.`biaya_perawatan_bayi` AS `Biaya_Perawatan_Bayi`,`a`.`biaya_obat_obatan` AS `Biaya_Obat_Obatan`,`a`.`biaya_cucian` AS `Biaya_Cucian`,`a`.`biaya_akte_kelahiran` AS `Biaya_Akte`,`a`.`biaya_transportasi` AS `Biaya_Transportasi`,`a`.`biaya_lain` AS `Biaya_Lain` from ((`tbl_kelahiran` `a` join `daftar_pasien` `b` on((`a`.`no_pasien` = `b`.`No_Pasien`))) join `daftar_satuan` `c` on((`a`.`id_sat_umur` = `c`.`Id_Sat`)));
CREATE VIEW `laporan_bayi_lahir` AS select `b`.`Id_Kelahiran` AS `Id_Kelahiran`,`b`.`Tanggal_Kelahiran` AS `Tanggal_Kelahiran`,`b`.`No_Pasien` AS `No_Pasien`,`b`.`Nama_Pasien` AS `Nama_Pasien`,`a`.`nm_bayi` AS `Nama_Bayi`,`a`.`waktu_lahir` AS `Waktu_Lahir`,`a`.`anak_ke` AS `Anak_Ke`,concat(`a`.`berat_lahir`,' ',`sat_berat`.`Nama_Satuan`) AS `Berat_Lahir`,concat(`a`.`panjang_badan`,' ',`sat_panjang`.`Nama_Satuan`) AS `Panjang_Badan`,concat(`a`.`lingkar_kepala`,' ',`sat_lingkar`.`Nama_Satuan`) AS `Lingkar_Kepala`,`a`.`jk` AS `Jenis_Kelamin`,`a`.`asuhan_bayi_saat_lahir` AS `Asuhan_Bayi_Saat_Lahir`,`a`.`keterangan` AS `Keterangan`,`a`.`kondisi_bayi` AS `Kondisi Bayi` from ((((`tbl_bayi_lahir` `a` join `daftar_kelahiran` `b` on((`a`.`id_kelahiran` = `b`.`Id_Kelahiran`))) join `daftar_satuan` `sat_berat` on((`a`.`id_sat_berat` = `sat_berat`.`Id_Sat`))) join `daftar_satuan` `sat_panjang` on((`a`.`id_sat_panjang` = `sat_panjang`.`Id_Sat`))) join `daftar_satuan` `sat_lingkar` on((`a`.`id_sat_lingkar` = `sat_lingkar`.`Id_Sat`)));
CREATE VIEW `laporan_kb` AS select `f`.`Id_Periksa` AS `Id_Periksa`,`f`.`Nama_Pasien` AS `Nama_Pasien`,`f`.`Tanggal_Periksa` AS `Tanggal_Periksa`,`f`.`No_Pasien` AS `No_Pasien`,`f`.`Tinggi_Badan` AS `Tinggi_Badan`,concat(`a`.`berat_badan`,' ',`d`.`Nama_Satuan`) AS `Berat_Badan`,`f`.`Keluhan/Diagnosa` AS `Keluhan/Diagnosa`,`f`.`Tensi` AS `Tensi`,`a`.`anak_ke` AS `Anak_Ke`,`a`.`haid_terakhir` AS `Haid_Terakhir`,`a`.`id_sat_berat` AS `Id_Sat_Berat`,`b`.`Nama_Obat` AS `Nama_Obat`,concat(`b`.`Jumlah`,' ',`b`.`Satuan`) AS `Jumlah` from (((`tbl_periksa_kb` `a` left join `laporan_rekap_pasien` `f` on((`a`.`id_periksa` = `f`.`Id_Periksa`))) join `laporan_terapi` `b` on((`a`.`id_periksa` = `b`.`Id_Periksa`))) join `daftar_satuan` `d` on((`a`.`id_sat_berat` = `d`.`Id_Sat`)));
CREATE VIEW `laporan_pemasukan` AS select `a`.`id_terapi` AS `id_terapi`,`a`.`id_periksa` AS `id_periksa`,`b`.`nm_obat` AS `nm_obat`,sum(`a`.`jumlah`) AS `jumlah`,sum((`a`.`jumlah` * `b`.`hrg_obat`)) AS `total_bayar` from (`tbl_terapi` `a` join `tbl_obat` `b` on((`a`.`id_obat` = `b`.`id_obat`))) group by `a`.`id_periksa`;
CREATE VIEW `laporan_harian` AS select `daftar_obat_beli`.`Tgl_Periksa` AS `Tgl_Periksa`,dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`) AS `hari`,`daftar_obat_beli`.`Nama_Obat` AS `Nama_Obat`,sum(`daftar_obat_beli`.`Jumlah`) AS `Jumlah`,sum(`daftar_obat_beli`.`Total_Harga`) AS `Total_harga` from `daftar_obat_beli` group by `daftar_obat_beli`.`Tgl_Periksa`,`daftar_obat_beli`.`Nama_Obat`;
CREATE VIEW `laporan_bulanan` AS select `daftar_obat_beli`.`Tgl_Periksa` AS `Tgl_Periksa`,sum(`daftar_obat_beli`.`Total_Harga`) AS `Total_harga` from `daftar_obat_beli` where ((month(`daftar_obat_beli`.`Tgl_Periksa`) = month(now())) and (year(`daftar_obat_beli`.`Tgl_Periksa`) = year(now()))) group by dayofmonth(`daftar_obat_beli`.`Tgl_Periksa`);
CREATE VIEW `laporan_tahunan` AS select `daftar_obat_beli`.`Tgl_Periksa` AS `Tgl_Periksa`,sum(`daftar_obat_beli`.`Total_Harga`) AS `Total_harga` from `daftar_obat_beli` where (year(`daftar_obat_beli`.`Tgl_Periksa`) = year(now())) group by month(`daftar_obat_beli`.`Tgl_Periksa`);
