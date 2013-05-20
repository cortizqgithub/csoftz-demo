/*==========================================================================*/
/* Source File:   JDBCPRODUCTDATA.JAVA                                      */
/* Description:   Data Logic which implements  interface for Product        */
/*                domain objects                                            */
/* Author:        Carlos Adolfo Ortiz Quir—s (COQ)                          */
/* Date:          Jan.05/2011                                               */
/* Last Modified: Jan.10/2011                                               */
/* Version:       1.4                                                       */
/* Copyright (c), 2011 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
 History
 Jan.05/2011 COQ  File created.
 ============================================================================*/
package com.csoftz.demo.data.db.jdbc;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.sql.Types;
import java.util.List;

import javax.sql.DataSource;

import org.springframework.jdbc.core.SqlParameter;
import org.springframework.jdbc.object.MappingSqlQuery;
import org.springframework.jdbc.object.SqlUpdate;

import com.csoftz.demo.domain.ProductInfo;
import com.csoftz.demo.domain.search.ProductSearchInfo;
import com.csoftz.demo.intr.data.IProductDataService;

/**
 * This is the persistence domain interface implementation to get all Product
 * information domain objects.<br/>
 * </br> It all depends on the implementer to decide if it is a database table,
 * a memory list, a file, etc.
 * 
 * @since 1.5(JDK), Jan.05/2011
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.4, Jan.10/2011
 */
@SuppressWarnings("unchecked")
public class JdbcProductData extends AbstractJdbcData implements
		IProductDataService {

	/**
	 * Default constructor.
	 */
	public JdbcProductData() {
		super();
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#get(int)
	 */
	@Override
	public ProductInfo get(int productId) {
		String qry = sqlSelectForPK;
		List<Object> values = new ArrayList<Object>();
		values.add(productId);
		ProductListQuery info = new ProductListQuery(getDataSource(), qry);
		info.declareParameter(new SqlParameter(Types.INTEGER));
		info.compile();
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing get(int)");
			getLog().debug("qry: [" + qry + "], ");
			getLog().debug("Using parameters: " + values.toString());
		}
		List<ProductInfo> productList = info.execute(values.toArray());
		if (productList.isEmpty()) {
			return null;
		}
		return productList.get(0);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#remove(int)
	 */
	@Override
	public void remove(int productId) {
		String qry = sqlDelete;
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing remove(int)");
			getLog().debug("qry: [" + qry + "] ");
			getLog().debug("Using key=[" + productId + "]");
		}

		SqlUpdate su = new SqlUpdate(getDataSource(), qry);
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.compile();

		Object[] params = new Object[] { productId };
		su.update(params);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#getAll()
	 */
	@Override
	public List<ProductInfo> getAll() {
		String qry = sqlSelect;
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing getAll()");
			getLog().debug("qry: [" + qry + "]");
		}
		ProductListQuery info = new ProductListQuery(getDataSource(), qry);
		info.compile();
		return info.execute();
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#save(com.csoftz.demo.domain.ProductInfo)
	 */
	@Override
	public void save(ProductInfo info) {
		String qry = sqlInsert;
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing save(ProductInfo)");
			getLog().debug("qry: [" + qry + "] ");
			getLog().debug("Using info=[" + info.toString() + "]");
		}
		SqlUpdate su = new SqlUpdate(getDataSource(), qry);
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.DATE));
		su.declareParameter(new SqlParameter(Types.DATE));
		su.declareParameter(new SqlParameter(Types.SMALLINT));
		su.compile();

		Object[] params = new Object[] { info.getName(), info.geteMail(),
				info.getPhone(), info.getAddress(), info.getCity(),
				info.getEstate(), info.getCountry(), info.getDateCreated(),
				info.getDateModified(), info.getActive() };
		su.update(params);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#update(com.csoftz.demo.domain.ProductInfo)
	 */
	@Override
	public void update(ProductInfo info) {
		String qry = sqlUpdate;
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing update(ProductInfo)");
			getLog().debug("qry: [" + qry + "] ");
			getLog().debug("Using info=[" + info.toString() + "]");
		}
		SqlUpdate su = new SqlUpdate(getDataSource(), qry);
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.VARCHAR));
		su.declareParameter(new SqlParameter(Types.DATE));
		su.declareParameter(new SqlParameter(Types.SMALLINT));
		su.declareParameter(new SqlParameter(Types.INTEGER));

		su.compile();

		Object[] params = new Object[] { info.getName(), info.geteMail(),
				info.getPhone(), info.getAddress(), info.getCity(),
				info.getEstate(), info.getCountry(), info.getDateModified(),
				info.getActive(), info.getProductId() };
		su.update(params);
	}

	/**
	 * See documentation in the following link.
	 * 
	 * @see com.csoftz.demo.intr.data.IProductDataService#findAllWith(com.csoftz.demo.domain.search.ProductSearchInfo)
	 */
	@Override
	public List<ProductInfo> findAllWith(ProductSearchInfo info) {
		String qry = sqlSelect;
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing findAllWith()");
			getLog().debug("qry: [" + qry + "]");
			getLog().debug("Using criteria: " + info);
		}
		if (info.getName().equals("") && info.getPhone().equals("")) {
			if (getLog().isDebugEnabled()) {
				getLog().debug("Full records retrieved.");
			}
			return getAll();
		} else {
			if (getLog().isDebugEnabled()) {
				getLog().debug("Search criteria search scan.");
			}
			String sWhere = "";
			if (!info.getName().equals("")) {
				if ("".equals(sWhere)) {
					sWhere = " WHERE ";
				}
				sWhere += " Name LIKE '%" + info.getName() + "%'";
			}
			if (!info.getPhone().equals("")) {
				if ("".equals(sWhere)) {
					sWhere = " WHERE ";
				} else {
					sWhere += " OR ";
				}
				sWhere += "  Phone LIKE '%" + info.getPhone() + "%'";
			}
			String sqlFind = sqlSelect + sWhere;
			if (getLog().isDebugEnabled()) {
				getLog().debug("Qry to use=[" + sqlFind + "]");
			}
			ProductListQuery data = new ProductListQuery(getDataSource(),
					sqlFind);
			data.compile();
			return data.execute();
		}
	}

	// ~========================================================================
	// ~ Private MappingSqlQueries
	// ~========================================================================

	// Query to get a list of domain objects

	/**
	 * This class is used as an event listener when retrieving records from
	 * database.
	 * 
	 */
	@SuppressWarnings("rawtypes")
	private class ProductListQuery extends MappingSqlQuery {
		/**
		 * @param ds
		 *            datasource to connect to database.
		 * @param sql
		 *            SQL statement to use/execute;
		 */
		public ProductListQuery(DataSource ds, String sql) {
			super(ds, sql);
		}

		/*
		 * (non-Javadoc)
		 * 
		 * @see
		 * org.springframework.jdbc.object.MappingSqlQuery#mapRow(java.sql.ResultSet
		 * , int)
		 */
		protected Object mapRow(ResultSet rs, int rowNum) throws SQLException {
			ProductInfo p = new ProductInfo();
			p.setProductId(rs.getInt("ProductId"));
			p.setName(rs.getString("Name"));
			p.seteMail(rs.getString("eMail"));
			p.setPhone(rs.getString("Phone"));
			p.setAddress(rs.getString("Address"));
			p.setCity(rs.getString("City"));
			p.setEstate(rs.getString("Estate"));
			p.setCountry(rs.getString("Country"));
			p.setDateCreated(rs.getDate("DateCreated"));
			p.setDateModified(rs.getDate("DateModified"));
			p.setActive(rs.getShort("active"));
			return p;
		}
	}
}
