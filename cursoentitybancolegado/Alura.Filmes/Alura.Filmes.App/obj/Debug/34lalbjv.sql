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

ALTER TABLE [Atores] DROP CONSTRAINT [PK_Atores];

GO

EXEC sp_rename N'Atores', N'actor';

GO

EXEC sp_rename N'actor.UltimoNome', N'last_name', N'COLUMN';

GO

EXEC sp_rename N'actor.PrimeiroNome', N'first_name', N'COLUMN';

GO

EXEC sp_rename N'actor.Id', N'actor_id', N'COLUMN';

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'last_name');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [actor] ALTER COLUMN [last_name] varchar(45) NOT NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'actor') AND [c].[name] = N'first_name');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [actor] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [actor] ALTER COLUMN [first_name] varchar(45) NOT NULL;

GO

ALTER TABLE [actor] ADD [last_update] datetime NOT NULL DEFAULT '0001-01-01T00:00:00.000';

GO

ALTER TABLE [actor] ADD CONSTRAINT [PK_actor] PRIMARY KEY ([actor_id]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230719141239_ShadowPropertie', N'2.0.0-rtm-26452');

GO

