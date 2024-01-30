CREATE TABLE [dbo].[LeaderBoard] (
    [PlayerID]           INT  NOT NULL,
    [PlayerName]   NVARCHAR (3)     NOT NULL,
    [WavesReached]      INT NOT NULL,
    [TotalEnemiesKilled] INT NOT NULL,
    [TotalCoinsEarned]   INT NOT NULL,
    CONSTRAINT [PK_LeaderBoard] PRIMARY KEY CLUSTERED ([PlayerID] ASC)
);

