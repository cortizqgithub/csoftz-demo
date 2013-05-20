/*----------------------------------------------------------------------------*/
/* File:           DBCREATETABLES.SQL                                         */
/* Description:    Rules, user defined types, etc.                            */
/* Author:         Carlos Adolfo Ortiz Quirós (COQ)                           */
/* Date:           Dec.01/2010                                                */
/* Last Modified:  Dec.01/2010                                                */
/* Version:        1.1                                                        */
/* Copyright (c), 2010 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
History
Dec.01/2010 COQ  File created.
------------------------------------------------------------------------------*/

-- LINQ/SQL always requires a table to hava a PK.
CREATE TABLE Product(
  ProductId INT IDENTITY(1,1)   NOT NULL,
  Name            NVARCHAR(60)  NOT NULL,
  eMail           NVARCHAR(100) NOT NULL,
  Phone           NVARCHAR(20)  NOT NULL,
  Address         NVARCHAR(200) NOT NULL,
  City            NVARCHAR(100) NOT NULL,
  Estate          NVARCHAR(100) NOT NULL,
  Country         NVARCHAR(100) NOT NULL,
  DateCreated     DATETIME      NOT NULL,
  DateModified    DATETIME      NOT NULL,
  Active          SMALLINT      NOT NULL DEFAULT 1 -- 0: False, 1: True
);
GO

ALTER TABLE Product
ADD CONSTRAINT PK_Product PRIMARY KEY CLUSTERED
(
  ProductId
);
GO
