/*==========================================================================*/
/* Source File:   MEMORYPRODUCTFILTERCRITERIASERVICE.VB                     */
/* Description:   Concrete implementation of Service for                    */
/*                ProductFilterCriteria operations.                         */
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
using CSoftZ.Demo.Interface;
using CSoftZ.Demo.Domain;

namespace CSoftZ.Demo.Service.Memory {
    /// <summary>
    /// Concrete implementation of Service for ProductFilterCriteria operations.
    /// </summary>
    public class MemoryProductFilterCriteriaService : IProductFilterCriteriaService {
        /// <summary>
        /// Get a list of ProductFilterCriteria objects. 
        /// </summary>
        /// <returns></returns>
        public List<ProductFilterCriteriaInfo> GetAll() {
            var l = new List<ProductFilterCriteriaInfo>() { 
                new ProductFilterCriteriaInfo() { Code = 0, Description = "--ALL--" },
                new ProductFilterCriteriaInfo() { Code = 1, Description = "Name" },
                new ProductFilterCriteriaInfo() { Code = 1, Description = "Address" },
                new ProductFilterCriteriaInfo() { Code = 1, Description = "Phone" }
            };
            return l; 
        }
    }
}
