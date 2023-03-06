use ProyectoMAD
go
create proc SelectUsuarios
(
@ClaveU varchar(50),
@Contraseña varchar(50),
@TipoU varchar(1) 
)
as
begin
select Usuario.idUser as NumeroIdentificacion, Usuario.nombreU [Nombre], Usuario.contraU [Contraseña], Usuario.tipoU, claveUsuario [Clave de Usuario] from Usuario
where claveUsuario = @ClaveU and contraU = @Contraseña and tipoU = @TipoU
end;
go
--IF OBJECT_ID('SelectUsuarios') IS NOT NULL
--BEGIN
--   DROP PROC SelectUsuarios;
--END

go

Create procedure ObtenerAdministradores --Obtiene las credenciales del Administrador
(
@ClaveU varchar(50),
@Contra varchar(50),
@TipoU int
)
as
Begin
select  A.idAdmin , B.idUser, B.nombreU, B.claveUsuario, B.contraU, B.tipoU  from Usuario B
join Administrador A
on a.idUserA = b.idUser
where A.idUserA = B.idUser and b.claveUsuario = @ClaveU and b.contraU = @Contra and b.tipoU = @TipoU
end;

go

create procedure sp_InsertarEmpleado
(
@Nombre varchar(30),
@ApellidoP varchar(50),
@ApellidoM varchar(50),
@FechaNac date,
@NumeroNomina int,
@Email varchar(25),
@CURP char(18),
@FechaIngreso date,
@ClaveUsuario varchar(30),
@Contraseña varchar(30)
)
as
Begin
--Usuario
insert into Usuario(claveUsuario, contraU, nombreU, apellidoPU, apellidoMU,tipoU)
values(@ClaveUsuario, @Contraseña, @Nombre, @ApellidoP, @ApellidoM, '0')
--Cajero
insert into Cajero(fechaNaci, fechaIngr, numeroNomi, email, CURP, claveAdmin)
values(@FechaNac, @FechaIngreso, @NumeroNomina, @Email, @CURP, 1)
end;

go

Create proc ListarEmpleados
as
Begin
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contraseña], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser
end;

go

create proc ActualizarEmpleados
(
@Id int,
@Nombre varchar(30),
@ApellidoP varchar(30),
@ApellidoM varchar(30),
@ClaveU varchar(30),
@Contra varchar(30),
@Correo varchar(30),
@FechaNac date,
@FechaIng date,
@Curp char(18),
@Nomina int
)
as
Begin
Update Usuario set nombreU = @Nombre, apellidoPU = @ApellidoP, apellidoMU = @ApellidoM, claveUsuario = @ClaveU, contraU = @Contra
where idUser = @Id
update Cajero set CURP = @Curp, fechaNaci = @FechaNac, fechaIngr = @FechaIng, email = @Correo, numeroNomi = @Nomina
where idCajero = @Id
end;

go

create proc BorrarEmpleados
(
@id int
)
as
Begin
delete Cajero where idCajero = @id
delete Usuario where idUser = @id
end;

go

create proc InsertarDepartamentos
(
@NombreDepa varchar(50),
@IdDepa int,
@Devolucion varchar(10),
@IdAdmin int
)
as 
Begin

insert into Departamento(departamento.idDepa, nombreDep, devoluDepa, claveAdminDepa)
values(@IdDepa, @NombreDepa, @Devolucion, @IdAdmin)
end;

go

create proc ActualizarDepartamentos
(
@Nombre varchar(30),
@Devolucion varchar(10),
@IdDepa int
)
as
Begin
Update Departamento set nombreDep = @Nombre, devoluDepa = @Devolucion, claveAdminDepa = '1'
where idDepa = @IdDepa
end;

go

create proc BorrarDepartamentos
(@IdCaja int
)
as
Begin
delete Departamento where idDepa = @IdCaja;
end;

go

create proc LeerDepartamentos
as
Begin
select Departamento.idDepa [Id Departamento], Departamento.nombreDep [Departamento], Departamento.devoluDepa [Devolucion], claveAdminDepa [Usuario Cambio]
from Departamento
end;

go

create proc CrearCajas
(@Id int,
@Disponibilidad varchar(20)
)
as
Begin	
Insert into Caja(idCaja, disponi, claveAdminCa)
values(@Id, @Disponibilidad, 1) 
end;

go

Create proc EditarCajas
(
@Id int, @Disponibilidad varchar(20)
)
as
Begin
update Caja set disponi = @Disponibilidad where idCaja = @Id
end;

go

create proc bajaCajas
(@idC int)
as
Begin
delete Caja where idCaja = @idC
end;

go

create proc ListarCaja
as
Begin
select idCaja[Numero de Caja], disponi[Disponibilidad] from Caja
end;

go

create proc ListarCajaCombo
as
Begin
select idCaja[Numero de Caja] from Caja where disponi = 'Activo'
end;

go

create proc ListarProductos
as
Begin
select A.idProduct [Codigo], A.nombrePro [Nombre Producto], A.descripcion [Descripción], A.PrecioUnitario [Precio Unitario], A.Costo [Costo],
A.activo [Activo], A.claveAdmin [Gestor], B.nombreDep [Departamento], A.existencia [Stock], A.fechaAlta [Fecha de Alta],
A.FechaCambio [Fecha de Actualizacion], A.ptReorden [Punto de Reorden], E.unidadMedida [Unidad de Medida], A.uniVendida [Cantidades Vendidas], c.claveUsuario [Usuario], D.idDesc [Id descuento] from Producto A
join Departamento B
on B.idDepa = A.claveDepa
join Usuario C
ON c.idUser = a.claveAdmin
left join Descuento D
ON D.idDesc = A.idDesc
join uniMedidaPro E
ON E.idMedida = A.uniMedida

end;

go

create proc ListarDepartamentos
as
Begin
SELECT Departamento.idDepa, Departamento.nombreDep from Departamento
end;

go

create proc ListarUnidadesMedida
as
Begin
SELECT uniMedidaPro.idMedida, uniMedidaPro.unidadMedida from uniMedidaPro
end;

go

create proc InsertarProductos
(
@CodigoProducto int,
@NombreProducto varchar(30),
@Descripcion varchar(60),
@UniMedida int,
@fechaAlta date ,
@existencia int ,
@ptReorden int ,
@activo varchar(30),
@Costo decimal(10,2),
@PrecioUnitario decimal(10,2),
@ClaveDepartamento int
)
as 
Begin
insert into Producto(idProduct, nombrePro,descripcion,uniMedida, fechaAlta,existencia,
ptReorden, activo,Costo,PrecioUnitario,claveAdmin,claveDepa, claveGest)
values(@CodigoProducto, @NombreProducto, @Descripcion, @UniMedida, @fechaAlta, @existencia,
@ptReorden, @activo, @Costo, @PrecioUnitario,1, @ClaveDepartamento, 1)
End;

go

create proc ActualizarProductos
(
@IdP int,
@NombreProducto varchar(30),
@Descripcion varchar(60),
@UnidadMedida int,
@FechaCambio date,
@existencia int,
@ptReorden int,
@Activo varchar(30),
@costo decimal(10,2),
@PrecioUnitario decimal(10,2),
@ClaveDeparmento int null
)
as
Begin
update Producto set nombrePro = @NombreProducto, descripcion = @Descripcion, uniMedida = @UnidadMedida,
FechaCambio = @FechaCambio, existencia = @existencia, ptReorden = @ptReorden, activo = @Activo, Costo = @costo, PrecioUnitario =  @PrecioUnitario, claveDepa = @ClaveDeparmento
where idProduct = @IdP
end;

go

create proc BajaProductos
(@CodigProduc int)
as
Begin
update Producto set activo = 'Inactivo' where Producto.idProduct = @CodigProduc
end;

go

create proc RealizarDescuento
(@Porcentaje int,
@Fecha1 date,
@Fecha2 date,
@ClaveProd int
)
as
Begin
	DECLARE @iDdis int;
	
	Print @iDdis
insert into descFecha(fechaIni, fechaFin)
values (@Fecha1, @Fecha2)	
select @iDdis= SCOPE_IDENTITY(); --Nesecario ponerlo aqui para que aqui reciba la ultima identity creada 
insert into Descuento(cantidad, claveFechaD)
values (@Porcentaje, @iDdis)
update Producto set idDesc = @iDdis where Producto.idProduct = @ClaveProd
end;

go

create proc editDescuento
(@idDesc int, @Fecha1 date,
 @Fecha2 date, @porcentaje int)
as
Begin
update Descuento set cantidad = @porcentaje where idDesc = @idDesc
update descFecha set fechaIni = @Fecha1, fechaFin = @Fecha2 where @idDesc = idFechaDesc
end;

go

create proc ListarDescuentosFecha
as
Begin
	SELECT Descuento.idDesc [Id Descuento], descFecha.fechaIni [Inicia], descFecha.fechaFin [Termina], Descuento.cantidad [Porcentaje], P.nombrePro [Nombre Producto], P.idProduct [Codigo] from Descuento
	join descFecha
	on descFecha.idFechaDesc = Descuento.idDesc
	join Producto P
	on Descuento.idDesc = P.idDesc
end;

go

create proc BorrarDescuento
(
@idDes int
)
as
Begin
delete Descuento where idDesc = @idDes
end;

go

create proc listarProdDescCB
as
Begin
select [Codigo], [Nombre Producto] from vwInventary where [id Descuento] is null
end;

go

create proc ListarInventario
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary where [Activo] = 'Activo'
end;

go

create procedure filtro_existenciaI
(@filtroI int)
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where [stock] like @filtroI 
end;

go

create procedure filtro_DepartamentoI
(@filtroI varchar (200))
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where [Departamento] like @filtroI + '%'
end;

go

create procedure filtro_agotadoI
(@filtroI int)
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where [stock] = @filtroI or (1 = @filtroI and [stock] > 0)
end;

go

create procedure filtro_mermaI
(@filtroI int)
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where (0 = @filtroI and [Merma] is null) or (1 = @filtroI and [Merma] > 0)
end;

go

create proc ConsultaRapida
as
Begin
select [Codigo], [Nombre Producto], [Precio Unitario], [Stock] from vwInventary where [Activo] = 'Activo'
end;

go

create proc filtroConsultaRapida
(@filID int, @filName varchar(200))
as
Begin
select [Codigo], [Nombre Producto], [Precio Unitario], [Stock] from vwInventary 
where @filID = [Codigo] or @filName like [Nombre Producto] + '%' or (@filID = [Codigo] and @filName like [Nombre Producto] + '%') and [Activo] = 'Activo'
end;

go

create proc productosVenta
as
Begin
select [Codigo], [Nombre Producto] from vwInventary where [Activo] = 'Activo'
end;

go

create proc filtroSelectProduct
(@filID int, @filName varchar(200))
as
Begin
select [Codigo], [Nombre Producto] from vwInventary 
where @filID = [Codigo] or @filName like [Nombre Producto] + '%' or (@filID = [Codigo] and @filName like [Nombre Producto] + '%') and [Activo] = 'Activo'
end;

go

create proc SeleccionarProductoInsertarProducto
(@CodigoProd int,
@NombreProd varchar(30),
@Caja int,
@Fecha date,
@CantidadAllevar int)
as
Begin
insert into VentaTemporal(CodigoProducto,NombreProducto, PrecioUnitario, ExistenciaProducto, FechaVenta, Caja, CantidadAllevar, idDescuento)
Select Producto.idProduct [Codigo], nombrePro [Nombre Producto], PrecioUnitario [Precio], Producto.existencia [Existencia], @Fecha, @Caja, @CantidadAllevar, B.idDesc from Producto left join Descuento B
on B.idDesc = Producto.idDesc
where Producto.idProduct = @CodigoProd or Producto.nombrePro = @NombreProd;
end;

go

create proc InsertarCarrito
as
Begin
Select idVentaTemp [Id], CodigoProducto [Codigo],  NombreProducto [Producto],  CantidadAllevar [A llevar], 
PrecioUnitario [Precio], ExistenciaProducto [Stock], d.cantidad [Porcentaje Descuento] from VentaTemporal
left join Descuento D
on D.idDesc = VentaTemporal.idDescuento
end;

go

create procedure filtro_DepartamentoScreen
(@filtroI varchar(200))
as
Begin
select Departamento.idDepa [Id Departamento], Departamento.nombreDep [Departamento], Departamento.devoluDepa [Devolucion], claveAdminDepa [Usuario Cambio]
from Departamento
where Departamento.nombreDep like @filtroI + '%'
end;

go

create procedure filtro_ProductoScreen
(@filtroI varchar(200))
as
Begin
select [Codigo], [Nombre Producto], [Descripción], [Precio Unitario], [Costo], [Activo], [Gestor], [Departamento], [Stock], [Fecha de Alta],
[Fecha de Actualizacion], [Punto de Reorden], [Unidad de Medida], [Cantidades Vendidas], [Usuario], [id Descuento] 
from vwInventary
where [Nombre Producto] like @filtroI + '%'
end;

go

create procedure filtro_EmpleadosScreen
(@filtroI varchar(200))
as
Begin
select [idEmpleado], [Nombre], [Apellido Paterno], [Apellido Materno], [Clave de Usuario], [Contraseña], [CURP], [Correo], [Nomina], [Fecha de Ingreso],
[Fecha Nacimiento]
from vwEmpleados
where  [Nombre] like @filtroI + '%'
end;

go

create procedure ActualizarCantidad
(@NombreProd varchar(30),
@Cantidad int)
as
Begin
update VentaTemporal set CantidadAllevar = CantidadAllevar+ @Cantidad where NombreProducto = @NombreProd
end;

go

create procedure EliminarCantidad 
(@NombreProd varchar(30),
@Cantidad int)
as
begin
update VentaTemporal set CantidadAllevar = CantidadAllevar - @Cantidad where NombreProducto = @NombreProd
end;

go

create procedure EliminarProductoCarrito 
(@NombreProd varchar(30),
@Cant int)
as
begin
Update VentaTemporal set CantidadAllevar = CantidadAllevar - @Cant where NombreProducto = @NombreProd
delete VentaTemporal where VentaTemporal.CantidadAllevar = 0 and NombreProducto = @NombreProd 
end;

go

create procedure EliminarProductoDevolucion
(@Codigo varchar(30),
@Cant int)
as
begin
Update DevolucionTemporal set cantDevuelta = cantDevuelta - @Cant where CodProd = @Codigo
delete DevolucionTemporal where cantDevuelta = 0 and CodProd = @Codigo 
end;

go

create procedure InsertarParaPagar
as
Begin  
select VentaTemporal.idVentaTemp [Id], VentaTemporal.NombreProducto [Producto], 
VentaTemporal.PrecioUnitario [Precio], VentaTemporal.CantidadAllevar [A llevar], D.cantidad [Descuento], subTotal [Subtotal], P.Costo [Costo] from VentaTemporal
left join Descuento D
on D.idDesc = VentaTemporal.idDescuento
join Producto P
on P.idProduct = VentaTemporal.CodigoProducto
end;

go

create proc GenerarVenta
(@CajeroId int,
@NumCaja int,
@Fecha date,
@MontoPago decimal(10,2),
@Total decimal(10,2),
@NombreCajero varchar(30)
)
as
Begin
   declare @CajeroId2 int = 0
   declare @CajeroId3 int = 0;
      set @CajeroId = (Select Usuario.idUser from Usuario where nombreU = @NombreCajero)
   
   insert into Caje_Pro(claveCajeroCP, noCajaCP)
    values(@CajeroId, @NumCaja)

   set @CajeroId3 = SCOPE_IDENTITY();

   insert into Recibo(fechaVenta, MontoPago, claveCajePro, total)
   values (@Fecha, @MontoPago, @CajeroId3, @Total)
--   set @CajeroId = (Select Usuario.idUser from Usuario where Usuario.nombreU = @NombreCajero)
End;

go

create proc GenerarVentaDetalle
(@idVentaHeader int,
@nombreProducto varchar(30),
@UnidaesVendidas int,
@Subtotal decimal(10,2),
@PrecioUnitario decimal(10,2),
@Venta decimal(10,2),
@Utilidad decimal(10,2)
)
as
BEGIN
declare @IdDepartamento int = 0;
declare @DescuentoId int = 0;
declare @CodigoProd int = 0;
set @IdDepartamento = (Select Producto.claveDepa from Producto where nombrePro = @nombreProducto)
set @DescuentoId = (Select Producto.idDesc from Producto where nombrePro = @nombreProducto)
set @CodigoProd = (Select Producto.idProduct from Producto where nombrePro = @nombreProducto)
set @idVentaHeader = IDENT_CURRENT('Recibo')
insert into VentaDetalle(noDeVenta,CodProducto, DepartamentoId,UnidadesVendidas, Subtotal,DescuentoId, PrecioUnitario, totalVenta, Utilidad)
values (@idVentaHeader,  @CodigoProd, @IdDepartamento, @UnidaesVendidas, @Subtotal, @DescuentoId, @PrecioUnitario, @Venta, @Utilidad)
END;

go

create proc GenerarTicket
(@IdVentaHeader int,
@MontoPagado decimal(10,2),
@ClavePago int)
as
Begin
set @IdVentaHeader = IDENT_CURRENT('Recibo')
insert into ticket(noVentaTic, clavePagoTic, montoPago)
values(@IdVentaHeader, @ClavePago, @MontoPagado)
end;

go

create procedure obtenerCajeroCobra
(@filtroI varchar(10))
as
Begin
select [Nombre], IdEmpleado
from vwEmpleado
where  @filtroI = [Clave de Usuario]
end;
--drop proc obtenerCajeroCobra
go
create procedure obtenerCajeroCobra2
(@filtroI int)
as
Begin
select [Nombre], IdEmpleado
from vwEmpleados2
where  [Clave de Usuario] = @filtroI
end;
drop proc obtenerCajeroCobra
go

create procedure obteneridCajeroCobra
(@filtroI int)
as
Begin
select IdEmpleado
from vwEmpleados
where  @filtroI = [Clave de Usuario]
end;

go

create procedure obtenerTicket
(@filtroNum int)
as
Begin
select [Num], [Fecha], [Codigo], [Producto], [Subtotal],
[Se llevo]from vwTicketsPorNum where @filtroNum = [Num]
end;

go

create procedure vaciarVentaTemporal
as
Begin
delete VentaTemporal
end;

go

create procedure obtenerIdVenta
as
Begin
declare @buscaID int = 0;
set @buscaID = IDENT_CURRENT('Recibo')
select noVenta from Recibo where noVenta = @buscaID
end;

go

create proc GenerarNotaCred
(@NumeroRecibo int,
@Total decimal(10,2),
@FechaNota date
)
as
Begin
DECLARE @IdAdmin int = 0;
set @IdAdmin = IDENT_CURRENT('Administrador')
insert into NotaCred(numeroRecibo, fechaNota, claveAdminNota, total)
values(@NumeroRecibo, @FechaNota, @IdAdmin, @Total)
end;

go

create proc GeneraDevolucion
(@CodigoProd int,
@CantDevuelta int,
@SubtotalDevoulucion decimal(10,2),
@Motivo varchar(300),
@NombreProd varchar(50)
)
as
Begin
declare @idNotaCred int = 0;
set @idNotaCred = IDENT_CURRENT('NotaCred')
insert into devolucion(noCredDev, codigoProDev, devCant, subtotalDev, motivo, NombreProd)
values(@idNotaCred, @CodigoProd, @CantDevuelta, @SubtotalDevoulucion, @Motivo, @NombreProd)
end;

go

create proc ActualizarProdDevolucionSinMerma
(@cant int,
 @CodProducto int)
as
Begin
update Producto set existencia = existencia + @cant where idProduct = @CodProducto
end;

go

create proc ActualizarProdDevolucionMerma
(@cant int,
 @CodProducto int)
as
Begin
update Producto set merma = merma + @cant where idProduct = @CodProducto
end;

go

create proc RestarStockVenta
(@cant int,
@NombreProd varchar(50))
as
Begin
update Producto set existencia = existencia - @cant where nombrePro= @NombreProd
end;

go

create proc TablaDevolucionTemp
as
Begin
select idDevTemp[ID], numeroRecibo [Recibo], Fecha [Fecha],
CodProd [Codigo], NombreProd [Producto], cantDevuelta [Devuelve], subTotalDevuelto [Subtotal], merma [Merma] from DevolucionTemporal
end;

go

create proc InsertarDevTemporalMerma
(@CodigoProd int,
@NumRecibo int,
@Fecha date,
@NombreProd varchar(50),
@cantDevuelta int,
@subtotal decimal(10,2),
@Merma int)
as
Begin
Insert into DevolucionTemporal(numeroRecibo, Fecha, CodProd,
 cantDevuelta, subTotalDevuelto, merma, NombreProd)
values(@NumRecibo, @Fecha,@CodigoProd, @cantDevuelta, @subtotal, @Merma, @NombreProd)
end;

go

create proc InsertarDevTemporalSinMerma
(@CodigoProd int,
@NumRecibo int,
@Fecha date,
@NombreProd varchar(50),
@cantDevuelta int,
@subtotal decimal(10,2))
as
Begin
Insert into DevolucionTemporal(numeroRecibo, Fecha, CodProd,
 cantDevuelta, subTotalDevuelto, NombreProd)
values(@NumRecibo, @Fecha,@CodigoProd, @cantDevuelta, @subtotal, @NombreProd)
end;

go

create proc BorrarGridDevolucion
as
BEGIN
delete DevolucionTemporal
END;

go

create procedure reporteVentas
as
Begin
select [Fecha de Venta], [Departamento], [Codigo del Articulo], [Precio Unitario],
[Unidades Vendidas], [Subtotal], [Descuento],
[Venta], [Utilidad] from vwVenta
end;

go

create procedure reporteCajero
as
Begin
Select [Fecha de Venta], [Cajero], [Departamento],
[Unidades Vendidas], [Suma Venta], [Utilidad] from vwCajero
end;

go

create procedure reporteCajeroFechas
(@fecha1 date, @fecha2 date)
as
Begin
Select [Fecha de Venta], [Cajero], [Departamento],
[Unidades Vendidas], [Suma Venta], [Utilidad] from vwCajero 
where @fecha1 <= [Fecha de Venta] and [Fecha de Venta] <= @fecha2
end;

go

create procedure reporteCajeroDepa
(@Depa varchar(100))
as
Begin
Select [Fecha de Venta], [Cajero], [Departamento],
[Unidades Vendidas], [Suma Venta], [Utilidad] from vwCajero 
where @Depa = [Departamento]
end;

go

create procedure reporteCajeroCajeroFiltro
(@Cajero varchar(100))
as
Begin
Select [Fecha de Venta], [Cajero], [Departamento],
[Unidades Vendidas], [Suma Venta], [Utilidad] from vwCajero 
where @Cajero = [Cajero]
end;

go

create procedure reporteVentaFechas
(@fecha1 date, @fecha2 date)
as
Begin
select [Fecha de Venta], [Departamento], [Codigo del Articulo], [Precio Unitario],
[Unidades Vendidas], [Subtotal], [Descuento],
[Venta], [Utilidad] from vwVenta
where @fecha1 <= [Fecha de Venta] and [Fecha de Venta] <= @fecha2
end;

go

create procedure reporteVentaDepa
(@Depa varchar(100))
as
Begin
select [Fecha de Venta], [Departamento], [Codigo del Articulo], [Precio Unitario],
[Unidades Vendidas], [Subtotal], [Descuento],
[Venta], [Utilidad] from vwVenta
where @Depa = [Departamento]
end;

go

create procedure reporteVentaCajaFiltro
(@Caja varchar(100))
as
Begin
select [Fecha de Venta], [Departamento], [Codigo del Articulo], [Precio Unitario],
[Unidades Vendidas], [Subtotal], [Descuento],
[Venta], [Utilidad] from vwVenta
where @Caja = [Caja]
end;

go

create procedure AumentarCantidadesVendidas
(@NombreProd varchar(50),
@CantVendida int)
as
Begin
update Producto set uniVendida = @CantVendida where nombrePro = @NombreProd
end;

go
