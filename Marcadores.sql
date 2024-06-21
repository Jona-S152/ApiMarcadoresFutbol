USE [DB_Marcadores]
GO

/****** Object:  Table [dbo].[Marcadores]    Script Date: 21/6/2024 0:18:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Marcadores](
	[IdPartido] [varchar](10) NOT NULL,
	[EtapaLiga] [varchar](1) NULL,
	[EquipoLocal] [varchar](20) NULL,
	[EquipoVisitante] [varchar](20) NULL,
	[FechaPartido] [varchar](20) NULL,
	[Resultado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPartido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

