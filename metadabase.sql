-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.7.10-log - MySQL Community Server (GPL)
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.1.0.4867
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
-- Volcando datos para la tabla meta.bds: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `bds` DISABLE KEYS */;
INSERT INTO `bds` (`ID`, `database_type`, `user`, `pass`, `server`, `protocol`, `port`, `alias`, `nombre`) VALUES
	(1, 'MariaDB', ' root', 'salmo23', 'server', 'tcp', '3307', 'MySQL', 'SUN'),
	(9, 'MongoDB', 'uzi', 'server', 'server', 'tcp', '3030', 'servidirijillo', 'mega'),
	(10, 'MariaDB', 'ds', 'fsd', 'fsd', 'wer', '123', 'bgr', 'vfjj'),
	(11, 'SQLServer', 'ds', 'fsd', 'fsd', 'wer', '123', 'bgr', 'vfjj'),
	(12, 'MongoDB', 'asd', 'server', 'server', 'protocol', '4100', 'basilla', 'bass'),
	(13, 'MariaDB', 'lkj', 'tr', 'tr', 'asd', '123', 'zxc', 'cv');
/*!40000 ALTER TABLE `bds` ENABLE KEYS */;

-- Volcando datos para la tabla meta.columnas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `columnas` DISABLE KEYS */;
/*!40000 ALTER TABLE `columnas` ENABLE KEYS */;

-- Volcando datos para la tabla meta.datos: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `datos` DISABLE KEYS */;
INSERT INTO `datos` (`Columna1`, `Columna2`, `Columna3`, `Columna4`, `Columna5`) VALUES
	(99, 2, 3, 4, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL),
	(5, 6, 7, 8, NULL);
/*!40000 ALTER TABLE `datos` ENABLE KEYS */;

-- Volcando datos para la tabla meta.mongobds: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `mongobds` DISABLE KEYS */;
INSERT INTO `mongobds` (`ID`, `Name`) VALUES
	(1, 'asd'),
	(2, 'asd'),
	(3, 'nu'),
	(4, 'lk');
/*!40000 ALTER TABLE `mongobds` ENABLE KEYS */;

-- Volcando datos para la tabla meta.tablas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tablas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tablas` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
