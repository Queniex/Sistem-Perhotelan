-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 19 Des 2022 pada 17.53
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projek_uas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `booking_kamar`
--

CREATE TABLE `booking_kamar` (
  `id` int(15) NOT NULL,
  `id_tamu` int(15) NOT NULL,
  `id_kamar` int(15) NOT NULL,
  `check_in` date NOT NULL,
  `check_out` date NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_kamar`
--

CREATE TABLE `jenis_kamar` (
  `id_jenis_kamar` int(15) NOT NULL,
  `jenis_kamar` varchar(30) NOT NULL,
  `harga` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `kamar`
--

CREATE TABLE `kamar` (
  `id_kamar` int(15) NOT NULL,
  `id_jenis_kamar` int(15) NOT NULL,
  `nama_kamar` varchar(30) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tamu`
--

CREATE TABLE `tamu` (
  `nik` int(16) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `Id_User` int(10) NOT NULL,
  `Username` varchar(50) CHARACTER SET armscii8 NOT NULL,
  `Pass` varchar(50) CHARACTER SET armscii8 NOT NULL,
  `Email` varchar(50) CHARACTER SET armscii8 NOT NULL,
  `Foto` varchar(255) CHARACTER SET armscii8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`Id_User`, `Username`, `Pass`, `Email`, `Foto`) VALUES
(1, 'admin', '123', 'admin@gmail.com', 'C:/Users/hp/Downloads/Hidden person-cuate.png'),
(2, 'test', '123', 'test@gmail.com', 'C:/Users/hp/Downloads/jaheeee.png'),
(3, 'test2', '', 'test2@gmail.com', 'C:/Users/hp/Downloads/pass.png'),
(4, 'test3', '123', 'test3@gmail.com', ''),
(5, 'test4', '123', 'test4@gmail.com', 'C:/Users/hp/Downloads/sit.png'),
(6, 'test5', 'txUwk/FVdpA=', 'test5@gmail.com', 'C:/Users/hp/Downloads/pass.png'),
(7, 'fildzah', 'txUwk/FVdpA=', 'fildzah@gmail.com', 'C:/Users/hp/Downloads/Personal site-amico.png'),
(8, '123', 'Hs4kAht3bqQ=', '123@gmail.com', 'C:/Users/hp/Downloads/plant.png'),
(9, 'fildzah2', '123', 'fildzah2@gmail.com', 'C:/Users/hp/Downloads/GDPR-amico2.png'),
(10, 'marissa', '202cb962ac59075b964b07152d234b70', 'marissa@gmail.com', 'C:/Users/hp/Downloads/2ba2d1949c9476eb2ac72994921ad87a.jpg'),
(11, 'test6', '202cb962ac59075b964b07152d234b70', 'test6@gmail.com', 'C:/Users/hp/Downloads/delete3.png'),
(12, 'test62', '202cb962ac59075b964b07152d234b70', 'test62@gmail.com', 'C:/Users/hp/Downloads/Admin-rafiki.png');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `booking_kamar`
--
ALTER TABLE `booking_kamar`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_tamu` (`id_tamu`),
  ADD KEY `id_kamar` (`id_kamar`);

--
-- Indeks untuk tabel `jenis_kamar`
--
ALTER TABLE `jenis_kamar`
  ADD PRIMARY KEY (`id_jenis_kamar`);

--
-- Indeks untuk tabel `kamar`
--
ALTER TABLE `kamar`
  ADD PRIMARY KEY (`id_kamar`),
  ADD KEY `id_jenis_kamar` (`id_jenis_kamar`);

--
-- Indeks untuk tabel `tamu`
--
ALTER TABLE `tamu`
  ADD PRIMARY KEY (`nik`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Id_User`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `booking_kamar`
--
ALTER TABLE `booking_kamar`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `jenis_kamar`
--
ALTER TABLE `jenis_kamar`
  MODIFY `id_jenis_kamar` int(15) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `kamar`
--
ALTER TABLE `kamar`
  MODIFY `id_kamar` int(15) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `tamu`
--
ALTER TABLE `tamu`
  MODIFY `nik` int(16) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `Id_User` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
