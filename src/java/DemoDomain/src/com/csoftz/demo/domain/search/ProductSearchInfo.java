package com.csoftz.demo.domain.search;

import java.io.Serializable;

import javax.validation.constraints.Size;

import com.csoftz.demo.domain.AbstractCommonDomain;

public class ProductSearchInfo extends AbstractCommonDomain implements
		Serializable {
	/**
	 * Serialization Id.
	 */
	private static final long serialVersionUID = -2646240618203165329L;

	@Size(min = 0, max = 60)
	private String name;

	@Size(min = 0, max = 20)
	private String phone;

	public ProductSearchInfo() {
		this.clear();
	}

	/**
	 * To clear current content status for object.
	 * 
	 * @see com.csoftz.demo.domain.AbstractCommonDomain#clear()
	 */
	@Override
	public void clear() {
		name = "";
		phone = "";
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
	 * @return the phone
	 */
	public String getPhone() {
		return phone;
	}

	/**
	 * @param phone
	 *            the phone to set
	 */
	public void setPhone(String phone) {
		this.phone = phone;
	}
}
