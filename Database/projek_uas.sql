-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 10 Jan 2023 pada 18.43
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

--
-- Dumping data untuk tabel `booking_kamar`
--

INSERT INTO `booking_kamar` (`id`, `id_tamu`, `id_kamar`, `check_in`, `check_out`, `status`) VALUES
(5, 2107411030, 10, '2023-01-01', '2023-01-03', 'Check Out'),
(7, 2107411030, 9, '2023-01-01', '2023-01-04', 'Check Out'),
(14, 2107411031, 12, '2023-01-02', '2023-01-07', 'Check Out'),
(15, 2107411030, 11, '2023-01-02', '2023-01-05', 'Check Out'),
(29, 2107411030, 13, '2023-01-02', '2023-01-04', 'Checkout'),
(31, 2107411030, 14, '2023-01-03', '2023-01-05', 'Checkout'),
(33, 2107411031, 10, '2023-01-03', '2023-01-03', 'Check Out'),
(34, 2107411030, 11, '2023-01-03', '2023-01-03', 'Check Out'),
(37, 2107411030, 9, '2023-01-03', '2023-01-04', 'Checkout'),
(39, 2107411030, 14, '2023-01-03', '2023-01-05', 'Checkout'),
(40, 2107411030, 13, '2023-01-03', '2023-01-05', 'Checkout'),
(41, 2107411030, 10, '2023-01-03', '2023-01-05', 'Checkout'),
(43, 2107411030, 9, '2023-01-03', '2023-01-04', 'Check Out'),
(44, 2107411030, 13, '2023-01-03', '2023-01-05', 'Check Out'),
(45, 2107411030, 10, '2023-01-04', '2023-01-07', 'Check Out');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jenis_kamar`
--

CREATE TABLE `jenis_kamar` (
  `id_jenis_kamar` int(15) NOT NULL,
  `jenis_kamar` varchar(30) NOT NULL,
  `harga` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `jenis_kamar`
--

INSERT INTO `jenis_kamar` (`id_jenis_kamar`, `jenis_kamar`, `harga`) VALUES
(2, 'Vanillaa', 100000),
(3, 'Chocolate', 300000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `kamar`
--

CREATE TABLE `kamar` (
  `id_kamar` int(15) NOT NULL,
  `id_jenis_kamar` int(15) NOT NULL,
  `nama_kamar` varchar(30) NOT NULL,
  `status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `kamar`
--

INSERT INTO `kamar` (`id_kamar`, `id_jenis_kamar`, `nama_kamar`, `status`) VALUES
(9, 3, '103', 'Belum Terisi'),
(10, 3, '201', 'Belum Terisi'),
(11, 3, '301', 'Belum Terisi'),
(12, 3, '302', 'Belum Terisi'),
(13, 2, '501', 'Belum Terisi'),
(14, 2, '502', 'Belum Terisi');

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

--
-- Dumping data untuk tabel `tamu`
--

INSERT INTO `tamu` (`nik`, `nama`, `alamat`, `jenis_kelamin`) VALUES
(2107411030, 'Quenie', 'Jl. Cobain Deh', 'Wanita'),
(2107411031, 'Salbiyah', 'Jl.Heehehehe', 'Wanita');

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
(13, 'Fildzah', '202cb962ac59075b964b07152d234b70', 'Fildzah@gmail.com', 'C:/Users/hp/Downloads/Fildzah Marissa.png'),
(14, 'Quenie', '202cb962ac59075b964b07152d234b70', 'Quenie@gmail.com', 'C:/Users/hp/Downloads/Learning-pana.png');

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
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT untuk tabel `jenis_kamar`
--
ALTER TABLE `jenis_kamar`
  MODIFY `id_jenis_kamar` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `kamar`
--
ALTER TABLE `kamar`
  MODIFY `id_kamar` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `Id_User` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
