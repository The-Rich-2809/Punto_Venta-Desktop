
Create DataBase TiendaAbarrotes 
Go

Use TiendaAbarrotes 
Go

Set Nocount on 
Go

--Creacion de la tabla empleado --
CREATE TABLE EMPLEADO
(IdEmpleado INT PRIMARY KEY NOT NULL,
Usuario NVARCHAR (20) NOT NULL,
Contrasena  VARBINARY(20) NOT NULL,
Nivel_Empleado INT NOT NULL,
Correo NVARCHAR (100) NOT NULL,
NOMBRE NVARCHAR (15) NOT NULL,
PRIMERAPELLIDO NVARCHAR (15) NOT NULL,
SEGUNDOAPELLIDO NVARCHAR (15) NOT NULL,
FECHA_NACIMIENTO DATE NOT NULL,
RFC NVARCHAR (15) NOT NULL,
TELEFONO NVARCHAR (12) NOT NULL,
CALLE NVARCHAR (20) NOT NULL,
NEXTERIOR INT NOT NULL,
CodPOSTAL INT NOT NULL,
CIUDAD NVARCHAR (15) NOT NULL,
ENTIDAD NVARCHAR (20) NOT NULL,
FECHACONTRA DATE NOT NULL,
SUELDO MONEY NOT NULL) 
Go

Insert Into EMPLEADO Values 
(0, LOWER('juan'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066','Juan','Prado','Albino','2004/12/28','NVA135745','55:1354:7844','Paco Alcachofa',12,09800,'Vegas','Guanajuato','2022/11/29',100000),
(1, LOWER('paco'),HASHBYTES('SHA1',N'bonafont14'),0,'jnava6066','Juan','Prado','Albino','2004/12/28','NVA135745','55:1354:7844','Paco Alcachofa',12,09800,'Vegas','Guanajuato','2022/11/29',100000),
(110, LOWER('Pablo'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066','Pablo','Mencho','Ruiz','2012/04/21','MERP9803216R3','55:3459:2854','Calzada de la virgen',002,04480,'CDMX','CDMX','2022/11/29',8000),
(120, LOWER('Solovino'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066','Solovino','Galvan','Rodriguez','2013/03/20','ROGS0003215610','56:3165:7654','Escuadron 201',45,09060,'CDMX','CDMX','2022/11/29',3000),
(130, LOWER('Luis'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Luis','Garcia','Sanchez','2014/11/01','GASL970604UI2','55:9082:8741','Viaducto rio',98,09010,'CDMX','CDMX','2022/11/29',4000),
(140, LOWER('Juana'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Juana','Albino','Nava','2015/05/21','AINJ020109P85','55:3559:0816','Avenida rio mayor',21,01269,'CDMX','CDMX','2022/11/29',8000),
(150, LOWER('Jose'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Jose','Padilla','Torres','2012/07/11','PAT0402073G2','55:9588:2784','Ferrocarril rio frio',08,01299,'CDMX','CDMX','2022/11/29',5000),
(160, LOWER('Manuel'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Manuel','Mendez','Garnica','2012/08/29','MEGM0408028G7','55:1963:2666','San rafael atlixco',640,01700,'CDMX','CDMX','2022/11/29',7000),
(170, LOWER('Jesus'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Jesus','Prado','Ruiz','2017/07/21','PARJ0411308P8','55:2211:0909','Portal churubusco',321,01120,'CDMX','CDMX','2022/11/29',2000),
(180, LOWER('Claudia'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Claudia','Ortigoza','Santiago','2017/07/21','OISC040115AJ0','55:2345:6789','avenida rio altar',222,01110,'CDMX','CDMX','2022/11/29',4000),
(190, LOWER('Salvador'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Salvador','Juarez','Alvarado','2017/07/21','AAJS870701HW5','55:2005:2120','Sur 171',256,01760,'CDMX','CDMX','2022/11/29',4000),
(200, LOWER('Juan'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Juan','Diaz','Mendez','2017/07/21','MEDJ910329B14','55:7649:9088','Canal de tezontle',897,01820,'CDMX','CDMX','2022/11/29',4000),
(210, LOWER('Sebastian'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Sebastian','Melendez','Perez','2016/09/15','PEMS040120QM10','55:0989:2091','Playa olas altas',641,03400,'CDMX','CDMX','2022/11/29',6000),
(220, LOWER('Eric'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Eric','Ronquillo','Rosas','2016/12/31','RORE850830787','55:8835:4894','Elvira',141,03610,'CDMX','CDMX','2022/11/29',1000),
(230, LOWER('Victor'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Victor','Torres','Padilla','2014/12/21','TOPV850502RJ5','55:6024:1933','Bertha',22,03650,'CDMX','CDMX','2022/11/29',5000),
(240, LOWER('Alysson'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Alysson','Diaz','Juarez','2017/02/11','DIJA040612C46','55:2093:6740','Maria',10,04938,'CDMX','CDMX','2022/11/29',3000),
(250, LOWER('Anisa'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Anisa','Torres','Ruiz','2017/08/16','RUTA900509QCA','55:3670:0674','C.elena',09,04370,'CDMX','CDMX','2022/11/29',6000),
(260, LOWER('Cristian'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Cristian','Mata','Tello','2017/01/15','MATC890211KI5','55:4709:3095','Guipuzcoa',12,04890,'CDMX','CDMX','2022/11/29',1000),
(270, LOWER('Daniela'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Daniela','Mendoza','Ruiz','2017/09/14','MERD990312Q25','55:6502:4942','Luz saviñon',78,09230,'CDMX','CDMX','2022/11/29',3000),
(280, LOWER('Monica'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Monica','Cruz','Malagon','2022/02/17','MACM031207767','55:2284:1477','C.palenque',982,09479,'CDMX','CDMX','2022/11/29',6000),
(290, LOWER('Natalia'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Natalia','Ruiz','Solano','2020/08/19','RUSN881101747','55:1365:5059','Avenida universidad',1611,09450,'CDMX','CDMX','2022/11/29',4000),
(300, LOWER('Renata'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Renata','Naranjo','Mendez','2019/11/13','NAMR9907294B5','55:2710:8626','Enrique rebsamen',981,09230,'CDMX','CDMX','2022/11/29',4000),
(310, LOWER('Hugo'),HASHBYTES('SHA1',N'bonafont13'),1,'jnava6066', 'Hugo','Hernandez','Gonzales','2020/12/12','HEGH990703J10','55:3213:1515','Nicolas San Juan',1891,09089,'CDMX','CDMX','2022/11/29',2000) 
Go

CREATE TABLE Rol
(IdRol INT PRIMARY KEY,
Identificador NVARCHAR(20),
Descripcion NVARCHAR(40)) 
Go

INSERT INTO Rol VALUES
(1,'Administración', 'Control completo sobre la configuración'),
(0,'Empleado', 'Empleado final') 
Go

CREATE TABLE PROVEEDORES
(CVEPROVEEDOR INT PRIMARY KEY NOT NULL,
NOMBRE_EMPRESA NVARCHAR (30) NOT NULL,
NOMBRE_ENCARGADO TEXT NOT NULL,
TELEFONO VARCHAR (15) NOT NULL,
FECHA_VISITA VARCHAR (11) NOT NULL,
FECHA_ENTREGA VARCHAR(11) NOT NULL) 
Go

Insert Into PROVEEDORES Values
(1100,'Gamesa','Juan','55:4702:1234','Sabado','Lunes'),
(1200,'Sabritas','Alberto','56:3245:0111','Miercoles','Jueves'),
(1400,'Coca Cola','Victor','56:8899:3612','Viernes','Jueves'),
(1500,'Pepsi','Eduardo','55:0131:7547','Lunes','Martes'),
(1600,'Bonafont','Gabriel','55:5123:9580','Miercoles','Jueves'),
(1700,'Epura','Ivan','55:5356:9228','Domingo','Sabado'),
(1800,'Boing','Israel','55:8530:5898','Viernes','Martes'),
(1900,'Bimbo','Diego','55:1892:1419','Lunes','Miercoles'),
(2000,'Bubbaloo','Rodrigo','55:4924:4477','Domingo','Martes'),
(2100,'Moderna','Javier','55:6685:9727','Martes','Jueves'),
(2200,'Ricolino','Fernanda','55:5763:7520','Viernes','Sabado'),
(2300,'La Costeña','Fernando','55:6396:5453','Sabado','Lunes'),
(2400,'Tia rosa','Gabriela','55:5420:0756','Lunes','Jueves'),
(2500,'Tecate','Ibrahim','55:7883:1885','Martes','Miercoles'),
(2600,'Corona','Octavio','55:2146:7897','Domingo','Lunes'),
(2700,'Axe','Ricardo','56:3613:5550','Sabado','Lunes'),
(2800,'Barcel','Aldo','55:7963:5363','Lunes','Viernes'),
(2900,'Palmolive','Jonathan','56:0760:1497','Miercoles','Lunes'),
(3000,'Volcanes','Naivi','55:3145:6555','Lunes','Jueves'),
(3100,'Philadelphia','Vidalina','56:0581:9541','Lunes','Jueves'),
(3200,'Suavitel','Daniel','56:0145:8236','Miercoles','Lunes') 
Go 

CREATE TABLE PRODUCTO
(IdPRODUCTO BigInt Primary KEY NOT NULL,
EMPRESA NVARCHAR (30) NOT NULL,
NOMBRE NVARCHAR (25) NOT NULL,
DESCRIPCION TEXT NOT NULL,
PRECIO MONEY NOT NULL,
COSTO MONEY NOT NULL,
EXISTENCIA INT NOT NULL) 
Go

Insert Into PRODUCTO Values
('7501011101456','Sabritas','Papas Naturales','Botana',15,10,5),
('7501011111028','Sabritas','Rancheritos','Botana',12,10,5),
('7501011114623','Sabritas','Paquetaxo Azul','Botana',16,10,5),
('7501011143753','Sabritas','Chetos Flamin Hot','Botana',12,10,6),
('744886345052','Jarritos','Jarrito Toronja','Refresco 2L',25,10,3),
('744886318827','Jarritos','Jarrito Tutifruti','Refresco 600ml',13,10,5),
('7501055305629','Coca-Cola','Sprite','Refresco 600ml',15,10,5),
('7501055303779','Coca-Cola','Fanta','Refresco 600ml',15,10,5),
('7501055339983','Coca-Cola','Mundet Manzana','Refresco 600ml',15,10,5),
('75004699','Coca-Cola','Coca-Cola','Refresco 500ml',13,10,105),
('7501030427193','Marinela','Barritas Fresa','Galleta',15,10,5),
('7501000112845','Bimbo','Rebanadas Vainilla','Pan',10,10,6),
('7501000112784','Bimbo','Nito','Pan',10,10,7),
('7501000658923','Gamesa','Marias','Galletas',15,10,10),
('7500478013654','Gamesa','Emperador Vainilla','Galletas',16,10,5),
('7501030418399','Bimbo','Donitas Espolvoreadas','Pan',20,10,5),
('041789001918','Maruchan','Sopa Pollo','Sopa Instantanea',15,10,10),
('7501018310523','La Moderna','Sopa Codo 2','Sopa',7,10,15),
('7500810000465','Barcel','Takis Morados','Botana',15,10,10)
Go

CREATE TABLE VENTAS
(IdVENTA INT PRIMARY KEY NOT NULL,
IMPORTE MONEY NOT NULL,
FECHA DATE NOT NULL,
CVEEMPLEADO INT NOT NULL)
Go