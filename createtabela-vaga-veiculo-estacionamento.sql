USE [Estacionamento]
GO
/****** Object:  Table [dbo].[Vaga]    Script Date: 28/06/2018 11:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vaga](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[VeiculoPlaca] [varchar](8) NULL,
	[Entrada] [datetime] NULL,
	[Saida] [datetime] NULL,
 CONSTRAINT [PK_Vaga] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/06/2018 11:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[CPF] [varchar](15) NULL,
	[Telefone] [varchar](15) NULL,
	[Cadastro] [datetime] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Veiculo]    Script Date: 28/06/2018 11:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Veiculo](
	[Placa] [varchar](8) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Cor] [varchar](50) NULL,
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Veiculo] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

GO
ALTER TABLE [dbo].[Vaga]  WITH CHECK ADD  CONSTRAINT [FK_Vaga_Veiculo] FOREIGN KEY([VeiculoPlaca])
REFERENCES [dbo].[Veiculo] ([Placa])
GO
ALTER TABLE [dbo].[Veiculo]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Veiculo] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Vaga] CHECK CONSTRAINT [FK_Vaga_Veiculo]
GO
