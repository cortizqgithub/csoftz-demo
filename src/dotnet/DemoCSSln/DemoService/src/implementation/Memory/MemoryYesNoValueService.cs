/*==========================================================================*/
/* Source File:   MEMORYYESNOVALUESSERVICE.VB                               */
/* Description:   Concrete implementation of Service for YesNo operations.  */
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
using CSoftZ.Demo.Common.Helper.Consts;
using CSoftZ.Demo.Interface;
using CSoftZ.Demo.Domain;

namespace CSoftZ.Demo.Service.Memory {
    /// <summary>
    /// Business Logic which implements interface for YesNo domain objects
    /// </summary>
    public class MemoryYesNoValueService : IYesNoValueService {
        /// <summary>
        /// Retrieves a List of Yes/No values.
        /// </summary>
        /// <returns></returns>
        public List<YesNoInfo> GetAll() {
            var l = new List<YesNoInfo>() { 
                new YesNoInfo() { Code = GlobalConstants.NO_VALUE, Description = "No" },
                new YesNoInfo() { Code = GlobalConstants.YES_VALUE, Description = "Yes" }
            };
            return l;
        }
    }
}
