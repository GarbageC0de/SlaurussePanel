-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Сен 05 2020 г., 05:21
-- Версия сервера: 5.7.26
-- Версия PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `xxx`
--

-- --------------------------------------------------------

--
-- Структура таблицы `accounts`
--

DROP TABLE IF EXISTS `accounts`;
CREATE TABLE IF NOT EXISTS `accounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `parameters` varchar(255) NOT NULL DEFAULT '-x 0 -y 0 -window -w 640 -h 480 -novid',
  `shared_secret` varchar(255) DEFAULT NULL,
  `5x5` int(11) NOT NULL DEFAULT '0',
  `2x2` int(11) NOT NULL DEFAULT '0',
  `x` varchar(255) NOT NULL DEFAULT '0',
  `y` varchar(255) NOT NULL DEFAULT '0',
  `userid` varchar(255) DEFAULT NULL,
  `profile` varchar(255) DEFAULT NULL,
  `colors` varchar(255) NOT NULL DEFAULT '2',
  `hello` int(1) NOT NULL DEFAULT '0',
  `whichlobby` varchar(255) NOT NULL DEFAULT 'UNK',
  `wins` varchar(255) NOT NULL DEFAULT 'UNK',
  `time` varchar(255) NOT NULL DEFAULT 'UNK',
  `exp` varchar(255) NOT NULL DEFAULT 'UNK',
  `ss` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `accounts`
--

INSERT INTO `accounts` (`id`, `login`, `password`, `parameters`, `shared_secret`, `5x5`, `2x2`, `x`, `y`, `userid`, `profile`, `colors`, `hello`, `whichlobby`, `wins`, `time`, `exp`, `ss`) VALUES
(1, '▰▰▰ WIN LOBBY ▰▰▰', 'LOBBY', '', '', 0, 0, '0', '0', '0', '0', '0', 2, 'WIN', 'UNK', 'UNK', 'UNK', NULL),
(2, '▰▰▰ LOSE LOBBY ▰▰▰', 'LOBBY', '', '', 0, 0, '0', '0', '0', '0', '0', 2, 'LOSE', 'UNK', 'UNK', 'UNK', NULL),
(3, '▰▰▰ ALWAYS IN WIN LOBBY ▰▰▰', 'LOBBY', '', '', 0, 0, '0', '0', '0', '0', '0', 2, 'ONLY WIN', 'UNK', 'UNK', 'UNK', NULL),
(4, '▰▰▰ ALWAYS IN LOSE LOBBY ▰▰▰', 'LOBBY', '', '', 0, 0, '0', '0', '0', '0', '0', 2, 'ONLY LOSE', 'UNK', 'UNK', 'UNK', NULL),
(5, '▰▰▰ NEW ACCOUNTS ▰▰▰', 'LOBBY', '', '', 0, 0, '0', '0', '0', '0', '0', 2, 'UNK', 'UNK', 'UNK', 'UNK', NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `disconnects`
--

DROP TABLE IF EXISTS `disconnects`;
CREATE TABLE IF NOT EXISTS `disconnects` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rec1` varchar(255) NOT NULL DEFAULT '0,0',
  `rec2` varchar(255) NOT NULL DEFAULT '0,0',
  `rec3` varchar(255) NOT NULL DEFAULT '0,0',
  `rec4` varchar(255) NOT NULL DEFAULT '0,0',
  `rec5` varchar(255) NOT NULL DEFAULT '0,0',
  `rec6` varchar(255) NOT NULL DEFAULT '0,0',
  `rec7` varchar(255) NOT NULL DEFAULT '0,0',
  `rec8` varchar(255) NOT NULL DEFAULT '0,0',
  `rec9` varchar(255) NOT NULL DEFAULT '0,0',
  `rec10` varchar(255) NOT NULL DEFAULT '0,0',
  `mode` varchar(255) NOT NULL DEFAULT '0',
  `color` varchar(255) NOT NULL DEFAULT '-11751600',
  `enabled` varchar(255) NOT NULL DEFAULT 'false',
  `win` varchar(999) NOT NULL DEFAULT 'test1,test1,test1,test1,test1',
  `lose` varchar(999) NOT NULL DEFAULT 'test2,test2,test2,test2,test2',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `disconnects`
--

INSERT INTO `disconnects` (`id`, `rec1`, `rec2`, `rec3`, `rec4`, `rec5`, `rec6`, `rec7`, `rec8`, `rec9`, `rec10`, `mode`, `color`, `enabled`, `win`, `lose`) VALUES
(1, '317,48', '316,23', '317,379', '318,713', '743,712', '1591,42', '1592,379', '1167,42', '742,41', '1166,378', '0', '-11751600', 'false', '76561198969438861,76561198885517928', '-Steamos -nofriendsui -nochatui -single_core -novid -noshader -nofbo -nodcaudio -nomsaa -16bpp -nosound -high');

-- --------------------------------------------------------

--
-- Структура таблицы `leaders`
--

DROP TABLE IF EXISTS `leaders`;
CREATE TABLE IF NOT EXISTS `leaders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `leaders`
--

INSERT INTO `leaders` (`id`, `login`) VALUES
(1, 'eztops6'),
(2, 'stixed_61uenie497saonkrdm2');

-- --------------------------------------------------------

--
-- Структура таблицы `settings`
--

DROP TABLE IF EXISTS `settings`;
CREATE TABLE IF NOT EXISTS `settings` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `steam` varchar(999) DEFAULT 'C:\\Program Files (x86)\\Steam\\',
  `csgo` varchar(999) DEFAULT 'C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\',
  `start1` varchar(255) NOT NULL DEFAULT '0,0',
  `play1` varchar(255) NOT NULL DEFAULT '0,0',
  `start2` varchar(255) NOT NULL DEFAULT '0,0',
  `play2` varchar(255) NOT NULL DEFAULT '0,0',
  `color_start1` varchar(255) NOT NULL DEFAULT '-15841008',
  `color_start2` varchar(255) NOT NULL DEFAULT '-15841008',
  `color_play1` varchar(255) NOT NULL DEFAULT '-1',
  `color_play2` varchar(255) NOT NULL DEFAULT '-1',
  `reconnect` varchar(255) NOT NULL DEFAULT '16000',
  `disconnect` varchar(255) NOT NULL DEFAULT '20000',
  `type` varchar(255) NOT NULL DEFAULT '1',
  `colors` varchar(255) NOT NULL DEFAULT '2',
  `type48` varchar(255) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `settings`
--

INSERT INTO `settings` (`id`, `steam`, `csgo`, `start1`, `play1`, `start2`, `play2`, `color_start1`, `color_start2`, `color_play1`, `color_play2`, `reconnect`, `disconnect`, `type`, `colors`, `type48`) VALUES
(1, 'C:\\Program Files (x86)\\Steam\\', 'C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\', '282,311', '21,65', '282,311', '21,65', '-16759505', '-16759505', '-1', '-1', '4000', '5', '2', '2', '1');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
