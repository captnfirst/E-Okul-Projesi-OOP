-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost:3306
-- Üretim Zamanı: 07 May 2023, 16:58:48
-- Sunucu sürümü: 10.3.38-MariaDB-cll-lve
-- PHP Sürümü: 8.1.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `u9176804_ismail`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bolum`
--

CREATE TABLE `bolum` (
  `bolum_id` int(11) NOT NULL,
  `bolum_adi` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `bolum`
--

INSERT INTO `bolum` (`bolum_id`, `bolum_adi`) VALUES
(9, 'Bilgisayar Mühendisligi'),
(11, 'Bilgisayar Programciligi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ders`
--

CREATE TABLE `ders` (
  `id` int(11) NOT NULL,
  `ders_adi` varchar(254) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `ders`
--

INSERT INTO `ders` (`id`, `ders_adi`) VALUES
(11, 'Görsel P'),
(10, 'Ingilizce'),
(9, 'Sistem Analizi'),
(8, 'Veri Yapilari');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ders_yonlendirme`
--

CREATE TABLE `ders_yonlendirme` (
  `id` int(11) NOT NULL,
  `ogrenci_id` int(11) NOT NULL,
  `ders_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `ders_yonlendirme`
--

INSERT INTO `ders_yonlendirme` (`id`, `ogrenci_id`, `ders_id`) VALUES
(22, 7, 10),
(21, 7, 9),
(20, 6, 11),
(19, 6, 10),
(18, 6, 9),
(17, 6, 8);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `devamsizlik`
--

CREATE TABLE `devamsizlik` (
  `id` int(11) NOT NULL,
  `ogrenci_id` int(11) NOT NULL,
  `devamsizlik` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `devamsizlik`
--

INSERT INTO `devamsizlik` (`id`, `ogrenci_id`, `devamsizlik`) VALUES
(7, 7, '2023-05-07');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

CREATE TABLE `kullanici` (
  `id` int(11) NOT NULL,
  `ad` varchar(254) NOT NULL,
  `soyad` varchar(254) NOT NULL,
  `eposta` varchar(254) NOT NULL,
  `sifre` varchar(254) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`id`, `ad`, `soyad`, `eposta`, `sifre`) VALUES
(1, 'Ismail', 'Nedanli', 'ismailnedanli@hotmail.com', '123321'),
(2, 'ismail', 'nedanli', 'ismail@hotmail.com', '123456'),
(3, 'ismail', 'nedanli', 'ismailnedann@hotmail.com', '123456'),
(4, 'Ismail', 'Nedanli', 'nedanliismail@hotmail.com', '123456'),
(5, 'ismail', 'nedanli', 'reak123@hotmail.com', '123456');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrenci`
--

CREATE TABLE `ogrenci` (
  `id` int(11) NOT NULL,
  `tc` bigint(11) NOT NULL,
  `ad` varchar(254) NOT NULL,
  `soyad` varchar(254) NOT NULL,
  `no` bigint(11) NOT NULL,
  `sinif` varchar(25) DEFAULT NULL,
  `bolum` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `ogrenci`
--

INSERT INTO `ogrenci` (`id`, `tc`, `ad`, `soyad`, `no`, `sinif`, `bolum`) VALUES
(6, 18149291296, 'Ismail', 'Nedanli', 1204225062, '2', 'Bilgisayar Programciligi'),
(7, 12345678911, 'Bahadir', 'Tilki', 1204005060, '1', 'Bilgisayar Mühendisligi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sinif`
--

CREATE TABLE `sinif` (
  `sinif_id` int(11) NOT NULL,
  `sinif_Adi` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `sinif`
--

INSERT INTO `sinif` (`sinif_id`, `sinif_Adi`) VALUES
(10, '2'),
(9, '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_not`
--

CREATE TABLE `tbl_not` (
  `id` int(11) NOT NULL,
  `ogrenci_id` int(11) NOT NULL,
  `ders_id` int(11) NOT NULL,
  `puan` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `tbl_not`
--

INSERT INTO `tbl_not` (`id`, `ogrenci_id`, `ders_id`, `puan`) VALUES
(1, 1, 1, 100),
(2, 1, 2, 50),
(3, 1, 3, 80),
(4, 1, 4, 70),
(5, 1, 6, 60),
(6, 2, 3, 50),
(7, 2, 6, 70),
(8, 1, 6, 60),
(9, 1, 4, 70),
(10, 1, 3, 80),
(11, 1, 2, 50),
(12, 1, 1, 100),
(13, 3, 3, 40),
(14, 3, 4, 20),
(15, 6, 11, 70),
(16, 6, 10, 60),
(17, 6, 9, 70),
(18, 6, 8, 80),
(19, 7, 10, 20),
(20, 7, 9, 30);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `bolum`
--
ALTER TABLE `bolum`
  ADD PRIMARY KEY (`bolum_id`);

--
-- Tablo için indeksler `ders`
--
ALTER TABLE `ders`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ders_yonlendirme`
--
ALTER TABLE `ders_yonlendirme`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `devamsizlik`
--
ALTER TABLE `devamsizlik`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kullanici`
--
ALTER TABLE `kullanici`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ogrenci`
--
ALTER TABLE `ogrenci`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sinif`
--
ALTER TABLE `sinif`
  ADD PRIMARY KEY (`sinif_id`);

--
-- Tablo için indeksler `tbl_not`
--
ALTER TABLE `tbl_not`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `bolum`
--
ALTER TABLE `bolum`
  MODIFY `bolum_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `ders`
--
ALTER TABLE `ders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Tablo için AUTO_INCREMENT değeri `ders_yonlendirme`
--
ALTER TABLE `ders_yonlendirme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Tablo için AUTO_INCREMENT değeri `devamsizlik`
--
ALTER TABLE `devamsizlik`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tablo için AUTO_INCREMENT değeri `kullanici`
--
ALTER TABLE `kullanici`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `ogrenci`
--
ALTER TABLE `ogrenci`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Tablo için AUTO_INCREMENT değeri `sinif`
--
ALTER TABLE `sinif`
  MODIFY `sinif_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_not`
--
ALTER TABLE `tbl_not`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
