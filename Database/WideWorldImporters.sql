USE [master]
GO
RESTORE DATABASE [WideWorldImporters] FROM  DISK = N'C:\Ankit\SQLbackups\WideWorldImporters-Full.bak' 
WITH  FILE = 1,  
MOVE N'WWI_Primary' TO N'C:\Ankit\SQL_Data\WideWorldImporters.mdf',  
MOVE N'WWI_UserData' TO N'C:\Ankit\SQL_Data\WideWorldImporters_UserData.ndf', 
MOVE N'WWI_Log'  TO N'C:\Ankit\SQL_Data\WideWorldImporters.ldf',  
MOVE N'WWI_InMemory_Data_1' TO N'C:\Ankit\SQL_Data\WideWorldImporters_InMemory_Data_1', 
NOUNLOAD,  
STATS = 5
GO