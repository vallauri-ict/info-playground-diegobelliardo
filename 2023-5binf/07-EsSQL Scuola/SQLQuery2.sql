ALTER TABLE CorsiDiLaurea
ADD CONSTRAINT PK_CorsiDiLaurea PRIMARY KEY (CorsoLaurea);

ALTER TABLE Persons
ADD CONSTRAINT PK_Person PRIMARY KEY (ID,LastName);


ALTER TABLE Studenti 
ADD CONSTRAINT StudentiCorsolaurea FOREIGN KEY (CorsoLaurea) REFERENCES CORSIDILAUREA(CorsoLaurea)



ALTER TABLE CorsiDiLaurea
ALTER COLUMN CorsoLaurea VARCHAR(50) NOT NULL;


select name 
   from sysobjects 
  where xtype = 'PK' 
    