/*==========================================================================*/
/* Source File:   DBPRODUCTSERVICE.JAVA                                     */
/* Description:   Business Logic which implements  interface for Product    */
/*                domain objects                                            */
/* Author:        Carlos Adolfo Ortiz Quir—s (COQ)                          */
/* Date:          Dec.24/2010                                               */
/* Last Modified: Jan.06/2011                                               */
/* Version:       1.3                                                       */
/* Copyright (c), 2010, 2011 CSoftZ                                         */
/*==========================================================================*/

/*===========================================================================
 History
 Dec.24/2010 COQ  File created.
 ============================================================================*/
package com.csoftz.demo.service.db;

import java.util.List;

import org.springframework.beans.factory.InitializingBean;

import com.csoftz.demo.domain.ProductInfo;
import com.csoftz.demo.domain.search.ProductSearchInfo;
import com.csoftz.demo.intr.data.IProductDataService;

/**
 * This is the business domain interface to get all Product information domain
 * objects.<br/>
 * </br> It all depends on the implementer to decide if it is a database table,
 * a memory list, a file, etc.
 * 
 * @since 1.5(JDK), Dec.24/2010
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.3, Jan.06/2011
 */
public class DbProductService implements InitializingBean, IProductDataService {

	/**
	 * Injected by IoC.
	 */
	private IProductDataService productData;

	/**
	 * If the object reference dependency properties are not properly set, an
	 * exception is thrown indicating that they are required to be configured
	 * for the bean to work properly.
	 * 
	 * @see org.springframework.beans.factory.InitializingBean#afterPropertiesSet()
	 */
	@Override
	public void afterPropertiesSet() throws Exception {
		if (productData == null) {
			throw new Exception("productData property is not assigned.");
		}
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#get(int)
	 */
	@Override
	public ProductInfo get(int productId) {
		return productData.get(productId);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#remove(int)
	 */
	@Override
	public void remove(int productId) {
		productData.remove(productId);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#getAll()
	 */
	@Override
	public List<ProductInfo> getAll() {
		return productData.getAll();
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#save(com.csoftz.demo.domain
	 *      .ProductInfo)
	 */
	@Override
	public void save(ProductInfo info) {
		productData.save(info);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#update(com.csoftz.demo.
	 *      domain.ProductInfo)
	 */
	@Override
	public void update(ProductInfo info) {
		productData.update(info);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#findAllWith(com.csoftz.demo.domain.search.ProductSearchInfo)
	 */
	@Override
	public List<ProductInfo> findAllWith(ProductSearchInfo info) {
		return productData.findAllWith(info);
	}

	/**
	 * This injected by IoC.
	 * 
	 * @param productData
	 */
	public void setProductData(IProductDataService productData) {
		this.productData = productData;
	}
}
