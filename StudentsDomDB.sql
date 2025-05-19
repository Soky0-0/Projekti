/*
No database-level extended properties were found or all existing extended properties are open in other windows
*/

---------------------------------------------------------
-- 1. Student
CREATE TABLE Student (
    ID_studenta INTEGER PRIMARY KEY,
    Ime VARCHAR(50) NOT NULL,
    Prezime VARCHAR(50) NOT NULL,
    Kontakt VARCHAR(20) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL CHECK (Email LIKE '%@%.%')
);
GO

---------------------------------------------------------
-- 2. Smještajna jedinica
CREATE TABLE Smjestajna_jedinica (
    ID_jedinice INTEGER PRIMARY KEY,
    Broj_sobe VARCHAR(10) UNIQUE NOT NULL,
    Kapacitet INTEGER NOT NULL CHECK (Kapacitet > 0),
    Tip_sobe INTEGER NOT NULL,
    Status VARCHAR(20) NOT NULL CHECK (Status IN ('slobodno', 'zauzeto')),
    FOREIGN KEY (Tip_sobe) REFERENCES Tip_smjestaja(ID_tipa)
);
GO

---------------------------------------------------------
-- 3. Tip smještaja
CREATE TABLE Tip_smjestaja (
    ID_tipa INTEGER PRIMARY KEY ,
    Opis VARCHAR(50) NOT NULL,
    Cijena_po_nocenju DECIMAL(10, 2) NOT NULL CHECK (Cijena_po_nocenju > 0)
);
GO

---------------------------------------------------------
-- 4. Rezervacija
CREATE TABLE Rezervacija (
    ID_rezervacije INTEGER PRIMARY KEY,
    Datum_rezervacije DATE NOT NULL,
    Datum_pocetka DATE NOT NULL CHECK (Datum_pocetka >= Datum_rezervacije),
    Datum_zavrsetka DATE NOT NULL CHECK (Datum_zavrsetka > Datum_pocetka),
    ID_jedinice INTEGER NOT NULL,
    FOREIGN KEY (ID_jedinice) REFERENCES Smjestajna_jedinica(ID_jedinice)
);
GO

---------------------------------------------------------
-- 5. Plaćanje
CREATE TABLE Placanje (
    ID_placanja INTEGER PRIMARY KEY,
    Iznos DECIMAL(10, 2) NOT NULL CHECK (Iznos > 0),
    Datum_placanja DATE NOT NULL,
    Nacin_placanja VARCHAR(50) NOT NULL CHECK (Nacin_placanja IN ('kartica', 'gotovina', 'uplatnica')),
    ID_rezervacije INTEGER NOT NULL,
    FOREIGN KEY (ID_rezervacije) REFERENCES Rezervacija(ID_rezervacije)
);
GO

---------------------------------------------------------
-- 6. Kvar
CREATE TABLE Kvar (
    ID_kvara INTEGER PRIMARY KEY ,
    Opis TEXT NOT NULL,
    Datum_prijave DATE NOT NULL,
    Status VARCHAR(20) NOT NULL CHECK (Status IN ('riješen', 'neriješen')),
    ID_jedinice INTEGER UNIQUE NOT NULL,
    FOREIGN KEY (ID_jedinice) REFERENCES Smjestajna_jedinica(ID_jedinice)
);
GO

---------------------------------------------------------
-- 7. Pritužba
CREATE TABLE Prituzba (
    ID_prituzbe INTEGER PRIMARY KEY,
    Opis TEXT NOT NULL,
    Datum_prijave DATE NOT NULL
);
GO

---------------------------------------------------------
-- 8. Zaposlenik
CREATE TABLE Zaposlenik (
    ID_zaposlenika INTEGER PRIMARY KEY,
    Ime VARCHAR(50) NOT NULL,
    Prezime VARCHAR(50) NOT NULL,
    Pozicija VARCHAR(50) NOT NULL,
    Kontakt VARCHAR(20) UNIQUE NOT NULL
);
GO

---------------------------------------------------------
-- 9. Administrator
CREATE TABLE Administrator (
    ID_admin INTEGER PRIMARY KEY,
    Ime VARCHAR(50) NOT NULL,
    Prezime VARCHAR(50) NOT NULL,
    Kontakt VARCHAR(20) UNIQUE NOT NULL
);
GO

---------------------------------------------------------
-- 10. Rad na kvarovima (M:N pomocna tablica)
CREATE TABLE Rad_na_kvarovima (
    ID_admin INTEGER,
    ID_zaposlenika INTEGER,
    ID_kvar INTEGER,
    Datum_rada DATE NOT NULL,
    PRIMARY KEY (ID_admin, ID_zaposlenika),
    FOREIGN KEY (ID_admin) REFERENCES Administrator(ID_admin),
    FOREIGN KEY (ID_zaposlenika) REFERENCES Zaposlenik(ID_zaposlenika),
    FOREIGN KEY (ID_kvar) REFERENCES Kvar(ID_kvara)
);
GO

---------------------------------------------------------
-- 11. Povijest rezervacija
CREATE TABLE Povijest_rezervacija (
    ID_povijesti INTEGER PRIMARY KEY ,
    Datum_izmjene DATE NOT NULL,
    Opis_izmjene TEXT NOT NULL
);
GO

---------------------------------------------------------
-- 12. Kreira (dvo-komponentna pomoćna tablica za FK)
CREATE TABLE Kreira (
    ID_student INT NOT NULL,
    ID_povijest INT NOT NULL,
    ID_rezervacije INT NOT NULL,
    PRIMARY KEY (ID_student, ID_povijest),
    FOREIGN KEY (ID_student) REFERENCES Student(ID_studenta),
    FOREIGN KEY (ID_povijest) REFERENCES Povijest_rezervacija(ID_povijesti),
    FOREIGN KEY (ID_rezervacije) REFERENCES Rezervacija(ID_rezervacije)
);
GO

---------------------------------------------------------
-- 13. Podnesena (za student-pritužba)
CREATE TABLE Podnesena (
    ID_student INT NOT NULL,
    ID_pritužbe INTEGER NOT NULL,
    Kategorija_prituzbe VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID_student, ID_pritužbe),
    FOREIGN KEY (ID_student) REFERENCES Student(ID_studenta),
    FOREIGN KEY (ID_pritužbe) REFERENCES Prituzba(ID_prituzbe)
);
GO

