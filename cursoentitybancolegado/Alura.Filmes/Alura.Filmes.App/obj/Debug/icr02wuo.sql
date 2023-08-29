IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Atores] (
    [Id] int NOT NULL IDENTITY,
    [PrimeiroNome] nvarchar(max) NOT NULL,
    [UltimoNome] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Atores] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230718191910_MigracaoInicial', N'2.0.0-rtm-26452');

GO

