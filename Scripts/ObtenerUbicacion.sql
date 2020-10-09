-- =============================================
-- Author:		Ciro
-- Create date: 20201009
-- Description:	Devuelve la ubicacion de un articulo
-- =============================================
CREATE FUNCTION ObtenerUbicacion
(
	-- Add the parameters for the function here
	@pSectoresId INT
)
RETURNS VARCHAR(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar VARCHAR(50)

	SELECT @ResultVar = D.NOMBRE + ' - ' + U.NOMBRE + ' - ' + S.DESCRIPCION
	FROM Depositos D INNER JOIN Ubicaciones U ON D.DEPOSITOSID = U.DEPOSITOSID
	INNER JOIN Sectores S ON U.UBICACIONESID = S.UBICACIONESID
	WHERE S.SECTORESID = @pSectoresId

	-- Return the result of the function
	RETURN @ResultVar

END
GO

