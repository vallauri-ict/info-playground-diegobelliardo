CREATE TABLE [dbo].[Lessons]
(
  [Id] INT NOT NULL IDENTITY,
  [CourseId] INT NOT NULL,
  [Title] NVARCHAR(100) NOT NULL,
  [Description] TEXT NULL,
  [Duration] NVARCHAR(8) NOT NULL DEFAULT('00:00:00'),
  CONSTRAINT PK_Lessons_Id PRIMARY KEY(Id),
  CONSTRAINT FK_Courses_Id FOREIGN KEY(CourseId) REFERENCES Courses(Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

GO