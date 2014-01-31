USE [joc]
GO

/****** Object:  StoredProcedure [dbo].[updateUtilizatori]    Script Date: 1/28/2014 10:33:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[updateUtilizatori]
@ID numeric(6) ,
@Username varchar(20),
@Data_Inregistrarii date,
@Parola varchar(20),
@Email varchar(40),
@scor numeric(6)
AS
BEGIN
SET NOCOUNT ON;
UPDATE Utilizatori
SET
[Username] = @Username
,[Data_Inregistrarii] = @Data_inregistrarii
, [Parola]=@Parola
, [Email]=@Email
, [scor]=@scor
WHERE [ID] = @ID 
end

GO

