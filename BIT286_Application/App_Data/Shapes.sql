
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


CREATE TABLE `shapes` (
  `edges` int(5) NOT NULL,
  `name` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


INSERT INTO `Shapes` (`edges`, `name`) VALUES


(3, 'Triangle'),
(4, 'Square'),
(5, 'Pentagon'),
(6, 'Hexagon'),
(8, 'Octagon');
