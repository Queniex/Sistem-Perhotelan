# PROJEK AKHIR PEMROGRAMAN VISUAL [SEMESTER 3]
KELAS : TI-3A <br>
KELOMPOK : 3 <br>
__ANGGOTA :__
1. Nabiilah Putri Afiifah (2107411004)
2. Larasati Maharani (2107411011)
3. Adelia Citra Utami (2107411027)
4. Fildzah Marissa Rusialdi (2107411030)
<hr>

## REQUIREMENT : 
  
__Terdapat Class :__ <br>
💠User <br>
💠Jenis Kamar <br>
💠Kamar <br>
💠Tamu <br>
💠Booking <br>

__Terdapat Form :__ <br>
💠Sign In <br>
💠Sign Up <br>
💠Form Jenis Kamar (Data Grid View Jenis Kamar) <br>
💠Form Tambah Jenis Kamar <br>
💠Form Edit Jenis Kamar <br>
💠Form Hapus Jenis Kamar <br>
💠Form Kamar (Data Grid View Kamar) <br>
💠Form Tambah Kamar <br>
💠Form Edit Kamar <br>
💠Form Hapus Kamar <br>
💠Form Tamu (Data Grid View Tamu) <br>
💠Form Tambah Tamu <br>
💠Form Edit Tamu <br>
💠Form Hapus Tamu <br>
💠Form Booking Kamar ( Data Grid dari table booking kamar di join dengan tamu dan kamar ) (Form Utama) <br>
💠Form Tambah Buku Tamu / Check In (Tanggal check in dan status = 1) <br>
💠Form Ubah Buku Tamu / Check In <br>
💠Form Hapus Buku Tamu / Check In <br>
💠Form Checkout (tanggal Check out dan status = 0 ) <br>

__Terdapat Fitur:__ <br>
💠Sign In, Sign Out, dan Sign Up <br>
💠User merupakan receptionist /  administrasi hotel. <br>
💠Form jenis kamar merupakan jenis kamar dan harga per malam <br>
💠Form Kamar merupakan informasi kamar dan status kamar apakah terisi atau kosong <br>
💠Form Tamu merupakan informasi yang berisi informasi orang yang akan booking hotel <br>
💠Form Booking dapat diisi setelah Form Tamu diisi <br>
💠Perhitungan total bayar dihitung berdasarkan harga per malam dikali berapa hari pengunjung hotel menginap. <br>

__Terdapat Table:__ <br>
💠Users (id, username, email, password) <br>
💠Kamar (id_kamar, id_jenis_kamar, nama_kamar, status) <br>
💠Jenis Kamar (id_jenis_kamar, jenis_kamar, harga_permalam) <br>
💠Tamu (nik, nama, alamat, jenis_kelamin) <br>
💠Booking Kamar (id, id_tamu, id_kamar, check_in (tanggal), check_out, total_bayar, status) <br>
<hr>

## DIAGRAM UML : 

__💠USE CASE DIAGRAM :__ <br>
<p align="left"> <img src="https://i.postimg.cc/MZ9k7jsG/Diagram-Projek-Vb-Diagram-Use-Case-drawio.png"> </p> <br>

__💠ACTIVITY DIAGRAM [USER] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/LXYph4pT/Use-Case-Login.png"> </p> <br>

__💠ACTIVITY DIAGRAM [KAMAR] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/7YL590wt/Use-Case-Jenis-Kamar.png"> </p> <br>

__💠ACTIVITY DIAGRAM [JENIS KAMAR] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/7YL590wt/Use-Case-Jenis-Kamar.png"> </p> <br>

__💠ACTIVITY DIAGRAM [TAMU] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/bvPDQMJk/Use-Case-Tamu.png"> </p> <br>

__💠ACTIVITY DIAGRAM [BOOKING] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/ZR7Wz5Lx/Use-Case-Booking.png"> </p> <br>

__💠CLASS DIAGRAM [USER] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/pTRzBd6n/cd-users.jpg"> </p> <br>

__💠CLASS DIAGRAM [JENIS KAMAR] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/0QkKwBzY/cd-jenis-Kamar.jpg"> </p> <br>

__💠CLASS DIAGRAM [KAMAR] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/4yKdvks9/cd-Kamar.jpg"> </p> <br>

__💠CLASS DIAGRAM [TAMU] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/cJrLGGt5/cd-Tamu.jpg"> </p> <br>

__💠CLASS DIAGRAM [BOOKING] :__ <br>
<p align="left"> <img src="https://i.postimg.cc/d3qMvGSt/cd-Booking.jpg"> </p> <br>
