CREATE TABLE [dbo].[Table] (
    [Code]             INT           NOT NULL,
    [Pass]             NVARCHAR (50) NOT NULL,
    [Name]             NVARCHAR (50) NOT NULL,
    [Family]           NVARCHAR (50) NOT NULL,
    [Region]           INT           NULL,
    [Addres]           NVARCHAR (50) NULL,
    [TypeOfRestaurant] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC)
);

