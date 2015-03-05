CREATE TABLE [dbo].[Demonstration]
(
	[DemonstrationId]	INT				NOT NULL IDENTITY,
	[SomeDescription]	VARCHAR(200)	NOT NULL,
	[SomeNumber]		INT				NOT NULL,
	[SomeFlag]			BIT				NOT NULL DEFAULT 0, 
	[CreationDate]		DATETIME		NOT NULL DEFAULT GETDATE(),
	[EditionDate]		DATETIME			NULL,

	CONSTRAINT [PK_Demonstration] PRIMARY KEY ([DemonstrationId]),

)
