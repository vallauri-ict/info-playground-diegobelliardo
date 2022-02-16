ALTER TABLE Student
ADD CONSTRAINT FK_StudentClass FOREIGN KEY (IdClass) REFERENCES Class(Id)

ALTER TABLE Mark
ADD CONSTRAINT FK_MarkStudent FOREIGN KEY (IdStudent) REFERENCES Student(Id)

CREATE TABLE ClassTeacherSubject(
[Id] INT NOT NULL PRIMARY KEY,
[IdClass] INT NOT NULL,
[IdTeacher] INT NOT NULL,
[IdSubject] INT NOT NULL,
[NumHours] INT,

CONSTRAINT FK_ThisClass FOREIGN KEY ([IdClass]) REFERENCES Class(Id),
CONSTRAINT FK_ThisTeacher FOREIGN KEY ([IdTeacher]) REFERENCES Teacher(Id),
CONSTRAINT FK_ThisSubject FOREIGN KEY ([IdSubject]) REFERENCES Subject(Id),
)

CREATE TABLE MarkClassTeacherSubject(
[Id] INT NOT NULL PRIMARY KEY,
[IdMark] INT NOT NULL,
[IdClassTeacherSubject] INT NOT NULL,
CONSTRAINT FK_ThisMark FOREIGN KEY ([IdMark]) REFERENCES Mark(Id),
CONSTRAINT FK_ThisClassTeacherSubject FOREIGN KEY ([IdClassTeacherSubject]) REFERENCES ClassTeacherSubject(Id)
)
