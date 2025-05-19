--TRIGGER----

-- Trigger koji automatski zapisuje sve izmjene u Povijest rezervacija
CREATE TRIGGER trg_AfterInsertRezervacija
ON Rezervacija
AFTER INSERT
AS
BEGIN
    -- Dodavanje zapisa u Povijest rezervacija svaki put kad se napravi nova rezervacija
    INSERT INTO Povijest_rezervacija (ID_povijesti, Datum_izmjene, Opis_izmjene)
    SELECT 
        ISNULL((SELECT MAX(ID_povijesti) FROM Povijest_rezervacija), 0) + 1,
        GETDATE(),
        CONCAT('Nova rezervacija ID:', ID_rezervacije)
    FROM inserted;
END;


-- Kreiraj testnu rezervaciju
INSERT INTO Rezervacija (ID_rezervacije, Datum_rezervacije, Datum_pocetka, Datum_zavrsetka, ID_jedinice)
VALUES (9, GETDATE(), DATEADD(DAY, 1, GETDATE()), DATEADD(DAY, 5, GETDATE()), 1);



SELECT * FROM Povijest_rezervacija;




--Trigger za automatsko ažuriranje statusa smještajne jedinice__
GO
CREATE TRIGGER trg_AfterInsertRezervacijaStatus
ON Rezervacija
AFTER INSERT
AS
BEGIN
    -- Automatsko ažuriranje statusa smještajne jedinice na 'zauzeto' nakon rezervacije
    UPDATE Smjestajna_jedinica
    SET Status = 'zauzeto'
    FROM Smjestajna_jedinica AS J
    INNER JOIN inserted AS R ON J.ID_jedinice = R.ID_jedinice;
END;
GO

INSERT INTO Smjestajna_jedinica (ID_jedinice, Broj_sobe, Kapacitet, Tip_sobe, Status)
VALUES (6, '536', 2, 1, 'slobodno');

INSERT INTO Rezervacija (ID_rezervacije, Datum_rezervacije, Datum_pocetka, Datum_zavrsetka, ID_jedinice)
VALUES (6, GETDATE(), DATEADD(DAY, 1, GETDATE()), DATEADD(DAY, 5, GETDATE()), 6);

-- Pregled trenutnog statusa smještajne jedinice
SELECT ID_jedinice, Broj_sobe, Status
FROM Smjestajna_jedinica
WHERE ID_jedinice = 6;


