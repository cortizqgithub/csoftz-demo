/*==========================================================================*/
/* Source File:   DBPRODUCTSERVICE.CS                                       */
/* Description:   Business Logic which implements  interface for Product    */
/*                domain objects                                            */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.02/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.02/2010 COQ  File created.
============================================================================*/

using System;
using System.Collections.Generic;
using CSoftZ.Demo.Domain;
using CSoftZ.Demo.Interface;
using Spring.Objects.Factory;

namespace CSoftZ.Demo.Service.Db {
    /// <summary>
    /// Business Logic  which implements interface for Book domain objects
    /// </summary>
    class DbProductService : IProductDataService, IInitializingObject {
        // Injected by IoC. Access to Data services.
        private IProductDataService _productData = null;

        ///  <summary>
        /// If the object reference dependency properties are not properly set, 
        /// an exception is thrown indicating that they are required to be 
        /// configured for the bean to work properly.
        /// </summary>
        /// <remarks></remarks>
        public void AfterPropertiesSet() {
            if (_productData == null) {
                throw new Exception("productData property is not assigned.");
            }
        }

        /// <summary>
        /// Given the ProductId by some means gets a record from list, be it a table or
        /// memory list or any other repository content.
        /// </summary>
        /// <param name="ProductId">Id of record to locate.</param>
        /// <returns>A reference to record found or null if no record found.</returns>
        public ProductInfo Get(int ProductId) {
            return _productData.Get(ProductId);
        }

        /// <summary>
        /// Given the bProductId and Product removes it from database.
        /// </summary>
        /// <param name="ProductId">Id of record to locate.</param>
        public void Remove(int ProductId) {
            _productData.Remove(ProductId);
        }

        /// <summary>
        /// Retrieves a full list of objects.
        /// </summary>
        /// <returns>A list of Product domain objects. If no records were found then the list is empty.</returns>
        /// <remarks></remarks>
        public List<ProductInfo> GetAll() {
            return _productData.GetAll();
        }

        /// <summary>
        /// Given the info record saves it to repository.
        /// </summary>
        /// <param name="info">Record information to save.</param>
        public void Save(ProductInfo info) {
            _productData.Save(info);
        }

        /// <summary>
        /// Given the info record updates it to repository.
        /// </summary>
        /// <param name="info">Record information to update.</param>
        public  void Update(ProductInfo info) {
            _productData.Update(info);
        }

        /// <summary>
        /// This is injected by IoC. Access to Data Services.
        /// </summary>
        public IProductDataService ProductData {
            set { _productData = value; }
        }
    }
}
