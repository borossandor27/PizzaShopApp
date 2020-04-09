-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Ápr 01. 11:16
-- Kiszolgáló verziója: 10.1.36-MariaDB
-- PHP verzió: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `pizzashop`
--
CREATE DATABASE IF NOT EXISTS `pizzashop` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `pizzashop`;

-- --------------------------------------------------------

--
-- A nézet helyettes szerkezete `minden`
-- (Lásd alább az aktuális nézetet)
--
CREATE TABLE IF NOT EXISTS `minden` (
`razon` int(2)
,`vazon` int(1)
,`fazon` int(1)
,`datum` varchar(19)
,`fnev` varchar(12)
,`ftel` varchar(13)
,`vnev` varchar(6)
,`vcim` varchar(36)
,`pazon` int(1)
,`db` int(1)
,`par` int(4)
,`ertek` bigint(21)
);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pfutar`
--

CREATE TABLE IF NOT EXISTS `pfutar` (
  `fazon` int(1) NOT NULL AUTO_INCREMENT,
  `fnev` varchar(12) DEFAULT NULL,
  `ftel` varchar(13) DEFAULT NULL,
  PRIMARY KEY (`fazon`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `pfutar`
--

INSERT INTO `pfutar` (`fazon`, `fnev`, `ftel`) VALUES
(1, 'Hurrikán', '+36 90 123456'),
(2, 'Gyalogkakukk', '+36 90 666666'),
(3, 'Gömbvillám', '+36 90 888888'),
(4, 'Szélvész', '+36 90 258369'),
(5, 'Imperial', '+36 90 987654');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ppizza`
--

CREATE TABLE IF NOT EXISTS `ppizza` (
  `pazon` int(1) NOT NULL AUTO_INCREMENT,
  `pnev` varchar(14) DEFAULT NULL,
  `par` int(4) DEFAULT NULL,
  PRIMARY KEY (`pazon`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `ppizza`
--

INSERT INTO `ppizza` (`pazon`, `pnev`, `par`) VALUES
(1, 'Capricciosa', 900),
(2, 'Frutti di Mare', 1100),
(3, 'Hawaii', 780),
(4, 'Vesuvio', 890),
(5, 'Sorrento', 990);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `prendeles`
--

CREATE TABLE IF NOT EXISTS `prendeles` (
  `razon` int(2) NOT NULL AUTO_INCREMENT,
  `vazon` int(1) DEFAULT NULL,
  `fazon` int(1) DEFAULT NULL,
  `datum` varchar(19) DEFAULT NULL,
  PRIMARY KEY (`razon`),
  KEY `fk5` (`vazon`),
  KEY `fk6` (`fazon`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `prendeles`
--

INSERT INTO `prendeles` (`razon`, `vazon`, `fazon`, `datum`) VALUES
(1, 4, 2, '2020-03-19 01:27:22'),
(2, 7, 2, '2020-03-19 04:05:16'),
(3, 1, 1, '2020-03-19 10:53:36'),
(4, 5, 2, '2020-03-19 16:26:48'),
(5, 2, 3, '2020-03-20 00:03:57'),
(6, 4, 2, '2020-03-20 03:02:44'),
(7, 6, 2, '2020-03-20 08:35:31'),
(8, 7, 4, '2020-03-20 10:52:23'),
(9, 1, 5, '2020-03-20 12:57:01'),
(10, 3, 5, '2020-03-20 17:31:50'),
(11, 2, 1, '2020-03-20 18:24:19'),
(12, 5, 2, '2020-03-21 03:03:48'),
(13, 6, 2, '2020-03-21 05:31:04'),
(14, 4, 3, '2020-03-21 07:49:54'),
(15, 1, 4, '2020-03-21 09:20:24'),
(16, 2, 5, '2020-03-21 17:32:24'),
(17, 7, 2, '2020-03-22 02:39:51'),
(18, 3, 2, '2020-03-22 04:37:56'),
(19, 4, 5, '2020-03-22 05:48:59'),
(20, 1, 1, '2020-03-23 07:08:27'),
(21, 5, 3, '2020-03-23 15:40:05');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ptetel`
--

CREATE TABLE IF NOT EXISTS `ptetel` (
  `razon` int(2) DEFAULT NULL,
  `pazon` int(1) DEFAULT NULL,
  `db` int(1) DEFAULT NULL,
  KEY `fk3` (`razon`),
  KEY `fk4` (`pazon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `ptetel`
--

INSERT INTO `ptetel` (`razon`, `pazon`, `db`) VALUES
(1, 1, 2),
(1, 4, 3),
(2, 2, 1),
(3, 1, 2),
(4, 1, 1),
(4, 4, 1),
(5, 2, 4),
(6, 1, 1),
(6, 4, 1),
(6, 5, 1),
(7, 5, 5),
(8, 4, 3),
(9, 2, 1),
(10, 1, 1),
(10, 4, 1),
(11, 1, 1),
(12, 2, 2),
(12, 4, 2),
(13, 4, 1),
(13, 5, 1),
(13, 2, 1),
(14, 2, 2),
(15, 1, 1),
(16, 2, 1),
(16, 4, 1),
(16, 5, 1),
(17, 1, 2),
(17, 2, 3),
(18, 1, 4),
(18, 5, 1),
(19, 1, 1),
(19, 2, 1),
(19, 4, 1),
(19, 5, 1),
(20, 5, 3),
(21, 2, 2),
(21, 4, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pvevo`
--

CREATE TABLE IF NOT EXISTS `pvevo` (
  `vazon` int(1) NOT NULL AUTO_INCREMENT,
  `vnev` varchar(6) DEFAULT NULL,
  `vcim` varchar(36) DEFAULT NULL,
  PRIMARY KEY (`vazon`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `pvevo`
--

INSERT INTO `pvevo` (`vazon`, `vnev`, `vcim`) VALUES
(1, 'Hapci', 'Kerekerdő Kis tisztás 2. Ágyacska 1.'),
(2, 'Vidor', 'Kerekerdő Kis tisztás 2. Ágyacska 2.'),
(3, 'Tudor', 'Kerekerdő Kis tisztás 2. Ágyacska 3.'),
(4, 'Kuka', 'Kerekerdő Kis tisztás 2. Ágyacska 4.'),
(5, 'Szende', 'Kerekerdő Kis tisztás 2. Ágyacska 5.'),
(6, 'Szundi', 'Kerekerdő Kis tisztás 2. Ágyacska 6.'),
(7, 'Morgó', 'Kerekerdő Kis tisztás 2. Ágyacska 7.');

-- --------------------------------------------------------

--
-- A nézet helyettes szerkezete `rendeles_nezet`
-- (Lásd alább az aktuális nézetet)
--
CREATE TABLE IF NOT EXISTS `rendeles_nezet` (
`razon` int(2)
,`pazon` int(1)
,`db` int(1)
,`par` int(4)
,`ertek` bigint(21)
);

-- --------------------------------------------------------

--
-- Nézet szerkezete `minden`
--
DROP TABLE IF EXISTS `minden`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `minden`  AS  select `prendeles`.`razon` AS `razon`,`prendeles`.`vazon` AS `vazon`,`prendeles`.`fazon` AS `fazon`,`prendeles`.`datum` AS `datum`,`pfutar`.`fnev` AS `fnev`,`pfutar`.`ftel` AS `ftel`,`pvevo`.`vnev` AS `vnev`,`pvevo`.`vcim` AS `vcim`,`rendeles_nezet`.`pazon` AS `pazon`,`rendeles_nezet`.`db` AS `db`,`rendeles_nezet`.`par` AS `par`,`rendeles_nezet`.`ertek` AS `ertek` from (((`prendeles` join `pfutar` on((`prendeles`.`fazon` = `pfutar`.`fazon`))) join `pvevo` on((`prendeles`.`vazon` = `pvevo`.`vazon`))) join `rendeles_nezet` on((`prendeles`.`razon` = `rendeles_nezet`.`razon`))) order by `prendeles`.`razon` ;

-- --------------------------------------------------------

--
-- Nézet szerkezete `rendeles_nezet`
--
DROP TABLE IF EXISTS `rendeles_nezet`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rendeles_nezet`  AS  select `ptetel`.`razon` AS `razon`,`ptetel`.`pazon` AS `pazon`,`ptetel`.`db` AS `db`,`ppizza`.`par` AS `par`,(`ppizza`.`par` * `ptetel`.`db`) AS `ertek` from (`ptetel` join `ppizza` on((`ptetel`.`pazon` = `ppizza`.`pazon`))) order by `ptetel`.`razon` ;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `prendeles`
--
ALTER TABLE `prendeles`
  ADD CONSTRAINT `fk5` FOREIGN KEY (`vazon`) REFERENCES `pvevo` (`vazon`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk6` FOREIGN KEY (`fazon`) REFERENCES `pfutar` (`fazon`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Megkötések a táblához `ptetel`
--
ALTER TABLE `ptetel`
  ADD CONSTRAINT `fk3` FOREIGN KEY (`razon`) REFERENCES `prendeles` (`razon`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk4` FOREIGN KEY (`pazon`) REFERENCES `ppizza` (`pazon`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
