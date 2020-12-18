-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-12-2020 a las 01:32:51
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `agenda1`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consulta`
--

CREATE TABLE `consulta` (
  `id_consulta` int(11) NOT NULL,
  `id_usuario` varchar(36) NOT NULL,
  `id_profesional` varchar(36) NOT NULL,
  `id_dia` int(2) NOT NULL,
  `fecha_consulta` datetime NOT NULL,
  `fecha_reserva` datetime NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dia`
--

CREATE TABLE `dia` (
  `id_dia` int(2) NOT NULL,
  `nombre_dia` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `dia`
--

INSERT INTO `dia` (`id_dia`, `nombre_dia`) VALUES
(0, 'Domingo'),
(1, 'Lunes'),
(2, 'Martes'),
(3, 'Miercoles'),
(4, 'Jueves'),
(5, 'Viernes'),
(6, 'Sabado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `disponibilidad`
--

CREATE TABLE `disponibilidad` (
  `id_profesional` varchar(36) NOT NULL,
  `id_dia` int(11) NOT NULL,
  `horario_inicio` datetime DEFAULT NULL,
  `horario_final` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `disponibilidad`
--

INSERT INTO `disponibilidad` (`id_profesional`, `id_dia`, `horario_inicio`, `horario_final`) VALUES
('616e4d1c582a4173b4413a539410548a', 1, NULL, NULL),
('616e4d1c582a4173b4413a539410548a', 2, NULL, NULL),
('616e4d1c582a4173b4413a539410548a', 3, NULL, NULL),
('616e4d1c582a4173b4413a539410548a', 4, NULL, NULL),
('616e4d1c582a4173b4413a539410548a', 5, NULL, NULL),
('616e4d1c582a4173b4413a539410548a', 6, NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesion`
--

CREATE TABLE `profesion` (
  `id_profesion` int(11) NOT NULL,
  `nombre_profesion` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `profesion`
--

INSERT INTO `profesion` (`id_profesion`, `nombre_profesion`) VALUES
(1, 'Doctor en Medicina'),
(2, 'Desarrollado de Software'),
(3, 'Fisico'),
(4, 'Matematico'),
(5, 'Abogado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesional`
--

CREATE TABLE `profesional` (
  `id_profesional` varchar(36) NOT NULL,
  `id_profesion` int(11) NOT NULL,
  `nombre_profesional` varchar(25) NOT NULL,
  `apellido_profesional` varchar(25) NOT NULL,
  `tipo_documento` varchar(25) NOT NULL,
  `documento` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `profesional`
--

INSERT INTO `profesional` (`id_profesional`, `id_profesion`, `nombre_profesional`, `apellido_profesional`, `tipo_documento`, `documento`) VALUES
('0400c197764c479baacf91c22cc5ae98', 4, 'Tentacion', 'Dolores', 'Pasaporte', '468-222-1222'),
('1b388e346cfd4f62a19b0ddbd7756778', 3, 'Nikola', 'Tesla', 'Pasaporte', '333-133-2333'),
('616e4d1c582a4173b4413a539410548a', 2, 'Dan', 'Fantom', 'Cedula', '111-222-0101'),
('7943f3890b1747ffb883a49c18fe0307', 2, 'Juanita', 'Perez', 'Cedula', '444-2221'),
('d8cdbbb600ae46fa84e381feca1ac4d7', 4, 'TestToTest', 'zeroDayExploit', 'Cedula', '1111-222'),
('ed8576c0674c4e078891adf65209e252', 1, 'Daniel', 'Goleman', 'Pasaporte', '011-221');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefono_profesional`
--

CREATE TABLE `telefono_profesional` (
  `id_profesional` varchar(36) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `tipo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefono_usuario`
--

CREATE TABLE `telefono_usuario` (
  `id_usuario` varchar(36) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `tipo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `telefono_usuario`
--

INSERT INTO `telefono_usuario` (`id_usuario`, `telefono`, `tipo`) VALUES
('87f8e47450ed478fb35f42e192a1aa82', '2020-8080', 'Celular');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` varchar(36) NOT NULL,
  `nombre_usuario` varchar(25) NOT NULL,
  `apellido_usuario` varchar(25) NOT NULL,
  `tipo_documento` varchar(25) NOT NULL,
  `documento` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nombre_usuario`, `apellido_usuario`, `tipo_documento`, `documento`) VALUES
('87f8e47450ed478fb35f42e192a1aa82', 'Sam', 'Sepia', 'Cedula', '202');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `consulta`
--
ALTER TABLE `consulta`
  ADD PRIMARY KEY (`id_consulta`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_profesional` (`id_profesional`),
  ADD KEY `id_dia` (`id_dia`);

--
-- Indices de la tabla `dia`
--
ALTER TABLE `dia`
  ADD PRIMARY KEY (`id_dia`);

--
-- Indices de la tabla `disponibilidad`
--
ALTER TABLE `disponibilidad`
  ADD PRIMARY KEY (`id_profesional`,`id_dia`),
  ADD KEY `id_dia` (`id_dia`);

--
-- Indices de la tabla `profesion`
--
ALTER TABLE `profesion`
  ADD PRIMARY KEY (`id_profesion`);

--
-- Indices de la tabla `profesional`
--
ALTER TABLE `profesional`
  ADD PRIMARY KEY (`id_profesional`),
  ADD KEY `id_profesion` (`id_profesion`);

--
-- Indices de la tabla `telefono_profesional`
--
ALTER TABLE `telefono_profesional`
  ADD PRIMARY KEY (`id_profesional`,`telefono`);

--
-- Indices de la tabla `telefono_usuario`
--
ALTER TABLE `telefono_usuario`
  ADD PRIMARY KEY (`id_usuario`,`telefono`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `consulta`
--
ALTER TABLE `consulta`
  MODIFY `id_consulta` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `consulta`
--
ALTER TABLE `consulta`
  ADD CONSTRAINT `consulta_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`),
  ADD CONSTRAINT `consulta_ibfk_2` FOREIGN KEY (`id_profesional`) REFERENCES `profesional` (`id_profesional`),
  ADD CONSTRAINT `consulta_ibfk_3` FOREIGN KEY (`id_dia`) REFERENCES `dia` (`id_dia`);

--
-- Filtros para la tabla `disponibilidad`
--
ALTER TABLE `disponibilidad`
  ADD CONSTRAINT `disponibilidad_ibfk_1` FOREIGN KEY (`id_profesional`) REFERENCES `profesional` (`id_profesional`),
  ADD CONSTRAINT `disponibilidad_ibfk_2` FOREIGN KEY (`id_dia`) REFERENCES `dia` (`id_dia`);

--
-- Filtros para la tabla `profesional`
--
ALTER TABLE `profesional`
  ADD CONSTRAINT `profesional_ibfk_1` FOREIGN KEY (`id_profesion`) REFERENCES `profesion` (`id_profesion`);

--
-- Filtros para la tabla `telefono_profesional`
--
ALTER TABLE `telefono_profesional`
  ADD CONSTRAINT `telefono_profesional_ibfk_1` FOREIGN KEY (`id_profesional`) REFERENCES `profesional` (`id_profesional`) ON DELETE CASCADE;

--
-- Filtros para la tabla `telefono_usuario`
--
ALTER TABLE `telefono_usuario`
  ADD CONSTRAINT `telefono_usuario_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
