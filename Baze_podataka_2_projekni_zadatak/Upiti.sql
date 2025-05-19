-- JEDNOSTAVNI UPITI -- 

--Prikaz svih studenata--
SELECT * FROM Student;


--Prikaz smještajnih jedinica koje su slobodne--
SELECT * FROM Smjestajna_jedinica WHERE Status = 'slobodno';


--Prikaz svih rezervacija s datumima početka i završetka--
SELECT ID_rezervacije, Datum_pocetka, Datum_zavrsetka FROM Rezervacija;


--Prikaz svih plaćanja iznad 100€--
SELECT * FROM Placanje WHERE Iznos > 100.00;


--Prikaz svih pritužbi prijavljenih na određeni datum--
SELECT * FROM Prituzba WHERE Datum_prijave = '2024-12-02';






-- SLOŽENI UPITI-----


--Prikaz studenata koji su trenutno rezervirali smještajnu jedinicu--
SELECT S.Ime, S.Prezime, R.ID_jedinice
FROM Student S
INNER JOIN Kreira K ON S.ID_studenta = K.ID_student
INNER JOIN Rezervacija R ON K.ID_rezervacije = R.ID_rezervacije;



--Broj rezervacija po smještajnim jedinicama--
SELECT R.ID_jedinice, COUNT(R.ID_rezervacije) AS Broj_rezervacija
FROM Rezervacija R
GROUP BY R.ID_jedinice;


--Ukupan iznos plaćanja po datumu--
SELECT Datum_placanja, SUM(Iznos) AS Ukupan_iznos
FROM Placanje
GROUP BY Datum_placanja
ORDER BY Ukupan_iznos DESC;


--Prikaz svih rezervacija koje su trajale dulje od 30 dana--
SELECT ID_rezervacije, Datum_pocetka, Datum_zavrsetka
FROM Rezervacija
WHERE Datum_zavrsetka IS NOT NULL
  AND DATEDIFF(DAY, Datum_pocetka, Datum_zavrsetka) > 0; 








