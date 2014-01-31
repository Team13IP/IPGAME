USE [joc]
GO

/****** Object:  StoredProcedure [dbo].[insertUtilizatori]    Script Date: 1/28/2014 10:33:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[insertUtilizatori]
@Username varchar(20),
@Data_Inregistrarii date,
@Parola varchar(20),
@Email varchar(40),
@scor numeric(6)
AS 
BEGIN 

 SET NOCOUNT ON; 

  BEGIN 

insert into Utilizatori (ID  , Username , Data_Inregistrarii , Parola , Email ,scor )

values((1+(select Max(ID) from Utilizatori)) ,@Username ,@Data_Inregistrarii ,@Parola ,@Email ,@scor )

  END 

END


GO

