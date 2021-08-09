-- =============================================
-- Author:		Ciro
-- Create date: 2020/11/25
-- Description:	SP para consulta de stock para remitos
-- =============================================
ALTER  PROCEDURE [dbo].[ConsultaStockRemitos]
	-- Add the parameters for the stored procedure here
	@pPatente VARCHAR(15),@pLegajo INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @EstadosIdEnDesarme INT
	
	SELECT @EstadosIdEnDesarme = ESTADOSID FROM Estados WHERE DESCRIPCION = 'En Desarme'

    SELECT S.ARTICULOSSTOCKID, S.CODIGOBARRA, A.DESCRIPCION ARTICULO, M.DESCRIPCION MARCA, MO.DESCRIPCION MODELO, V.DESCRIPCION, V.MOTOR, VT.DESCRIPCION TIPOVEHICULO, V.ANIO, V.PATENTE, 
	S.ARTICULOSID, S.VEHICULOSID, F.NROLEGAJO
	FROM ArticulosStock S INNER JOIN Vehiculos V ON S.VEHICULOSID = V.VEHICULOSID
	INNER JOIN Marcas M ON V.MARCASID = M.MARCASID
	INNER JOIN Modelos MO ON V.MODELOSID = MO.MODELOSID
	INNER JOIN Articulos A ON S.ARTICULOSID = A.ARTICULOSID
	INNER JOIN VehiculosTipo VT ON V.VEHICULOSTIPOID = VT.VEHICULOSTIPOID	
	INNER JOIN Formulario04D F ON V.VEHICULOSID = F.VEHICULOSID
	WHERE (V.PATENTE = @pPatente OR F.NROLEGAJO = @pLegajo)
	AND S.ESTADOSID = @EstadosIdEnDesarme
	AND S.ARTICULOSSTOCKID NOT IN (SELECT ARTICULOSSTOCKID FROM RemitosDetalle WHERE REMITOSID IN (SELECT REMITOSID FROM Remitos WHERE ESTADO IN ('P', 'C')))
END



