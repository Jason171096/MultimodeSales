-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-10-2020 a las 18:44:24
-- Versión del servidor: 10.1.32-MariaDB
-- Versión de PHP: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarCliente` (IN `idcliente` BIGINT, IN `nombre` VARCHAR(50))  NO SQL
BEGIN
	INSERT INTO clientes(IDCliente, Nombre) VALUES (idcliente, nombre);
END$$

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

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarModelo` (IN `buscar` VARCHAR(50))  NO SQL
BEGIN
	SELECT IDModelo, m.IDMarca, m.Nombre, Color, Talla, PrecioCliente, Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca WHERE modelos.IDModelo LIKE CONCAT('%',buscar,'%');
END$$

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

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerModelos` ()  NO SQL
BEGIN
	SELECT IDModelo, m.IDMarca, m.Nombre, Color, Talla, PrecioCliente, Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VerModelosLimit` (IN `inicio` INT)  READS SQL DATA
BEGIN
	SELECT IDModelo, m.IDMarca, m.Nombre, Color, Talla, PrecioCliente, Fecha FROM modelos mo INNER JOIN marca m ON m.IDMarca = mo.IDMarca LIMIT inicio, 100;
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
(93, 'NORMA VALDOVINOS', ''),
(100, 'TERESA ', NULL),
(101, 'OSCAR', NULL);

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
(28, 'AMARILLO'),
(29, 'TURQUESA');

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
(1, 'ANDREA'),
(3, 'TERRA'),
(5, 'MODACLUB'),
(6, 'VICKY FORM');

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
('100', 5, 'AZUL', '22', '500.00', NULL, '2020-10-13 23:35:14'),
('10001', 5, 'MERLOT', '22 AL 26', '459.50', NULL, '2020-10-04 18:19:49'),
('10002', 5, 'AZUL', '25', '460.50', NULL, '2020-10-04 18:19:51'),
('10009', 5, 'NEGRO', '23 AL 26', '551.50', NULL, '2020-10-04 18:19:49'),
('101', 5, 'AMARILLO', '23', '516.55', NULL, '2020-10-13 23:35:15'),
('102', 5, 'NEGRO', '24', '533.10', NULL, '2020-10-13 23:35:15'),
('103', 5, 'VIOLETA', '25', '549.65', NULL, '2020-10-13 23:35:15'),
('104', 5, 'AZUL', 'M', '566.20', NULL, '2020-10-13 23:35:15'),
('105', 5, 'AMARILLO', 'CH', '582.75', NULL, '2020-10-13 23:35:15'),
('106', 5, 'NEGRO', 'T', '599.30', NULL, '2020-10-13 23:35:15'),
('107', 5, 'VIOLETA', 'XG', '615.85', NULL, '2020-10-13 23:35:15'),
('108', 5, 'AZUL', '22', '632.40', NULL, '2020-10-13 23:35:15'),
('109', 5, 'AMARILLO', '23', '648.95', NULL, '2020-10-13 23:35:15'),
('110', 5, 'NEGRO', '24', '665.50', NULL, '2020-10-13 23:35:15'),
('111', 5, 'VIOLETA', '25', '682.05', NULL, '2020-10-13 23:35:15'),
('112', 5, 'AZUL', 'M', '698.60', NULL, '2020-10-13 23:35:15'),
('113', 5, 'AMARILLO', 'CH', '715.15', NULL, '2020-10-13 23:35:15'),
('114', 5, 'NEGRO', 'T', '731.70', NULL, '2020-10-13 23:35:15'),
('115', 5, 'VIOLETA', 'XG', '748.25', NULL, '2020-10-13 23:35:15'),
('116', 5, 'AZUL', '22', '764.80', NULL, '2020-10-13 23:35:15'),
('117', 5, 'AMARILLO', '23', '781.35', NULL, '2020-10-13 23:35:15'),
('118', 5, 'NEGRO', '24', '797.90', NULL, '2020-10-13 23:35:15'),
('119', 5, 'VIOLETA', '25', '814.45', NULL, '2020-10-13 23:35:15'),
('120', 5, 'AZUL', 'M', '831.00', NULL, '2020-10-13 23:35:15'),
('121', 5, 'AMARILLO', 'CH', '847.55', NULL, '2020-10-13 23:35:16'),
('122', 5, 'NEGRO', 'T', '864.10', NULL, '2020-10-13 23:35:16'),
('123', 5, 'VIOLETA', 'XG', '880.65', NULL, '2020-10-13 23:35:16'),
('124', 5, 'AZUL', '22', '897.20', NULL, '2020-10-13 23:35:16'),
('125', 5, 'AMARILLO', '23', '913.75', NULL, '2020-10-13 23:35:16'),
('126', 5, 'NEGRO', '24', '930.30', NULL, '2020-10-13 23:35:16'),
('127', 5, 'VIOLETA', '25', '946.85', NULL, '2020-10-13 23:35:16'),
('128', 5, 'AZUL', 'M', '963.40', NULL, '2020-10-13 23:35:16'),
('129', 5, 'AMARILLO', 'CH', '979.95', NULL, '2020-10-13 23:35:16'),
('130', 5, 'NEGRO', 'T', '996.50', NULL, '2020-10-13 23:35:16'),
('131', 5, 'VIOLETA', 'XG', '1013.05', NULL, '2020-10-13 23:35:16'),
('132', 5, 'AZUL', '22', '1029.60', NULL, '2020-10-13 23:35:16'),
('133', 5, 'AMARILLO', '23', '1046.15', NULL, '2020-10-13 23:35:16'),
('134', 5, 'NEGRO', '24', '1062.70', NULL, '2020-10-13 23:35:16'),
('135', 5, 'VIOLETA', '25', '1079.25', NULL, '2020-10-13 23:35:16'),
('136', 5, 'AZUL', 'M', '1095.80', NULL, '2020-10-13 23:35:16'),
('137', 5, 'AMARILLO', 'CH', '1112.35', NULL, '2020-10-13 23:35:16'),
('138', 5, 'NEGRO', 'T', '1128.90', NULL, '2020-10-13 23:35:16'),
('139', 5, 'VIOLETA', 'XG', '1145.45', NULL, '2020-10-13 23:35:16'),
('140', 5, 'AZUL', '22', '1162.00', NULL, '2020-10-13 23:35:16'),
('141', 5, 'AMARILLO', '23', '1178.55', NULL, '2020-10-13 23:35:16'),
('142', 5, 'NEGRO', '24', '1195.10', NULL, '2020-10-13 23:35:16'),
('143', 5, 'VIOLETA', '25', '1211.65', NULL, '2020-10-13 23:35:16'),
('144', 5, 'AZUL', 'M', '1228.20', NULL, '2020-10-13 23:35:16'),
('145', 5, 'AMARILLO', 'CH', '1244.75', NULL, '2020-10-13 23:35:16'),
('146', 5, 'NEGRO', 'T', '1261.30', NULL, '2020-10-13 23:35:16'),
('147', 5, 'VIOLETA', 'XG', '1277.85', NULL, '2020-10-13 23:35:17'),
('148', 5, 'AZUL', '22', '1294.40', NULL, '2020-10-13 23:35:17'),
('149', 5, 'AMARILLO', '23', '1310.95', NULL, '2020-10-13 23:35:17'),
('150', 5, 'NEGRO', '24', '1327.50', NULL, '2020-10-13 23:35:17'),
('151', 5, 'VIOLETA', '25', '1344.05', NULL, '2020-10-13 23:35:17'),
('152', 5, 'AZUL', 'M', '1360.60', NULL, '2020-10-13 23:35:17'),
('153', 5, 'AMARILLO', 'CH', '1377.15', NULL, '2020-10-13 23:35:17'),
('154', 5, 'NEGRO', 'T', '1393.70', NULL, '2020-10-13 23:35:17'),
('155', 5, 'VIOLETA', 'XG', '1410.25', NULL, '2020-10-13 23:35:17'),
('156', 5, 'AZUL', '22', '1426.80', NULL, '2020-10-13 23:35:17'),
('157', 5, 'AMARILLO', '23', '1443.35', NULL, '2020-10-13 23:35:17'),
('158', 5, 'NEGRO', '24', '1459.90', NULL, '2020-10-13 23:35:17'),
('159', 5, 'VIOLETA', '25', '1476.45', NULL, '2020-10-13 23:35:17'),
('160', 5, 'AZUL', 'M', '1493.00', NULL, '2020-10-13 23:35:17'),
('161', 5, 'AMARILLO', 'CH', '1509.55', NULL, '2020-10-13 23:35:17'),
('162', 5, 'NEGRO', 'T', '1526.10', NULL, '2020-10-13 23:35:17'),
('163', 5, 'VIOLETA', 'XG', '1542.65', NULL, '2020-10-13 23:35:17'),
('164', 5, 'AZUL', '22', '1559.20', NULL, '2020-10-13 23:35:17'),
('165', 5, 'AMARILLO', '23', '1575.75', NULL, '2020-10-13 23:35:17'),
('166', 5, 'NEGRO', '24', '1592.30', NULL, '2020-10-13 23:35:17'),
('167', 5, 'VIOLETA', '25', '1608.85', NULL, '2020-10-13 23:35:17'),
('168', 5, 'AZUL', 'M', '1625.40', NULL, '2020-10-13 23:35:18'),
('169', 5, 'AMARILLO', 'CH', '1641.95', NULL, '2020-10-13 23:35:18'),
('170', 5, 'NEGRO', 'T', '1658.50', NULL, '2020-10-13 23:35:18'),
('171', 5, 'VIOLETA', 'XG', '1675.05', NULL, '2020-10-13 23:35:18'),
('172', 5, 'AZUL', '22', '1691.60', NULL, '2020-10-13 23:35:18'),
('173', 5, 'AMARILLO', '23', '1708.15', NULL, '2020-10-13 23:35:18'),
('174', 5, 'NEGRO', '24', '1724.70', NULL, '2020-10-13 23:35:18'),
('175', 5, 'VIOLETA', '25', '1741.25', NULL, '2020-10-13 23:35:18'),
('176', 5, 'AZUL', 'M', '1757.80', NULL, '2020-10-13 23:35:18'),
('177', 5, 'AMARILLO', 'CH', '1774.35', NULL, '2020-10-13 23:35:19'),
('178', 5, 'NEGRO', 'T', '1790.90', NULL, '2020-10-13 23:35:19'),
('179', 5, 'VIOLETA', 'XG', '1807.45', NULL, '2020-10-13 23:35:19'),
('180', 5, 'AZUL', '22', '1824.00', NULL, '2020-10-13 23:35:19'),
('181', 5, 'AMARILLO', '23', '1840.55', NULL, '2020-10-13 23:35:19'),
('182', 5, 'NEGRO', '24', '1857.10', NULL, '2020-10-13 23:35:20'),
('183', 5, 'VIOLETA', '25', '1873.65', NULL, '2020-10-13 23:35:20'),
('184', 5, 'AZUL', 'M', '1890.20', NULL, '2020-10-13 23:35:20'),
('185', 5, 'AMARILLO', 'CH', '1906.75', NULL, '2020-10-13 23:35:20'),
('186', 5, 'NEGRO', 'T', '1923.30', NULL, '2020-10-13 23:35:20'),
('187', 5, 'VIOLETA', 'XG', '1939.85', NULL, '2020-10-13 23:35:20'),
('188', 5, 'AZUL', '22', '1956.40', NULL, '2020-10-13 23:35:20'),
('189', 5, 'AMARILLO', '23', '1972.95', NULL, '2020-10-13 23:35:20'),
('190', 5, 'NEGRO', '24', '1989.50', NULL, '2020-10-13 23:35:20'),
('191', 5, 'VIOLETA', '25', '2006.05', NULL, '2020-10-13 23:35:20'),
('192', 5, 'AZUL', 'M', '2022.60', NULL, '2020-10-13 23:35:20'),
('193', 5, 'AMARILLO', 'CH', '2039.15', NULL, '2020-10-13 23:35:20'),
('194', 5, 'NEGRO', 'T', '2055.70', NULL, '2020-10-13 23:35:20'),
('195', 5, 'VIOLETA', 'XG', '2072.25', NULL, '2020-10-13 23:35:20'),
('196', 5, 'AZUL', '22', '2088.80', NULL, '2020-10-13 23:35:21'),
('197', 5, 'AMARILLO', '23', '2105.35', NULL, '2020-10-13 23:35:21'),
('198', 5, 'NEGRO', '24', '2121.90', NULL, '2020-10-13 23:35:21'),
('199', 5, 'VIOLETA', '25', '2138.45', NULL, '2020-10-13 23:35:21'),
('2', 1, 'NEGRO/AZUL', '22', '750.00', NULL, '2020-10-12 09:34:28'),
('200', 5, 'AZUL', 'M', '2155.00', NULL, '2020-10-13 23:35:21'),
('201', 5, 'AMARILLO', 'CH', '2171.55', NULL, '2020-10-13 23:35:21'),
('202', 5, 'NEGRO', 'T', '2188.10', NULL, '2020-10-13 23:35:21'),
('203', 5, 'VIOLETA', 'XG', '2204.65', NULL, '2020-10-13 23:35:21'),
('204', 5, 'AZUL', '22', '2221.20', NULL, '2020-10-13 23:35:21'),
('205', 5, 'AMARILLO', '23', '2237.75', NULL, '2020-10-13 23:35:21'),
('206', 5, 'NEGRO', '24', '2254.30', NULL, '2020-10-13 23:35:21'),
('207', 5, 'VIOLETA', '25', '2270.85', NULL, '2020-10-13 23:35:21'),
('208', 5, 'AZUL', 'M', '2287.40', NULL, '2020-10-13 23:35:21'),
('209', 5, 'AMARILLO', 'CH', '2303.95', NULL, '2020-10-13 23:35:21'),
('210', 5, 'NEGRO', 'T', '2320.50', NULL, '2020-10-13 23:35:21'),
('211', 5, 'VIOLETA', 'XG', '2337.05', NULL, '2020-10-13 23:35:21'),
('212', 5, 'AZUL', '22', '2353.60', NULL, '2020-10-13 23:35:21'),
('213', 5, 'AMARILLO', '23', '2370.15', NULL, '2020-10-13 23:35:21'),
('214', 5, 'NEGRO', '24', '2386.70', NULL, '2020-10-13 23:35:21'),
('215', 5, 'VIOLETA', '25', '2403.25', NULL, '2020-10-13 23:35:21'),
('216', 5, 'AZUL', 'M', '2419.80', NULL, '2020-10-13 23:35:22'),
('217', 5, 'AMARILLO', 'CH', '2436.35', NULL, '2020-10-13 23:35:22'),
('218', 5, 'NEGRO', 'T', '2452.90', NULL, '2020-10-13 23:35:22'),
('219', 5, 'VIOLETA', 'XG', '2469.45', NULL, '2020-10-13 23:35:22'),
('220', 5, 'AZUL', '22', '2486.00', NULL, '2020-10-13 23:35:22'),
('221', 5, 'AMARILLO', '23', '2502.55', NULL, '2020-10-13 23:35:22'),
('222', 5, 'NEGRO', '24', '2519.10', NULL, '2020-10-13 23:35:22'),
('223', 5, 'VIOLETA', '25', '2535.65', NULL, '2020-10-13 23:35:22'),
('224', 5, 'AZUL', 'M', '2552.20', NULL, '2020-10-13 23:35:22'),
('225', 5, 'AMARILLO', 'CH', '2568.75', NULL, '2020-10-13 23:35:22'),
('226', 5, 'NEGRO', 'T', '2585.30', NULL, '2020-10-13 23:35:22'),
('227', 5, 'VIOLETA', 'XG', '2601.85', NULL, '2020-10-13 23:35:22'),
('228', 5, 'AZUL', '22', '2618.40', NULL, '2020-10-13 23:35:22'),
('229', 5, 'AMARILLO', '23', '2634.95', NULL, '2020-10-13 23:35:22'),
('230', 5, 'NEGRO', '24', '2651.50', NULL, '2020-10-13 23:35:22'),
('231', 5, 'VIOLETA', '25', '2668.05', NULL, '2020-10-13 23:35:22'),
('232', 5, 'AZUL', 'M', '2684.60', NULL, '2020-10-13 23:35:22'),
('233', 5, 'AMARILLO', 'CH', '2701.15', NULL, '2020-10-13 23:35:22'),
('234', 5, 'NEGRO', 'T', '2717.70', NULL, '2020-10-13 23:35:22'),
('235', 5, 'VIOLETA', 'XG', '2734.25', NULL, '2020-10-13 23:35:22'),
('236', 5, 'AZUL', '22', '2750.80', NULL, '2020-10-13 23:35:22'),
('237', 5, 'AMARILLO', '23', '2767.35', NULL, '2020-10-13 23:35:22'),
('238', 5, 'NEGRO', '24', '2783.90', NULL, '2020-10-13 23:35:22'),
('239', 5, 'VIOLETA', '25', '2800.45', NULL, '2020-10-13 23:35:22'),
('240', 5, 'AZUL', 'M', '2817.00', NULL, '2020-10-13 23:35:23'),
('241', 5, 'AMARILLO', 'CH', '2833.55', NULL, '2020-10-13 23:35:23'),
('242', 5, 'NEGRO', 'T', '2850.10', NULL, '2020-10-13 23:35:23'),
('243', 5, 'VIOLETA', 'XG', '2866.65', NULL, '2020-10-13 23:35:23'),
('244', 5, 'AZUL', '22', '2883.20', NULL, '2020-10-13 23:35:23'),
('245', 5, 'AMARILLO', '23', '2899.75', NULL, '2020-10-13 23:35:23'),
('246', 5, 'NEGRO', '24', '2916.30', NULL, '2020-10-13 23:35:23'),
('247', 5, 'VIOLETA', '25', '2932.85', NULL, '2020-10-13 23:35:23'),
('248', 5, 'AZUL', 'M', '2949.40', NULL, '2020-10-13 23:35:23'),
('249', 5, 'AMARILLO', 'CH', '2965.95', NULL, '2020-10-13 23:35:23'),
('25', 5, 'MERLOT', '22 AL 27  ENTEROS', '459.50', NULL, '2020-10-04 18:19:49'),
('250', 5, 'NEGRO', 'T', '2982.50', NULL, '2020-10-13 23:35:23'),
('251', 5, 'VIOLETA', 'XG', '2999.05', NULL, '2020-10-13 23:35:23'),
('252', 5, 'AZUL', '22', '3015.60', NULL, '2020-10-13 23:35:23'),
('253', 5, 'AMARILLO', '23', '3032.15', NULL, '2020-10-13 23:35:23'),
('254', 5, 'NEGRO', '23 AL 26', '574.50', NULL, '2020-10-04 18:19:49'),
('255', 5, 'VIOLETA', '25', '3065.25', NULL, '2020-10-13 23:35:26'),
('256', 5, 'AZUL', 'M', '3081.80', NULL, '2020-10-13 23:35:26'),
('257', 5, 'AMARILLO', 'CH', '3098.35', NULL, '2020-10-13 23:35:26'),
('258', 5, 'NEGRO', 'T', '3114.90', NULL, '2020-10-13 23:35:26'),
('259', 5, 'VIOLETA', 'XG', '3131.45', NULL, '2020-10-13 23:35:26'),
('260', 5, 'AZUL', '22', '3148.00', NULL, '2020-10-13 23:35:26'),
('261', 5, 'AMARILLO', '23', '3164.55', NULL, '2020-10-13 23:35:26'),
('262', 5, 'NEGRO', '24', '3181.10', NULL, '2020-10-13 23:35:26'),
('263', 5, 'VIOLETA', '25', '3197.65', NULL, '2020-10-13 23:35:26'),
('264', 5, 'AZUL', 'M', '3214.20', NULL, '2020-10-13 23:35:26'),
('265', 5, 'AMARILLO', 'CH', '3230.75', NULL, '2020-10-13 23:35:26'),
('266', 5, 'NEGRO', 'T', '3247.30', NULL, '2020-10-13 23:35:26'),
('267', 5, 'VIOLETA', 'XG', '3263.85', NULL, '2020-10-13 23:35:27'),
('268', 5, 'AZUL', '22', '3280.40', NULL, '2020-10-13 23:35:27'),
('269', 5, 'AMARILLO', '23', '3296.95', NULL, '2020-10-13 23:35:27'),
('270', 5, 'NEGRO', '24', '3313.50', NULL, '2020-10-13 23:35:27'),
('271', 5, 'VIOLETA', '25', '3330.05', NULL, '2020-10-13 23:35:27'),
('272', 5, 'AZUL', 'M', '3346.60', NULL, '2020-10-13 23:35:27'),
('273', 5, 'AMARILLO', 'CH', '3363.15', NULL, '2020-10-13 23:35:27'),
('274', 5, 'NEGRO', 'T', '3379.70', NULL, '2020-10-13 23:35:27'),
('275', 5, 'VIOLETA', 'XG', '3396.25', NULL, '2020-10-13 23:35:27'),
('276', 5, 'AZUL', '22', '3412.80', NULL, '2020-10-13 23:35:27'),
('277', 5, 'AMARILLO', '23', '3429.35', NULL, '2020-10-13 23:35:27'),
('278', 5, 'NEGRO', '24', '3445.90', NULL, '2020-10-13 23:35:27'),
('279', 5, 'VIOLETA', '25', '3462.45', NULL, '2020-10-13 23:35:27'),
('280', 5, 'AZUL', 'M', '3479.00', NULL, '2020-10-13 23:35:27'),
('281', 5, 'AMARILLO', 'CH', '3495.55', NULL, '2020-10-13 23:35:27'),
('282', 5, 'NEGRO', 'T', '3512.10', NULL, '2020-10-13 23:35:27'),
('283', 5, 'VIOLETA', 'XG', '3528.65', NULL, '2020-10-13 23:35:27'),
('284', 5, 'AZUL', '22', '3545.20', NULL, '2020-10-13 23:35:27'),
('285', 5, 'AMARILLO', '23', '3561.75', NULL, '2020-10-13 23:35:27'),
('286', 5, 'NEGRO', '24', '3578.30', NULL, '2020-10-13 23:35:27'),
('287', 5, 'VIOLETA', '25', '3594.85', NULL, '2020-10-13 23:35:27'),
('288', 5, 'AZUL', 'M', '3611.40', NULL, '2020-10-13 23:35:27'),
('289', 5, 'AMARILLO', 'CH', '3627.95', NULL, '2020-10-13 23:35:27'),
('290', 5, 'NEGRO', 'T', '3644.50', NULL, '2020-10-13 23:35:27'),
('291', 5, 'VIOLETA', 'XG', '3661.05', NULL, '2020-10-13 23:35:27'),
('292', 5, 'AZUL', '22', '3677.60', NULL, '2020-10-13 23:35:27'),
('293', 5, 'AMARILLO', '23', '3694.15', NULL, '2020-10-13 23:35:27'),
('294', 5, 'NEGRO', '24', '3710.70', NULL, '2020-10-13 23:35:28'),
('295', 5, 'VIOLETA', '25', '3727.25', NULL, '2020-10-13 23:35:28'),
('296', 5, 'AZUL', 'M', '3743.80', NULL, '2020-10-13 23:35:28'),
('297', 5, 'AMARILLO', 'CH', '3760.35', NULL, '2020-10-13 23:35:28'),
('298', 5, 'NEGRO', 'T', '3776.90', NULL, '2020-10-13 23:35:28'),
('299', 5, 'VIOLETA', 'XG', '3793.45', NULL, '2020-10-13 23:35:28'),
('3', 3, 'MARINO', '22', '0.00', NULL, '2020-10-13 23:04:43'),
('300', 5, 'AZUL', '22', '3810.00', NULL, '2020-10-13 23:35:28'),
('301', 5, 'AMARILLO', '23', '3826.55', NULL, '2020-10-13 23:35:28'),
('302', 5, 'NEGRO', '24', '3843.10', NULL, '2020-10-13 23:35:28'),
('303', 5, 'VIOLETA', '25', '3859.65', NULL, '2020-10-13 23:35:28'),
('304', 5, 'AZUL', 'M', '3876.20', NULL, '2020-10-13 23:35:28'),
('305', 5, 'AMARILLO', 'CH', '3892.75', NULL, '2020-10-13 23:35:28'),
('306', 5, 'NEGRO', 'T', '3909.30', NULL, '2020-10-13 23:35:28'),
('307', 5, 'VIOLETA', 'XG', '3925.85', NULL, '2020-10-13 23:35:28'),
('308', 5, 'AZUL', '22', '3942.40', NULL, '2020-10-13 23:35:28'),
('309', 5, 'AMARILLO', '23', '3958.95', NULL, '2020-10-13 23:35:28'),
('310', 5, 'NEGRO', '24', '3975.50', NULL, '2020-10-13 23:35:28'),
('311', 5, 'VIOLETA', '25', '3992.05', NULL, '2020-10-13 23:35:28'),
('312', 5, 'AZUL', 'M', '4008.60', NULL, '2020-10-13 23:35:28'),
('313', 5, 'AMARILLO', 'CH', '4025.15', NULL, '2020-10-13 23:35:28'),
('314', 5, 'NEGRO', 'T', '4041.70', NULL, '2020-10-13 23:35:28'),
('315', 5, 'VIOLETA', 'XG', '4058.25', NULL, '2020-10-13 23:35:28'),
('316', 5, 'AZUL', '22', '4074.80', NULL, '2020-10-13 23:35:28'),
('317', 5, 'AMARILLO', '23', '4091.35', NULL, '2020-10-13 23:35:28'),
('318', 5, 'NEGRO', '24', '4107.90', NULL, '2020-10-13 23:35:28'),
('319', 5, 'VIOLETA', '25', '4124.45', NULL, '2020-10-13 23:35:28'),
('320', 5, 'AZUL', 'M', '4141.00', NULL, '2020-10-13 23:35:29'),
('321', 5, 'AMARILLO', 'CH', '4157.55', NULL, '2020-10-13 23:35:29'),
('322', 5, 'NEGRO', 'T', '4174.10', NULL, '2020-10-13 23:35:29'),
('323', 5, 'VIOLETA', 'XG', '4190.65', NULL, '2020-10-13 23:35:29'),
('324', 5, 'AZUL', '22', '4207.20', NULL, '2020-10-13 23:35:29'),
('325', 5, 'AMARILLO', '23', '4223.75', NULL, '2020-10-13 23:35:29'),
('326', 5, 'NEGRO', '24', '4240.30', NULL, '2020-10-13 23:35:29'),
('327', 5, 'VIOLETA', '25', '4256.85', NULL, '2020-10-13 23:35:29'),
('328', 5, 'AZUL', 'M', '4273.40', NULL, '2020-10-13 23:35:29'),
('329', 5, 'AMARILLO', 'CH', '4289.95', NULL, '2020-10-13 23:35:29'),
('330', 5, 'NEGRO', 'T', '4306.50', NULL, '2020-10-13 23:35:29'),
('331', 5, 'VIOLETA', 'XG', '4323.05', NULL, '2020-10-13 23:35:29'),
('332', 5, 'AZUL', '22', '4339.60', NULL, '2020-10-13 23:35:29'),
('333', 5, 'AMARILLO', '23', '4356.15', NULL, '2020-10-13 23:35:29'),
('334', 5, 'NEGRO', '24', '4372.70', NULL, '2020-10-13 23:35:29'),
('335', 5, 'VIOLETA', '25', '4389.25', NULL, '2020-10-13 23:35:29'),
('336', 5, 'AZUL', 'M', '4405.80', NULL, '2020-10-13 23:35:29'),
('337', 5, 'AMARILLO', 'CH', '4422.35', NULL, '2020-10-13 23:35:29'),
('338', 5, 'NEGRO', 'T', '4438.90', NULL, '2020-10-13 23:35:29'),
('339', 5, 'VIOLETA', 'XG', '4455.45', NULL, '2020-10-13 23:35:29'),
('340', 5, 'AZUL', '22', '4472.00', NULL, '2020-10-13 23:35:29'),
('341', 5, 'AMARILLO', '23', '4488.55', NULL, '2020-10-13 23:35:29'),
('342', 5, 'NEGRO', '24', '4505.10', NULL, '2020-10-13 23:35:29'),
('343', 5, 'VIOLETA', '25', '4521.65', NULL, '2020-10-13 23:35:29'),
('344', 5, 'AZUL', 'M', '4538.20', NULL, '2020-10-13 23:35:29'),
('345', 5, 'AMARILLO', 'CH', '4554.75', NULL, '2020-10-13 23:35:29'),
('346', 5, 'NEGRO', 'T', '4571.30', NULL, '2020-10-13 23:35:30'),
('347', 5, 'VIOLETA', 'XG', '4587.85', NULL, '2020-10-13 23:35:30'),
('348', 5, 'AZUL', '22', '4604.40', NULL, '2020-10-13 23:35:30'),
('349', 5, 'AMARILLO', '23', '4620.95', NULL, '2020-10-13 23:35:30'),
('35', 3, 'MARINO', '25', '0.00', NULL, '2020-10-13 23:19:05'),
('350', 5, 'NEGRO', '24', '4637.50', NULL, '2020-10-13 23:35:30'),
('351', 5, 'VIOLETA', '25', '4654.05', NULL, '2020-10-13 23:35:30'),
('352', 5, 'AZUL', 'M', '4670.60', NULL, '2020-10-13 23:35:30'),
('353', 5, 'AMARILLO', 'CH', '4687.15', NULL, '2020-10-13 23:35:30'),
('354', 5, 'NEGRO', 'T', '4703.70', NULL, '2020-10-13 23:35:30'),
('355', 5, 'VIOLETA', 'XG', '4720.25', NULL, '2020-10-13 23:35:30'),
('356', 5, 'AZUL', '22', '4736.80', NULL, '2020-10-13 23:35:30'),
('357', 5, 'AMARILLO', '23', '4753.35', NULL, '2020-10-13 23:35:30'),
('358', 5, 'NEGRO', '24', '4769.90', NULL, '2020-10-13 23:35:30'),
('359', 5, 'VIOLETA', '25', '4786.45', NULL, '2020-10-13 23:35:30'),
('360', 5, 'AZUL', 'M', '4803.00', NULL, '2020-10-13 23:35:30'),
('361', 5, 'AMARILLO', 'CH', '4819.55', NULL, '2020-10-13 23:35:30'),
('362', 5, 'NEGRO', 'T', '4836.10', NULL, '2020-10-13 23:35:30'),
('363', 5, 'VIOLETA', 'XG', '4852.65', NULL, '2020-10-13 23:35:30'),
('364', 5, 'AZUL', '22', '4869.20', NULL, '2020-10-13 23:35:30'),
('365', 5, 'AMARILLO', '23', '4885.75', NULL, '2020-10-13 23:35:30'),
('366', 5, 'NEGRO', '24', '4902.30', NULL, '2020-10-13 23:35:30'),
('367', 5, 'VIOLETA', '25', '4918.85', NULL, '2020-10-13 23:35:30'),
('368', 5, 'AZUL', 'M', '4935.40', NULL, '2020-10-13 23:35:30'),
('369', 5, 'AMARILLO', 'CH', '4951.95', NULL, '2020-10-13 23:35:31'),
('370', 5, 'NEGRO', 'T', '4968.50', NULL, '2020-10-13 23:35:31'),
('371', 5, 'VIOLETA', 'XG', '4985.05', NULL, '2020-10-13 23:35:31'),
('372', 5, 'AZUL', '22', '5001.60', NULL, '2020-10-13 23:35:31'),
('373', 5, 'AMARILLO', '23', '5018.15', NULL, '2020-10-13 23:35:31'),
('374', 5, 'NEGRO', '24', '5034.70', NULL, '2020-10-13 23:35:31'),
('375', 5, 'VIOLETA', '25', '5051.25', NULL, '2020-10-13 23:35:31'),
('376', 5, 'AZUL', 'M', '5067.80', NULL, '2020-10-13 23:35:31'),
('377', 5, 'AMARILLO', 'CH', '5084.35', NULL, '2020-10-13 23:35:31'),
('378', 5, 'NEGRO', 'T', '5100.90', NULL, '2020-10-13 23:35:31'),
('379', 5, 'VIOLETA', 'XG', '5117.45', NULL, '2020-10-13 23:35:31'),
('380', 5, 'AZUL', '22', '5134.00', NULL, '2020-10-13 23:35:31'),
('381', 5, 'AMARILLO', '23', '5150.55', NULL, '2020-10-13 23:35:31'),
('382', 5, 'NEGRO', '24', '5167.10', NULL, '2020-10-13 23:35:31'),
('383', 5, 'VIOLETA', '25', '5183.65', NULL, '2020-10-13 23:35:31'),
('384', 5, 'AZUL', 'M', '5200.20', NULL, '2020-10-13 23:35:31'),
('385', 5, 'AMARILLO', 'CH', '5216.75', NULL, '2020-10-13 23:35:31'),
('386', 5, 'NEGRO', 'T', '5233.30', NULL, '2020-10-13 23:35:31'),
('387', 5, 'VIOLETA', 'XG', '5249.85', NULL, '2020-10-13 23:35:32'),
('388', 5, 'AZUL', '22', '5266.40', NULL, '2020-10-13 23:35:32'),
('389', 5, 'AMARILLO', '23', '5282.95', NULL, '2020-10-13 23:35:32'),
('390', 5, 'NEGRO', '24', '5299.50', NULL, '2020-10-13 23:35:32'),
('391', 5, 'VIOLETA', '25', '5316.05', NULL, '2020-10-13 23:35:32'),
('392', 5, 'AZUL', 'M', '5332.60', NULL, '2020-10-13 23:35:32'),
('393', 5, 'AMARILLO', 'CH', '5349.15', NULL, '2020-10-13 23:35:32'),
('394', 5, 'NEGRO', 'T', '5365.70', NULL, '2020-10-13 23:35:32'),
('395', 5, 'VIOLETA', 'XG', '5382.25', NULL, '2020-10-13 23:35:32'),
('396', 5, 'AZUL', '22', '5398.80', NULL, '2020-10-13 23:35:32'),
('397', 5, 'AMARILLO', '23', '5415.35', NULL, '2020-10-13 23:35:32'),
('398', 5, 'NEGRO', '24', '5431.90', NULL, '2020-10-13 23:35:32'),
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
  MODIFY `IDCliente` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- AUTO_INCREMENT de la tabla `color`
--
ALTER TABLE `color`
  MODIFY `IDColor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `IDPedido` bigint(20) NOT NULL AUTO_INCREMENT;

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
