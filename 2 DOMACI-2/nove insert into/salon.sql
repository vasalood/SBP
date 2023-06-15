--SALON PRVOG PREDSTAVNISTVA
INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Cvijiceva 2', 'Salon automobila', 1807987542331, 1);

--SALON DRUGOG PREDSTAVNISTVA
INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Milankoviceva 4', 'Auto salon', 1807987333331, 2);

--SALON CETVRTOG PREDSTAVNISTVA
INSERT INTO SALON
("Lokacija", "Ime", "Maticni_Broj_Sefa", "Id_Predstavnistva")
VALUES
('Djokoviceva 15', 'Automobili', 1844444542331, 4);


ALTER TABLE ZAPOSLENI DROP CONSTRAINT "FK_OVLASCENI_SERVIS";
ALTER TABLE ZAPOSLENI DROP CONSTRAINT "FK_SALON";