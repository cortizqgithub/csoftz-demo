/*==========================================================================*/
/* Source File:   IPRODUCTDATASERVICE.CS                                    */
/* Description:   Business Logic interface for Product domain objects       */
/* Author:        Carlos Adolfo Ortiz Quir—s (COQ)                          */
/* Date:          Dec.24/2010                                               */
/* Last Modified: Jan.06/2011                                               */
/* Version:       1.2                                                       */
/* Copyright (c), 2010, 2011 CSoftZ                                         */
/*==========================================================================*/

/*===========================================================================
 History
 Dec.24/2010 COQ  File created.
 ============================================================================*/
package com.csoftz.demo.intr.data;

import java.util.List;
import com.csoftz.demo.domain.ProductInfo;
import com.csoftz.demo.domain.search.ProductSearchInfo;

/**
 * Business Logic interface for Product domain objects
 * 
 * @since 1.5(JDK), Dec.24/2010
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.2, Jan.06/2011
 */
public interface IProductDataService {

	/**
	 * Given the ProductId by some means gets a record from list, be it a table
	 * or memory list or any other repository content.
	 * 
	 * @param ProductId
	 *            Id of record to locate.
	 * @return A reference to record found or null if no record found.
	 */
	public ProductInfo get(int productId);

	/**
	 * Given the ProductId and Product removes it from database.
	 * 
	 * @param ProductId
	 *            Id of record to locate.
	 */
	public void remove(int productId);

	/**
	 * Retrieves a full list of objects.
	 * 
	 * @return A list of Product domain objects. If no records were found then
	 *         the list is empty.
	 */
	public List<ProductInfo> getAll();

	/**
	 * Given the info record saves it to repository.
	 * 
	 * @param info
	 *            Record information to save.
	 */
	public void save(ProductInfo info);

	/**
	 * Given the info record updates it to repository.
	 * 
	 * @param info
	 *            Record information to update.
	 */
	public void update(ProductInfo info);

	/**
	 * Given the info parameter criteria performs a search in the domain space
	 * to locate records that satisfies the given search criteria.
	 * 
	 * @param info
	 *            Search parameter criteria. It is up to implementer to decide
	 *            what to do with the fields therein.
	 * @return
	 */
	public List<ProductInfo> findAllWith(ProductSearchInfo info);
}
