-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-01-2015 a las 22:45:33
-- Versión del servidor: 5.6.21
-- Versión de PHP: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `proyectointegrador4to`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sensor1`
--

CREATE TABLE IF NOT EXISTS `sensor1` (
`id` int(5) NOT NULL,
  `FlujoMinuto` int(20) NOT NULL,
  `Total` int(20) NOT NULL,
  `Fecha` varchar(25) NOT NULL,
  `DentroLimite` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sensor2`
--

CREATE TABLE IF NOT EXISTS `sensor2` (
`id` int(5) NOT NULL,
  `FlujoMinuto` int(20) NOT NULL,
  `Total` int(20) NOT NULL,
  `Fecha` varchar(25) NOT NULL,
  `DentroLimite` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sensor3`
--

CREATE TABLE IF NOT EXISTS `sensor3` (
`id` int(5) NOT NULL,
  `FlujoMinuto` int(20) NOT NULL,
  `Total` int(20) NOT NULL,
  `Fecha` varchar(25) NOT NULL,
  `DentroLimite` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `sensor1`
--
ALTER TABLE `sensor1`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `sensor2`
--
ALTER TABLE `sensor2`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `sensor3`
--
ALTER TABLE `sensor3`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `sensor1`
--
ALTER TABLE `sensor1`
MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `sensor2`
--
ALTER TABLE `sensor2`
MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `sensor3`
--
ALTER TABLE `sensor3`
MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
