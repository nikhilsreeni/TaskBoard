CREATE TABLE [dbo].[User] (
    [UserID] UNIQUEIDENTIFIER  DEFAULT (newid()) NOT NULL,
    [UserName]  NVARCHAR (50) NULL,
	[Password]  NVARCHAR (50) NULL,
	[DateOfBirth]   DATETIME  NULL,
	[CreatedDate]   DATETIME  DEFAULT (getdate()) NULL,
    [ModifedDate]   DATETIME DEFAULT (getdate()) NULL,
    [CreatedBy] NVARCHAR(50) NULL, 
    [ModifiedBy] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserID] ASC),
	CONSTRAINT UC_UserName UNIQUE([UserName])  
);

