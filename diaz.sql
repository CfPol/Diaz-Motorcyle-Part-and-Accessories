-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2024 at 06:28 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `diaz`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Level` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`Username`, `Password`, `Level`) VALUES
('1', '356a192b7913b04c54574d18c28d46e6395428ab', 'Owner'),
('2', 'da4b9237bacccdf19c0760cab7aec4a8359010b0', 'Employee'),
('me', '17ba0791499db908433b80f37c5fbc89b870084b', 'Owner');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `Invoice_id` int(11) NOT NULL,
  `Customer_name` varchar(255) NOT NULL,
  `Total_amount` double NOT NULL,
  `Payment_method` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `Warranty_number` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`Invoice_id`, `Customer_name`, `Total_amount`, `Payment_method`, `Date`, `Warranty_number`) VALUES
(1, 'kyo', 0, 'Gcash', '0000-00-00', NULL),
(2, 'sdf', 13.75, 'Cash', '0000-00-00', NULL),
(3, 'sadf', 600, 'Cash', '0000-00-00', NULL),
(4, 'adf', 900, 'Gcash', '2024-05-08', NULL),
(5, 'kyo', 613.25, 'Gcash', '2024-05-08', NULL),
(6, 'kyo', 613.25, 'Gcash', '2024-05-08', NULL),
(7, 'kyo', 600, 'Cash', '2024-05-08', NULL),
(8, 'kyo', 600, 'Cash', '2024-05-08', NULL),
(9, 'kyo', 600, 'Cash', '2024-05-08', NULL),
(10, 'kyo', 600, 'Cash', '2024-05-08', NULL),
(11, 'adf', 600, 'Cash', '2024-05-08', NULL),
(12, 'adf', 600, 'Cash', '2024-05-08', NULL),
(13, 'adf', 600, 'Gcash', '2024-05-08', NULL),
(14, 'adf', 600, 'Gcash', '2024-05-08', NULL),
(15, 'ad', 5000, 'Cash', '2024-05-08', NULL),
(16, 'ad', 5000, 'Cash', '2024-05-08', NULL),
(17, 'adf', 5000, 'Cash', '2024-05-08', NULL),
(18, 'adf', 5000, 'Cash', '2024-05-08', NULL),
(19, 'df', 5000, 'Cash', '2024-05-08', NULL),
(20, 'df', 5000, 'Cash', '2024-05-08', NULL),
(21, 'sadf', 5000, 'Cash', '2024-05-08', 1),
(22, 'sadf', 5000, 'Cash', '2024-05-08', 1);

-- --------------------------------------------------------

--
-- Table structure for table `invoice_items`
--

CREATE TABLE `invoice_items` (
  `Product` int(11) NOT NULL,
  `Invoice_ref` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Total_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoice_items`
--

INSERT INTO `invoice_items` (`Product`, `Invoice_ref`, `Quantity`, `Total_price`) VALUES
(8, 5, 1, 600.5);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `Product_id` int(11) NOT NULL,
  `Supplier` int(11) NOT NULL,
  `Product_name` varchar(255) NOT NULL,
  `Brand` varchar(255) NOT NULL,
  `Model` varchar(255) NOT NULL,
  `Unit_price` double NOT NULL,
  `Available_stock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`Product_id`, `Supplier`, `Product_name`, `Brand`, `Model`, `Unit_price`, `Available_stock`) VALUES
(1, 1, 'battery', 'motolite', 'a78', 5000, 0),
(2, 1, 'Spark Plug', 'random', '15a1', 600, 10),
(3, 1, 'adf', 'df', 'adf', 12, 12),
(4, 1, 'adsf', 'adf', 'adf', 12, 12),
(5, 1, 'lol', 'sdf', 'sd', 12.75, 12),
(6, 9, 'adf', 'adf', 'adf', 1, 1),
(7, 1, 'chain', 'ching chong', 'z42', 300, 20),
(8, 9, 'brake caliper', 'ching chong', 'idk man', 600.5, 3),
(9, 1, 'battery', 'motolite', 'a78', 5000, 10),
(10, 1, 'Wheels', 'Jaxnation', 'LeMans', 8583.63, 15),
(12, 1, 'Ignition system', 'Skiba', 'Explorer', 2829.65, 59),
(13, 1, 'Battery', 'Eare', 'Galant', 2303.99, 28),
(15, 1, 'Battery', 'Lazzy', 'Boxster', 4792.14, 74),
(16, 1, 'Frame', 'Kanoodle', 'F-Series', 824.47, 35),
(20, 1, 'Wheels', 'Avaveo', 'GX', 2750.3, 0),
(22, 1, 'suspension', 'Gigazoom', 'Outlander', 7928.77, 68),
(23, 1, 'Sprockets', 'Browsedrive', 'Outlander', 9688.16, 20),
(24, 1, 'Tires', 'Bubblemix', 'XK Series', 4877.58, 12),
(25, 1, 'Frame', 'Wordpedia', 'NSX', 8188.41, 38),
(26, 1, 'Chain', 'Wikido', 'Silhouette', 4247.84, 70),
(28, 1, 'Ignition system', 'Mydeo', 'Sonoma', 2999.2, 17),
(29, 1, 'Tires', 'Pixope', 'Grand Prix', 3539.5, 38),
(30, 1, 'Fairing', 'Kare', 'Avalon', 7784.58, 66),
(32, 1, 'Wheels', 'Fivebridge', '3500', 1129.92, 59),
(33, 1, 'brakes', 'Twitterbeat', '745', 4902.64, 86),
(35, 1, 'Handlebars', 'Aivee', 'Colt Vista', 1630.16, 3),
(36, 1, 'Chain', 'Ntags', 'Insight', 4348.06, 27),
(39, 1, 'suspension', 'Yadel', 'A6', 6503.55, 62),
(40, 1, 'Frame', 'Feedspan', 'Nitro', 7009.1, 30),
(41, 1, 'Seat', 'Blogtags', 'Savana 1500', 1461.65, 65),
(43, 1, 'Fairing', 'Meeveo', 'Viper', 6720.58, 63),
(45, 1, 'Cooling system', 'Feednation', 'RDX', 807.42, 22),
(47, 1, 'Mirrors', 'Thoughtsphere', 'Malibu', 1695.7, 37),
(48, 1, 'Lights', 'Flashpoint', '500SEL', 3089.87, 51),
(51, 1, 'exhaust', 'Bubbletube', 'E-Class', 6181.46, 74),
(52, 1, 'Fairing', 'Babbleset', 'S10', 2787.05, 43),
(53, 1, 'Cooling system', 'Brainsphere', 'Venture', 6795.82, 82),
(55, 1, 'Handlebars', 'Kimia', 'Dakota', 8772.8, 19),
(56, 1, 'Fuel tank', 'Janyx', 'Express 3500', 3470.85, 20),
(57, 1, 'Seat', 'Mydo', 'Montero', 7388, 83),
(58, 1, 'engine', 'Leexo', 'C30', 2857.84, 99),
(59, 1, 'Seat', 'Photojam', 'Savana 2500', 9976.96, 48),
(61, 1, 'Battery', 'Jatri', 'S-Class', 2781.97, 94),
(64, 1, 'Fuel tank', 'Plambee', 'C-Class', 4502.24, 94),
(65, 1, 'suspension', 'Voonte', 'Camaro', 3092.37, 52),
(66, 1, 'Lights', 'Brainverse', 'Q7', 2213.09, 100),
(67, 1, 'Chain', 'Twitterlist', 'Xterra', 8482.39, 5),
(68, 1, 'Handlebars', 'Wikibox', '458 Italia', 9957.4, 44),
(70, 1, 'Chain', 'Shuffledrive', 'Express 2500', 1190.77, 70),
(71, 1, 'Wheels', 'Roodel', '80', 6813.78, 95),
(72, 1, 'Tires', 'Jetwire', 'Rapide', 4768.6, 35),
(73, 1, 'body', 'Fliptune', 'Bravada', 5115.04, 3),
(74, 1, 'engine', 'Flipstorm', 'IS', 4966.16, 89),
(75, 1, 'suspension', 'Twitternation', 'F-Series', 9191.64, 82),
(77, 1, 'Battery', 'Flipbug', 'Patriot', 3696.16, 22),
(79, 1, 'Lights', 'Gabtype', 'F250', 6089.16, 99),
(80, 1, 'Handlebars', 'Jabbertype', 'SC', 2648.04, 22),
(81, 1, 'Handlebars', 'Oyoloo', 'TrailBlazer', 8543.41, 78),
(83, 1, 'Transmission', 'Yozio', 'Yukon XL 1500', 4157.16, 36),
(84, 1, 'Battery', 'Fiveclub', 'Outlander', 5659.72, 47),
(85, 1, 'Lights', 'Trilith', 'riolet', 6460.46, 11),
(86, 1, 'engine', 'Feedfish', 'Rainier', 4881.86, 50),
(87, 1, 'Fuel tank', 'Geba', '3 Series', 5419.9, 69),
(88, 1, 'Fairing', 'Feedfire', 'S10', 1250.36, 49),
(89, 1, 'Transmission', 'Quatz', 'B-Series Plus', 6424.57, 68),
(90, 1, 'Frame', 'Skyvu', 'Freestar', 3707.96, 60),
(91, 1, 'Mirrors', 'Agimba', 'MKS', 7986.59, 17),
(92, 1, 'brakes', 'Gabspot', 'Astro', 8574.1, 84),
(95, 1, 'Wheels', 'Meeveo', 'Summit', 2804.15, 81),
(96, 1, 'Seat', 'Pixoboo', 'SL-Class', 1836.07, 46),
(97, 1, 'Battery', 'Wordtune', 'CR-V', 3055.04, 76),
(98, 1, 'suspension', 'Latz', 'Galant', 4938.85, 40),
(99, 1, 'Handlebars', 'LiveZ', 'Highlander', 3997.31, 57),
(100, 1, 'Ignition system', 'Jabbersphere', 'CR-V', 3035.45, 88),
(102, 1, 'Sprockets', 'Realbuzz', 'R-Class', 7026.66, 92),
(103, 1, 'Sprockets', 'Trudoo', 'Dakota', 9395.04, 12),
(104, 1, 'Mirrors', 'Skyba', 'Taurus', 3639.08, 16),
(105, 1, 'Chain', 'Skibox', 'Windstar', 1144.3, 95),
(106, 1, 'brakes', 'Zoovu', 'Taurus', 5358.97, 23),
(107, 1, 'suspension', 'Brightbean', 'Grand Am', 3612.08, 11),
(108, 1, 'Fairing', 'Quinu', 'Rodeo Sport', 103.59, 54),
(109, 1, 'Seat', 'Brightdog', '911', 6592.25, 5),
(110, 1, 'Frame', 'Lazzy', '300', 2863.12, 39),
(112, 1, 'Ignition system', 'Photobean', 'Pilot', 4287.83, 47),
(114, 1, 'Fuel tank', 'Jetwire', '9000', 7047.53, 97),
(115, 1, 'suspension', 'Omba', 'Storm', 4908.25, 15),
(116, 1, 'Handlebars', 'Photobug', 'LS', 1036.96, 91),
(117, 1, 'Ignition system', 'Pixonyx', 'Escort', 610.31, 99),
(118, 1, 'Battery', 'Zoombeat', 'A4', 4742.9, 5),
(120, 1, 'Tires', 'Lazz', 'Elise', 9685.66, 81),
(122, 1, 'Frame', 'Jazzy', 'Odyssey', 1121.32, 30),
(124, 1, 'Seat', 'Kamba', 'SC', 8063.36, 30),
(125, 1, 'Sprockets', 'Skyba', '9-3', 3348.11, 85),
(126, 1, 'Fairing', 'Mymm', 'Mazda5', 945.4, 35),
(127, 1, 'engine', 'DabZ', 'Voyager', 3659.04, 53),
(128, 1, 'Ignition system', 'Twitterworks', 'Pajero', 6759.84, 3),
(129, 1, 'Handlebars', 'Topicshots', 'Solara', 8008.84, 24),
(130, 1, 'Fairing', 'Tagcat', 'Navigator L', 86.98, 31),
(131, 1, 'Fuel tank', 'Twitterwire', 'IS F', 9959.99, 35),
(133, 1, 'Lights', 'Twitterbridge', 'Sportvan G30', 9655.21, 75),
(134, 1, 'Frame', 'Quinu', 'V70', 3618.68, 82),
(135, 1, 'Wheels', 'Demivee', 'Sierra 2500', 1915.95, 83),
(137, 1, 'brakes', 'Jazzy', 'Freestar', 3464.98, 32),
(138, 1, 'Battery', 'Rhyzio', '928', 9731.72, 15),
(139, 1, 'Seat', 'Tagchat', 'Highlander', 8985.76, 77),
(140, 1, 'Ignition system', 'Gigaclub', 'LS', 9076.6, 30),
(143, 1, 'Sprockets', 'Riffpedia', 'Endeavor', 6410.96, 76),
(144, 1, 'Sprockets', 'Voonyx', 'Mazdaspeed6', 5712.18, 50),
(145, 1, 'suspension', 'Voonyx', 'MX-5', 1436.4, 18),
(147, 1, 'Chain', 'Fivespan', 'Lumina', 7085.34, 88),
(149, 1, 'Mirrors', 'Zoombeat', 'GTO', 975.69, 8),
(151, 1, 'Chain', 'Yodoo', 'Mark LT', 1979.29, 44),
(152, 1, 'Tires', 'Kaymbo', 'LeMans', 6068.49, 25),
(153, 1, 'Chain', 'Dabjam', 'LX', 900.81, 17),
(154, 1, 'Transmission', 'Yambee', 'Tiburon', 6258.53, 75),
(155, 1, 'Handlebars', 'Skinte', 'Focus', 6054.22, 0),
(156, 1, 'Battery', 'Yoveo', 'E-Class', 1353.17, 67),
(157, 1, 'Battery', 'Jabbercube', 'Frontier', 4472.5, 2),
(158, 1, 'Sprockets', 'Edgetag', 'CLK-Class', 2730.46, 19),
(160, 1, 'Ignition system', 'Yakijo', 'Wrangler', 6176.33, 99),
(161, 1, 'Wheels', 'Pixope', 'Z4', 5334.52, 0),
(162, 1, 'engine', 'Youspan', 'Solara', 5211.62, 32),
(163, 1, 'brakes', 'Tambee', 'Solstice', 5790.46, 57),
(164, 1, 'Ignition system', 'Bubbletube', 'Explorer Sport Trac', 5187.09, 82),
(165, 1, 'exhaust', 'Photobug', 'Relay', 5299.69, 30),
(167, 1, 'Lights', 'Oloo', 'F150', 1759.41, 59),
(168, 1, 'Transmission', 'Kwideo', 'Countach', 9483.81, 55),
(169, 1, 'Tires', 'Geba', 'Windstar', 8657.97, 83),
(172, 1, 'Fairing', 'Dabvine', 'Accord', 9206.94, 38),
(173, 1, 'Transmission', 'Eazzy', 'Mountaineer', 8625.78, 23),
(176, 1, 'suspension', 'Skinte', 'Esprit', 8712.32, 40),
(177, 1, 'exhaust', 'Aibox', 'Sierra 2500', 6601.89, 80),
(179, 1, 'engine', 'Topicware', 'Aveo', 5057.34, 17),
(180, 1, 'Tires', 'Plambee', 'A6', 3826, 94),
(181, 1, 'suspension', 'Leexo', 'Forenza', 2180.43, 38),
(182, 1, 'brakes', 'Yodo', 'Bronco', 4715.39, 74),
(185, 1, 'Tires', 'Topdrive', 'xB', 7672.23, 30),
(187, 1, 'suspension', 'Viva', 'Bonneville', 9194.8, 8),
(188, 1, 'brakes', 'Thoughtsphere', '928', 5833.26, 9),
(190, 1, 'Handlebars', 'Geba', '4Runner', 9503.9, 10),
(191, 1, 'Chain', 'Gigabox', 'CLK-Class', 2704.91, 72),
(193, 1, 'Cooling system', 'Wordware', 'Xterra', 1655.97, 69),
(194, 1, 'suspension', 'Gevee', 'Riviera', 5048.1, 59),
(195, 1, 'Mirrors', 'Shuffledrive', 'Impala', 348.28, 35),
(196, 1, 'Cooling system', 'Divape', 'LHS', 9054.82, 82),
(197, 1, 'Seat', 'Flashspan', 'Cabriolet', 3960.91, 21),
(200, 1, 'Lights', 'Bubblemix', 'E-Series', 4237.6, 11),
(201, 1, 'Chain', 'Vimbo', 'Crossfire', 4123.58, 11),
(202, 1, 'Chain', 'Agimba', 'Lucerne', 7867.73, 97),
(203, 1, 'Cooling system', 'Meejo', 'Express 3500', 4199.94, 25),
(204, 1, 'Fuel tank', 'Youfeed', 'Corrado', 2879.74, 59),
(206, 1, 'Mirrors', 'Bubblemix', '626', 453.79, 75),
(207, 1, 'Fairing', 'Riffwire', 'Escort', 5574.6, 72),
(208, 1, 'Transmission', 'Bubbletube', 'LeSabre', 4919.18, 79),
(209, 1, 'Cooling system', 'Photobean', '57S', 2890.63, 34),
(210, 1, 'Handlebars', 'Bubbletube', 'Escort', 451.36, 13),
(211, 1, 'Chain', 'Pixonyx', 'XG350', 6069.73, 91),
(212, 1, 'Battery', 'Mynte', 'Crown Victoria', 189.28, 72),
(213, 1, 'Seat', 'Voonix', 'Charger', 2077.47, 50),
(214, 1, 'Sprockets', 'Jazzy', 'B2600', 9355.72, 34),
(215, 1, 'Transmission', 'Youspan', '323', 536.92, 33),
(217, 1, 'Cooling system', 'Trudoo', 'Prius', 2453.68, 23),
(219, 1, 'Ignition system', 'Trudeo', 'Malibu', 1489.72, 18),
(222, 1, 'Wheels', 'Kwimbee', 'V70', 9131, 9),
(223, 1, 'Ignition system', 'Kwinu', 'Savana 2500', 4337.13, 26),
(224, 1, 'body', 'Tambee', 'XC70', 5124.84, 95),
(227, 1, 'Cooling system', 'Janyx', 'Fifth Ave', 9185.46, 23),
(228, 1, 'Fairing', 'Vipe', 'Suburban 1500', 9722.31, 73),
(229, 1, 'Seat', 'Youtags', 'F-Series Super Duty', 1245.07, 3),
(231, 1, 'Fuel tank', 'Centizu', 'Xterra', 8254.83, 0),
(232, 1, 'Mirrors', 'Rhynyx', 'Town Car', 9008.46, 58),
(233, 1, 'Battery', 'Kwilith', 'Fusion', 3455.3, 45),
(234, 1, 'Seat', 'Zava', 'Quest', 8615.84, 62),
(235, 1, 'suspension', 'Jabbercube', 'Spirit', 4155.83, 66),
(237, 1, 'engine', 'Zoomdog', '2500', 1407.09, 16),
(238, 1, 'Cooling system', 'Edgeify', 'F450', 8168.54, 38),
(239, 1, 'Sprockets', 'Eidel', 'V70', 7804.86, 41),
(240, 1, 'Lights', 'Vipe', 'SC', 153.58, 83),
(241, 1, 'engine', 'Yata', 'S6', 5699.3, 87),
(242, 1, 'Fairing', 'Mybuzz', 'Reno', 2637.14, 73),
(243, 1, 'Chain', 'Camimbo', 'Diablo', 5583.71, 41),
(244, 1, 'Mirrors', 'Rhyzio', 'GTI', 1496.38, 24),
(245, 1, 'Lights', 'Blogspan', 'xA', 8797.72, 97),
(248, 1, 'Cooling system', 'Brainbox', 'Daytona', 3620.25, 35),
(251, 1, 'Frame', 'Jabbersphere', '7 Series', 6605.84, 5),
(252, 1, 'suspension', 'Jabbersphere', 'Astro', 6249.09, 31),
(253, 1, 'Tires', 'Jaxspan', 'Grand Prix', 7506.22, 91),
(256, 1, 'Ignition system', 'Browsetype', 'Passat', 9906.69, 89),
(257, 1, 'suspension', 'Avaveo', 'Cabriolet', 4817.92, 75),
(259, 1, 'Lights', 'Flashpoint', 'DBS', 2999.57, 34),
(260, 1, 'Transmission', 'Skynoodle', 'V8 Vantage', 6392.54, 66),
(262, 1, 'Frame', 'Janyx', 'Suburban 1500', 6486.08, 19),
(263, 1, 'Cooling system', 'Meeveo', 'Yukon XL 2500', 4289.53, 78),
(266, 1, 'Cooling system', 'Skilith', 'Escape', 9321.91, 6),
(267, 1, 'Mirrors', 'Realmix', 'Miata MX-5', 4642.25, 74),
(269, 1, 'Tires', 'Gigazoom', 'Sedona', 2306.11, 39),
(270, 1, 'Lights', 'Midel', 'Sunbird', 5944.03, 19),
(271, 1, 'body', 'Zoonder', 'Gallardo', 9791.33, 49),
(272, 1, 'Ignition system', 'DabZ', 'Forester', 365.12, 66),
(275, 1, 'suspension', 'Reallinks', 'Aero 8', 8241.95, 78),
(276, 1, 'Sprockets', 'Buzzdog', 'Mustang', 2238.49, 39),
(277, 1, 'Lights', 'Voomm', 'Fusion', 1222.87, 45),
(279, 1, 'Transmission', 'Oyondu', 'A6', 4646.53, 20),
(281, 1, 'Wheels', 'Oyope', 'Exige', 9716.55, 72),
(283, 1, 'Cooling system', 'Skiptube', 'Frontier', 9788.8, 7),
(285, 1, 'brakes', 'Browsebug', 'CLK-Class', 4406.76, 71),
(286, 1, 'Fuel tank', 'Edgetag', 'del Sol', 6006.29, 18),
(287, 1, 'Lights', 'Rhyzio', 'Armada', 6086.8, 43),
(288, 1, 'Frame', 'Dabvine', 'Ram 1500 Club', 340.45, 15),
(290, 1, 'Fuel tank', 'Kazu', 'MPV', 7654.31, 97),
(292, 1, 'Sprockets', 'Brainsphere', 'Montero', 5642.58, 87),
(293, 1, 'Battery', 'Gigashots', 'MX-5', 8467.84, 5),
(294, 1, 'Handlebars', 'Innojam', 'Grand Am', 3222.59, 43),
(295, 1, 'exhaust', 'Blogtag', 'Ghost', 6870.48, 73),
(296, 1, 'exhaust', 'Shufflester', 'Spirit', 1202.87, 43),
(297, 1, 'Ignition system', 'Fatz', 'XC60', 2275.32, 78),
(298, 1, 'body', 'Chatterpoint', 'Camaro', 601.3, 33),
(299, 1, 'Fairing', 'Photobean', 'Silhouette', 7531.4, 55),
(301, 1, 'Fairing', 'Blogtags', 'Caravan', 9107.72, 17),
(302, 1, 'brakes', 'Topiclounge', 'X6', 4267.07, 36),
(303, 1, 'Sprockets', 'Dabjam', '98', 2793.8, 88),
(304, 1, 'Fairing', 'Wikibox', '9-5', 2235.58, 0),
(307, 1, 'body', 'Thoughtbeat', 'Corvette', 3827.04, 66),
(310, 1, 'Transmission', 'Edgeify', 'Tredia', 9281.18, 11),
(312, 1, 'suspension', 'Fivebridge', '3 Series', 4206.85, 19),
(313, 1, 'engine', 'Wikibox', 'Boxster', 4946.03, 36),
(314, 1, 'Transmission', 'Zoonoodle', 'Caravan', 5143.69, 98),
(315, 1, 'Fairing', 'Gevee', 'TSX', 548.67, 88),
(316, 1, 'Battery', 'Youspan', 'Milan', 3326.98, 34),
(317, 1, 'engine', 'Zoovu', 'Freestyle', 9276.98, 21),
(321, 1, 'Sprockets', 'Dabjam', 'Cooper', 239.83, 91),
(323, 1, 'Fairing', 'Devify', 'SJ', 9244.71, 72),
(325, 1, 'Mirrors', 'Browsetype', 'Avenger', 5615.29, 82),
(327, 1, 'Ignition system', 'Topicware', 'E350', 4727.55, 60),
(328, 1, 'body', 'Avamm', 'F-Series', 3618.25, 37),
(329, 1, 'Mirrors', 'Miboo', '7 Series', 6206.68, 35),
(330, 1, 'Ignition system', 'Cogilith', 'Avenger', 559.74, 99),
(331, 1, 'Mirrors', 'Kimia', 'Prius', 7893.61, 79),
(332, 1, 'Frame', 'Oozz', '944', 923.2, 63),
(333, 1, 'Cooling system', 'Mydo', 'Firebird', 2871.19, 47),
(334, 1, 'brakes', 'Quatz', 'Sequoia', 5566.19, 34),
(339, 1, 'Tires', 'Tanoodle', 'LeSabre', 4846.76, 71),
(340, 1, 'Tires', 'Tagcat', '3 Series', 86.41, 83),
(341, 1, 'exhaust', 'Wikibox', 'Trooper', 92.6, 95),
(342, 1, 'exhaust', 'Browsedrive', 'Focus', 2966.51, 36),
(343, 1, 'Battery', 'Zava', 'Mighty Max', 2308.89, 53),
(345, 1, 'body', 'Trupe', 'Challenger', 7981.74, 54),
(346, 1, 'suspension', 'Yamia', 'Diablo', 7678.6, 78),
(347, 1, 'Cooling system', 'Devpoint', 'Entourage', 8367.47, 77),
(348, 1, 'Cooling system', 'Skinder', 'Patriot', 7203.24, 6),
(349, 1, 'brakes', 'Realbuzz', 'Forester', 2090.71, 28),
(350, 1, 'Chain', 'Eire', 'Canyon', 3429.47, 77),
(351, 1, 'Seat', 'Realfire', 'Esprit', 8321.19, 91),
(352, 1, 'Mirrors', 'Browseblab', 'Summit', 800.67, 32),
(353, 1, 'exhaust', 'Voomm', '6 Series', 1068.73, 59),
(354, 1, 'Handlebars', 'Flipstorm', 'LR3', 5126.02, 44),
(355, 1, 'Seat', 'Topicblab', 'Terrain', 3508.98, 57),
(356, 1, 'suspension', 'Kazio', 'E-Class', 178.63, 96),
(357, 1, 'Fuel tank', 'Linkbridge', 'Town & Country', 8772.36, 51),
(358, 1, 'body', 'Yabox', 'Endeavor', 6454.55, 18),
(359, 1, 'brakes', 'Brainlounge', 'Breeze', 4171.52, 84),
(360, 1, 'exhaust', 'Edgeify', 'Corolla', 2227.78, 100),
(361, 1, 'Cooling system', 'Nlounge', 'Neon', 2439.37, 79),
(364, 1, 'Sprockets', 'Twiyo', 'Cooper Clubman', 9894.41, 75),
(365, 1, 'Seat', 'Meejo', 'Yukon', 2399.95, 39),
(366, 1, 'Tires', 'Feedmix', 'Park Avenue', 5083.29, 38),
(368, 1, 'Fairing', 'Snaptags', 'Viper', 9478.73, 75),
(369, 1, 'Battery', 'Browsecat', 'Riviera', 581.43, 88),
(370, 1, 'Fairing', 'Thoughtmix', 'Mazda6', 4541.06, 44),
(371, 1, 'Fairing', 'Mymm', 'Range Rover', 4179.64, 52),
(372, 1, 'engine', 'Skyvu', 'Bronco', 2620.5, 4),
(373, 1, 'Fairing', 'Gabvine', 'X5 M', 4386.46, 22),
(374, 1, 'Wheels', 'Edgeblab', 'Trooper', 7806.3, 100),
(375, 1, 'Wheels', 'Kwimbee', 'Expo', 2283.74, 56),
(377, 1, 'Fuel tank', 'Pixope', 'X5 M', 3867.22, 7),
(379, 1, 'Fuel tank', 'Fivebridge', 'Odyssey', 5200.02, 8),
(380, 1, 'Frame', 'Twitterlist', 'Rainier', 5841.43, 22),
(381, 1, 'Battery', 'Avamm', 'Canyon', 6916.93, 49),
(382, 1, 'Cooling system', 'Dynava', 'Regal', 3458.7, 39),
(384, 1, 'Sprockets', 'Tagcat', 'Seville', 803.05, 12),
(387, 1, 'Fairing', 'Teklist', 'Truck', 1861.39, 35),
(390, 1, 'Mirrors', 'Blogtag', 'Mirage', 7196.32, 24),
(391, 1, 'Mirrors', 'Buzzster', 'Freelander', 8779.98, 55),
(392, 1, 'body', 'Cogilith', 'F250', 1761.31, 79),
(393, 1, 'Sprockets', 'Realblab', 'Arnage', 2576.02, 33),
(395, 1, 'Transmission', 'Voonder', 'Metro', 3692.77, 9),
(396, 1, 'suspension', 'Mymm', 'Caliber', 6280.41, 92),
(397, 1, 'Frame', 'Cogilith', 'Achieva', 1385.89, 36),
(402, 1, 'Seat', 'Eadel', 'Civic', 6222.26, 10),
(403, 1, 'suspension', 'Podcat', 'Mazda3', 7041.01, 64),
(404, 1, 'Fairing', 'Abatz', 'Lumina APV', 7044.61, 87),
(405, 1, 'brakes', 'Quaxo', 'Impreza', 9963.99, 24),
(407, 1, 'Lights', 'Pixope', 'Sienna', 595.11, 47),
(408, 1, 'Wheels', 'Geba', 'LeSabre', 3820.44, 87),
(409, 1, 'Fairing', 'Miboo', 'Truck', 7471.26, 97),
(410, 1, 'Handlebars', 'Shuffletag', 'rio', 8975.17, 2),
(411, 1, 'exhaust', 'Wikido', 'Type 2', 9727.93, 4),
(414, 1, 'Handlebars', 'Dynazzy', 'Marquis', 8956.9, 15),
(415, 1, 'Seat', 'Zoomdog', 'Yukon XL 2500', 3148.47, 15),
(416, 1, 'Wheels', 'Feedbug', 'Bonneville', 3731.44, 91),
(417, 1, 'Handlebars', 'Twinte', 'LSS', 8053.2, 27),
(418, 1, 'Mirrors', 'Yodel', 'Escalade', 1499.67, 11),
(419, 1, 'exhaust', 'Tagchat', 'Impreza', 5488.72, 89),
(423, 1, 'Ignition system', 'Shuffletag', 'Suburban 1500', 2878, 66),
(427, 1, 'Transmission', 'Vipe', 'PT Cruiser', 7350.9, 0),
(428, 1, 'Sprockets', 'Dabvine', 'S10', 3894.95, 79),
(431, 1, 'brakes', 'Divape', 'DBS', 4025.19, 52),
(432, 1, 'Handlebars', 'Youfeed', 'Murciélago', 6604.17, 93),
(434, 1, 'Handlebars', 'Realfire', 'Corvette', 5604.04, 0),
(435, 1, 'Lights', 'Oyoba', 'Truck', 764.52, 95),
(441, 1, 'Fuel tank', 'Voomm', 'Corvette', 687.92, 73),
(443, 1, 'Chain', 'Yozio', 'Suburban 2500', 1294.74, 87),
(444, 1, 'Chain', 'Skinte', 'M', 8974.82, 29),
(445, 1, 'Lights', 'Eabox', 'F430 Spider', 8209.35, 63),
(448, 1, 'Cooling system', 'Browsetype', 'MX-5', 9809.74, 17),
(449, 1, 'Fairing', 'Tagfeed', 'M-Class', 2291.38, 64),
(450, 1, 'Handlebars', 'Blognation', '1500', 2292.01, 34),
(451, 1, 'Cooling system', 'Twitternation', 'TrailBlazer', 8433.06, 50),
(452, 1, 'Wheels', 'Skynoodle', 'Wrangler', 8644.3, 53),
(453, 1, 'suspension', 'Trupe', 'Elantra', 6412.92, 78),
(454, 1, 'Ignition system', 'Skippad', 'Brat', 1074.32, 61),
(455, 1, 'Handlebars', 'Voomm', 'Sephia', 6282.44, 94),
(456, 1, 'Fuel tank', 'Mycat', 'Yukon XL 1500', 9138.44, 20),
(458, 1, 'Wheels', 'Skinix', 'Ciera', 7555.89, 92),
(459, 1, 'Tires', 'Devshare', 'Trans Sport', 622.64, 84),
(461, 1, 'body', 'Photobug', 'Mustang', 6845.63, 43),
(463, 1, 'Transmission', 'Digitube', 'S10', 1516.61, 72),
(464, 1, 'body', 'Thoughtmix', 'Firebird', 6711.09, 100),
(468, 1, 'Lights', 'Nlounge', 'Ram 1500', 2812.39, 74),
(469, 1, 'Battery', 'Photojam', 'S6', 1421.92, 85),
(471, 1, 'suspension', 'Yoveo', 'Catera', 6401.51, 98),
(472, 1, 'Sprockets', 'Photospace', 'Reno', 9450.08, 46),
(473, 1, 'Transmission', 'Photobug', 'Acadia', 9726.11, 54),
(478, 1, 'Lights', 'Twitterbeat', '600SEL', 7640.96, 64),
(479, 1, 'brakes', 'Fivechat', 'Jetta', 9231.58, 7),
(481, 1, 'Fuel tank', 'Rhynyx', 'Loyale', 2217.79, 58),
(482, 1, 'Frame', 'Zoombeat', 'Premier', 2118.55, 35),
(483, 1, 'Seat', 'Skimia', 'Ram Van B350', 697.02, 22),
(484, 1, 'Battery', 'Gigazoom', 'Corolla', 6508.55, 34),
(485, 1, 'Mirrors', 'Quatz', 'Sebring', 6439.3, 40),
(490, 1, 'Frame', 'Dabshots', 'CR-V', 9943.67, 86),
(491, 1, 'Wheels', 'Skimia', 'F150', 1687.05, 89),
(493, 1, 'exhaust', 'Mynte', 'Seville', 5280.34, 64),
(494, 1, 'Transmission', 'Skinder', 'LeBaron', 1139, 37),
(495, 1, 'Fuel tank', 'Thoughtstorm', 'Express 3500', 8694.34, 15),
(499, 1, 'exhaust', 'Fatz', 'Malibu', 7795.33, 54),
(501, 1, 'Fuel tank', 'Avavee', 'S-Series', 3362.25, 70),
(502, 1, 'brakes', 'Topicshots', 'S60', 342.1, 55),
(503, 1, 'Frame', 'Voonix', '2500 Club Coupe', 8535.68, 11),
(504, 1, 'suspension', 'Gabtype', 'Safari', 7523.23, 38),
(505, 1, 'Wheels', 'Realfire', 'Mazdaspeed 3', 4805.51, 83),
(506, 1, 'Handlebars', 'Topicware', 'Accord', 4524.27, 21),
(508, 1, 'Frame', 'Yakijo', 'Hombre', 6576.79, 34),
(509, 1, 'Handlebars', 'Zoozzy', 'Tracker', 6068.17, 24),
(510, 1, 'Mirrors', 'Meetz', 'Mirage', 6647.54, 63),
(511, 1, 'Seat', 'Photofeed', 'Exige', 3335.61, 29),
(512, 1, 'Fairing', 'Blogtags', 'Challenger', 9251.58, 17),
(513, 1, 'brakes', 'Oyoyo', '4Runner', 2649.76, 81),
(514, 1, 'Seat', 'Eadel', 'Loyale', 6809.86, 25),
(515, 1, 'body', 'Wikizz', 'E-Series', 5223.8, 66),
(518, 1, 'Transmission', 'Jetpulse', 'Escalade ESV', 1080.46, 82),
(519, 1, 'body', 'Yombu', 'Elantra', 6700.34, 70),
(521, 1, 'body', 'Dabshots', 'Sentra', 8161.95, 21),
(524, 1, 'Fairing', 'Jaxworks', 'Aerio', 2648.64, 56),
(529, 1, 'Seat', 'Quire', 'Maxima', 5623.2, 32),
(530, 1, 'engine', 'Zooxo', 'Range Rover', 8357.27, 93),
(537, 1, 'Seat', 'Eimbee', 'Pacifica', 6151.45, 99),
(538, 1, 'Seat', 'Babbleblab', 'Corvette', 187.53, 50),
(539, 1, 'exhaust', 'Thoughtstorm', 'CL', 6080.02, 99),
(540, 1, 'Transmission', 'Muxo', 'Type-1h', 8340.85, 77),
(541, 1, 'Frame', 'Katz', '928', 3889.74, 95),
(543, 1, 'Tires', 'Youfeed', 'Thunderbird', 3687.58, 86),
(544, 1, 'Ignition system', 'Zooxo', '7 Series', 4714.21, 67),
(548, 1, 'Cooling system', 'Shufflebeat', 'Thunderbird', 1713.28, 6),
(549, 1, 'exhaust', 'Bubbletube', 'Econoline E350', 1216.02, 51),
(550, 1, 'Battery', 'Janyx', '300ZX', 3896.51, 85),
(552, 1, 'Wheels', 'Rhyzio', 'Pilot', 5015.11, 55),
(554, 1, 'Wheels', 'Topiczoom', 'New Beetle', 9328.02, 58),
(556, 1, 'Mirrors', 'Gigabox', 'Flex', 7834.2, 77),
(557, 1, 'body', 'Yadel', 'E-Class', 8251.23, 51),
(558, 1, 'Battery', 'Thoughtstorm', 'Tacoma', 1618.56, 21),
(561, 1, 'Ignition system', 'Flipopia', 'Range Rover', 2422.78, 11),
(562, 1, 'Wheels', 'Thoughtblab', 'GTO', 243.86, 39),
(563, 1, 'Handlebars', 'Voonder', 'Eclipse', 8705.87, 75),
(564, 1, 'Cooling system', 'Cogidoo', 'Monterey', 9252.06, 58),
(565, 1, 'Frame', 'Skimia', 'Cordia', 4978.05, 30),
(566, 1, 'Fairing', 'Zoomcast', 'Suburban 1500', 7777.32, 50),
(568, 1, 'Transmission', 'Viva', 'Z4', 1704.95, 95),
(569, 1, 'Tires', 'Kanoodle', 'Continental', 7441.46, 51),
(570, 1, 'Chain', 'Aivee', 'Solara', 292.23, 78),
(571, 1, 'Fairing', 'Kwimbee', 'M-Class', 4199.94, 70),
(572, 1, 'Chain', 'Yakidoo', 'Sentra', 3934.15, 75),
(573, 1, 'Seat', 'Bubblebox', 'Aerostar', 3933.8, 74),
(574, 1, 'Fuel tank', 'Skynoodle', 'G-Series G20', 3724.12, 59),
(576, 1, 'suspension', 'Flashspan', 'Colt Vista', 9408.11, 54),
(578, 1, 'brakes', 'Brightbean', 'Suburban 1500', 2770.64, 8),
(579, 1, 'Fairing', 'Flipopia', 'Phantom', 3843.76, 24),
(581, 1, 'brakes', 'Yakidoo', 'Sunbird', 2515.98, 63),
(583, 1, 'suspension', 'Browsecat', 'Gallardo', 2951.84, 3),
(585, 1, 'Wheels', 'Ozu', 'Z4 M', 2552.15, 60),
(587, 1, 'Lights', 'Realbridge', 'Mirage', 5231.13, 25),
(588, 1, 'Chain', 'Quinu', '500SEL', 7602.09, 60),
(590, 1, 'Chain', 'Edgepulse', 'LeBaron', 8161.45, 74),
(591, 1, 'Seat', 'Avamm', 'Boxster', 9167.24, 13),
(593, 1, 'Wheels', 'Skyba', '9-2X', 4950.22, 64),
(594, 1, 'Lights', 'Quimm', 'LaCrosse', 189.93, 14),
(595, 1, 'Ignition system', 'Rhybox', 'A3', 9654.2, 94),
(596, 1, 'Battery', 'Skyba', 'Explorer', 5234.5, 72),
(597, 1, 'body', 'Yadel', 'Venture', 6327.81, 14),
(598, 1, 'engine', 'Skippad', 'Sentra', 8253.17, 35),
(601, 1, 'Ignition system', 'Twimbo', 'LHS', 851.36, 57),
(603, 1, 'Mirrors', 'Jabbercube', 'Expedition EL', 844.86, 57),
(604, 1, 'Wheels', 'Devpoint', 'XC70', 917.61, 16),
(605, 1, 'Ignition system', 'Einti', 'DeVille', 9437.74, 88),
(608, 1, 'engine', 'Jaxspan', 'Range Rover Evoque', 9032.74, 53),
(610, 1, 'Sprockets', 'Npath', 'Continental GTC', 3769.07, 57),
(611, 1, 'Ignition system', 'Babblestorm', 'Camry', 4969.57, 4),
(614, 1, 'Fuel tank', 'Skinte', 'Miata MX-5', 6219.07, 44),
(617, 1, 'Ignition system', 'Buzzbean', 'MX-6', 5208.96, 82),
(618, 1, 'Seat', 'Kimia', 'Ram Van 3500', 4127.75, 18),
(619, 1, 'exhaust', 'Brainsphere', 'RL', 1249.61, 70),
(624, 1, 'Sprockets', 'Npath', 'Impreza', 6755.21, 88),
(625, 1, 'engine', 'Leexo', 'Esteem', 7257.71, 34),
(626, 1, 'Battery', 'Skyba', 'Chariot', 5739.75, 56),
(627, 1, 'Cooling system', 'Wikivu', 'Precis', 8176.15, 58),
(628, 1, 'Handlebars', 'Fadeo', 'Blazer', 660.46, 37),
(630, 1, 'brakes', 'Twinder', 'Rogue', 7498.16, 49),
(631, 1, 'Wheels', 'Twitterbridge', 'Corsica', 2293.91, 63),
(633, 1, 'Mirrors', 'Tanoodle', 'Econoline E350', 6266.68, 18),
(634, 1, 'Lights', 'Meembee', '626', 3760.77, 61),
(635, 1, 'Mirrors', 'Divanoodle', 'Avalon', 7200.27, 4),
(636, 1, 'Seat', 'Fliptune', 'Touareg', 3699.02, 57),
(637, 1, 'Lights', 'Zooxo', 'Coupe Quattro', 7356.91, 62),
(638, 1, 'Mirrors', 'Yadel', 'Mustang', 6198.19, 42),
(640, 1, 'brakes', 'Yakidoo', 'Grand Prix', 5536.01, 74),
(641, 1, 'Ignition system', 'Dabjam', 'SLK-Class', 7234.91, 90),
(642, 1, 'Ignition system', 'Photojam', 'Dakota', 3166.11, 20),
(644, 1, 'Handlebars', 'Rhybox', 'Quest', 2453.18, 96),
(645, 1, 'Fairing', 'Shufflester', 'Golf', 9760.72, 8),
(646, 1, 'Ignition system', 'Yombu', 'Ranger', 6972.74, 45),
(647, 1, 'suspension', 'Feedspan', 'XJ', 8258.18, 76),
(648, 1, 'exhaust', 'Voolith', 'Savana 2500', 3142.76, 60),
(649, 1, 'Lights', 'Wikizz', 'CLK-Class', 335.12, 51),
(650, 1, 'Transmission', 'Photobug', 'Rodeo Sport', 7819.24, 78),
(651, 1, 'Ignition system', 'Meedoo', 'Golf', 5596.21, 11),
(652, 1, 'Wheels', 'Voonder', 'Thunderbird', 361.6, 8),
(654, 1, 'Battery', 'Rhyloo', 'Econoline E350', 563.39, 81),
(655, 1, 'Lights', 'Youopia', '626', 6233.3, 56),
(656, 1, 'Tires', 'Zoomdog', 'i-370', 9785.69, 64),
(658, 1, 'Transmission', 'Eayo', 'Thunderbird', 1852.44, 90),
(659, 1, 'exhaust', 'Avaveo', 'XT', 2144.64, 86),
(662, 1, 'Lights', 'Zoonoodle', 'CR-V', 7533.9, 3),
(663, 1, 'Fairing', 'Yakidoo', 'XK Series', 6216.2, 31),
(666, 1, 'exhaust', 'Jabbersphere', 'XLR', 3081.12, 56),
(667, 1, 'Seat', 'Quatz', 'Caravan', 9034.73, 54),
(669, 1, 'engine', 'Divape', 'MKZ', 4159.27, 74),
(672, 1, 'Handlebars', 'Dabjam', 'Envoy XL', 3064.76, 51),
(673, 1, 'Battery', 'Geba', 'Altima', 4855.54, 29),
(674, 1, 'Handlebars', 'Dazzlesphere', 'Sportvan G30', 557.22, 84),
(676, 1, 'exhaust', 'Dazzlesphere', 'X-90', 3237.56, 39),
(677, 1, 'suspension', 'Kimia', 'Xtra', 2328.04, 10),
(678, 1, 'brakes', 'Gabtype', 'Sierra 3500', 57.27, 51),
(679, 1, 'exhaust', 'Eidel', 'XLR', 5625.78, 73),
(680, 1, 'Mirrors', 'Trunyx', 'Ram Van B350', 4373.03, 38),
(681, 1, 'Fairing', 'Shufflester', 'Tracker', 4056.83, 65),
(682, 1, 'Ignition system', 'Centidel', 'Esprit', 687, 23),
(684, 1, 'exhaust', 'Browsetype', 'Continental Super', 9832.97, 96),
(685, 1, 'Lights', 'Camimbo', 'Explorer', 1645.64, 11),
(686, 1, 'exhaust', 'Jazzy', 'tC', 1967, 52),
(687, 1, 'Handlebars', 'Dabshots', 'Corolla', 3316.85, 0),
(688, 1, 'Seat', 'Leenti', 'Acadia', 6409.02, 13),
(689, 1, 'engine', 'Jabbercube', 'X6', 8710.28, 77),
(691, 1, 'Tires', 'Dablist', 'Land Cruiser', 6898.27, 27),
(692, 1, 'Handlebars', 'Trilia', 'MKX', 1143.34, 90),
(694, 1, 'Seat', 'Gabtype', 'Freelander', 5179.31, 45),
(696, 1, 'Ignition system', 'Fivebridge', 'R-Class', 2406.2, 11),
(697, 1, 'brakes', 'Yadel', 'M5', 8864.55, 92),
(698, 1, 'body', 'Topicblab', 'Caravan', 1490.41, 88),
(700, 1, 'Fuel tank', 'Livepath', 'Cobalt', 6465.88, 52),
(702, 1, 'exhaust', 'Aivee', '90', 8437.25, 23),
(706, 1, 'Frame', 'Buzzdog', 'Lucerne', 7293.73, 44),
(710, 1, 'Chain', 'DabZ', 'New Yorker', 7253.15, 10),
(712, 1, 'body', 'Twitterworks', 'S40', 2678.41, 39),
(714, 1, 'Chain', 'Fliptune', 'Corvette', 8743.37, 51),
(715, 1, 'engine', 'Devify', 'Focus', 63.56, 86),
(716, 1, 'Battery', 'Aibox', 'Crown Victoria', 9594.57, 42),
(717, 1, 'Battery', 'Wikibox', 'Ram', 1170.78, 41),
(718, 1, 'Sprockets', 'Yozio', 'Camaro', 6146.72, 4),
(720, 1, 'Fairing', 'Viva', 'Cutlass Cruiser', 3934.37, 68),
(721, 1, 'Chain', 'Youspan', 'E-Class', 234.16, 46),
(722, 1, 'Wheels', 'Rhybox', 'Excel', 2039.29, 12),
(725, 1, 'Wheels', 'Twitterworks', 'Terraza', 9092.41, 30),
(726, 1, 'engine', 'Photospace', 'XK Series', 6953.58, 61),
(728, 1, 'Mirrors', 'Kazio', 'Z3', 8814.21, 98),
(729, 1, 'Frame', 'Riffpath', '9000', 8972.58, 71),
(730, 1, 'Chain', 'Devpulse', 'Nubira', 2618.97, 92),
(732, 1, 'Transmission', 'Topicware', 'E250', 6515.89, 100),
(733, 1, 'Fairing', 'Yakidoo', 'Integra', 5978.23, 69),
(735, 1, 'exhaust', 'Bubblebox', 'Quest', 3198.95, 69),
(736, 1, 'Sprockets', 'Oyondu', 'Sunbird', 4410.03, 72),
(737, 1, 'Handlebars', 'Cogidoo', 'Land Cruiser', 9695.26, 75),
(738, 1, 'Transmission', 'Thoughtbeat', 'Q', 6592.47, 86),
(739, 1, 'Wheels', 'Omba', 'Tacoma', 1666.35, 7),
(740, 1, 'Mirrors', 'Yambee', 'Outlander', 339.53, 67),
(741, 1, 'Ignition system', 'Yakijo', 'Optima', 3665.88, 62),
(744, 1, 'Fairing', 'Babblestorm', 'Legacy', 3653.05, 79),
(745, 1, 'Transmission', 'Ainyx', 'Century', 9284.98, 30),
(746, 1, 'suspension', 'Edgewire', 'Tiburon', 817.81, 16),
(748, 1, 'Lights', 'Tazzy', 'Grand Cherokee', 2298.95, 21),
(750, 1, 'Sprockets', 'Brightdog', 'Avalon', 4240.96, 48),
(751, 1, 'Mirrors', 'Edgeblab', 'Sunbird', 7205.93, 34),
(752, 1, 'Fairing', 'Innotype', 'RL', 4353.68, 91),
(753, 1, 'Transmission', 'Camido', 'V90', 5188.08, 25),
(754, 1, 'Seat', 'Npath', 'G', 9323.21, 7),
(755, 1, 'Wheels', 'Wordify', 'Club Wagon', 4809.25, 38),
(757, 1, 'Frame', 'Photobean', 'Grand Cherokee', 4013.54, 99),
(760, 1, 'Fuel tank', 'Cogilith', 'Durango', 1984.32, 96),
(761, 1, 'Transmission', 'Wordware', 'Mustang', 4451.83, 78),
(763, 1, 'exhaust', 'Zoombox', 'Grand Am', 2818.98, 78),
(764, 1, 'Seat', 'Skibox', 'RL', 4117.07, 47),
(765, 1, 'Handlebars', 'Pixope', 'Passat', 8246.54, 45),
(766, 1, 'Lights', 'Topicstorm', 'Fleetwood', 8436.9, 24),
(767, 1, 'Fairing', 'Meemm', '1500', 4318.12, 49),
(768, 1, 'Chain', 'Nlounge', 'Yukon', 5982.15, 17),
(769, 1, 'Transmission', 'Ntag', 'Armada', 8973.81, 99),
(770, 1, 'Wheels', 'Demizz', 'GX', 8815.68, 33),
(772, 1, 'exhaust', 'Zoomdog', 'Cirrus', 4573.8, 91),
(773, 1, 'body', 'Thoughtstorm', 'C30', 3374.46, 63),
(775, 1, 'body', 'Jazzy', 'Altima', 4818.91, 38),
(778, 1, 'Wheels', 'Flashspan', 'E-350 Super Duty', 827.3, 60),
(781, 1, 'Wheels', 'Kazu', 'X6 M', 4733.67, 0),
(782, 1, 'Chain', 'Camimbo', 'Range Rover', 9633.68, 54),
(784, 1, 'Tires', 'Avamm', 'Crown Victoria', 3263.43, 20),
(788, 1, 'Battery', 'Topiczoom', '6000', 2341.04, 1),
(790, 1, 'Fairing', 'Topicblab', 'A6', 89.58, 73),
(799, 1, 'Sprockets', 'Photojam', 'G37', 5438.71, 18),
(801, 1, 'Sprockets', 'Realpoint', 'R-Class', 626.3, 89),
(807, 1, 'Seat', 'Voonte', 'Sprinter', 5146.9, 72),
(809, 1, 'Ignition system', 'Innojam', 'Charger', 4471.11, 61),
(811, 1, 'Mirrors', 'Brainlounge', 'M3', 4618.14, 34),
(812, 1, 'body', 'Livetube', 'LeSabre', 2665.09, 36),
(813, 1, 'Sprockets', 'Meezzy', 'F-Series', 6478.64, 57),
(815, 1, 'suspension', 'Rooxo', 'X6 M', 7818.95, 9),
(819, 1, 'Wheels', 'Skyba', 'Continental', 902.77, 43),
(823, 1, 'body', 'Flipopia', 'Forester', 9106.57, 8),
(829, 1, 'Fairing', 'Twiyo', 'Viper', 5081.67, 17),
(831, 1, 'Cooling system', 'Abata', 'Pathfinder Armada', 9936.6, 85),
(835, 1, 'engine', 'Skimia', 'Diamante', 6822.25, 72),
(837, 1, 'Cooling system', 'Skilith', 'CL-Class', 6408.37, 15),
(843, 1, 'Sprockets', 'Jetwire', 'Mustang', 3857.1, 35),
(844, 1, 'Lights', 'Aimbo', 'Lynx', 9443.14, 61),
(845, 1, 'Tires', 'Tavu', 'Malibu', 8376.51, 47),
(851, 1, 'Ignition system', 'Skinder', 'Golf', 5477.21, 91),
(852, 1, 'Transmission', 'Brainlounge', 'Yukon XL 1500', 1259.98, 39),
(856, 1, 'exhaust', 'Layo', 'A8', 9595.18, 13),
(858, 1, 'Mirrors', 'Brainsphere', 'Eclipse', 1818.58, 53),
(859, 1, 'Mirrors', 'Ntag', 'Courier', 9185.36, 93),
(861, 1, 'brakes', 'Devshare', 'Aurora', 6266.69, 55),
(862, 1, 'brakes', 'Reallinks', 'Crown Victoria', 7814.12, 1),
(863, 1, 'Lights', 'Tekfly', 'Dakota', 9455.23, 27),
(867, 1, 'body', 'Realfire', 'Grand Cherokee', 1706.7, 49),
(868, 1, 'Chain', 'Centizu', 'Tracker', 9262.19, 27),
(869, 1, 'Lights', 'Skajo', 'Tiburon', 5090.59, 49),
(873, 1, 'Mirrors', 'Kazio', 'Ram 1500', 5438.66, 43),
(874, 1, 'Frame', 'Feedfire', 'Regal', 4733.93, 13),
(875, 1, 'Fuel tank', 'Trudoo', 'Crown Victoria', 8726.22, 31),
(886, 1, 'body', 'Gabvine', 'Prizm', 1641.17, 41),
(887, 1, 'engine', 'Photobug', 'Range Rover', 6696.47, 70),
(888, 1, 'Cooling system', 'Yozio', 'GTI', 8359.07, 52),
(890, 1, 'Wheels', 'Photofeed', '612 Scaglietti', 5179.09, 77),
(892, 1, 'Tires', 'Fiveclub', 'Cabriolet', 1067.19, 25),
(894, 1, 'Ignition system', 'Lazzy', 'Nitro', 1204.65, 80),
(897, 1, 'Battery', 'Feedbug', 'A4', 7001.95, 64),
(899, 1, 'Ignition system', 'Yodoo', 'Gallardo', 3367.66, 15),
(907, 1, 'Sprockets', 'Miboo', 'Escort', 2599.94, 14),
(908, 1, 'Fairing', 'Tambee', 'Matrix', 2915.35, 25),
(909, 1, 'brakes', 'Midel', 'B-Series', 5204.72, 91),
(910, 1, 'suspension', 'Edgeblab', 'DBS', 3647.54, 67),
(911, 1, 'Wheels', 'Photofeed', 'Pathfinder', 4570.54, 9),
(912, 1, 'exhaust', 'Livetube', 'S10', 954.84, 67),
(914, 1, 'body', 'Skipstorm', 'Grand Voyager', 3567.49, 23),
(920, 1, 'Frame', 'Topicshots', 'ES', 5192.05, 49),
(921, 1, 'Cooling system', 'Tagfeed', 'V70', 4617.96, 94),
(922, 1, 'Ignition system', 'Mynte', 'Golf', 9174.46, 36),
(923, 1, 'Frame', 'Blogpad', 'Taurus', 5098.67, 1),
(925, 1, 'Transmission', 'Yodoo', 'MX-5', 6919.43, 37),
(929, 1, 'brakes', 'Skyvu', 'Explorer Sport', 2616.87, 58),
(930, 1, 'Handlebars', 'Skipstorm', 'Avalanche 2500', 7513.66, 48),
(935, 1, 'Handlebars', 'Camido', 'Prelude', 8946.1, 49),
(939, 1, 'Handlebars', 'Buzzster', 'Windstar', 944.85, 50),
(948, 1, 'Chain', 'Kaymbo', 'Suburban 1500', 998.66, 85),
(953, 1, 'body', 'Skyvu', 'Envoy', 1869.38, 66),
(954, 1, 'Transmission', 'Wordtune', 'SLK-Class', 4712.41, 31),
(956, 1, 'Fuel tank', 'Dynabox', 'Avenger', 5749.93, 42),
(957, 1, 'Lights', 'Flipstorm', 'E350', 5897.18, 8),
(958, 1, 'Frame', 'Zooxo', 'E-Class', 6490.24, 31),
(962, 1, 'engine', 'Meeveo', 'Quest', 9115.14, 56),
(963, 1, 'Battery', 'Oyoloo', 'Corolla', 1405.97, 16),
(966, 1, 'engine', 'Jazzy', 'Mustang', 1508.35, 37),
(967, 1, 'Fairing', 'Twitterbridge', 'Grand Caravan', 3170.67, 12),
(972, 1, 'brakes', 'Npath', 'Murano', 8440.96, 44),
(974, 1, 'Frame', 'Topiclounge', 'Camaro', 6997.7, 18),
(975, 1, 'Ignition system', 'Skivee', 'Ram 3500', 9393.02, 16),
(982, 1, 'Fuel tank', 'Rhycero', 'Expedition EL', 3274.75, 33),
(991, 1, 'Sprockets', 'Dazzlesphere', 'STS-V', 4482.79, 31),
(995, 1, 'Lights', 'Miboo', 'Ram Van B250', 1399.23, 57);

-- --------------------------------------------------------

--
-- Table structure for table `repair_service`
--

CREATE TABLE `repair_service` (
  `Service_id` int(11) NOT NULL,
  `Invoice_reference` int(11) NOT NULL,
  `Repairman` varchar(255) NOT NULL,
  `Parts_purchased` varchar(3) NOT NULL,
  `Service_charge` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `Supplier_id` int(11) NOT NULL,
  `Supplier_name` varchar(255) NOT NULL,
  `Contact_person` varchar(255) NOT NULL,
  `Contact_number` varchar(11) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Supplier_id`, `Supplier_name`, `Contact_person`, `Contact_number`, `Email`, `Address`) VALUES
(1, 'RusstheGruss shop', 'John Russ', '09999999999', 'sampleemail@gmail.com', 'australia'),
(9, 'Bert Yu construction', 'jelo aguilar', '09397767933', 'foxburger1@gmial.com', 'somewhere near cathedral');

-- --------------------------------------------------------

--
-- Table structure for table `warranty`
--

CREATE TABLE `warranty` (
  `Warranty_id` int(11) NOT NULL,
  `Product` int(11) NOT NULL,
  `Date_purchased` date NOT NULL,
  `End_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `warranty`
--

INSERT INTO `warranty` (`Warranty_id`, `Product`, `Date_purchased`, `End_date`) VALUES
(1, 9, '2024-05-08', '2024-11-08'),
(2, 9, '2024-05-08', '2024-11-08');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`Invoice_id`),
  ADD KEY `invoice_FK_2` (`Warranty_number`);

--
-- Indexes for table `invoice_items`
--
ALTER TABLE `invoice_items`
  ADD KEY `FK_1` (`Product`),
  ADD KEY `FK_2` (`Invoice_ref`) USING BTREE;

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Product_id`),
  ADD KEY `product_FK_1` (`Supplier`);

--
-- Indexes for table `repair_service`
--
ALTER TABLE `repair_service`
  ADD PRIMARY KEY (`Service_id`),
  ADD KEY `repair_FK_1` (`Invoice_reference`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`Supplier_id`);

--
-- Indexes for table `warranty`
--
ALTER TABLE `warranty`
  ADD PRIMARY KEY (`Warranty_id`),
  ADD KEY `warranty_FK_1` (`Product`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
  MODIFY `Invoice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `Product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1001;

--
-- AUTO_INCREMENT for table `repair_service`
--
ALTER TABLE `repair_service`
  MODIFY `Service_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `Supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `warranty`
--
ALTER TABLE `warranty`
  MODIFY `Warranty_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `invoice`
--
ALTER TABLE `invoice`
  ADD CONSTRAINT `invoice_FK_2` FOREIGN KEY (`Warranty_number`) REFERENCES `warranty` (`Warranty_id`);

--
-- Constraints for table `invoice_items`
--
ALTER TABLE `invoice_items`
  ADD CONSTRAINT `FK_1` FOREIGN KEY (`Product`) REFERENCES `product` (`Product_id`),
  ADD CONSTRAINT `FK_2` FOREIGN KEY (`Invoice_ref`) REFERENCES `invoice` (`Invoice_id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_FK_1` FOREIGN KEY (`Supplier`) REFERENCES `supplier` (`Supplier_id`);

--
-- Constraints for table `repair_service`
--
ALTER TABLE `repair_service`
  ADD CONSTRAINT `repair_FK_1` FOREIGN KEY (`Invoice_reference`) REFERENCES `invoice` (`Invoice_id`);

--
-- Constraints for table `warranty`
--
ALTER TABLE `warranty`
  ADD CONSTRAINT `warranty_FK_1` FOREIGN KEY (`Product`) REFERENCES `product` (`Product_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
