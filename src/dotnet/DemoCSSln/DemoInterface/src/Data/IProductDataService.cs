/*==========================================================================*/
/* Source File:   IPRODUCTDATASERVICE.CS                                    */
/* Description:   Business Logic interface for Product domain objects       */
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

using System.Collections.Generic;
using CSoftZ.Demo.Domain;

namespace CSoftZ.Demo.Interface {
    /// <summary>
    /// Business Logic interface for Product domain objects
    /// </summary>
    public interface IProductDataService {
        /// <summary>
        /// Given the ProductId by some means gets a record from list, be it a table or
        /// memory list or any other repository content.
        /// </summary>
        /// <param name="ProductId">Id of record to locate.</param>
        /// <returns>A reference to record found or null if no record found.</returns>
        ProductInfo Get(int ProductId);

        /// <summary>
        /// Given the bProductId and Product removes it from database.
        /// </summary>
        /// <param name="ProductId">Id of record to locate.</param>
        void Remove(int ProductId);

        /// <summary>
        /// Retrieves a full list of objects.
        /// </summary>
        /// <returns>A list of Product domain objects. If no records were found then the list is empty.</returns>
        /// <remarks></remarks>
        List<ProductInfo> GetAll();

        /// <summary>
        /// Given the info record saves it to repository.
        /// </summary>
        /// <param name="info">Record information to save.</param>
        void Save(ProductInfo info);

        /// <summary>
        /// Given the info record updates it to repository.
        /// </summary>
        /// <param name="info">Record information to update.</param>
        void Update(ProductInfo info);        
    }
}
