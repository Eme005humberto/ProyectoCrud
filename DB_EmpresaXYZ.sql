USE [DB_EmpresaXYZ]
GO
/****** Object:  Table [dbo].[tblEmployees]    Script Date: 01/09/2023 02:45:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Add_Product_Computer]    Script Date: 01/09/2023 02:45:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Add_Product_Computer]
@Name_Product Varchar(100),
@Model Varchar(100),
@Amount Int,
@Unit_price decimal(10,2),
@Date_Product DateTime
As
Begin
  Insert into PRODUCTS_COMPUTER Values(@Name_Product,@Model,@Amount,@Unit_price,@Date_Product)
  print 'LOS DATOS SE INGRESARON CORRECTAMENTE!!!'
End

GO
/****** Object:  StoredProcedure [dbo].[sp_Agregar]    Script Date: 01/09/2023 02:45:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Creamos el procedimiento almacenado que tiene como nombre agregar
Create procedure [dbo].[sp_Agregar]
@Nombre Varchar(50),
@Apellidos Varchar(50),
@Cargo Varchar(50)
as begin
  Insert into tblEmployees values(@Nombre,@Apellidos,@Cargo)
End
GO
/****** Object:  StoredProcedure [dbo].[sp_Elimiar]    Script Date: 01/09/2023 02:45:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Creamos el procedimiento almacenado que tiene como nombre Eliminar
Create procedure [dbo].[sp_Elimiar]
@Id int
as begin
  Delete from tblEmployees Where Id = @Id
  End

GO
/****** Object:  StoredProcedure [dbo].[sp_Modificar]    Script Date: 01/09/2023 02:45:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Creamos el procedimiento almacenado que tiene como nombre modificar
Create procedure [dbo].[sp_Modificar]
@Id int,
@Nombre Varchar(50),
@Apellidos Varchar(50),
@Cargo Varchar(50)
as begin
  Update tblEmployees set Nombre = @Nombre , Apellidos = @Apellidos , Cargo = @Cargo
  Where Id = @Id
End
GO
/****** Object:  StoredProcedure [dbo].[sp_MostrarDatos]    Script Date: 01/09/2023 02:45:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Creamos los procedimiento almacenados
Create procedure [dbo].[sp_MostrarDatos]
as begin
 Select * from tblEmployees
end
GO
