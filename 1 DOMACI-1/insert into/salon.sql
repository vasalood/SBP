INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Cvijiceva 2', 'Salon automobila', 2312984715494, 1);

INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Milankoviceva 4', 'Auto salon', 2312984715494, 1);

INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Djokoviceva 15', 'Automobili', 1109978234313, 3);

INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Nebojsina 85', 'Salon vozila', 1109978234313, 3);

INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Predragova 15', 'Automoto salon', 1109978234313, 2);

INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Milutinova 14', 'Salon vozila', 1109978234313, 4);

INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Jovanova 46', 'Auto salon vozila', 1109978234313, 4);



ALTER TABLE ZAPOSLENI DROP CONSTRAINT "FK_OVLASCENI_SERVIS";
ALTER TABLE ZAPOSLENI DROP CONSTRAINT "FK_SALON";