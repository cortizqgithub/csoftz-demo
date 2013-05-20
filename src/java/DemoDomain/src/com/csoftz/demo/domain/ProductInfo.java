/*----------------------------------------------------------------------------*/
/* Source File:   PRODUCTINFO.JAVA                                            */
/* Description:   The domain info class for Product objects.                  */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Dec.24/2010                                                 */
/* Last Modified: Jan.06/2011                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2010 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Dec.24/2010 COQ  File created.
 -----------------------------------------------------------------------------*/

package com.csoftz.demo.domain;

import java.io.Serializable;
import java.util.Date;

import javax.validation.constraints.Max;
import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

/**
 * The domain info class for Product objects. 
 * 
 * @since 1.5(JDK), Dec.24/2010
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.2, Jan.06/2011
 */
public class ProductInfo extends AbstractCommonDomain implements Serializable {
	/**
	 * Serialization Id.
	 */
	private static final long serialVersionUID = -5498035032105722619L;

	/* private fields */
	private int productId;
	
	@NotNull
	@Size(min=1, max=60)
	private String name;
	
    @NotNull
	@Size(min=1, max=100)
	private String eMail;
    
    @NotNull
	@Size(min=1, max=20)
	private String phone;
    
    @NotNull
	@Size(min=1, max=100)
	private String address;
    
    @NotNull
	@Size(min=1, max=100)
	private String city;
    
    @NotNull
	@Size(min=1, max=100)
	private String estate;
    
    @NotNull
	@Size(min=1, max=100)
	private String country;
	private Date dateCreated;
	private Date dateModified;
	
	@NotNull
	@Min(0)
	@Max(1)
	private short active;

	/**
	 * Default constructor.
	 */
	public ProductInfo() {
		this.clear();
	}

	/**
	 * To clear current content status for object.
	 *  @see com.csoftz.demo.domain.AbstractCommonDomain#clear()
	 */
	@Override
	public void clear() {
		productId = 0;
		name = "";
		eMail = "";
		phone = "";
		address = "";
		city = "";
		estate = "";
		country = "";
		dateCreated = new Date();
		dateModified = new Date();
		active = 0;
	}

	/**
	 * @return the productId
	 */
	public int getProductId() {
		return productId;
	}

	/**
	 * @param productId
	 *            the productId to set
	 */
	public void setProductId(int productId) {
		this.productId = productId;
	}

	/**
	 * @return the name
	 */
	public String getName() {
		return name;
	}

	/**
	 * @param name
	 *            the name to set
	 */
	public void setName(String name) {
		this.name = name;
	}

	/**
	 * @return the eMail
	 */
	public String geteMail() {
		return eMail;
	}

	/**
	 * @param eMail
	 *            the eMail to set
	 */
	public void seteMail(String eMail) {
		this.eMail = eMail;
	}

	/**
	 * @return the address
	 */
	public String getAddress() {
		return address;
	}

	/**
	 * @param address
	 *            the address to set
	 */
	public void setAddress(String address) {
		this.address = address;
	}

	/**
	 * @return the city
	 */
	public String getCity() {
		return city;
	}

	/**
	 * @param city
	 *            the city to set
	 */
	public void setCity(String city) {
		this.city = city;
	}

	/**
	 * @return the estate
	 */
	public String getEstate() {
		return estate;
	}

	/**
	 * @param estate
	 *            the estate to set
	 */
	public void setEstate(String estate) {
		this.estate = estate;
	}

	/**
	 * @return the country
	 */
	public String getCountry() {
		return country;
	}

	/**
	 * @param country
	 *            the country to set
	 */
	public void setCountry(String country) {
		this.country = country;
	}

	/**
	 * @return the dateCreated
	 */
	public Date getDateCreated() {
		return dateCreated;
	}

	/**
	 * @param dateCreated
	 *            the dateCreated to set
	 */
	public void setDateCreated(Date dateCreated) {
		this.dateCreated = dateCreated;
	}

	/**
	 * @return the dateModified
	 */
	public Date getDateModified() {
		return dateModified;
	}

	/**
	 * @param dateModified
	 *            the dateModified to set
	 */
	public void setDateModified(Date dateModified) {
		this.dateModified = dateModified;
	}

	/**
	 * @return the active
	 */
	public short getActive() {
		return active;
	}

	/**
	 * @param active
	 *            the active to set
	 */
	public void setActive(short active) {
		this.active = active;
	}

	/**
	 * @return the phone
	 */
	public String getPhone() {
		return phone;
	}

	/**
	 * @param phone the phone to set
	 */
	public void setPhone(String phone) {
		this.phone = phone;
	}
}