create database ProyectoMAD
go

IF OBJECT_ID('ProyectoMAD') IS NOT NULL
BEGIN
   DROP DATABASE ProyectoMAD;
END
use ProyectoMAD
go
IF OBJECT_ID('Usuario') IS NOT NULL
BEGIN
   DROP TABLE Usuario;
END



CREATE TABLE Usuario 
(
   idUser INT IDENTITY (1, 1) NOT NULL,
   nombreU  VARCHAR (30) NOT NULL,
   apellidoPU VARCHAR (30) NOT NULL,
   apellidoMU VARCHAR (30) NOT NULL,
   claveUsuario varchar(50) not null,
   contraU VARCHAR (30) NOT NULL,
   tipoU varchar(1)  not null,
   CONSTRAINT PK_user 
   PRIMARY KEY (idUser)
);

go
alter table Usuario
ADD UNIQUE (ClaveUsuario)
go
IF OBJECT_ID('Administrador') IS NOT NULL
BEGIN
   DROP TABLE Administrador;
END
go
--puto si no te jalaa
CREATE TABLE Administrador
(
   idAdmin INT IDENTITY (1, 1) NOT NULL,
   idUserA  INT not NULL,
   CONSTRAINT PK_admin
   PRIMARY KEY (idAdmin), 
   CONSTRAINT FK_idUser
   FOREIGN KEY (idUserA) 
   REFERENCES Usuario (idUser)
);

IF OBJECT_ID('Cajero') IS NOT NULL
BEGIN
   DROP TABLE Cajero;
END

CREATE TABLE Cajero
(
   idCajero INT Identity(2,1)  NOT NULL,
   CURP CHAR (18) NOT NULL,
   fechaNaci DATE NOT NULL,
   numeroNomi INT NOT NULL,
   email VARCHAR (25) NOT NULL,
   fechaIngr DATE NOT NULL,
   uniVend INT,
   ventas INT,
   claveAdmin INT NOT NULL,
   --claveUser INT NOT NULL,
   CONSTRAINT PK_Cajero
   PRIMARY KEY (idCajero),

   CONSTRAINT FK_claveAdmin
   FOREIGN KEY (claveAdmin)
   REFERENCES Administrador (idAdmin),

   --CONSTRAINT FK_claveUser
   --FOREIGN KEY (claveUser)
   --REFERENCES Usuario (idUser),
   --Constraint
   CONSTRAINT CK_uniVend
   CHECK (-1 <= uniVend),
   CONSTRAINT CK_ventas
   CHECK (-1 <= ventas)
);
go

IF OBJECT_ID('Producto') IS NOT NULL
BEGIN
   DROP TABLE Producto;
END
go
CREATE TABLE Producto
(
    idProduct INT NOT NULL,
	nombrePro VARCHAR (30) NOT NULL,
	descripcion VARCHAR (60) NOT NULL,
	uniMedida INT NOT NULL,
	fechaAlta DATE NOT NULL,
	existencia INT NOT NULL,
	ptReorden INT NOT NULL,
	claveGest INT NOT NULL, 
	activo varchar(30),
	merma INT default 0,
	Costo decimal(10,2) not null,
	PrecioUnitario decimal(10,2) not null,
	uniVendida INT default 0,
	claveAdmin INT NOT NULL, 
	claveDepa INT NOT NULL,
	--claveDesc INT NOT NULL,
	--clavePre INT NOT NULL,   
	idDesc int null,
	fechaDesc DATE,
	FechaCambio date null,
	CONSTRAINT PK_idProd
	PRIMARY KEY (idProduct),
	CONSTRAINT CK_activo
	CHECK (activo = 'Activo' OR activo = 'Inactivo'),
	CONSTRAINT FK_claveUserPro
    FOREIGN KEY (claveAdmin)
    REFERENCES Administrador (idAdmin)
)

  --merma default 0 dios plan polan

go


IF OBJECT_ID('uniMedidaPro') IS NOT NULL
BEGIN
   DROP TABLE uniMedidaPro;
END
go

CREATE TABLE uniMedidaPro
(
   idMedida INT IDENTITY (0,1) NOT NULL,
   unidadMedida VARCHAR (70)
   CONSTRAINT PK_idMedida
   PRIMARY KEY (idMedida)
);

go
ALTER TABLE Producto
  ADD CONSTRAINT FK_idMedida
  FOREIGN KEY (uniMedida)
  REFERENCES uniMedidaPro (idMedida);

go

IF OBJECT_ID('Caja') IS NOT NULL
BEGIN
   DROP TABLE Caja;
END
go
CREATE TABLE Caja
(
   idCaja INT NOT NULL,
   disponi varchar(20),
   claveAdminCa INT NOT NULL,
   CONSTRAINT PK_idCaja
   PRIMARY KEY (idCaja),
   CONSTRAINT FK_claveAdminCa
   FOREIGN KEY (claveAdminCa)
   REFERENCES Administrador (idAdmin),
   CONSTRAINT CK_disponi
   CHECK (disponi = 'Activo' OR disponi = 'Inactivo')
);
go
IF OBJECT_ID('Recibo') IS NOT NULL
BEGIN
   DROP TABLE Recibo;
END
go
CREATE TABLE Recibo
(
   noVenta INT IDENTITY (10000, 1) NOT NULL,
   fechaVenta DATE NOT NULL,
   total Money NOT NULL,
   claveCajePro INT NOT NULL,
   MontoPago Money null,
   CONSTRAINT PK_noVenta
   PRIMARY KEY (noVenta),
   CONSTRAINT CK_total
   CHECK (0 <= total)
);

go
IF OBJECT_ID('VentaDetalle') IS NOT NULL
BEGIN
   DROP TABLE VentaDetalle;
END
go
create table VentaDetalle
(
  idVentaDetalle int identity(0,1) not null,
  noDeVenta int not null,
  CodProducto int not null,
  DepartamentoId int not null,
  UnidadesVendidas int not null,
  Subtotal money not null,
  DescuentoId int null,
  PrecioUnitario money not null,
  Utilidad money not null, 
  totalVenta money not null,
  Constraint Pk_VentaDetail
  Primary key(idVentaDetalle),
  Constraint FK_noDeVenta
  Foreign key (noDeVenta)
  references Recibo(noVenta),
  Constraint FK_noProd
  Foreign key (CodProducto)
  references Producto(idProduct)
);

go
IF OBJECT_ID('NotaCred') IS NOT NULL
BEGIN
   DROP TABLE NotaCred;
END
go
CREATE TABLE NotaCred
(
   noCredit INT IDENTITY (10000, 1) NOT NULL,
   total decimal(10,2) NOT NULL,
   numeroRecibo INT NOT NULL, 
   fechaNota DATE NOT NULL,
   claveAdminNota INT NOT NULL,
   CONSTRAINT PK_noCredit
   PRIMARY KEY (noCredit),
   CONSTRAINT FK_claveAdminNota
   FOREIGN KEY (claveAdminNota)
   REFERENCES Administrador (idAdmin),
   CONSTRAINT FK_idVenta
   FOREIGN KEY (numeroRecibo)
   REFERENCES Recibo (noVenta)
);

go
IF OBJECT_ID('Departamento') IS NOT NULL
BEGIN
   DROP TABLE Departamento;
END
go
CREATE TABLE Departamento
(
   idDepa INT NOT NULL,
   nombreDep VARCHAR (30) NOT NULL,
   devoluDepa varchar(10) not null,
   claveAdminDepa INT NULL,
   CONSTRAINT PK_idDepa
   PRIMARY KEY (idDepa),
   CHECK ('No' = devoluDepa OR 'Si' = devoluDepa)
);
go
ALTER TABLE Producto
  ADD CONSTRAINT FK_claveDepa
  FOREIGN KEY (claveDepa)
  REFERENCES Departamento (idDepa);
go

ALTER TABLE VentaDetalle
  ADD CONSTRAINT FK_noDeDepa
  FOREIGN KEY (DepartamentoId)
  REFERENCES Departamento(idDepa);

go

IF OBJECT_ID('MetodPago') IS NOT NULL
BEGIN
   DROP TABLE MetodPago;
END
go
CREATE TABLE MetodPago
(
   idPago INT IDENTITY (0, 1) NOT NULL,
   tipoMetod VARCHAR (30) NOT NULL,
   CONSTRAINT PK_idPago
   PRIMARY KEY (idPago),
);
go
IF OBJECT_ID('Descuento') IS NOT NULL
BEGIN
   DROP TABLE Descuento;
END
go

IF OBJECT_ID('descFecha') IS NOT NULL
BEGIN
   DROP TABLE descFecha;
END
go
CREATE TABLE descFecha
(
   idFechaDesc INT IDENTITY (1, 1) NOT NULL,
   fechaIni DATE NOT NULL,
   fechaFin DATE NOT NULL,
   CONSTRAINT PK_idFechaDesc
   PRIMARY KEY (idFechaDesc)
);
go

CREATE TABLE Descuento
(
   idDesc INT IDENTITY (1, 1) NOT NULL,
   cantidad INT NOT NULL,
   claveFechaD INT default(1) NULL, 
   CONSTRAINT PK_idDesc
   PRIMARY KEY (idDesc),
   CONSTRAINT CK_cantidad
   CHECK (0 < cantidad),
   CONSTRAINT FK_claveFechaD
   FOREIGN KEY (claveFechaD)
   REFERENCES descFecha (idFechaDesc)
);
go

  go
IF OBJECT_ID('Caje_Pro') IS NOT NULL
BEGIN
   DROP TABLE Caje_Pro;
END
go
Create TABLE Caje_Pro
(
   idCajePro INT IDENTITY (0, 1) NOT NULL,
   claveCajeroCP INT NOT NULL,
   --codigoProCP INT NOT NULL,
   noCajaCP INT NOT NULL,
   CONSTRAINT PK_idCajePro
   PRIMARY KEY (idCajePro),
   CONSTRAINT FK_claveCajeroCP
   FOREIGN KEY (claveCajeroCP)
   REFERENCES Cajero (idCajero),
   --CONSTRAINT FK_codigoProCP
   --FOREIGN KEY (codigoProCP)
   --REFERENCES Producto (idProduct),
   CONSTRAINT FK_noCajaCP
   FOREIGN KEY (noCajaCP)
   REFERENCES Caja (idCaja),
   --CONSTRAINT CK_activoCP
   --CHECK (activoCP = 'Activo' OR activoCP = 'Inactivo')
);
go 
--alter table Caje_Pro
-- drop column existenciaCP

--ALTER TABLE Recibo
--  ADD CONSTRAINT FK_claveCajePro
--  FOREIGN KEY (claveCajePro)
--  REFERENCES Caje_Pro (idCajePro);
go
IF OBJECT_ID('ticket') IS NOT NULL
BEGIN
   DROP TABLE ticket;
END
go

CREATE TABLE ticket
(
   idTicket INT IDENTITY (10000, 1) NOT NULL,
   noVentaTic INT NOT NULL,
   clavePagoTic INT NOT NULL,
   montoPago money not null,
   CONSTRAINT PK_idTicket
   PRIMARY KEY (idTicket),
   CONSTRAINT FK_noVentaTic
   FOREIGN KEY (noVentaTic)
   REFERENCES Recibo (noVenta),
   CONSTRAINT FK_clavePagoTic
   FOREIGN KEY (clavePagoTic)
   REFERENCES MetodPago (idPago)
);
go

IF OBJECT_ID('devolucion') IS NOT NULL
BEGIN
   DROP TABLE devolucion;
END
go
CREATE TABLE devolucion
(
   idDev INT IDENTITY (0, 1) NOT NULL,
   noCredDev INT NOT NULL,
   codigoProDev INT NOT NULL,
   devCant INT NOT NULL,
   subtotalDev money NOT NULL,
   motivo varchar(300) NOT NULL,
   CONSTRAINT PK_idDev
   PRIMARY KEY (idDev),
   CONSTRAINT FK_noCredDev
   FOREIGN KEY (noCredDev)
   REFERENCES NotaCred (noCredit),
   CONSTRAINT FK_codigoProDev
   FOREIGN KEY (codigoProDev)
   REFERENCES Producto (idProduct)
);
ALTER TABLE devolucion
  Add NombreProd varchar(50) null


ALTER TABLE Producto
  ADD CONSTRAINT FK_idDesc 
  FOREIGN KEY (idDesc)
  REFERENCES Descuento (idDesc);
go

create table VentaTemporal
(
  idVentaTemp int identity (0,1) not null,
  CodigoProducto int not null,
  NombreProducto varchar(50) not null,
  ExistenciaProducto varchar(200) not null,
  PrecioUnitario money not null,
  FechaVenta date null,
  Caja int null,
  CantidadAllevar int not null,
  idDescuento int null,
  subTotal money null,
  Constraint FK_IdDescProdTemp
  Foreign key (idDescuento)
  References Descuento(idDesc)
);
go

create table DevolucionTemporal
(
  idDevTemp int identity (0,1) not null,
  numeroRecibo int not null,
  Fecha date not null,
  NombreProd varchar(50) null,
  CodProd int not null,
  cantDevuelta int not null,
  subTotalDevuelto decimal(10,2) not null,
  Motivo varchar(300) null,
  merma int null
);

--noCredDev INT NOT NULL,
--   codigoProDev INT NOT NULL,
--   devCant INT NOT NULL,
--   subtotalDev money NOT NULL,
--   motivo varchar(300) NOT NULL,

--total decimal(10,2) NOT NULL,
--   numeroRecibo INT NOT NULL, 
--   fechaNota DATE NOT NULL,
--   claveAdminNota INT NOT NULL,
