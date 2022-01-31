CREATE TABLE [dbo].[Driver] (
    [number]         INT           NOT NULL,
    [full_name]      VARCHAR (100) NULL,
    [country]        CHAR (2)      NOT NULL,
    [date_birth]     DATE          NULL,
    [team_id]        INT           NULL,
    [podiums_number] INT           NULL,
    PRIMARY KEY CLUSTERED ([number] ASC)
);

CREATE TABLE [dbo].[StoricoAggiornamenti] (
    [id]                INT           IDENTITY (1, 1) NOT NULL,
    [number]            INT           NOT NULL,
    [full_name]         VARCHAR (100) NULL,
    [country]           CHAR (2)      NOT NULL,
    [date_birth]        DATE          NULL,
    [team_id]           INT           NULL,
    [podiums_number]    INT           NULL,
    [numberNew]         INT           NOT NULL,
    [full_nameNew]      VARCHAR (100) NULL,
    [countryNew]        CHAR (2)      NOT NULL,
    [date_birthNew]     DATE          NULL,
    [team_idNew]        INT           NULL,
    [podiums_numberNew] INT           NULL,
    [data]              DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[StoricoCancellazioni] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [number]         INT           NOT NULL,
    [full_name]      VARCHAR (100) NULL,
    [country]        CHAR (2)      NOT NULL,
    [date_birth]     DATE          NULL,
    [team_id]        INT           NULL,
    [podiums_number] INT           NULL,
    [data]           DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);