/*==========================================================================*/
/* Source File:   IPRODUCTFILTERCRITERIASERVICE.VB                          */
/* Description:   Service for ProductFilterCriteria operations.             */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.03/2010 COQ  File created.
============================================================================*/

using System.Collections.Generic;
using CSoftZ.Demo.Domain;

namespace CSoftZ.Demo.Interface {
    /// <summary>
    /// Service for ProductFilterCriteria operations.
    /// </summary>
    public interface IProductFilterCriteriaService {
        /// <summary>
        /// Get a list of ProductFilterCriteria objects. 
        /// </summary>
        /// <returns></returns>
        List<ProductFilterCriteriaInfo> GetAll();
    }
}
