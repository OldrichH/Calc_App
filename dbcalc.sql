-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Čtv 19. říj 2023, 14:10
-- Verze serveru: 10.1.38-MariaDB
-- Verze PHP: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `dbcalc`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `calculation`
--
create database dbcalc;

CREATE TABLE `calculation` (
  `Id` int(11) NOT NULL,
  `ValueA` double NOT NULL,
  `ValueB` double NOT NULL,
  `Result` double NOT NULL,
  `Operation` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `calculation`
--

INSERT INTO `calculation` (`Id`, `ValueA`, `ValueB`, `Result`, `Operation`, `Date`) VALUES
(86, 25, 6, 31, '+', '2023-10-19 13:56:25'),
(87, 31, 5, 155, '*', '2023-10-19 13:56:29'),
(88, 1552, 2, 1550, '-', '2023-10-19 13:56:32'),
(89, 5, 5, 0, '-', '2023-10-19 13:56:35'),
(90, 5, 5, 1, '/', '2023-10-19 13:56:41'),
(91, 9, 9, 18, '+', '2023-10-19 13:56:49'),
(92, 69, 69, 0, '-', '2023-10-19 13:56:55'),
(93, 8, 6, 2, '-', '2023-10-19 13:57:00'),
(94, 22, 2, 24, '+', '2023-10-19 13:57:03'),
(95, 247, 7, 254, '+', '2023-10-19 13:57:07'),
(96, 5, 0, 0, '/', '2023-10-19 13:58:15'),
(97, 5, 5, 10, '+', '2023-10-19 13:58:20'),
(98, 5, 0, 0, '/', '2023-10-19 14:00:37'),
(99, 55, 5, 60, '+', '2023-10-19 14:05:41'),
(100, 5, 5, 10, '+', '2023-10-19 14:10:06');

--
-- Klíče pro exportované tabulky
--

--
-- Klíče pro tabulku `calculation`
--
ALTER TABLE `calculation`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `calculation`
--
ALTER TABLE `calculation`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
