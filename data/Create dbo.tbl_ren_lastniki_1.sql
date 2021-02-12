USE [Komunala_DB_test]
GO

/****** Object: Table [dbo].[tbl_ren_lastniki] Script Date: 12. 02. 2021 14:47:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ren_lastniki] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [nen_id]         NCHAR (11)     NULL,
    [emso_ms]        NVARCHAR (13)  NULL,
    [ime]            NVARCHAR (255) NULL,
    [naslov]         NVARCHAR (255) NULL,
    [leto]           NCHAR (4)      NULL,
    [delez_stev_izr] INT            NULL,
    [delez_imen_izr] INT            NULL,
    [delez_proc]     FLOAT (53)     NULL,
    [status]         NCHAR (3)      NULL
);


