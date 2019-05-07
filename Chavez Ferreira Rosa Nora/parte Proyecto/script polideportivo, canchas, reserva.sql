use dbCancha
SELECT * FROM tblCancha
SELECT * FROM tblReserva
select * from tblCliente
SELECT * FROM tblPoliDeportivo
SELECT * FROM tblPersonal

--INSERT INTO tblPersona VALUES (24,'José Manuel', 'Vázquez Lorenzo', 1, '1978/11/19', '7276211', 'manuel_vázquez19', 'XYOG4FS0Q');
--INSERT INTO tblPersona VALUES (25,'Josefina', 'Ramos Montero', 0, '1993/07/06', '5574775', 'josefina_ramos06', 'QDRL0FU0E');

--INSERT INTO tblPersonal VALUES (1, 24, 'Recepcionista', 0, 'Av. Mutualista, C/Los Cocos');
--INSERT INTO tblPersonal VALUES (2, 25, 'Cobrador', 0, 'Av. Virgen de Lujan, B/Tarechis');

--INSERT INTO tblCliente VALUES (1,1,'34895147', 570);
--INSERT INTO tblCliente VALUES (2,2,'89745214', 201);
--INSERT INTO tblCliente VALUES (3,3,'35748914', 451);

USE dbCancha
INSERT  INTO tblPoliDeportivo VALUES (1,'SANTA ROSITA', '4TO ANILLO, AV, PARAGUA, CALLE PAJARITO ', 3922334,0)
INSERT INTO tblPoliDeportivo VALUES (2, 'VILLA 1ERO DE MAYO', 'AV. CUMAVI, RADIAL 8', 32920172,0)
INSERT INTO  tblPoliDeportivo VALUES (3,'POLIDEPORTIVO UAGRM','AV. BUSCH # 980', 78312344,0)
INSERT INTO tblPoliDeportivo VALUES (4,'LA GAMBETA','AV. 18 DE MARZO 12',60912346,1)
INSERT INTO tblPoliDeportivo VALUES (5,'LOS POCITOS','5TO ANILLO, AV. BENI',75566998,1)


INSERT INTO tblCancha VALUES (1,1,'1123', 'cancha 1','soccer 7', '14',68,45,250,270,'https://maps.app.goo.gl/Pcj2cDNTqtQQBc6L8')
INSERT INTO tblCancha VALUES (2,1,'1123', 'cancha 2','soccer 7', '14',68,45,250,270,'https://goo.gl/maps/tKz75YhKxrdNcpmt7')
INSERT INTO tblCancha VALUES (3,2,'1121', 'cancha 3','BASKET', '10',28,15,180,200,'https://goo.gl/maps/tKz75YhKxrdNcpmt7')
INSERT INTO tblCancha VALUES (4,5,'1108', 'cancha 4','VOLEYBOL', '12',18,9,200,220,'https://goo.gl/maps/tKz75YhKxrdNcpmt7')


INSERT INTO tblReserva VALUES (1,2,2,2,'2018-04-28','17:00:0','19:00:0',2,250,2);
INSERT INTO tblReserva VALUES (2,3,2,2,'2018-04-28','12:00:0','14:00:0',2,250,3);
