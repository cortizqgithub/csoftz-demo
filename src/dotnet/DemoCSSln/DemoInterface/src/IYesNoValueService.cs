/*==========================================================================*/
/* Source File:   IYESNOVALUESERVICE.VB                                     */
/* Description:   Service for YesNo operations.                             */
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
    /// Service for YesNo operations.
    /// </summary>
    public interface IYesNoValueService {
        /// <summary>
        /// Retrieves a List of Yes/No values.
        /// </summary>
        /// <returns></returns>
        List<YesNoInfo> GetAll();
    }
}
