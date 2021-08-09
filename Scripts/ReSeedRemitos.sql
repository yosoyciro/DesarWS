DECLARE @RemitosId INT
SELECT @RemitosId = ISNULL(MAX(REMITOSID), 0) + 1 FROM Remitos
EXECUTE [dbo].[ReseedIdentity] 'Remitos','REMITOSID',@RemitosId

DECLARE @RemitosDetalleId INT
SELECT @RemitosDetalleId = ISNULL(MAX(REMITOSDETALLEID), 0) + 1 FROM RemitosDetalle
EXECUTE [dbo].[ReseedIdentity] 'RemitosDetalle','REMITOSDETALLEID',@RemitosDetalleId

EXECUTE [dbo].[ReseedIdentity] 'RemitosAuditoria','REMITOSAUDITORIAID',1;