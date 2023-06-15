INSERT INTO ZAPOSLENI
VALUES
(0702992632111, 60000, 'Marko', 'Petrovic', '1992-02-07', '2020-11-05', 3, 'Tehnicka struka', '2021-05-23', 'Visi tehnicar poliranja', 'Auto centar Tasic', NULL, NULL, 'Nadredjeni', 1, 0, 0, NULL, NULL, 0702992632111, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1807987542331, 55000, 'Jovana', 'Milovanovic', '1987-07-18', '2017-05-21', 6, 'Ekonomska struka', NULL, NULL, NULL, 1, '2027-12-28', 'Nadredjeni', 1, 0, 0, NULL, NULL, 1807987542331, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(2312984715494, 65000, 'Petar', 'Milic', '1984-12-23', '2015-08-14', 8, 'Tehnicka struka', '2017-02-12', 'Visi tehnicar motornih vozila', 'Visa tehnicka skola Nis', NULL, NULL, 'Nadredjeni', 1, 0, 1, NULL, NULL, 2312984715494, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(0601996379936, 60000, 'Ivan', 'Stojanovic', '1996-01-06', '2020-06-12', 3, 'Tehnicka struka', '2022-10-03', 'Visi tehnicar limarije', 'Visa tehnicka skola Kragujevac', NULL, NULL, 'Nadredjeni', 1, 0, 0, NULL, NULL, 0601996379936, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1506975236325, 75000, 'Ana', 'Simic', '1975-06-15', '2013-12-02', 10, 'Ekonomska struka', NULL, NULL, NULL, 1, '2030-08-17', 'Nadredjeni', 1, 1, 1, NULL, NULL, 1506975236325, NULL, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1501998177837, 50000, 'Nikola', 'Jankovic', '1998-01-15', '2020-10-09', 3, 'Tehnicka struka', '2022-11-06', 'Mehanicar', 'Tehnicka skola 15. maj', NULL, NULL, 'Podredjeni', 0, 0, 0, 'Po ugovoru', '2024-11-22', 0702992632111, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1901993850763, 55000, 'Ivana', 'Nikolic', '1993-01-19', '2019-02-18', 4, 'Ekonomska struka', NULL, NULL, NULL, 1, '2024-03-13', 'Podredjeni', 0, 0, 0, 'Stalno', NULL, 1807987542331, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(0803994658751, 35000, 'Milica', 'Jovic', '1994-03-08', '2022-03-28', 1, 'Tehnicka struka', NULL, NULL, NULL, NULL, NULL, 'Podredjeni', 0, 0, 0, 'Po ugovoru', '2025-07-17', 2312984715494, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1112996293488, 35000, 'Luka', 'Djordjevic', '1996-12-11', '2022-02-23', 1, 'Tehnicka struka', NULL, NULL, NULL, NULL, NULL, 'Podredjeni', 0, 0, 0, 'Stalno', NULL, 0601996379936, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(2710994407317, 40000, 'Maja', 'Lukic', '1994-10-27', '2021-09-17', 2, 'Ekonomska struka', NULL, NULL, NULL, 0, NULL, 'Podredjeni', 0, 0, 0, 'Po ugovoru', '2025-04-03', 1807987542331, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1109978234313, 75000, 'Mihajlo', 'Probojcevic', '1978-09-11', '2015-11-08', 8, 'Tehnicka struka', '2017-02-14', 'Masinski inzenjer', 'Masinski fakultet', NULL, NULL, 'Nadredjeni', 1, 1, 1, NULL, NULL, 1109978234313, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(0202990236325, 70000, 'Jasmina', 'Ilic', '1990-02-02', '2019-12-02', 4, 'Ekonomska struka', NULL, NULL, NULL, 1, '2026-05-12', 'Nadredjeni', 0, 1, 0, NULL, NULL, 1506975236325, NULL, NULL);

INSERT INTO ZAPOSLENI
VALUES
(1203988436388, 70000, 'Jovan', 'Cekic', '1988-03-12', '2018-12-02', 5, 'Tehnicka struka', '2018-02-14', 'Masinski inzenjer', 'Masinski fakultet', NULL, NULL, 'Nadredjeni', 0, 1, 0, NULL, NULL, 1109978234313, NULL, NULL);



INSERT INTO ZAPOSLENI
VALUES
(2311984437657, 40000, 'Momir', 'Ilic', '1984-11-23', '2020-09-20', 2, 'Ekonomska struka', NULL, NULL, NULL, 0, NULL, 'Podredjeni', 0, 0, 0, 'Po ugovoru', '2025-06-17', 1807987542331, NULL,NULL);



UPDATE ZAPOSLENI SET "Id_Ovlascenog_Servisa" = 0  WHERE "Maticni_Broj" = 702992632111;
UPDATE ZAPOSLENI SET "Id_Ovlascenog_Servisa" = 0  WHERE "Maticni_Broj" = 1501998177837;
UPDATE ZAPOSLENI SET "Id_Ovlascenog_Servisa" = 6  WHERE "Maticni_Broj" = 2312984715494;
UPDATE ZAPOSLENI SET "Id_Ovlascenog_Servisa" = 6  WHERE "Maticni_Broj" = 0803994658751;
UPDATE ZAPOSLENI SET "Id_Ovlascenog_Servisa" = 4  WHERE "Maticni_Broj" = 0601996379936;
UPDATE ZAPOSLENI SET "Id_Ovlascenog_Servisa" = 4  WHERE "Maticni_Broj" = 1112996293488;
UPDATE ZAPOSLENI SET "Id_Salona" = 1  WHERE "Maticni_Broj" = 1807987542331;
UPDATE ZAPOSLENI SET "Id_Salona" = 1  WHERE "Maticni_Broj" = 1901993850763;
UPDATE ZAPOSLENI SET "Id_Salona" = 3  WHERE "Maticni_Broj" = 1506975236325;
UPDATE ZAPOSLENI SET "Id_Salona" = 1  WHERE "Maticni_Broj" = 2710994407317;







ALTER TABLE ZAPOSLENI MODIFY "Mat_Br_Rukovodioca" NULL;
ALTER TABLE ZAPOSLENI MODIFY "Datum_Rodjenja" NULL;
ALTER TABLE ZAPOSLENI MODIFY "Datum_Zaposlenja" NULL;
ALTER TABLE PREDSTAVNISTVO MODIFY "Maticni_Broj_Direktora" NULL;
ALTER TABLE OVLASCENI_SERVIS MODIFY "Maticni_Broj_Sefa" NULL;
ALTER TABLE OVLASCENI_SERVIS MODIFY "ID_Predstavnistva" NULL;