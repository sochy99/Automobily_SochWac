CREATE TABLE [dbo].[TB_main] (
    [Id]                     INT          NOT NULL IDENTITY,
    [Model]                  VARCHAR (20) NOT NULL,
    [Rok_vyroby]             INT          NOT NULL,
    [Cena]                   INT          NOT NULL,
    [Spotreba]               INT          NOT NULL,
    [Automaticka_prevodovka] BIT          NOT NULL,
    [Vykon]                  INT          NOT NULL,
    [Barva]                  VARCHAR (20) NOT NULL,
    [Palivo_Id]              INT          NOT NULL,
    [Znacka_Id]              INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Palivo] FOREIGN KEY ([Palivo_Id]) REFERENCES [dbo].[TB_palivo] ([Id]),
    CONSTRAINT [FK_Znacka] FOREIGN KEY ([Znacka_Id]) REFERENCES [dbo].[TB_znacka] ([Id])
);

