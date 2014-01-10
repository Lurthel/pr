# --------------------------------------------------------
# Host:                         89.73.138.92
# Server version:               5.5.8
# Server OS:                    Win32
# HeidiSQL version:             6.0.0.3838
# Date/time:                    2011-05-26 12:14:21
# --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

# Dumping structure for table csharp.dokumenty
DROP TABLE IF EXISTS `dokumenty`;
CREATE TABLE IF NOT EXISTS `dokumenty` (
  `dokument_typ` varchar(255) DEFAULT NULL,
  `dokument_nr_seria` varchar(45) DEFAULT NULL,
  `dokument_nr_numer` int(11) DEFAULT NULL,
  `dokument_nr_rok` int(11) DEFAULT NULL,
  `dokument_nr` varchar(45) DEFAULT NULL,
  `dokument_kon_nazwa` varchar(255) DEFAULT NULL,
  `dokument_kon_adres` varchar(45) DEFAULT NULL,
  `dokument_kon_nip` varchar(45) DEFAULT NULL,
  `dokument_kon_regon` varchar(45) DEFAULT NULL,
  `dokument_kon_pesel` varchar(45) DEFAULT NULL,
  `dokument_id` int(11) NOT NULL AUTO_INCREMENT,
  `dokument_data` date NOT NULL,
  PRIMARY KEY (`dokument_id`)
) ENGINE=MyISAM AUTO_INCREMENT=46 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.dokumenty: 32 rows
/*!40000 ALTER TABLE `dokumenty` DISABLE KEYS */;
INSERT INTO `dokumenty` (`dokument_typ`, `dokument_nr_seria`, `dokument_nr_numer`, `dokument_nr_rok`, `dokument_nr`, `dokument_kon_nazwa`, `dokument_kon_adres`, `dokument_kon_nip`, `dokument_kon_regon`, `dokument_kon_pesel`, `dokument_id`, `dokument_data`) VALUES
	('PT', '222221', 22221, 2011, 'PT/2011/222221', 'Magazyn', '', '', '', '', 60, '2011-05-26'),
	('FA', '22231', 3221, 2011, 'FA/2011/22231', 'Agata', 'zxcvbn, 95-977 Kraków', '13654789654', '89657456987', '3265987456333', 59, '2011-05-26'),
	('KFA', '222221', 57, 2011, 'KFA/2011/222221', 'Poprawiona nazwa', 'Jakis adres, 36-985 Miasto', '12369874566', '25896547896', '', 58, '2011-05-26'),
	('FA', '222221', 2221, 2011, 'FA/2011/222221', 'Nowa Nazwa', 'Jakis adres, 36-985 Miasto', '12369874566', '25896547896', '98745698745698', 57, '2011-05-26'),
	('ZW', '2121', 47, 2011, 'ZW/2011/2121', 'Nowy Kontrahent', 'ul.Iksinska,95-968 Miastowo  ', '7896541236', '1456987456', '', 56, '2011-05-26'),
	('WT', '2212223', 21223, 2011, 'WT/2011/2212223', 'Nowy Kontrahent', 'ul.Iksinska,95-968 Miastowo  ', '7896541236', '1456987456', '46236598746', 53, '2011-05-26'),
	('PT', '21233', 2123, 2011, 'PT/2011/21233', 'Magazyn', '', '', '', '', 52, '2011-05-26'),
	('PT', '21212', 21, 2011, 'PT/2011/21212', 'Magazyn', '', '', '', '', 50, '2011-05-26'),
	('PT', '21212', 21, 2011, 'PT/2011/21212', 'Magazyn', '', '', '', '', 49, '2011-05-26'),
	('KFA', '2121', 47, 2011, 'KFA/2011/2121', 'Nowy Kontrahent poprawiony', 'ul.Iksinska,95-968 Miastowo  ', '7896541236', '1456987456', '', 48, '2011-05-26'),
	('FA', '2121', 21, 2011, 'FA/2011/2121', 'Nowy Kontrahent', 'ul.Iksinska,95-968 Miastowo  ', '7896541236', '1456987456', '46236598746', 47, '2011-05-26'),
	('FA', '1234', 123, 2011, 'FA/2011/1234', 'Agata', 'zxcvbn, 95-977 Kraków', '13654789654', '89657456987', '3265987456333', 46, '2011-05-26');
/*!40000 ALTER TABLE `dokumenty` ENABLE KEYS */;


# Dumping structure for table csharp.dokument_towary
DROP TABLE IF EXISTS `dokument_towary`;
CREATE TABLE IF NOT EXISTS `dokument_towary` (
  `dt_id` int(11) NOT NULL AUTO_INCREMENT,
  `dt_nazwa` varchar(45) DEFAULT NULL,
  `dt_jm` varchar(45) DEFAULT NULL,
  `dt_cena` varchar(45) DEFAULT NULL,
  `dt_vat` varchar(45) DEFAULT NULL,
  `dt_ilosc` varchar(45) DEFAULT NULL,
  `dt_nr_kat` varchar(45) DEFAULT NULL,
  `dokument_id` int(11) NOT NULL,
  PRIMARY KEY (`dt_id`),
  KEY `fk_dokument_towary_dokumenty1` (`dokument_id`)
) ENGINE=MyISAM AUTO_INCREMENT=106 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.dokument_towary: 103 rows
/*!40000 ALTER TABLE `dokument_towary` DISABLE KEYS */;
INSERT INTO `dokument_towary` (`dt_id`, `dt_nazwa`, `dt_jm`, `dt_cena`, `dt_vat`, `dt_ilosc`, `dt_nr_kat`, `dokument_id`) VALUES
	(184, 'Test opakwoanie 4', 'litr', '11', '23', '0', '1', 58),
	(183, 'Test m2', 'litr', '1', '8', '0', '1', 58),
	(182, 'Test komplet', 'litr', '1', '8', '0', '11', 58),
	(181, 'Komplet #1', 'litr', '213', '23', '0', '312', 58),
	(180, 'Test okna towar', 'szt', '1', '23', '0', '1', 58),
	(179, 'Test okna towar', 'szt', '1', '23', '1', '1', 57),
	(178, 'Komplet #1', 'litr', '213', '23', '223', '312', 57),
	(177, 'Test komplet', 'litr', '1', '8', '1', '11', 57),
	(176, 'Test m2', 'litr', '1', '8', '1', '1', 57),
	(175, 'Test opakwoanie 4', 'litr', '11', '23', '1', '1', 57),
	(174, 'Opakowanie Srosi', 'szt', '50', '8', '3', '12', 57),
	(173, 'Sda', 'litr', '123123', '23', '123', '123', 57),
	(172, 'Komplet #1', 'litr', '123', '8', '123', 'dsa', 57),
	(171, 'Towar #2', 'szt', '1', '1', '102', 'tj', 57),
	(170, 'Towar #1', 'szt', '1', '1', '2', 'tj', 57),
	(169, 'Test m2', 'litr', '1', '8', '1', '1', 57),
	(168, 'Test opakwoanie 4', 'litr', '11', '23', '1', '1', 57),
	(167, 'Test okna towar', 'szt', '1', '23', '10001', '1', 57),
	(166, 'Test', 'litr', '1', '8', '1', '12313', 56),
	(165, 'Chleb', 'szt', '43', '3', '1242', '92342', 56),
	(164, 'TestAsd', 'litr', '12', '3', '12', '12', 56),
	(163, 'Chleb', 'szt', '43', '3', '1242', '92342', 56),
	(162, 'Test', 'litr', '1', '8', '1', '12313', 56),
	(161, 'Sda', 'litr', '123123', '23', '123', '123', 56),
	(160, 'Test okna towar', 'szt', '1', '23', '1', '1', 56),
	(159, 'Komplet to nie jest 2', 'litr', '123123', '8', '3', '123', 56),
	(158, 'Test', 'litr', '1', '8', '1', '12313', 55),
	(157, 'Chleb', 'szt', '43', '3', '1242', '92342', 55),
	(156, 'TestAsd', 'litr', '12', '3', '12', '12', 55),
	(155, 'Chleb', 'szt', '43', '3', '1242', '92342', 55),
	(154, 'Test', 'litr', '1', '8', '1', '12313', 55),
	(153, 'Sda', 'litr', '123123', '23', '123', '123', 55),
	(152, 'Test okna towar', 'szt', '1', '23', '1', '1', 55),
	(151, 'Komplet to nie jest 2', 'litr', '123123', '8', '3', '123', 55),
	(150, 'Opakowanie Srosi', 'szt', '50', '8', '1', '12', 54),
	(149, 'Komplet #2', 'tuzin', '12', '8', '1', '23', 54),
	(148, 'Chleb', 'szt', '43', '3', '1', '92342', 54),
	(147, 'Opakowanie Srosi', 'szt', '50', '8', '1', '12', 53),
	(146, 'Komplet #2', 'tuzin', '12', '8', '1', '23', 53),
	(145, 'Chleb', 'szt', '43', '3', '1', '92342', 53),
	(144, 'Opakowanie Srosi', 'szt', '50', '8', '1', '12', 52),
	(143, 'Sda', 'litr', '123123', '23', '1', '123', 52),
	(142, 'Sda', 'litr', '123123', '23', '1', '123', 52),
	(141, 'Opakowanie Srosi', 'szt', '50', '8', '1', '12', 51),
	(140, 'Sda', 'litr', '123123', '23', '1', '123', 51),
	(139, 'Sda', 'litr', '123123', '23', '1', '123', 51),
	(138, 'Komplet #1', 'litr', '213', '23', '100', '312', 50),
	(137, 'Sda', 'litr', '123123', '23', '100', '123', 50),
	(136, 'Sda', 'litr', '123123', '23', '1000', '123', 50),
	(135, 'Chleb', 'szt', '43', '3', '1000', '92342', 50),
	(134, 'Towar #2', 'szt', '1', '1', '100', 'tj', 50),
	(133, 'Test okna towar', 'szt', '1', '23', '10000', '1', 50),
	(132, 'Komplet #1', 'litr', '213', '23', '100', '312', 49),
	(131, 'Sda', 'litr', '123123', '23', '100', '123', 49),
	(130, 'Sda', 'litr', '123123', '23', '1000', '123', 49),
	(129, 'Chleb', 'szt', '43', '3', '1000', '92342', 49),
	(128, 'Towar #2', 'szt', '1', '1', '100', 'tj', 49),
	(127, 'Test okna towar', 'szt', '1', '23', '10000', '1', 49),
	(126, 'Test', 'litr', '21', '8', '0', '12313', 48),
	(125, 'Chleb', 'szt', '21', '3', '0', '92342', 48),
	(124, 'TestAsd', 'litr', '21', '3', '0', '12', 48),
	(123, 'Chleb', 'szt', '21', '3', '0', '92342', 48),
	(122, 'Test', 'litr', '21', '8', '0', '12313', 48),
	(121, 'Sda', 'litr', '21', '23', '0', '123', 48),
	(120, 'Test okna towar', 'szt', '21', '23', '0', '1', 48),
	(119, 'Komplet to nie jest 2', 'litr', '21', '8', '0', '123', 48),
	(118, 'Komplet to nie jest 2', 'litr', '123123', '8', '3', '123', 47),
	(117, 'Test okna towar', 'szt', '1', '23', '1', '1', 47),
	(116, 'Sda', 'litr', '123123', '23', '123', '123', 47),
	(115, 'Test', 'litr', '1', '8', '1', '12313', 47),
	(114, 'Chleb', 'szt', '43', '3', '1242', '92342', 47),
	(113, 'TestAsd', 'litr', '12', '3', '12', '12', 47),
	(112, 'Chleb', 'szt', '43', '3', '1242', '92342', 47),
	(111, 'Test', 'litr', '1', '8', '1', '12313', 47),
	(110, 'Test', 'litr', '1', '8', '1', '12313', 46),
	(109, 'Towar #2', 'szt', '1', '1', '2', 'tj', 46),
	(108, 'Test opakwoanie 4', 'litr', '11', '23', '1', '1', 46),
	(107, 'Towar #1', 'szt', '1', '1', '2', 'tj', 46),
	(106, 'Opakowanie Srosi', 'szt', '50', '8', '3', '12', 46),
	(185, 'Opakowanie Srosi', 'szt', '50', '8', '0', '12', 58),
	(186, 'Sda', 'litr', '123123', '23', '0', '123', 58),
	(187, 'Komplet #1', 'litr', '123', '8', '0', 'dsa', 58),
	(188, 'Towar #2', 'szt', '1', '1', '0', 'tj', 58),
	(189, 'Towar #1', 'szt', '1', '1', '0', 'tj', 58),
	(190, 'Test m2', 'litr', '1', '8', '0', '1', 58),
	(191, 'Test opakwoanie 4', 'litr', '11', '23', '0', '1', 58),
	(192, 'Test okna towar', 'szt', '1', '23', '0', '1', 58),
	(193, 'Komplet to nie jest 2', 'litr', '123123', '8', '3', '123', 59),
	(194, 'Opakowanie Srosi', 'szt', '50', '8', '3', '12', 59),
	(195, 'Chleb', 'szt', '43', '3', '2242', '92342', 59),
	(196, 'Sda', 'litr', '123123', '23', '123', '123', 59),
	(197, 'TestAsd', 'litr', '12', '3', '12', '12', 59),
	(198, 'Test komplet', 'litr', '1', '8', '1', '11', 59),
	(199, 'Produkt testowy', 'litr', '123', '8', '100', '123', 60),
	(200, 'Produkt testowy', 'litr', '123', '8', '70', '123', 60),
	(201, 'RTest', 'szt', '33', '8', '70', '442342', 60),
	(202, 'Produkt testowy', 'litr', '123', '8', '77', '123', 60);
/*!40000 ALTER TABLE `dokument_towary` ENABLE KEYS */;


# Dumping structure for table csharp.grupy
DROP TABLE IF EXISTS `grupy`;
CREATE TABLE IF NOT EXISTS `grupy` (
  `grupa_id` int(11) NOT NULL AUTO_INCREMENT,
  `grupa_nazwa` varchar(45) DEFAULT NULL,
  `grupa_rodzic` int(11) DEFAULT '0',
  `grupa_poziom` int(11) DEFAULT '1',
  PRIMARY KEY (`grupa_id`),
  KEY `rodzic` (`grupa_rodzic`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.grupy: 10 rows
/*!40000 ALTER TABLE `grupy` DISABLE KEYS */;
INSERT INTO `grupy` (`grupa_id`, `grupa_nazwa`, `grupa_rodzic`, `grupa_poziom`) VALUES
	(1, 'Grupa #1', 0, 1),
	(2, 'Pieczywo', 0, 1),
	(21, 'Testowa', 0, 1),
	(23, 'Grupa #2', 0, 1),
	(24, 'Grupa #3', 0, 1),
	(25, 'Grupa #4', 0, 1),
	(26, 'Grupa #5', 0, 1),
	(27, 'Grupa #6', 0, 1),
	(28, 'Rowery', 0, 1),
	(29, 'Komputery', 0, 1);
/*!40000 ALTER TABLE `grupy` ENABLE KEYS */;


# Dumping structure for table csharp.inwentaryzacja_elementy
DROP TABLE IF EXISTS `inwentaryzacja_elementy`;
CREATE TABLE IF NOT EXISTS `inwentaryzacja_elementy` (
  `element_id` int(11) NOT NULL AUTO_INCREMENT,
  `element_nazwa` varchar(45) DEFAULT NULL,
  `element_nr_kat` varchar(45) DEFAULT NULL,
  `element_ilosc_system` float DEFAULT NULL,
  `element_ilosc_natura` float DEFAULT NULL,
  PRIMARY KEY (`element_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

# Dumping data for table csharp.inwentaryzacja_elementy: 0 rows
/*!40000 ALTER TABLE `inwentaryzacja_elementy` DISABLE KEYS */;
/*!40000 ALTER TABLE `inwentaryzacja_elementy` ENABLE KEYS */;


# Dumping structure for table csharp.inwentaryzacje
DROP TABLE IF EXISTS `inwentaryzacje`;
CREATE TABLE IF NOT EXISTS `inwentaryzacje` (
  `inwentaryzacja_id` int(11) NOT NULL AUTO_INCREMENT,
  `inwentaryzacja_data_rozpoczecie` date NOT NULL,
  `inwentaryzacja_data_zakonczenie` date DEFAULT NULL,
  `inwentaryzacja_uwagi` text,
  PRIMARY KEY (`inwentaryzacja_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

# Dumping data for table csharp.inwentaryzacje: 0 rows
/*!40000 ALTER TABLE `inwentaryzacje` DISABLE KEYS */;
/*!40000 ALTER TABLE `inwentaryzacje` ENABLE KEYS */;


# Dumping structure for table csharp.kontrahenci
DROP TABLE IF EXISTS `kontrahenci`;
CREATE TABLE IF NOT EXISTS `kontrahenci` (
  `kontrahent_id` int(11) NOT NULL AUTO_INCREMENT,
  `kontrahent_nazwa` varchar(45) DEFAULT NULL,
  `kontrahent_adres` varchar(45) DEFAULT NULL,
  `kontrahent_nip` varchar(45) DEFAULT NULL,
  `kontrahent_regon` varchar(45) DEFAULT NULL,
  `kontrahent_pesel` varchar(45) DEFAULT NULL,
  `kontrahent_nr_kontaktowy` varchar(45) DEFAULT NULL,
  `kontrahent_data_rejestracji` date DEFAULT NULL,
  PRIMARY KEY (`kontrahent_id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.kontrahenci: 5 rows
/*!40000 ALTER TABLE `kontrahenci` DISABLE KEYS */;
INSERT INTO `kontrahenci` (`kontrahent_id`, `kontrahent_nazwa`, `kontrahent_adres`, `kontrahent_nip`, `kontrahent_regon`, `kontrahent_pesel`, `kontrahent_nr_kontaktowy`, `kontrahent_data_rejestracji`) VALUES
	(6, 'Nowa Nazwa', 'Jakis adres, 36-985 Miasto', '12369874566', '25896547896', '98745698745698', '321-321-321', '2011-05-07'),
	(7, 'Nowy Kontrahent', 'ul.Iksinska,95-968 Miastowo  ', '7896541236', '1456987456', '46236598746', '125-987-654', '2011-05-17'),
	(5, 'Agata', 'zxcvbn, 95-977 Kraków', '13654789654', '89657456987', '3265987456333', '326-987-654', '2011-05-07'),
	(8, 'adadad', 'asdasdasdasd', '123123123222', '1231231231232', '89052104223', '413241232', '2011-05-18'),
	(11, 'Klient', 'Testowy', '0', '0', '897456200268', '6598-9872-625', '2011-05-26');
/*!40000 ALTER TABLE `kontrahenci` ENABLE KEYS */;


# Dumping structure for table csharp.magazyny
DROP TABLE IF EXISTS `magazyny`;
CREATE TABLE IF NOT EXISTS `magazyny` (
  `magazyn_id` int(11) NOT NULL AUTO_INCREMENT,
  `magazyn_nazwa` varchar(45) NOT NULL,
  `magazyn_lokalizacja` varchar(45) NOT NULL,
  `magazyn_data_utworzenia` date DEFAULT NULL,
  PRIMARY KEY (`magazyn_id`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.magazyny: 5 rows
/*!40000 ALTER TABLE `magazyny` DISABLE KEYS */;
INSERT INTO `magazyny` (`magazyn_id`, `magazyn_nazwa`, `magazyn_lokalizacja`, `magazyn_data_utworzenia`) VALUES
	(33, 'Magazyn Nazwa', 'Nazwowosc', '2011-05-19'),
	(34, 'Magazyn Testowy', 'Testowosc', '2011-05-26'),
	(2, 'Magazyn Warszafka', 'Warszawa', NULL),
	(30, 'Magazyn NT', 'Nowy Targ', '2011-05-17'),
	(29, 'Magazyn 51', 'Strefa 51', '2011-05-17');
/*!40000 ALTER TABLE `magazyny` ENABLE KEYS */;


# Dumping structure for table csharp.slownik
DROP TABLE IF EXISTS `slownik`;
CREATE TABLE IF NOT EXISTS `slownik` (
  `slownik_id` int(11) NOT NULL AUTO_INCREMENT,
  `slownik_value` varchar(45) DEFAULT NULL,
  `slownik_typ` varchar(45) DEFAULT NULL,
  `slownik_activ` int(1) DEFAULT '1',
  PRIMARY KEY (`slownik_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

# Dumping data for table csharp.slownik: 0 rows
/*!40000 ALTER TABLE `slownik` DISABLE KEYS */;
/*!40000 ALTER TABLE `slownik` ENABLE KEYS */;


# Dumping structure for table csharp.towary
DROP TABLE IF EXISTS `towary`;
CREATE TABLE IF NOT EXISTS `towary` (
  `towar_id` int(11) NOT NULL AUTO_INCREMENT,
  `magazyn_id` int(11) NOT NULL,
  `towar_nazwa` varchar(45) NOT NULL,
  `towar_jm` varchar(45) NOT NULL,
  `towar_nr_kat` varchar(45) NOT NULL,
  `towar_cena` double NOT NULL,
  `towar_stan_min` double NOT NULL DEFAULT '0',
  `towar_vat` int(11) NOT NULL,
  `towar_min_marza` double NOT NULL DEFAULT '0',
  `grupa_id` int(11) DEFAULT '0',
  `towar_stan` double DEFAULT '0',
  `towar_opakowanie_id` int(11) DEFAULT NULL,
  `towar_sztuk_opakowanie` double DEFAULT NULL,
  PRIMARY KEY (`towar_id`,`magazyn_id`),
  KEY `fk_towary_towary_towary1` (`towar_id`),
  KEY `fk_towary_grupy1` (`grupa_id`),
  KEY `fk_opakowania` (`towar_opakowanie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6298 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.towary: 72 rows
/*!40000 ALTER TABLE `towary` DISABLE KEYS */;
INSERT INTO `towary` (`towar_id`, `magazyn_id`, `towar_nazwa`, `towar_jm`, `towar_nr_kat`, `towar_cena`, `towar_stan_min`, `towar_vat`, `towar_min_marza`, `grupa_id`, `towar_stan`, `towar_opakowanie_id`, `towar_sztuk_opakowanie`) VALUES
	(6286, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 123, NULL, NULL),
	(6287, 2, 'Komplet #1', 'litr', 'dsa', 123, 123, 8, 123, 1, 123, NULL, NULL),
	(6288, 2, 'Komplet #2', 'tuzin', '23', 12, 1, 8, 123, 1, 123, NULL, NULL),
	(6290, 2, 'Opakowanie Srosi', 'szt', '12', 50, 2, 8, 20, 21, 3, 6289, 5),
	(6291, 2, 'TestAsd', 'litr', '12', 12, 12, 3, 12, 1, 12, NULL, NULL),
	(6292, 2, 'Test', 'litr', '12313', 1, 1, 8, 1, 2, 1, NULL, NULL),
	(6293, 2, 'Test m2', 'litr', '1', 1, 1, 8, 1, 21, 1, NULL, NULL),
	(6294, 2, 'Towar #1', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6295, 33, 'RTest', 'szt', '442342', 33, 10, 8, 10, 24, 2005, NULL, NULL),
	(6296, 2, 'Chleb', 'szt', '92342', 43, 14, 3, 2, 1, 1242, NULL, NULL),
	(6297, 2, 'Towar #2', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6298, 33, 'Produkt testowy', 'litr', '123', 123, 1, 8, 1, 1, 112, 6295, 12),
	(6299, 2, 'Towar #1', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6300, 2, 'Towar #2', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6301, 2, 'Komplet #1', 'litr', 'dsa', 123, 123, 8, 123, 1, 123, NULL, NULL),
	(6302, 2, 'Chleb', 'szt', '92342', 43, 14, 3, 2, 1, 1242, NULL, NULL),
	(6303, 33, 'RTest', 'szt', '442342', 33, 10, 8, 10, 24, 2005, NULL, NULL),
	(6304, 2, 'Komplet #1', 'litr', '312', 213, 123123, 23, 132, 2, 123, NULL, NULL),
	(6305, 2, 'Komplet #2', 'tuzin', '23', 12, 1, 8, 123, 1, 123, NULL, NULL),
	(6306, 2, 'Test', 'litr', '12313', 1, 1, 8, 1, 2, 1, NULL, NULL),
	(6307, 2, 'Komplet to nie jest 2', 'litr', '123', 123123, 1, 8, 12, 2, 3, NULL, NULL),
	(6308, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 123, NULL, NULL),
	(6309, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 123, NULL, NULL),
	(6310, 33, 'Produkt testowy', 'litr', '123', 123, 1, 8, 1, 1, 82, 6295, 12),
	(6311, 2, 'Opakowanie Srosi', 'szt', '12', 50, 2, 8, 20, 21, 3, 6289, 5),
	(6312, 2, 'TestAsd', 'litr', '12', 12, 12, 3, 12, 1, 12, NULL, NULL),
	(6313, 2, 'Test komplet', 'litr', '11', 1, 11, 8, 1, 2, 1, NULL, NULL),
	(6314, 2, 'Test okna towar', 'szt', '1', 1, 1, 23, 1, 2, 1, NULL, NULL),
	(6315, 2, 'Test opakwoanie 4', 'litr', '1', 11, 1, 23, 1, 1, 1, 6280, 1),
	(6316, 2, 'Test m2', 'litr', '1', 1, 1, 8, 1, 21, 1, NULL, NULL),
	(6317, 2, 'Towar #1', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6318, 2, 'Towar #2', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6319, 2, 'Komplet #1', 'litr', 'dsa', 123, 123, 8, 123, 1, 123, NULL, NULL),
	(6320, 2, 'Chleb', 'szt', '92342', 43, 14, 3, 2, 1, 1241, NULL, NULL),
	(6321, 33, 'RTest', 'szt', '442342', 33, 10, 8, 10, 24, 2075, NULL, NULL),
	(6322, 2, 'Komplet #1', 'litr', '312', 213, 123123, 23, 132, 2, 123, NULL, NULL),
	(6323, 2, 'Komplet #2', 'tuzin', '23', 12, 1, 8, 123, 1, 122, NULL, NULL),
	(6324, 2, 'Test', 'litr', '12313', 1, 1, 8, 1, 2, 1, NULL, NULL),
	(6325, 2, 'Komplet to nie jest 2', 'litr', '123', 123123, 1, 8, 12, 2, 3, NULL, NULL),
	(6326, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 124, NULL, NULL),
	(6327, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 124, NULL, NULL),
	(6328, 33, 'Produkt testowy', 'litr', '123', 123, 1, 8, 1, 1, 89, 6295, 12),
	(6329, 2, 'Opakowanie Srosi', 'szt', '12', 50, 2, 8, 20, 21, 3, 6289, 5),
	(6330, 2, 'TestAsd', 'litr', '12', 12, 12, 3, 12, 1, 12, NULL, NULL),
	(6331, 2, 'Test komplet', 'litr', '11', 1, 11, 8, 1, 2, 1, NULL, NULL),
	(6332, 2, 'Test okna towar', 'szt', '1', 1, 1, 23, 1, 2, 10001, NULL, NULL),
	(6333, 2, 'Test opakwoanie 4', 'litr', '1', 11, 1, 23, 1, 1, 1, 6280, 1),
	(6334, 2, 'Test m2', 'litr', '1', 1, 1, 8, 1, 21, 1, NULL, NULL),
	(6335, 2, 'Towar #1', 'szt', 'tj', 1, 2, 1, 2, 0, 2, NULL, NULL),
	(6336, 2, 'Towar #2', 'szt', 'tj', 1, 2, 1, 2, 0, 102, NULL, NULL),
	(6337, 2, 'Komplet #1', 'litr', 'dsa', 123, 123, 8, 123, 1, 123, NULL, NULL),
	(6338, 2, 'Chleb', 'szt', '92342', 43, 14, 3, 2, 1, 2242, NULL, NULL),
	(6339, 33, 'RTest', 'szt', '442342', 33, 10, 8, 10, 24, 2005, NULL, NULL),
	(6340, 2, 'Komplet #1', 'litr', '312', 213, 123123, 23, 132, 2, 123, NULL, NULL),
	(6341, 2, 'Komplet #2', 'tuzin', '23', 12, 1, 8, 123, 1, 123, NULL, NULL),
	(6342, 2, 'Test', 'litr', '12313', 1, 1, 8, 1, 2, 1, NULL, NULL),
	(6343, 2, 'Komplet to nie jest 2', 'litr', '123', 123123, 1, 8, 12, 2, 3, NULL, NULL),
	(6344, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 1123, NULL, NULL),
	(6345, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 123, NULL, NULL),
	(6346, 33, 'Produkt testowy', 'litr', '123', 123, 1, 8, 1, 1, 12, 6295, 12),
	(6347, 2, 'Opakowanie Srosi', 'szt', '12', 50, 2, 8, 20, 21, 3, 6289, 5),
	(6348, 2, 'TestAsd', 'litr', '12', 12, 12, 3, 12, 1, 12, NULL, NULL),
	(6349, 2, 'Test komplet', 'litr', '11', 1, 11, 8, 1, 2, 1, NULL, NULL),
	(6350, 2, 'Test okna towar', 'szt', '1', 1, 1, 23, 1, 2, 1, NULL, NULL),
	(6351, 2, 'Test opakwoanie 4', 'litr', '1', 11, 1, 23, 1, 1, 1, 6280, 1),
	(6352, 2, 'Test m2', 'litr', '1', 1, 1, 8, 1, 21, 1, NULL, NULL),
	(6285, 2, 'Sda', 'litr', '123', 123123, 123, 23, 123, 2, 223, NULL, NULL),
	(6282, 2, 'Test komplet', 'litr', '11', 1, 11, 8, 1, 2, 1, NULL, NULL),
	(6283, 2, 'Komplet to nie jest 2', 'litr', '123', 123123, 1, 8, 12, 2, 3, NULL, NULL),
	(6284, 2, 'Komplet #1', 'litr', '312', 213, 123123, 23, 132, 2, 223, NULL, NULL),
	(6280, 2, 'Test okna towar', 'szt', '1', 1, 1, 23, 1, 2, 1, NULL, NULL),
	(6281, 2, 'Test opakwoanie 4', 'litr', '1', 11, 1, 23, 1, 1, 1, 6280, 1);
/*!40000 ALTER TABLE `towary` ENABLE KEYS */;


# Dumping structure for table csharp.towary_towary
DROP TABLE IF EXISTS `towary_towary`;
CREATE TABLE IF NOT EXISTS `towary_towary` (
  `tt_id` int(11) NOT NULL AUTO_INCREMENT,
  `tt_komplet_id` int(11) NOT NULL,
  `tt_towar_id` int(11) NOT NULL,
  PRIMARY KEY (`tt_id`)
) ENGINE=MyISAM AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

# Dumping data for table csharp.towary_towary: 8 rows
/*!40000 ALTER TABLE `towary_towary` DISABLE KEYS */;
INSERT INTO `towary_towary` (`tt_id`, `tt_komplet_id`, `tt_towar_id`) VALUES
	(26, 6288, 6290),
	(25, 6288, 6289),
	(24, 6288, 6288),
	(23, 6288, 6287),
	(22, 6288, 6286),
	(27, 6288, 6282),
	(28, 6288, 6283),
	(29, 6288, 6284);
/*!40000 ALTER TABLE `towary_towary` ENABLE KEYS */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
