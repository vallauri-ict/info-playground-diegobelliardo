--step 1
USE [C:\USERS\FENIC\DESKTOP\INFO-PLAYGROUND-DIEGOBELLIARDO\2022-5BINF\08-ENDRYPTDB\DBPROVA.MDF] ;  
CREATE MASTER KEY ENCRYPTION BY   
PASSWORD = 'prova';  
--DROP MASTER KEY

CREATE TABLE TABLE3 
(ID int,
PERSONNAME nvarchar(200),
AGE int,
HOBBY nvarchar(200),
SALARY varbinary(128))

--step 3
CREATE CERTIFICATE MyCertificate1
   WITH SUBJECT = 'Secret info - Salary';  
GO  
--drop CERTIFICATE MyCertificate1

CREATE SYMMETRIC KEY SSN_Key_01  
    WITH ALGORITHM = AES_256  
    ENCRYPTION BY CERTIFICATE MyCertificate1;  
GO  
--drop SYMMETRIC KEY SSN_Key_01 

--step 4
OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE MyCertificate1;  

INSERT INTO TABLE3 VALUES 
(1,'Alex',40,'skateboarding', EncryptByKey(Key_GUID('SSN_Key_01'), '1000')),
(2,'John',32,'wrestling',EncryptByKey(Key_GUID('SSN_Key_01'), '1500')),
(3,'Asti',25,'jogging',EncryptByKey(Key_GUID('SSN_Key_01'), '24560')),
(4,'Jay',53,'football',EncryptByKey(Key_GUID('SSN_Key_01'), '502')),
(5,'Selena',40,'yoga',EncryptByKey(Key_GUID('SSN_Key_01'), '2500'))
--truncate table TABLE3
--DROP TABLE TABLE3

--step 5
OPEN SYMMETRIC KEY SSN_Key_01  
   DECRYPTION BY CERTIFICATE MyCertificate1;  

SELECT *, CONVERT(varchar, DecryptByKey(SALARY)) AS [Decrypted Salary]
FROM TABLE3

CLOSE SYMMETRIC KEY SSN_Key_01