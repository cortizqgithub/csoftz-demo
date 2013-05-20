/*==========================================================================*/
/* Source File:   MEMORYPAGESIZEVALUESERVICE.VB                             */
/* Description:   Concrete implementation of Service for                    */
/*                PageSize operations.                                      */
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
using CSoftZ.Demo.Interface;

namespace CSoftZ.Demo.Service.Memory {
    /// <summary>
    /// Concrete implementation of Service for PageSize Operations.
    /// </summary>
    public class MemoryPageSizevalueService : IPageSizeValueService {
        /// <summary>
        /// Get a list of PageSizeInfo objects.
        /// </summary>
        /// <returns></returns>
        public List<PageSizeInfo> GetAll() {
            var l = new List<PageSizeInfo>() {
                new PageSizeInfo() {Code = 5, Description = "5"},
                new PageSizeInfo() {Code = 10, Description = "10"},
                new PageSizeInfo() {Code = 20, Description = "20"},
                new PageSizeInfo() {Code = 75, Description = "75"},
                new PageSizeInfo() {Code = 100, Description = "100"},
                new PageSizeInfo() {Code = 200, Description = "200"}
            };
            return l;
        }
    }
}
