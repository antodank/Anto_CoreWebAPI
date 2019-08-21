USE [master]
GO
RESTORE DATABASE [WideWorldImportersDW] FROM  DISK = N'C:\Ankit\SQLbackups\WideWorldImportersDW-Full.bak' 
WITH  FILE = 1,  
MOVE N'WWI_Primary' TO N'C:\Ankit\SQL_Data\WideWorldImportersDW.mdf',  
MOVE N'WWI_UserData' TO N'C:\Ankit\SQL_Data\WideWorldImportersDW_UserData.ndf',  
MOVE N'WWI_Log' TO N'C:\Ankit\SQL_Data\WideWorldImportersDW.ldf', 
MOVE N'WWIDW_InMemory_Data_1' TO N'C:\Ankit\SQL_Data\WideWorldImportersDW_InMemory_Data_1',  
NOUNLOAD,  
REPLACE,  
STATS = 5
GO