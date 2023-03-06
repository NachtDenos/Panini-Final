use ProyectoMAD
SELECT IC.COLUMN_NAME, IC.Data_TYPE, EP.[Value] as [MS_Description], IKU.CONSTRAINT_NAME,
ITC.CONSTRAINT_TYPE, IC.IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS IC
INNER JOIN sys.columns sc ON OBJECT_ID(QUOTENAME(IC.TABLE_SCHEMA) + '.' +
QUOTENAME(IC.TABLE_NAME)) = sc.[object_id] AND IC.COLUMN_NAME = sc.name
LEFT OUTER JOIN sys.extended_properties EP ON sc.[object_id] = EP.major_id AND
sc.[column_id] = EP.minor_id AND EP.name = 'MS_Description' AND EP.class = 1 
LEFT OUTER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE IKU ON IKU.COLUMN_NAME =
IC.COLUMN_NAME and IKU.TABLE_NAME = IC.TABLE_NAME and IKU.TABLE_CATALOG = IC.TABLE_CATALOG
LEFT OUTER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS ITC ON ITC.TABLE_NAME =
IKU.TABLE_NAME and ITC.CONSTRAINT_NAME = IKU.CONSTRAINT_NAME
WHERE IC.TABLE_CATALOG = 'ProyectoMAD'
and IC.TABLE_SCHEMA = 'dbo'
--and IC.TABLE_NAME = 'Table'
order by IC.ORDINAL_POSITION

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Marca la disponibilidad de la caja con un 1 o 0',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Caja',
@level2type = N'Column', @level2name = 'disponi';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Muestra la cantidad de existencia del producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Caje_Pro',
@level2type = N'Column', @level2name = 'existenciaCP';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de Nacimiento del cajero',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cajero',
@level2type = N'Column', @level2name = 'fechaNaci';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Numero de nómina del cajero',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cajero',
@level2type = N'Column', @level2name = 'numeroNomi';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de cuanto entro a trabajar el cajero',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cajero',
@level2type = N'Column', @level2name = 'fechaIngr';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Unidades vendidas por el cajero',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cajero',
@level2type = N'Column', @level2name = 'uniVend';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Ventas hechas por el cajero',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Cajero',
@level2type = N'Column', @level2name = 'ventas';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Muestra si el departamento tiene devoluciones o no',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Departamento',
@level2type = N'Column', @level2name = 'devoluDepa';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha inicial del descuento',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'descFecha',
@level2type = N'Column', @level2name = 'fechaIni';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha final del descuento',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'descFecha',
@level2type = N'Column', @level2name = 'fechaFin';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad a descontar al producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Descuento',
@level2type = N'Column', @level2name = 'cantidad';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del metodo de pago',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'MetodPago',
@level2type = N'Column', @level2name = 'tipoMetod';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Total devuelto en lo que consta a precios',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'NotaCred',
@level2type = N'Column', @level2name = 'total';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Numero del recibo perteneciente a los productos devueltos',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'NotaCred',
@level2type = N'Column', @level2name = 'numeroRecibo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de la alta de la Nota de Credito',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'NotaCred',
@level2type = N'Column', @level2name = 'fechaNota';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'nombrePro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Descripcion del producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Unidad de medida del producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'uniMedida';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de cuando se dio de alta el producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'fechaAlta';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de productos existentes',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'existencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad que señala la necesidad de un reabastecimiento',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'ptReorden';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Señala si el producto está activo con 1 o 0',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'activo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de productos devueltos',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'merma';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad de productos vendidos',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'uniVendida';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha del descuento del producto',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Producto',
@level2type = N'Column', @level2name = 'fechaDesc';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de cuando se realizó el recibo',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Recibo',
@level2type = N'Column', @level2name = 'fechaVenta';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Cantidad total de precio en el recibo',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Recibo',
@level2type = N'Column', @level2name = 'total';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'nombreU';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido paterno del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'apellidoPU';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido materno del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'apellidoMU';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Contraseña del usuario',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'contraU';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Tipo del usuario, dependiendo de si es 0 (Admin) o 1 (Cajero)',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'Usuario',
@level2type = N'Column', @level2name = 'tipoU';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Nombre del producto de la venta',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table', @level1name = 'VentaProduct',
@level2type = N'Column', @level2name = 'nombreProdVenta';

