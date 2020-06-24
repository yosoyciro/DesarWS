--Empiezo por las tablas que se cargan en el data solamente
DECLARE @PedidosWebId INT
SELECT @PedidosWebId = MAX(PEDIDOSWEBID) + 1 FROM PedidosWeb
EXECUTE [dbo].[ReseedIdentity] 'PedidosWeb','PEDIDOSWEBID',@PedidosWebId
GO
DECLARE @PedidosWebDetalleId INT
SELECT @PedidosWebDetalleId = MAX(PEDIDOSWEBDETALLEID) + 1 FROM PedidosWebDetalle
EXECUTE  [dbo].[ReseedIdentity] 'PedidosWebDetalle','PEDIDOSWEBDETALLEID',@PedidosWebDetalleId
GO
DECLARE @PedidosWebFormasPagoId INT
SELECT @PedidosWebFormasPagoId = MAX(PEDIDOSWEBFORMASPAGOID) + 1 FROM PedidosWebFormasPago
EXECUTE [dbo].[ReseedIdentity] 'PedidosWebFormasPago','PEDIDOSWEBFORMASPAGOID',@PedidosWebFormasPagoId
GO
--Aca van las tablas que se cargan en ambos lados
EXECUTE[dbo].[ReseedIdentity] 'Personas','PERSONASID',0
GO
EXECUTE [dbo].[ReseedIdentity] 'PedidosWebArchivos','PEDIDOSWEBARCHIVOSID',0
GO
EXECUTE [dbo].[ReseedIdentity] 'Vehiculos','VEHICULOSID',0;