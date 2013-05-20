/*==========================================================================*/
/* Source File:   PAGESIZEINFO.VB                                           */
/* Description:   Domain object to hold PageSize values to fill combo boxes */ 
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Sep.01/2010 COQ  File created.
============================================================================*/

namespace CSoftZ.Demo.Domain {
    /// <summary>
    /// Domain object to hold PageSize values to fill combo boxes.
    /// </summary>
    public class PageSizeInfo : AbstractDescriptiveCommonDomain {
         /// <summary>
        /// Default constructor.
        /// </summary>
        public PageSizeInfo() {
            base.Clear();
        }
    }
}
