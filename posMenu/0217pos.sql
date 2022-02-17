-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        10.1.28-MariaDB - mariadb.org binary distribution
-- 서버 OS:                        Win32
-- HeidiSQL 버전:                  11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- 테이블 dawoon.dc_posmenu 구조 내보내기
CREATE TABLE IF NOT EXISTS `dc_posmenu` (
  `posseq` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `price` int(11) DEFAULT NULL,
  `options` char(10) DEFAULT NULL,
  PRIMARY KEY (`posseq`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 테이블 데이터 dawoon.dc_posmenu:~5 rows (대략적) 내보내기
DELETE FROM `dc_posmenu`;
/*!40000 ALTER TABLE `dc_posmenu` DISABLE KEYS */;
INSERT INTO `dc_posmenu` (`posseq`, `name`, `price`, `options`) VALUES
	(1, '1', 1, '1'),
	(3, '3', 3, '3'),
	(23, '3', 4, '4'),
	(41, '1', 1, '1'),
	(1241, '111', 11, '11');
/*!40000 ALTER TABLE `dc_posmenu` ENABLE KEYS */;

-- 테이블 dawoon.dc_posorder 구조 내보내기
CREATE TABLE IF NOT EXISTS `dc_posorder` (
  `number` int(11) NOT NULL,
  `menu` varchar(50) DEFAULT NULL,
  `pay` int(11) DEFAULT NULL,
  `money` decimal(18,0) DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 테이블 데이터 dawoon.dc_posorder:~0 rows (대략적) 내보내기
DELETE FROM `dc_posorder`;
/*!40000 ALTER TABLE `dc_posorder` DISABLE KEYS */;
/*!40000 ALTER TABLE `dc_posorder` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
