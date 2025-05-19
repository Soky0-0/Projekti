-- 1. Popunjavanje tablice Tip_smjestaja
INSERT INTO Tip_smjestaja (ID_tipa, Opis, Cijena_po_nocenju)
VALUES 
(1, 'Jednokrevetna', 200.00),
(2, 'Dvokrevetna', 350.00),
(3, 'Trokrevetna', 500.00),
(4, 'Apartman', 800.00),
(5, 'Luksuzna', 1500.00);

-- 2. Popunjavanje tablice Student
INSERT INTO Student (ID_studenta, Ime, Prezime, Kontakt, Email)
VALUES
(1, 'Ivan', 'Ivić', '0911234567', 'ivan.ivic@example.com'),
(2, 'Ana', 'Anić', '0922345678', 'ana.anic@example.com'),
(3, 'Marko', 'Markić', '0953456789', 'marko.markic@example.com'),
(4, 'Lucija', 'Lučić', '0974567890', 'lucija.lucic@example.com'),
(5, 'Petra', 'Petrić', '0985678901', 'petra.petric@example.com');

-- 3. Popunjavanje tablice Smjestajna_jedinica
INSERT INTO Smjestajna_jedinica (ID_jedinice, Broj_sobe, Kapacitet, Tip_sobe, Status)
VALUES
(1, '101', 1, 1, 'slobodno'),
(2, '102', 2, 2, 'zauzeto'),
(3, '103', 3, 3, 'slobodno'),
(4, '104', 4, 4, 'zauzeto'),
(5, '105', 2, 5, 'slobodno');

-- 4. Popunjavanje tablice Rezervacija
INSERT INTO Rezervacija (ID_rezervacije, Datum_rezervacije, Datum_pocetka, Datum_zavrsetka, ID_jedinice)
VALUES
(1, '2024-12-01', '2024-12-05', '2024-12-10', 2),
(2, '2024-11-15', '2024-11-20', '2024-11-25', 4),
(3, '2024-10-10', '2024-10-15', '2024-10-20', 3),
(4, '2024-09-01', '2024-09-05', '2024-09-10', 5),
(5, '2024-12-01', '2024-12-06', '2024-12-12', 1);

-- 5. Popunjavanje tablice Placanje
INSERT INTO Placanje (ID_placanja, Iznos, Datum_placanja, Nacin_placanja, ID_rezervacije)
VALUES
(1, 1000.00, '2024-12-02', 'kartica', 1),
(2, 1500.00, '2024-11-16', 'gotovina', 2),
(3, 500.00, '2024-10-11', 'uplatnica', 3),
(4, 2000.00, '2024-09-02', 'kartica', 4),
(5, 800.00, '2024-12-03', 'gotovina', 5);

-- 6. Popunjavanje tablice Kvar
INSERT INTO Kvar (ID_kvara, Opis, Datum_prijave, Status, ID_jedinice)
VALUES
(1, 'Problem sa grijanjem', '2024-12-01', 'neriješen', 2),
(2, 'Kvar na bojleru', '2024-11-10', 'riješen', 4),
(3, 'Puknuće cijevi', '2024-10-05', 'neriješen', 3),
(4, 'Neispravan klima uređaj', '2024-09-15', 'riješen', 5),
(5, 'Lom stakla na prozoru', '2024-12-02', 'neriješen', 1);

-- 7. Popunjavanje tablice Prituzba
INSERT INTO Prituzba (ID_prituzbe, Opis, Datum_prijave)
VALUES
(1, 'Buka u susjednim sobama', '2024-12-02'),
(2, 'Nedostatak tople vode', '2024-11-12'),
(3, 'Slabo grijanje', '2024-10-07'),
(4, 'Neodržavanje čistoće', '2024-09-20'),
(5, 'Problem s parkiranjem', '2024-12-03');

-- 8. Popunjavanje tablice Zaposlenik
INSERT INTO Zaposlenik (ID_zaposlenika, Ime, Prezime, Pozicija, Kontakt)
VALUES
(1, 'Josip', 'Josipović', 'Domar', '0911122233'),
(2, 'Maja', 'Majić', 'Čistačica', '0922233344'),
(3, 'Ivan', 'Kovačić', 'Voditelj', '0933344455'),
(4, 'Tina', 'Tinić', 'Domar', '0944455566'),
(5, 'Ana', 'Marušić', 'Recepcionist', '0955566677');

-- 9. Popunjavanje tablice Administrator
INSERT INTO Administrator (ID_admin, Ime, Prezime, Kontakt)
VALUES
(1, 'Hrvoje', 'Hrvoić', '0976677888'),
(2, 'Lucija', 'Lucinović', '0987788999'),
(3, 'Marko', 'Marinović', '0998899000'),
(4, 'Ivana', 'Ivanović', '0919900111'),
(5, 'Petar', 'Petrović', '0921001122');

-- 10. Popunjavanje tablice Rad_na_kvarovima
INSERT INTO Rad_na_kvarovima (ID_admin, ID_zaposlenika, ID_kvar, Datum_rada)
VALUES
(1, 1, 1, '2024-12-03'),
(2, 2, 2, '2024-11-13'),
(3, 3, 3, '2024-10-08'),
(4, 4, 4, '2024-09-21'),
(5, 5, 5, '2024-12-04');

-- 11. Popunjavanje tablice Povijest_rezervacija
INSERT INTO Povijest_rezervacija (ID_povijesti, Datum_izmjene, Opis_izmjene)
VALUES
(1, '2024-12-04', 'Promjena datuma rezervacije'),
(2, '2024-11-15', 'Dodavanje dodatnog gosta'),
(3, '2024-10-09', 'Otkazivanje rezervacije'),
(4, '2024-09-22', 'Promjena smještaja'),
(5, '2024-12-05', 'Produženje rezervacije');

-- 12. Popunjavanje tablice Kreira
INSERT INTO Kreira (ID_student, ID_povijest, ID_rezervacije)
VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

-- 13. Popunjavanje tablice Podnesena
INSERT INTO Podnesena (ID_student, ID_prituzbe, Kategorija_prituzbe)
VALUES
(1, 1, 'Buka'),
(2, 2, 'Tehnički problem'),
(3, 3, 'Grijanje'),
(4, 4, 'Čistoća'),
(5, 5, 'Parking');
