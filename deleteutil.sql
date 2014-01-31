USE [joc]
GO

/****** Object:  StoredProcedure [dbo].[deleteUtilizatori]    Script Date: 1/28/2014 10:33:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[deleteUtilizatori](@Username varchar(20))
AS
   DELETE FROM Utilizatori
   WHERE Username = @Username
GO

