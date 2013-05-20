/*==========================================================================*/
/* Source File:   LINQABSTRACTBASE.CS                                       */
/* Description:   Common methods for LINQ procewssing.                      */
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

using CSoftZ.Demo.Common.Helper;
using CSoftZ.Demo.Common.Helper.Data.Linq;

namespace CSoftZ.Demo.Data.Db.Linq {
    public abstract class LinqAbstractBase {
        // Injected by IoC. Access to a helper class for database connection 
        // settings.
        public DataSource DS{get; set;}

        // Access to the ORM tool to the database. Layer using ADo.NET with Linq to Entities.
        private CSoftZDemoDataModel dbCtx = null;

        /// <summary>
        /// Expose Database context as a property. It is read-only.
        /// </summary>
        public CSoftZDemoDataModel DbCtx {
            get { return dbCtx; }
        }

        /// <summary>
        /// Connect to database throug LINQ to Entities.
        /// </summary>
        /// <returns></returns>
        protected void InitCtx() {
            dbCtx = new CSoftZDemoDataModel(DS.Connection);
            //dbCtx = new CSoftZDemoDataModel();
        }

        /// <summary>
        /// Make all descendants implement this method to ensure 
        /// helper methods work flawlessly.
        /// </summary>
        public abstract void SetupHelpers();
    }
}
    