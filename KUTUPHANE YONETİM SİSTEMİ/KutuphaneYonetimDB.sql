-- Yeni bir veritabaný oluþturma (opsiyonel)
CREATE DATABASE KutuphaneYonetimDB;
GO
USE KutuphaneYonetimDB;
GO


CREATE TABLE Kullanicilar (
    kullanici_id INT PRIMARY KEY IDENTITY(1,1),           -- Sizin isteðinizdeki 'Ýd'
    ad NVARCHAR(100) NOT NULL,
    soyad NVARCHAR(100) NOT NULL,
    eposta NVARCHAR(100) NOT NULL UNIQUE,       -- Giriþ için benzersiz olmalý
    sifre_hashed NVARCHAR(256) NOT NULL,               -- Sizin isteðinizdeki 'Þifre' (Hashlenmiþ tutulmasý önerilir)
    okul_numarasi NVARCHAR(50) UNIQUE,           -- Sizin isteðinizdeki 'Okul numarasý'
    telefon NVARCHAR(20),
    rol NVARCHAR(50)  NOT NULL CHECK (rol IN ('Öðrenci', 'Personel', 'Yönetici')) DEFAULT 'Öðrenci',                 -- Sizin isteðinizdeki 'Rol' ('Ogrenci', 'Personel', 'Yonetici' olabilir) 
);
GO

CREATE TABLE Yazarlar (
    yazar_id INT PRIMARY KEY IDENTITY(1,1),
    yazar_ad NVARCHAR(200) NOT NULL -- Yazarýn Adý ve Soyadý
);
GO

CREATE TABLE Kategoriler (
    kategori_id INT PRIMARY KEY IDENTITY(1,1), -- Sizin isteðinizdeki 'Kitap tür id'
    kategori_adi NVARCHAR(100) NOT NULL UNIQUE     -- Sizin isteðinizdeki 'Tür adý'
); 
GO

CREATE TABLE Kitaplar (
    kitap_id INT PRIMARY KEY IDENTITY(1,1),          -- Sizin isteðinizdeki 'Ýd'
    ad NVARCHAR(255) NOT NULL,                 -- Sizin isteðinizdeki 'Ad'
    isbn NVARCHAR(20) UNIQUE,                  -- Sizin isteðinizdeki 'Ýsbn'
    ozet NVARCHAR(MAX),                        -- Sizin isteðinizdeki 'Özet'
    stok INT NOT NULL DEFAULT 0,               -- Sizin isteðinizdeki 'Stok'
    yayin_yili INT,                             -- Sizin isteðinizdeki 'Yayýn yýlý'
    raf_bilgisi NVARCHAR(50),                   -- Sizin isteðinizdeki 'Raf bilgisi'
);
GO

CREATE TABLE Kitap_Yazar (
    kitap_yazar_id INT PRIMARY KEY IDENTITY(1,1),  -- Sizin isteðinizdeki 'Kitap yazar id'
    kitap_id INT NOT NULL,
    yazar_id INT NOT NULL,
    FOREIGN KEY (kitap_id) REFERENCES Kitaplar(kitap_id),
    FOREIGN KEY (yazar_id) REFERENCES Yazarlar(yazar_id)
    -- NOT: "Yazar adý" yerine YazarID kullanýldý.
);
GO

CREATE TABLE Kitap_Kategori (
    kitap_kategori_id INT PRIMARY KEY IDENTITY(1,1),  -- Sizin isteðinizdeki 'Kitap yazar id'
    kitap_id INT NOT NULL,
    kategori_id INT NOT NULL,
    FOREIGN KEY (kitap_id) REFERENCES Kitaplar(kitap_id),
    FOREIGN KEY (kategori_id ) REFERENCES Kategoriler(kategori_id )
    -- NOT: "Yazar adý" yerine YazarID kullanýldý.
);
GO

CREATE TABLE Odunc_Islemleri (
    odunc_id INT PRIMARY KEY IDENTITY(1,1), -- Birincil Anahtar
    talep_tarihi DATETIME DEFAULT GETDATE(), -- Öðrencinin talep gönderdiði tarih
    onay_tarihi DATETIME, -- Personelin onayladýðý tarih
    teslim_tarihi DATETIME, -- Kitabýn öðrenciye verildiði tarih
    iade_tarihi DATETIME, -- Öðrencinin kitabý iade ettiði tarih
    son_teslim_tarihi DATETIME, -- Gecikme takibi için
    durum NVARCHAR(50) NOT NULL CHECK (durum IN ('Beklemede', 'Onaylandý', 'Teslim Edildi','Ýade edildi','Gecikmiþ')) DEFAULT 'Beklemede',
    personel_id INT, -- Ýþlemi yürüten personel (KULLANICILAR tablosunda RolID = Personel olmalý, NULL olabilir)
    kitap_id INT NOT NULL, -- Ödünç alýnan kitap
    ogrenci_id INT NOT NULL, -- Talepte bulunan öðrenci (KULLANICILAR tablosunda RolID = Ogrenci olmalý)
    FOREIGN KEY (kitap_id) REFERENCES Kitaplar(kitap_id),
    FOREIGN KEY (ogrenci_id) REFERENCES Kullanicilar(kullanici_id),
    FOREIGN KEY (personel_id) REFERENCES Kullanicilar(kullanici_id)
);
GO