﻿CREATE VIEW [Portal].[ModelerUser]
AS 
	SELECT [Id]
      ,[Login]
      ,[Imie]
      ,[Nazwisko]
      ,[Email]
      ,[Haslo]
      ,[Aktywny]
      ,[Domenowy]
      ,[Nazwa]
      ,[IdArch]
      ,[IdArchLink]
      ,[ObowiazujeOd]
      ,[IsValid]
      ,[ValidFrom]
      ,[IsDeleted]
      ,[CreatedOn]
      ,[CreatedBy]
      ,[RealCreatedOn]
      ,[IsStatus]
      ,[StatusS]
      ,[StatusW]
      ,[StatusP]
   FROM [dbo].[Uzytkownicy]