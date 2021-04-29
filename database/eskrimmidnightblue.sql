-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2021 at 02:53 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eskrimmidnightblue`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`) VALUES
(1, 'owner', 'owner123'),
(2, 'admin1', 'admin123'),
(3, 'admin2', 'admin234');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `id` int(11) NOT NULL,
  `namamenu` varchar(50) NOT NULL,
  `rasa` varchar(50) NOT NULL,
  `topping` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`id`, `namamenu`, `rasa`, `topping`) VALUES
(1, 'Es Krim Cup', 'Vanila', 'Meses'),
(2, 'Es Krim Cup', 'Vanila', 'Caramel'),
(3, 'Es Krim Cup', 'Vanila', 'Pocky'),
(4, 'Es Krim Cup', 'Vanila', 'Honeystar'),
(5, 'Es Krim Cup', 'Coklat', 'Meses'),
(6, 'Es Krim Cup', 'Coklat', 'Caramel'),
(7, 'Es Krim Cup', 'Coklat', 'Pocky'),
(8, 'Es Krim Cup', 'Coklat', 'Honeystar'),
(9, 'Es Krim Cup', 'Oreo', 'Meses'),
(10, 'Es Krim Cup', 'Oreo', 'Caramel'),
(11, 'Es Krim Cup', 'Oreo', 'Pocky'),
(12, 'Es Krim Cup', 'Oreo', 'Honeystar'),
(13, 'Es Krim Cup', 'Stroberi', 'Meses'),
(14, 'Es Krim Cup', 'Stroberi', 'Caramel'),
(15, 'Es Krim Cup', 'Stroberi', 'Pocky'),
(16, 'Es Krim Cup', 'Stroberi', 'Honeystar'),
(17, 'Es Krim Cone', 'Vanila', 'Meses'),
(18, 'Es Krim Cone', 'Vanila', 'Caramel'),
(19, 'Es Krim Cone', 'Vanila', 'Pocky'),
(20, 'Es Krim Cone', 'Vanila ', 'Honeystar'),
(21, 'Es Krim Cone', 'Coklat', 'Meses'),
(22, 'Es Krim Cone', 'Coklat', 'Caramel'),
(23, 'Es Krim Cone', 'Coklat', 'Pocky'),
(24, 'Es Krim Cone', 'Coklat', 'Honeystar'),
(25, 'Es Krim Cone', 'Stroberi', 'Meses'),
(26, 'Es Krim Cone', 'Stroberi', 'Caramel'),
(27, 'Es Krim Cone', 'Stroberi', 'Pocky'),
(28, 'Es Krim Cone', 'Stroberi', 'Honeystar'),
(29, 'Es Krim Cone', 'Oreo', 'Meses'),
(30, 'Es Krim Cone', 'Oreo', 'Caramel'),
(31, 'Es Krim Cone', 'Oreo ', 'Pocky'),
(32, 'Es Krim Cone ', 'Oreo', 'Honeystar'),
(33, 'Es Krim Parfait', 'Vanila', 'Meses'),
(34, 'Es Krim Parfait', 'Vanila', 'Caramel'),
(35, 'Es Krim Parfait', 'Vanila', 'Pocky'),
(36, 'Es Krim Parfait', 'Vanila', 'Honeystar'),
(37, 'Es Krim Parfait', 'Coklat', 'Meses'),
(38, 'Es Krim Parfait', 'Coklat', 'Caramel'),
(39, 'Es Krim Parfait', 'Coklat', 'Pocky'),
(40, 'Es Krim Parfait', 'Coklat', 'Honeystar'),
(41, 'Es Krim Parfait', 'Stroberi', 'Meses'),
(42, 'Es Krim Parfait', 'Stroberi', 'Caramel'),
(43, 'Es Krim Parfait', 'Stroberi', 'Pocky'),
(44, 'Es Krim Parfait', 'Stroberi', 'Honeystar'),
(45, 'Es Krim Parfait', 'Oreo', 'Meses'),
(46, 'Es Krim Parfait', 'Oreo', 'Caramel'),
(47, 'Es Krim Parfait', 'Oreo', 'Pocky'),
(48, 'Es Krim Parfait', 'Oreo', 'Honeystar');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
