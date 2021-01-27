-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jan 21, 2021 at 05:21 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `directoriotelefonico_albumfotografico`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DirectorioTelefonico_Eventos_CRUD` (IN `OPC_` INT, IN `fecha_` DATE, IN `lugar_` VARCHAR(50), IN `descrLugar_` VARCHAR(200), IN `descrImg_` VARCHAR(200), IN `dirImagen_` VARCHAR(200))  BEGIN
   /*CREATE EVENT*/
   IF (OPC_=1) THEN
   
   INSERT INTO directoriotelefonico_eventos (fechaEvento, lugarEvento, descripcionLugarEvento, descripcionImagen, dirImagen) values
   (fecha_,lugar_,descrLugar_,descrImg_,dirImagen_);
   
   SELECT 'Registro creado correctamente';
   END IF;
   
   /*READ EVENTS*/
   IF (OPC_=2) THEN
   
   SELECT  fechaEvento Fecha_Evento, lugarEvento Lugar_Evento, descripcionLugarEvento Descripcion_Lugar,
   descripcionImagen Descripcion_Imagen, dirImagen Directorio_Imagen
   FROM directoriotelefonico_eventos LIMIT 1;
   
   END IF;
   
    /*UPDATE EVENTS*/
   IF (OPC_=3) THEN
   
   UPDATE directoriotelefonico_eventos
   SET fechaEvento=fecha_, lugarEvento=lugar_, descripcionImagen=descrImg_, dirImagen=dirImagen_
   WHERE descripcionLugarEvento=descrLugar_;
   
   SELECT 'El Evento ha sido editado correctamente';
   
   END IF;
   
    /*UPDATE EVENTS*/
   IF (OPC_=4) THEN
   
   DELETE FROM directoriotelefonico_eventos
   WHERE descripcionLugarEvento=descrLugar_;
   
   SELECT 'El Evento ha sido Eliminado';
   
   END IF;
   
    /*SEARCH EVENTS BY descripcionLugarEvento*/
   IF (OPC_=5) THEN
   
   SELECT fechaEvento Fecha_Evento, lugarEvento Lugar_Evento, descripcionLugarEvento Descripcion_Lugar,
   descripcionImagen Descripcion_Imagen, dirImagen Directorio_Imagen FROM directoriotelefonico_eventos
   WHERE descripcionLugarEvento LIKE concat('%',descrLugar_,'%') ;
   
   END IF;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `directoriotelefonico_eventos`
--

CREATE TABLE `directoriotelefonico_eventos` (
  `idEvento` int(11) NOT NULL,
  `fechaEvento` date DEFAULT NULL,
  `lugarEvento` varchar(25) DEFAULT NULL,
  `descripcionLugarEvento` varchar(200) DEFAULT NULL,
  `descripcionImagen` varchar(200) DEFAULT NULL,
  `dirImagen` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `directoriotelefonico_eventos`
--

INSERT INTO `directoriotelefonico_eventos` (`idEvento`, `fechaEvento`, `lugarEvento`, `descripcionLugarEvento`, `descripcionImagen`, `dirImagen`) VALUES
(1, '2021-01-23', 'Oficina - Medellín', 'Oficina Colegio de la ciudad de Medellín', 'Colegio de la salle med', 'C:\\Users\\aramirez\\Downloads\\colegio.jpg'),
(2, '2021-01-28', 'Oficina - Cali', 'Visita Coliseo Romano', 'Coliseo de la ciudad de Roma, Italia', 'C:\\Users\\aramirez\\Downloads\\colRomano.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `directoriotelefonico_eventos`
--
ALTER TABLE `directoriotelefonico_eventos`
  ADD PRIMARY KEY (`idEvento`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `directoriotelefonico_eventos`
--
ALTER TABLE `directoriotelefonico_eventos`
  MODIFY `idEvento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
