DROP FUNCTION [dbo].[PrecioArticulo]
GO


-- =============================================
-- Author:		Ciro
-- Create date: 2020/03/17
-- Description:	<Description,,>
-- =============================================
ALTER FUNCTION [dbo].[PrecioArticulo] (@pArticulosId INT,@pCategoriasId INT, @TipoCaja char(1), @pAnio INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
	DECLARE @ListasPrecioId AS INT	
	DECLARE @PrecioVenta AS DECIMAL(10,2)
	DECLARE @PorcCajaAutomatica DECIMAL(7,2)
	DECLARE @AntiguedadModelo INT
	DECLARE @PorcentajeDescuento DECIMAL(7,2)

    -- Insert statements for procedure here
	SELECT TOP 1 @ListasPrecioId = LISTASPRECIOID, @PorcCajaAutomatica = PORCCAJAAUTOMATICA FROM ListasPrecio 
	WHERE VIGENTEDESDE <= dbo.ConvFechaClarion(GETDATE()) AND CATEGORIASID = @pCategoriasId
	ORDER BY VIGENTEDESDE DESC
	IF @@ROWCOUNT > 0
	BEGIN
		SELECT @PrecioVenta = IMPORTE FROM ListasPrecioDetalle WHERE LISTASPRECIOID = @ListasPrecioId AND ARTICULOSID = @pArticulosId
	END

	IF @TipoCaja = 'A' AND @pArticulosId = 10
		SET @PrecioVenta = @PrecioVenta + (@PrecioVenta * (@PorcCajaAutomatica/100))

	--Verifico si le hago un descuento
	SET @AntiguedadModelo = YEAR(GETDATE()) - @pAnio
	SELECT TOP 1 @PorcentajeDescuento = PORCENTAJEAJUSTE FROM ListasPreciosDescuentos WHERE @AntiguedadModelo > RANGO ORDER BY RANGO DESC

	SET @PrecioVenta = @PrecioVenta - (@PrecioVenta * (@PorcentajeDescuento / 100))

	RETURN @PrecioVenta
END

