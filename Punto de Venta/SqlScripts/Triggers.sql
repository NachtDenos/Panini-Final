use ProyectoMAD
go
CREATE TRIGGER tr_bajaDescuentoPro ON Descuento
INSTEAD OF DELETE
AS
BEGIN
DECLARE @ID INT
Select @ID = idDesc
FROM deleted
update Producto set idDesc = null where @ID = idDesc
end;

go

--drop trigger tr_Actualizarcant on devolucion
--instead of insert
--as
--Begin
--declare @Id int;
--declare @Merma int;
--declare @Cant int;
--select @Id = idProduct from Producto
--update Producto set merma = merma + @Merma, existencia = existencia + @Cant where idProduct = @Id
--end;

