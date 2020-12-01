--Empiezo por las tablas que se cargan en el data solamente
DECLARE @PedidosWebId INT
SELECT @PedidosWebId = MAX(PEDIDOSWEBID) + 1 FROM PedidosWeb
EXECUTE [dbo].[ReseedIdentity] 'PedidosWeb','PEDIDOSWEBID',@PedidosWebId

DECLARE @PedidosWebDetalleId INT
SELECT @PedidosWebDetalleId = MAX(PEDIDOSWEBDETALLEID) + 1 FROM PedidosWebDetalle
EXECUTE  [dbo].[ReseedIdentity] 'PedidosWebDetalle','PEDIDOSWEBDETALLEID',@PedidosWebDetalleId

DECLARE @PedidosWebFormasPagoId INT
SELECT @PedidosWebFormasPagoId = MAX(PEDIDOSWEBFORMASPAGOID) + 1 FROM PedidosWebFormasPago
EXECUTE [dbo].[ReseedIdentity] 'PedidosWebFormasPago','PEDIDOSWEBFORMASPAGOID',@PedidosWebFormasPagoId

DECLARE @PedidosWebTarjetasCuponesId INT
SELECT @PedidosWebTarjetasCuponesId = MAX(PEDIDOSWEBTARJETASCUPONESID) + 1 FROM PedidosWebTarjetasCupones
EXECUTE [dbo].[ReseedIdentity] 'PedidosWebTarjetasCupones','PEDIDOSWEBTARJETASCUPONESID',@PedidosWebTarjetasCuponesId

DECLARE @RemitosId INT
SELECT @RemitosId = ISNULL(MAX(REMITOSID), 0) + 1 FROM Remitos
EXECUTE [dbo].[ReseedIdentity] 'Remitos','REMITOSID',@RemitosId

DECLARE @RemitosDetalleId INT
SELECT @RemitosDetalleId = ISNULL(MAX(REMITOSDETALLEID), 0) + 1 FROM RemitosDetalle
EXECUTE [dbo].[ReseedIdentity] 'RemitosDetalle','REMITOSDETALLEID',@RemitosDetalleId
--Aca van las tablas que se cargan en ambos lados
EXECUTE[dbo].[ReseedIdentity] 'Personas','PERSONASID',0
EXECUTE [dbo].[ReseedIdentity] 'PedidosWebArchivos','PEDIDOSWEBARCHIVOSID',0
EXECUTE [dbo].[ReseedIdentity] 'Vehiculos','VEHICULOSID',0;
EXECUTE [dbo].[ReseedIdentity] 'RemitosAuditoria','REMITOSAUDITORIAID',1;
EXECUTE [dbo].[ReseedIdentity] 'Localidades','LOCALIDADESID',5001;