/*==========================================================================*/
/* Source File:   PRODUCTFILTERCRITERIAINFO.VB                              */
/* Description:   Domain object to hold ProductFilterCriteria values        */ 
/*                to fill combo boxes.                                      */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Sep.02/2010 COQ  File created.
============================================================================*/

namespace CSoftZ.Demo.Domain {
    /// <summary>
    /// Domain object to hold ProductFilterCriteria values to fill
    /// combo boxes.
    /// </summary>
    public class ProductFilterCriteriaInfo : AbstractDescriptiveCommonDomain {
         /// <summary>
        /// Default constructor.
        /// </summary>
        public ProductFilterCriteriaInfo() {
            base.Clear();
        }
    }
}
