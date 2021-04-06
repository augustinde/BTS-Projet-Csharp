-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 06, 2021 at 10:36 AM
-- Server version: 5.7.31
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testlab7`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `idClt` int(11) NOT NULL AUTO_INCREMENT,
  `nomClt` varchar(255) NOT NULL,
  `prenomClt` varchar(255) NOT NULL,
  `adresseClt` varchar(255) DEFAULT NULL,
  `cpClt` varchar(5) DEFAULT NULL,
  `villeClt` varchar(255) DEFAULT NULL,
  `adresseMailClt` varchar(255) DEFAULT NULL,
  `telClt` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idClt`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`idClt`, `nomClt`, `prenomClt`, `adresseClt`, `cpClt`, `villeClt`, `adresseMailClt`, `telClt`) VALUES
(1, 'Brindille', 'Julien', '7 rue De Gaulle', '02420', 'Nauroy', 'Julien.Brindille@gmail.com', '0625698451'),
(2, 'Sasin', 'Lucas', '7 rue savaux', '02000', 'Laon', 'sasinLuca@hotmail.com', '0623151524'),
(3, 'Hedou', 'Adrien', '15 rue de Paris', '75000', 'Paris', 'HedouAdrien@gmail.com', '0635358457'),
(4, 'Verson', 'Augustin', '45 rue des paquerettes', '02100', 'St-Quentin', 'VersonAugustin@outlook.fr', '0323235689'),
(5, 'Brazeilles', 'Josette', '27 rue des flambeaux', '02500', 'Hirson', 'BrazeillesJosette@yahoo.fr', '0324245875'),
(6, 'Hedouxe', 'Leo', '25 rue de léroine', '02200', 'Soisson', '18 rue du pont', '0654587510'),
(7, 'Desaintfucien', 'Ugo', '3 rue de cathedrale', '02220', 'Crepy-en-vallois', '44', '44'),
(8, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(9, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(10, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(12, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(13, 'test', 'bob', 'adresse', '22', 'ville', 'email', '145'),
(14, 'test', 'bob', 'adresse', '22', 'ville', 'email', '145'),
(15, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(16, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(17, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(18, 'test', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789'),
(19, 'Bob', 'Bobby', '16 rue du test', '02420', 'testland', 'test@test.com', '0123456789');

-- --------------------------------------------------------

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
CREATE TABLE IF NOT EXISTS `employe` (
  `idEmploye` int(11) NOT NULL AUTO_INCREMENT,
  `nomUtilisateur` varchar(255) NOT NULL,
  `motDePasse` text NOT NULL,
  `fonction` varchar(20) NOT NULL,
  `actif` varchar(3) NOT NULL,
  PRIMARY KEY (`idEmploye`),
  KEY `fk_idFonction` (`fonction`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employe`
--

INSERT INTO `employe` (`idEmploye`, `nomUtilisateur`, `motDePasse`, `fonction`, `actif`) VALUES
(2, 'jose', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', 'Technicien', 'oui'),
(10, 'francis', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', 'Administrateur', 'oui');

-- --------------------------------------------------------

--
-- Table structure for table `fichedereparation`
--

DROP TABLE IF EXISTS `fichedereparation`;
CREATE TABLE IF NOT EXISTS `fichedereparation` (
  `idFiche` int(11) NOT NULL AUTO_INCREMENT,
  `dateAchat` datetime NOT NULL,
  `idModele` int(11) NOT NULL,
  `commentaire` varchar(255) NOT NULL,
  `dateDevis` date NOT NULL DEFAULT '2000-01-01',
  `dureeReparation` int(11) NOT NULL,
  `idTva` int(11) NOT NULL,
  `ttc` double NOT NULL,
  `ht` double NOT NULL,
  `idMainOeuvre` int(11) NOT NULL,
  `statut` varchar(255) NOT NULL,
  `sousStatut` varchar(30) NOT NULL,
  `idClient` int(11) NOT NULL,
  `idMarque` int(11) NOT NULL,
  `numSerie` varchar(255) NOT NULL,
  PRIMARY KEY (`idFiche`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fichedereparation`
--

INSERT INTO `fichedereparation` (`idFiche`, `dateAchat`, `idModele`, `commentaire`, `dateDevis`, `dureeReparation`, `idTva`, `ttc`, `ht`, `idMainOeuvre`, `statut`, `sousStatut`, `idClient`, `idMarque`, `numSerie`) VALUES
(7, '2021-02-14 08:58:30', 11, 'test', '2021-02-16', 2, 3, 124.32, 103.6, 3, 'Facture', 'Archivée', 1, 1, ''),
(10, '2021-02-14 09:04:09', 11, 'dd', '2021-02-17', 2, 3, 122.88000000000001, 102.4, 3, 'Facture', 'En attente de règlement', 1, 1, ''),
(11, '2021-02-28 11:00:21', 11, 'test', '2021-02-28', 2, 3, 122.88000000000001, 102.4, 3, 'Devis', 'En attente d\'accord client', 1, 1, 'dddd3');

-- --------------------------------------------------------

--
-- Table structure for table `fichehaspiecedet`
--

DROP TABLE IF EXISTS `fichehaspiecedet`;
CREATE TABLE IF NOT EXISTS `fichehaspiecedet` (
  `idFicheHasPieceDet` int(11) NOT NULL AUTO_INCREMENT,
  `idFiche` int(11) NOT NULL,
  `idPieceDet` int(11) NOT NULL,
  `quantite` int(11) NOT NULL,
  `prixTotal` double NOT NULL,
  PRIMARY KEY (`idFicheHasPieceDet`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fichehaspiecedet`
--

INSERT INTO `fichehaspiecedet` (`idFicheHasPieceDet`, `idFiche`, `idPieceDet`, `quantite`, `prixTotal`) VALUES
(8, 7, 1, 3, 3.6),
(11, 10, 1, 2, 2.4),
(12, 11, 1, 2, 2.4);

-- --------------------------------------------------------

--
-- Table structure for table `fonction`
--

DROP TABLE IF EXISTS `fonction`;
CREATE TABLE IF NOT EXISTS `fonction` (
  `idFonction` int(11) NOT NULL AUTO_INCREMENT,
  `libelleFonction` varchar(255) NOT NULL,
  PRIMARY KEY (`idFonction`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `fonction`
--

INSERT INTO `fonction` (`idFonction`, `libelleFonction`) VALUES
(1, 'Administrateur'),
(2, 'Technicien');

-- --------------------------------------------------------

--
-- Table structure for table `infolab7`
--

DROP TABLE IF EXISTS `infolab7`;
CREATE TABLE IF NOT EXISTS `infolab7` (
  `idInfoLab` int(11) NOT NULL AUTO_INCREMENT,
  `nomLab` varchar(255) NOT NULL,
  `adresseLab` varchar(255) NOT NULL,
  `cpLab` varchar(5) NOT NULL,
  `villeLab` varchar(255) NOT NULL,
  `telLab` varchar(10) NOT NULL,
  `faxLab` varchar(10) NOT NULL,
  `typeSocieteLab` varchar(255) NOT NULL,
  `RCSLab` varchar(255) NOT NULL,
  `SiretLab` varchar(255) NOT NULL,
  `APELab` varchar(255) NOT NULL,
  PRIMARY KEY (`idInfoLab`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `infolab7`
--

INSERT INTO `infolab7` (`idInfoLab`, `nomLab`, `adresseLab`, `cpLab`, `villeLab`, `telLab`, `faxLab`, `typeSocieteLab`, `RCSLab`, `SiretLab`, `APELab`) VALUES
(1, 'LAB7', '18 rue Le Sueur', '75116', 'Paris', '0145006622', '0145006699', 'SARL', 'PARIS B 395 284 870', '395 254 870 00023', '323Z');

-- --------------------------------------------------------

--
-- Table structure for table `mainoeuvre`
--

DROP TABLE IF EXISTS `mainoeuvre`;
CREATE TABLE IF NOT EXISTS `mainoeuvre` (
  `idMainOeuvre` int(11) NOT NULL AUTO_INCREMENT,
  `montantMainOeuvre` double NOT NULL,
  `actif` tinyint(1) NOT NULL,
  PRIMARY KEY (`idMainOeuvre`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mainoeuvre`
--

INSERT INTO `mainoeuvre` (`idMainOeuvre`, `montantMainOeuvre`, `actif`) VALUES
(1, 150, 0),
(2, 90, 0),
(3, 50, 1);

-- --------------------------------------------------------

--
-- Table structure for table `marque`
--

DROP TABLE IF EXISTS `marque`;
CREATE TABLE IF NOT EXISTS `marque` (
  `idMarque` int(11) NOT NULL AUTO_INCREMENT,
  `nomMarque` varchar(255) NOT NULL,
  PRIMARY KEY (`idMarque`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `marque`
--

INSERT INTO `marque` (`idMarque`, `nomMarque`) VALUES
(1, 'ACCUPHASE'),
(2, 'ANTHEn'),
(3, 'AUDIO ANALOGUE'),
(4, 'Boston'),
(5, 'Conrad Johnson'),
(6, 'Coplan'),
(7, 'Creek'),
(8, 'D&M Professional'),
(9, 'Gryphon'),
(10, 'Hegel'),
(11, 'KEF'),
(12, 'Marantz'),
(13, 'Polkaudio Home'),
(14, 'Sherbourn'),
(15, 'Airbus');

-- --------------------------------------------------------

--
-- Table structure for table `modele`
--

DROP TABLE IF EXISTS `modele`;
CREATE TABLE IF NOT EXISTS `modele` (
  `idModele` int(11) NOT NULL AUTO_INCREMENT,
  `nomModele` varchar(255) NOT NULL,
  `marque` int(11) NOT NULL,
  PRIMARY KEY (`idModele`),
  KEY `fk_marque` (`marque`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `modele`
--

INSERT INTO `modele` (`idModele`, `nomModele`, `marque`) VALUES
(1, 'GT1', 4),
(2, 'GT2', 4),
(3, 'EM-4', 8),
(4, 'EM-2', 8),
(5, 'EXM-400', 14),
(6, 'EXM-520', 14),
(7, 'VG41', 2),
(8, 'VG42', 2),
(9, 'RK27', 11),
(10, 'RK28', 11),
(11, 'A200', 1);

-- --------------------------------------------------------

--
-- Table structure for table `piecedetachee`
--

DROP TABLE IF EXISTS `piecedetachee`;
CREATE TABLE IF NOT EXISTS `piecedetachee` (
  `idPieceDet` int(11) NOT NULL AUTO_INCREMENT,
  `nomPieceDet` varchar(255) NOT NULL,
  `prixUnitairePieceDet` double NOT NULL,
  `stockPieceDet` int(11) NOT NULL,
  PRIMARY KEY (`idPieceDet`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `piecedetachee`
--

INSERT INTO `piecedetachee` (`idPieceDet`, `nomPieceDet`, `prixUnitairePieceDet`, `stockPieceDet`) VALUES
(1, 'vis', 1.2, 33),
(3, 'haut parleur', 7.5, 17),
(7, 'boulon', 4.3, 117);

-- --------------------------------------------------------

--
-- Table structure for table `status`
--

DROP TABLE IF EXISTS `status`;
CREATE TABLE IF NOT EXISTS `status` (
  `idStatus` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) NOT NULL,
  PRIMARY KEY (`idStatus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tva`
--

DROP TABLE IF EXISTS `tva`;
CREATE TABLE IF NOT EXISTS `tva` (
  `idTva` int(11) NOT NULL AUTO_INCREMENT,
  `montantTva` double NOT NULL,
  `actif` tinyint(1) NOT NULL,
  PRIMARY KEY (`idTva`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tva`
--

INSERT INTO `tva` (`idTva`, `montantTva`, `actif`) VALUES
(3, 20, 1),
(4, 21, 0),
(5, 10, 0),
(6, 22, 0),
(7, 23, 0);

-- --------------------------------------------------------

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nomUtilisateur` varchar(255) NOT NULL,
  `motDePasse` text NOT NULL,
  `fonction` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nomUtilisateur`, `motDePasse`, `fonction`) VALUES
(1, 'francislechat', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', '1');

-- --------------------------------------------------------

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
CREATE TABLE IF NOT EXISTS `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__migrationhistory`
--

INSERT INTO `__migrationhistory` (`MigrationId`, `ContextKey`, `Model`, `ProductVersion`) VALUES
('202012131046563_InitialMigration', 'TestEF.Migrations.Configuration', 0x1f8b0800000000000400cd57db6edb38107d5fa0ff40f039357341d1dd406a91daf122689d0451da775a1a3b4429524b5281fd6d7dd84fda5fd8a1a88b25c5899b5d2c160102899acbe1993343faaf1f7f461f37b9248f60acd02aa62793634a40a53a136a1dd3d2addefe4a3f7e78f34b7499e51bf2adb13bf376e8a96c4c1f9c2bce19b3e903e4dc4e72911a6df5ca4d529d339e69767a7cfc1b3b3961802128c62224ba2b951339542ff83ad52a85c2955c2e7406d2d6ebf825a9a2926b9e832d780a31bd07eb2ee7945c48c1317b02724509574a3bee10dbf9570b89335aad930217b8bcdf1680762b2e2dd498cf3bf343e11f9f7af8ac736c42a5a5753affc9802767351f6ce8fe2a5669cb17327689ccbaaddf75c55a4c2f4af7a00d25c354e75369bc5943e924181e91f07ad4561b45e1ff8ec8b494ae34102b289de1f288dc964b29d2cfb0bdd7df41c5aa9472170ba2c16fbd055cba35ba00e3b677b0aa115e6594b0be1f1b3ab66e3b3e01fd957267a7945c6372be94d0967a67a789d3067e0705863bc86eb97360948f011559a3ec835cfe7f930db585ad41c9826fbe805abb8798e2232573b181ac59a9117c55023b099d9c29a19f24625d9dc6d5c37e705c20dc1ac0623b5bfa35d8b827ea888aaf4b69eb54fddd849809b89e202c251d84d04793462a4f216d3175cdc94277365dccf6b471b4e04581a4edb475bd4292d0d3d3b7c9cf0b3f0f31586a9fd07f8bb6cd8412e06b187cc5d488742e8c7533eef892fbb24db37c64b65b813dec3699fa240fd5df71ded8fbe7e0d3ebc3a167c7da1c3792a372ab3d419bbfedf491633547b9e4e6891e9a6a59e66a5f1f3ee71dba62d73fac8c23446c807c480a1bb132980643929fd3e7d0a4cddeea74a0c7a8d6c6cb67cf482cc18412a4e651644128c91f72e2bf4faac7a914b8e1ce62c19558619dc3c4a4ef26ef0747d9ffe75861d666f2a0b3e53f9ff9c253fae2541f1d09878f79891788306ebb20ff748a8f47cd2173fa99311dd417d36ca9117700d90ef757cef0712f446cf7b616cdc08a7517c2dfdd14a45e645dd0c6e64aad744332ee6b17516332a8c1021ccf909e0be3c48aa70e3fa7606d75e47ee3b24493cb7c09d995ba295d51ba0b6b215fcade111eb1e7f35707551f737453f837fb6f6c01610adc02dca84fa590598b7b3ed6e0be105e29b5b011155e3930dc7adb46bad6eac040357d332840f9b6b887bc9018ccdea8843fc26bb0e16de30bac79ba6d26dafe202f17a24f7b34137c6d786eeb189dbfff05c2fc4f900f7f0379bcdd67b40c0000, '6.4.4');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `modele`
--
ALTER TABLE `modele`
  ADD CONSTRAINT `fk_marque` FOREIGN KEY (`marque`) REFERENCES `marque` (`idMarque`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
