
RESTORE DATABASE ADWORKSDB
FROM DISK = 'C:\Users\Josiane\Downloads\AdventureWorks2016 (1).bak'
WITH MOVE 'AdventureWorks2016_Data' TO 'C:\Users\Josiane\Downloads\AdventureWorks2016 (1).mdf',
MOVE 'AdventureWorks2016_Log' TO 'C:\Users\Josiane\Downloads\AdventureWorks2016 (1).ldf' 
