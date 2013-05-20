/*==========================================================================*/
/* Source File:   LINQENTITIESPRODUCTDATA.CS                                */
/* Description:   Data Logic interface implementation for Product domain    */
/*                objects                                                   */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.02/2010                                               */
/* Last Modified: Dec.07/2010                                               */
/* Version:       1.2                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.02/2010 COQ  File created.
============================================================================*/

using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CSoftZ.Demo.Common.Helper.Data.Linq;
using CSoftZ.Demo.Domain;
using CSoftZ.Demo.Interface;

namespace CSoftZ.Demo.Data.Db.Linq.Entities {
    public class LinqEntitiesProductData : LinqAbstractBase, IProductDataService {

        /// <summary>
        /// Make all descendants implement this method to ensure 
        /// helper methods work flawlessly.
        /// </summary>
        public override void SetupHelpers() {
            InitCtx();
            Mapper.Reset();
            Mapper.CreateMap<Product, ProductInfo>();
            Mapper.CreateMap<ProductInfo, Product>();
        }

        /// <summary>
        /// A private helper method to locate single record in database for primary key parameters.
        /// </summary>
        /// <param name="productId">Id to locate record</param>
        /// <returns>A Book instance or null if not found</returns>
        private Product LocateRecord(int productId) {
            var l = (from o in DbCtx.Products
                     where o.ProductId == productId
                     select o);

            Product p = l.FirstOrDefault<Product>();
            return p;
        }

        /// <summary>
        /// Given the ProductId by some means gets a record from list, be it a table or
        /// memory list or any other repository content.
        /// </summary>
        /// <param name="ProductId">Id of record to locate.</param>
        /// <returns>A reference to record found or null if no record found.</returns>
        public ProductInfo Get(int ProductId) {
            SetupHelpers();
            Product p = LocateRecord(ProductId);
            if (p == null) {
                return null;
            }

            ProductInfo info = Mapper.Map<Product, ProductInfo>(p);
            return info;
        }

        /// <summary>
        /// Given the bProductId and Product removes it from database.
        /// </summary>
        /// <param name="ProductId">Id of record to locate.</param>
        public void Remove(int ProductId) {
            SetupHelpers();
            Product p = LocateRecord(ProductId);
            if (p != null) {
                DbCtx.Products.DeleteObject(p);
                DbCtx.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves a full list of objects.
        /// </summary>
        /// <returns>A list of Product domain objects. If no records were found then the list is empty.</returns>
        /// <remarks></remarks>
        public List<ProductInfo> GetAll() {
            SetupHelpers();
            var l = (from o in DbCtx.Products
                     select o);
           List<ProductInfo> lInfo = Mapper.Map<List<Product>, List<ProductInfo>>(l.ToList<Product>());
            return lInfo;
        }

        /// <summary>
        /// Given the info record saves it to repository.
        /// </summary>
        /// <param name="info">Record information to save.</param>
        public void Save(ProductInfo info) {
            SetupHelpers();
            Product p = Mapper.Map<ProductInfo, Product>(info);
            DbCtx.Products.AddObject(p);
            DbCtx.SaveChanges();
        }

        /// <summary>
        /// Given the info record updates it to repository.
        /// </summary>
        /// <param name="info">Record information to update.</param>
        public void Update(ProductInfo info) {
            SetupHelpers();
            Product p = LocateRecord(info.ProductId);
            if (p != null) {
                Mapper.DynamicMap<ProductInfo, Product>(info, p);
                DbCtx.SaveChanges();
            }
        }
    }
}
