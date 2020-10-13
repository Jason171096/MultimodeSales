-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 13-10-2020 a las 17:57:25
-- Versión del servidor: 10.4.13-MariaDB
-- Versión de PHP: 7.4.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `multifashion`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarMarca` (IN `idmarca` INT(11), IN `nombre` VARCHAR(50))  MODIFIES SQL DATA
BEGIN
	INSERT INTO marca VALUES(idmarca, nombre); 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarModelo` (IN `idmodelo` VARCHAR(50), IN `idmarca` BIGINT, IN `color` VARCHAR(50), IN `talla` VARCHAR(50), IN `preciocliente` DECIMAL(10,2))  NO SQL
BEGIN
	INSERT INTO modelos (modelos.IDModelo, modelos.IDMarca, modelos.Color, 	modelos.Talla, modelos.PrecioCliente, modelos.Fecha) VALUES(idmodelo, idmarca, color, talla, preciocliente, NOW());
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarPedidosFinal` (IN `idmodelo` VARCHAR(50), IN `idcliente` BIGINT, IN `color` INT, IN `talla` INT)  MODIFIES SQL DATA
INSERT INTO pedidos(IDModelo, IDCliente, Color, Talla, Fecha) VALUES(idmodelo, idcliente, color, talla, NOW())$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ColoresyTallas` (IN `valor` INT, IN `opcion` INT, IN `id` INT, IN `nn` VARCHAR(50))  READS SQL DATA
BEGIN
	IF valor = 1 THEN
    	IF opcion = 1 THEN
        	INSERT INTO color (color.Nombre) VALUES(nn);
        ELSEIF opcion = 2 THEN 
        	UPDATE color SET color.Nombre = nn WHERE color.IDColor = id;
       	ELSE
        	DELETE FROM color WHERE color.IDColor = id;
        END IF;
    ELSE
    	IF opcion = 1 THEN
        	INSERT INTO talla (talla.Numero) VALUES(nn);
        ELSEIF opcion = 2 THEN 
        	UPDATE talla SET talla.Numero = nn WHERE talla.IDTalla = id;
       	ELSE
        	DELETE FROM talla WHERE talla.IDTalla = id;
        END IF;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarCliente` (IN `idclienteActual` BIGINT, IN `idcliente` BIGINT, IN `nombre` VARCHAR(50))  NO SQL
BEGIN
    SET @var1 := (SELECT COUNT(*) FROM clientes WHERE clientes.IDCliente = idclienteActual);
    IF @var1 = 0 THEN 
    	UPDATE clientes SET clientes.Nombre = nombre WHERE clientes.IDCliente = idclienteActual;
    ELSE
    	UPDATE clientes SET clientes.IDCliente = idcliente, clientes.Nombre = nombre WHERE clientes.IDCliente = idclienteActual;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarMarca` (IN `idmarcaActual` BIGINT, IN `idmarca` BIGINT, IN `nombre` VARCHAR(50))  NO SQL
BEGIN
    SET @var1 := (SELECT COUNT(*) FROM marca WHERE marca.IDMarca = idmarcaActual);
    IF @var1 = 0 THEN 
    	UPDATE marca SET marca.Nombre = nombre WHERE marca.IDMarca = idmarcaActual;
    ELSE
    	UPDATE marca SET marca.IDMarca = idmarca, marca.Nombre = nombre WHERE marca.IDMarca = idmarcaActual;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarModelo` (IN `idmodeloActual` VARCHAR(50), IN `idmodelo` VARCHAR(50), IN `idmarca` BIGINT, IN `color` VARCHAR(50), IN `talla` VARCHAR(50), IN `preciocliente` DECIMAL(10,2))  NO SQL
BEGIN
	SET @var:= (SELECT COUNT(*) FROM modelos WHERE modelos.IDModelo = idmodeloActual);
    IF @var = 0 THEN
    	UPDATE modelos SET modelos.IDMarca = idmarca, modelos.Color = color, modelos.Talla = talla, modelos.PrecioCliente = preciocliente WHERE modelos.IDModelo = idmodeloActual;
    ELSE 
    	UPDATE modelos SET modelos.IDModelo = idmodelo, modelos.IDMarca = idmarca, modelos.Color = color, modelos.Talla = talla, modelos.PrecioCliente = preciocliente WHERE modelos.IDModelo = idmodeloActual;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarPedidoFinal` (IN `idmodelo` VARCHAR(50), IN `idcliente` BIGINT)  MODIFIES SQL DATA
BEGIN
	UPDATE pedidos SET Llego = 1 WHERE (IDModelo = idmodelo AND IDCliente = idcliente); 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerClientes` ()  READS SQL DATA
BEGIN
	SELECT IDCliente, Nombre FROM clientes;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerColores` ()  READS SQL DATA
SELECT color.IDColor, color.Nombre FROM color$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerListaPedidoFinal` ()  READS SQL DATA
SELECT p.IDPedido, c.IDCliente, c.Nombre, m.IDModelo, m.Color, m.Talla, m.PrecioCliente FROM pedidos p INNER JOIN clientes c ON p.IDCliente = c.IDCliente INNER JOIN modelos m ON m.IDModelo = p.IDModelo ORDER BY c.IDCliente ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerMarcas` ()  BEGIN
	SELECT IDMarca, Nombre FROM marca;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerModelos` (IN `inicio` INT, IN `fin` INT)  READS SQL DATA
BEGIN
	SELECT IDModelo, m.IDMarca, m.Nombre, Color, Talla, PrecioCliente, Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca LIMIT inicio, fin;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerTallas` ()  READS SQL DATA
SELECT talla.IDTalla, talla.Numero FROM talla$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `IDCliente` bigint(20) NOT NULL,
  `Nombre` varchar(29) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`IDCliente`, `Nombre`, `Telefono`) VALUES
(1, 'ANA LAURA GUZMAN', ''),
(2, 'RAQUEL MENDOZA', ''),
(3, 'ANGELES CHAVEZ', ''),
(4, 'CRISTINA AVILA', ''),
(5, 'KARINA CHAVEZ MORFIN', ''),
(6, 'BLANCA ESTHELA CHAVEZ', ''),
(7, 'CARMEN LOPEZ', ''),
(8, 'AURELIA VALENCIA', ''),
(9, 'EDUARDO PEÑA', ''),
(10, 'CECILIA MORFIN MUNGUIA', ''),
(11, 'JUANA ALVAREZ GARCIA', ''),
(12, 'ANDREA FIGUEROA', ''),
(13, 'IRENE MONTES', ''),
(14, 'JOSEFINA BARRAGAN', ''),
(15, 'KARINA OCEGUERA', ''),
(16, 'MA. ELENA TORRES', ''),
(17, 'MARGARITA BARRAGAN', ''),
(18, 'MARIA GONZALEZ', ''),
(19, 'MARIA GPE. GARCIA N.', ''),
(20, 'MARIA RUIZ', ''),
(21, 'MARIA RUIZ', ''),
(22, 'MARICELA OROZCO', ''),
(23, 'CECILIA RUIZ', ''),
(24, 'SILVIA SANDOVAL', ''),
(25, 'A.YANETH MENDOZA', ''),
(26, 'SANDRA IBARRA', ''),
(27, 'VICTORIA CHAVEZ', ''),
(28, 'YOLANDA GERRERO', ''),
(29, 'ROCIO SANCHEZ', ''),
(30, 'VIRIDIANA MANZO', ''),
(31, 'ARACELI TORRES', ''),
(32, 'CARLA INES CEJA', ''),
(33, 'LUZ ELENA VALENCIA', ''),
(34, 'MAYRA A. MORFIN', ''),
(35, 'MARTA CERVANTES HERRERA', ''),
(36, 'TERESA VALENCIA', ''),
(37, 'MARIA CEJA', ''),
(38, 'HILDA MORFIN', ''),
(39, 'ANDREA MALDONADO', ''),
(40, 'LIDIA ESPINOZA', ''),
(41, 'MA. DE JESUS SANCHEZ', ''),
(42, 'BLANCA VARGAS CHAVEZ', ''),
(43, 'MONICA LUA', ''),
(44, 'ANGELES APOLINAR', ''),
(45, 'MA. ELENA BARAJAS', ''),
(46, 'GRISELDA CHAVEZ ESPINOZA', ''),
(47, 'MARIA CELI GONZALEZ G.', ''),
(48, 'MARIA ELENA FLORES', ''),
(49, 'EVA MARTINEZ', ''),
(50, 'MARTHA SANCHEZ', ''),
(51, 'HERMINIA CHAVEZ', ''),
(52, 'LUCELY VILCHES', ''),
(53, 'MAYRA PULIDO', ''),
(54, 'GUADALUPE RINCON', ''),
(55, 'YESICA MORALES', ''),
(56, 'SILVIA MENDOZA', ''),
(57, 'GUADALUPE GARCIA', ''),
(58, 'LETY', ''),
(59, 'MARISOL CHAVEZ', ''),
(60, 'GRISELDA GAYTAN', ''),
(61, 'ELVIA ROCIO MALFAVON', ''),
(62, 'PILAR MENDOZA', ''),
(63, 'GONZALO CHAVEZ', ''),
(64, 'CECILIA CEJA', ''),
(65, 'ESPERANZA ALVAREZ', ''),
(66, 'BERTHA GUZMAN', ''),
(67, 'VANESSA FIGUEROA', ''),
(68, 'ANGELICA CARDENAS', ''),
(69, 'MAURA GALLARDO', ''),
(70, 'ELIZABETH ESTRADA', ''),
(72, 'ANA ISABEL AVILA', ''),
(73, 'ANTONIO GUDIÑO SANCHEZ CARTON', ''),
(74, 'MA. DEL RAYO ACEVES', ''),
(78, 'ESTEFANY MADRIGAL TORRES', ''),
(80, 'MIREYA MENDOZA', ''),
(81, 'NELLELI CHAVEZ', ''),
(82, 'MARIA DE JESUS BUCIO', ''),
(85, 'ANGELICA MENDOZA', ''),
(86, 'EVA VILCHEZ', ''),
(87, 'JUANA GARCIA SANCHEZ', ''),
(93, 'NORMA VALDOVINOS', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `color`
--

CREATE TABLE `color` (
  `IDColor` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `color`
--

INSERT INTO `color` (`IDColor`, `Nombre`) VALUES
(23, 'NEGRO'),
(24, 'AZUL'),
(25, 'MORADO'),
(26, 'ROJO'),
(27, 'VERDE'),
(28, 'AMARILLO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `IDMarca` bigint(20) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`IDMarca`, `Nombre`) VALUES
(3, 'Terra'),
(5, 'ModaClub'),
(6, 'Vicky Form');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modelos`
--

CREATE TABLE `modelos` (
  `IDModelo` varchar(50) NOT NULL,
  `IDMarca` bigint(20) NOT NULL,
  `Color` varchar(50) DEFAULT NULL,
  `Talla` varchar(50) DEFAULT NULL,
  `PrecioCliente` decimal(10,2) DEFAULT NULL,
  `PrecioPublico` decimal(10,2) DEFAULT NULL,
  `Fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modelos`
--

INSERT INTO `modelos` (`IDModelo`, `IDMarca`, `Color`, `Talla`, `PrecioCliente`, `PrecioPublico`, `Fecha`) VALUES
('10001', 5, 'MERLOT', '22 AL 26', '459.50', NULL, '2020-10-04 18:19:49'),
('10002', 5, 'AZUL', '25', '460.50', NULL, '2020-10-04 18:19:51'),
('10009', 5, 'NEGRO', '23 AL 26', '551.50', NULL, '2020-10-04 18:19:49'),
('2', 5, 'PERLA', '22', '600.00', NULL, '2020-10-12 09:34:28'),
('25', 5, 'MERLOT', '22 AL 27  ENTEROS', '459.50', NULL, '2020-10-04 18:19:49'),
('254', 5, 'NEGRO', '23 AL 26', '574.50', NULL, '2020-10-04 18:19:49'),
('6762', 5, 'NEGRO', '22 AL 27  ENTEROS', '459.50', NULL, '2020-10-04 18:19:49'),
('801', 5, 'LADRILLO', '22 AL 26', '45.00', NULL, '2020-10-04 18:19:48'),
('8049', 5, 'NEGRO', '23 AL 26', '505.50', NULL, '2020-10-04 18:19:49'),
('8050', 5, 'NUTRIA', '23 AL 26', '574.50', NULL, '2020-10-04 18:19:49'),
('95184', 5, 'NEGRO', '23 AL 26', '896.50', NULL, '2020-10-04 18:19:49');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `IDPedido` bigint(20) NOT NULL,
  `IDModelo` varchar(50) NOT NULL,
  `IDCliente` bigint(20) DEFAULT NULL,
  `Color` varchar(50) DEFAULT NULL,
  `Talla` varchar(50) DEFAULT NULL,
  `Fecha` datetime NOT NULL,
  `Llego` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_venta`
--

CREATE TABLE `pedido_venta` (
  `IDVentaPedido` bigint(20) NOT NULL,
  `IDVenta` bigint(20) NOT NULL,
  `IDPedido` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `talla`
--

CREATE TABLE `talla` (
  `IDTalla` int(11) NOT NULL,
  `Numero` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `talla`
--

INSERT INTO `talla` (`IDTalla`, `Numero`) VALUES
(26, 'CH'),
(27, 'M'),
(28, 'G'),
(29, 'XG'),
(30, '18');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `IDUsuario` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contrasena` varchar(50) NOT NULL,
  `EsAdmin` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`IDUsuario`, `Nombre`, `Contrasena`, `EsAdmin`) VALUES
(1, 'Oscar', 'admin', b'1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `IDVenta` bigint(20) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`IDCliente`);

--
-- Indices de la tabla `color`
--
ALTER TABLE `color`
  ADD PRIMARY KEY (`IDColor`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`IDMarca`);

--
-- Indices de la tabla `modelos`
--
ALTER TABLE `modelos`
  ADD PRIMARY KEY (`IDModelo`),
  ADD KEY `IDMarca` (`IDMarca`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`IDPedido`),
  ADD KEY `IDModelo` (`IDModelo`),
  ADD KEY `IDCliente` (`IDCliente`);

--
-- Indices de la tabla `pedido_venta`
--
ALTER TABLE `pedido_venta`
  ADD PRIMARY KEY (`IDVentaPedido`),
  ADD KEY `IDVenta` (`IDVenta`),
  ADD KEY `IDPedido` (`IDPedido`);

--
-- Indices de la tabla `talla`
--
ALTER TABLE `talla`
  ADD PRIMARY KEY (`IDTalla`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IDUsuario`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`IDVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `IDCliente` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=95;

--
-- AUTO_INCREMENT de la tabla `color`
--
ALTER TABLE `color`
  MODIFY `IDColor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `IDPedido` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1535;

--
-- AUTO_INCREMENT de la tabla `talla`
--
ALTER TABLE `talla`
  MODIFY `IDTalla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IDUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `modelos`
--
ALTER TABLE `modelos`
  ADD CONSTRAINT `modelos_ibfk_1` FOREIGN KEY (`IDMarca`) REFERENCES `marca` (`IDMarca`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`IDModelo`) REFERENCES `modelos` (`IDModelo`),
  ADD CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`IDCliente`) REFERENCES `clientes` (`IDCliente`);

--
-- Filtros para la tabla `pedido_venta`
--
ALTER TABLE `pedido_venta`
  ADD CONSTRAINT `pedido_venta_ibfk_1` FOREIGN KEY (`IDVenta`) REFERENCES `venta` (`IDVenta`),
  ADD CONSTRAINT `pedido_venta_ibfk_2` FOREIGN KEY (`IDPedido`) REFERENCES `pedidos` (`IDPedido`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
