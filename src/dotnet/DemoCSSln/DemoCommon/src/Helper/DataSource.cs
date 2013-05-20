/*==========================================================================*/
/* Source File:   DATASOURCE.CS                                             */
/* Description:   Helper class to hold settings for database operations.    */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.02/2010                                               */
/* Last Modified: Dec.02/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.02/2010 COQ  File created.
============================================================================*/

using System;
using CSoftZ.Demo.Common.Helper.Data.Linq;

namespace CSoftZ.Demo.Common.Helper {
    /// <summary>
    /// Helper class to hold settings for database operations.
    /// </summary>
    public class DataSource {
        // The ADO.Net connection string. This is injected by IoC.
        public String Connection { get; set; }

        /// <summary>
        /// Sets an object instance for Database operations.
        /// </summary>
        /// <returns></returns>
        public CSoftZDemoDataModel RetrieveDBContext() {
            return new CSoftZDemoDataModel(Connection);
        }
    }
}
