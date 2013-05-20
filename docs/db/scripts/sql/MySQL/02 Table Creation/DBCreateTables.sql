/*----------------------------------------------------------------------------*/
/* File:           DBCREATETABLES.SQL                                         */
/* Description:    Rules, user defined types, etc.                            */
/* Author:         Carlos Adolfo Ortiz Quirós (COQ)                           */
/* Date:           Jan.05/2011                                                */
/* Last Modified:  Jan.05/2011                                                */
/* Version:        1.1                                                        */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
History
Jan.05/2011 COQ  File created.
------------------------------------------------------------------------------*/

--  always requires a table to have a PK.
CREATE TABLE Product(
  ProductId       INT           NOT NULL AUTO_INCREMENT,
  Name            NVARCHAR(60)  NOT NULL,
  eMail           NVARCHAR(100) NOT NULL,
  Phone           NVARCHAR(20)  NOT NULL,
  Address         NVARCHAR(200) NOT NULL,
  City            NVARCHAR(100) NOT NULL,
  Estate          NVARCHAR(100) NOT NULL,
  Country         NVARCHAR(100) NOT NULL,
  DateCreated     DATETIME      NOT NULL,
  DateModified    DATETIME      NOT NULL,
  Active          SMALLINT      NOT NULL DEFAULT 1, -- 0: False, 1: True
  PRIMARY KEY PK_Product (ProductId)
);

 INSERT INTO Product(Name,eMail,Phone,Address,City,Estate,Country,DateCreated,DateModified,Active)
VALUES