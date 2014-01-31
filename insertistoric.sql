USE [joc]
GO

/****** Object:  StoredProcedure [dbo].[insertIstoric]    Script Date: 1/28/2014 10:33:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[insertIstoric]
@ID_Player1 numeric(6),
@ID_Personaj1 numeric(6),
@ID_Player2 numeric(6),
@ID_Personaj2 numeric(6),
@Winner varchar(10)
AS 
BEGIN 

 SET NOCOUNT ON; 

  BEGIN 

insert into Istoric(ID , ID_Player1 , ID_Personaj1 , ID_Player2 , ID_personaj2 , Winner)

values(isnull((1+(select max(ID) from Istoric)),1) , @ID_Player1 , @ID_Personaj1 , @ID_Player2 , @ID_personaj2 , @Winner)

  END 

END



GO

