USE [DB_Marcadores]
GO

/****** Object:  StoredProcedure [dbo].[sp_MarcadoresLiga]    Script Date: 21/6/2024 0:19:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_MarcadoresLiga] 
	@Opcion		VARCHAR(1),
	@Codigo		VARCHAR(20),
	@Etapa		VARCHAR(1),
	@ELocal		VARCHAR(20),
	@EVisitante VARCHAR(20),
	@Fecha		VARCHAR(20),
	@Resultado	VARCHAR(20)
AS
BEGIN
	DECLARE @Sql VARCHAR(255),  @NewCodigo VARCHAR(20);

	IF (@Opcion = 'I')
		BEGIN
			
			SET @NewCodigo = LEFT(@ELocal, 3) + LEFT(@EVisitante, 3) + @Etapa;

			SET @Sql = 'INSERT INTO Marcadores (IdPartido, EtapaLiga, EquipoLocal, EquipoVisitante, FechaPartido, Resultado) ' +
               'VALUES (''' + @NewCodigo + ''', ''' + @Etapa + ''', ''' + @ELocal + ''', ''' + @EVisitante + ''', ''' + @Fecha + ''', ''' + @Resultado + ''')';
			EXEC(@Sql);
		END
	ELSE IF (@Opcion = 'D')
		BEGIN
			SET @Sql = 'DELETE FROM Marcadores WHERE IdPartido = '''+ @Codigo +''''
			EXEC(@Sql);
		END
END
GO

