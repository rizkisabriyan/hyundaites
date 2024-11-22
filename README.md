# User Manual Guide
Coding test Hyundai Auto Ever Indonesia


API(hyundai)
1.buka direktori hyundai di visual studio
2.buat lah database baru di SSMS(SQL Server) dengan source:

create database hyundai;

create table Cars(
id int  NOT NULL IDENTITY(1,1) primary key,
nama varchar(50),
model varchar(10),
years varchar(20),
image varchar(2000)
);

create table Customer(
id int  NOT NULL IDENTITY(1,1) primary key,
nama varchar(50),
email varchar(50),
phone varchar(20),
book_dt varchar(20)
);


3.setelah database berhasil dibuat. kembali ke visual studio dan tambahkan server:
-ke bagian tab atas pilih view -> server explorer -> new connection sesuaikan username dan password(tidak boleh ******)
4. setelah selesai menambah server, silahkan running:
-ke bagian tab atas -> pilih Logo play(segitiga hijau thick)
5.tunggu beberapa detik, jika tab browser baru terbuka dan menampilkan controller, API siap di tes



remarks:
Versi yang digunakan adalah 8.0.8.
jika koneksi database bermasalah saat api dijalankan. silahkan tambahkan source ini di appsetting.json

TrustServerCertificate=True

-buka appseting.json
-lihat connection string









UI(hyundaiClient)
1.buka direktori hyundaiClient di visual studio
2.silahkan running:
-ke bagian tab atas -> pilih Logo play(segitiga hijau thick)
5.tunggu beberapa detik, jika tab browser baru terbuka dan menampilkan controller, UI siap di tes



remarks:
-Gambar masih belum bisa muncul
-gambar masih belum bisa di save
-calender masih manual
-ketersediaan jadwal belum tersedia




