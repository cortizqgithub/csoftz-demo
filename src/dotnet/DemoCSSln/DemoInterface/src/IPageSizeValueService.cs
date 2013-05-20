/*==========================================================================*/
/* Source File:   IPAGESIZEVALUESERVICE.VB                                  */
/* Description:   Service for PageSize operations.                          */
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
    /// Service for PageSize operations.
    /// </summary>
    public interface IPageSizeValueService {
        /// <summary>
        /// Get a list of PageSizeInfo objects.
        /// </summary>
        /// <returns></returns>
        List<PageSizeInfo> GetAll();
    }
}
