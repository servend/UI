-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Ноя 20 2022 г., 11:31
-- Версия сервера: 10.4.25-MariaDB
-- Версия PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `gur`
--

-- --------------------------------------------------------

--
-- Структура таблицы `turtable`
--

CREATE TABLE `turtable` (
  `ID` int(11) NOT NULL,
  `Имя` varchar(40) NOT NULL,
  `тур 1` int(11) NOT NULL,
  `тур 2` int(11) NOT NULL,
  `тур 3` int(11) NOT NULL,
  `тур 4` int(11) NOT NULL,
  `Финал` int(11) NOT NULL,
  `Итоговый рейтинг` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Структура таблицы `uchast`
--

CREATE TABLE `uchast` (
  `ID` int(11) NOT NULL,
  `Имя` varchar(50) NOT NULL,
  `Фамилия` varchar(50) DEFAULT NULL,
  `Рейтинг` int(11) DEFAULT NULL,
  `Звание` varchar(50) DEFAULT NULL,
  `Тип` varchar(50) DEFAULT NULL,
  `Статистика` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `turtable`
--
ALTER TABLE `turtable`
  ADD PRIMARY KEY (`Итоговый рейтинг`),
  ADD KEY `ID` (`ID`,`Имя`);

--
-- Индексы таблицы `uchast`
--
ALTER TABLE `uchast`
  ADD PRIMARY KEY (`Имя`,`ID`),
  ADD UNIQUE KEY `ID` (`ID`),
  ADD KEY `Рейтинг` (`Рейтинг`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `uchast`
--
ALTER TABLE `uchast`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `turtable`
--
ALTER TABLE `turtable`
  ADD CONSTRAINT `turtable_ibfk_1` FOREIGN KEY (`ID`,`Имя`) REFERENCES `uchast` (`ID`, `Имя`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
