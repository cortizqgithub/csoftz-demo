/*----------------------------------------------------------------------------*/
/* Source File:   PRODUCTCONTROLLER.JAVA                                      */
/* Description:   Controller class for product page                           */
/* Author:        Carlos Adolfo Ortiz Quir—s (COQ)                            */
/* Date:          Jan.04/2011                                                 */
/* Last Modified: Jan.07/2011                                                 */
/* Version:       1.3                                                         */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Jan.04/2011 COQ  File created.
 -----------------------------------------------------------------------------*/

package com.csoftz.demo.web;

import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.validation.Valid;

import org.springframework.beans.factory.InitializingBean;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.csoftz.demo.common.consts.GlobalConstants;
import com.csoftz.demo.common.consts.RequestConstants;
import com.csoftz.demo.domain.ProductInfo;
import com.csoftz.demo.domain.search.ProductSearchInfo;
import com.csoftz.demo.intr.data.IProductDataService;

/**
 * Controller class for home page (HOME.JSP)
 * 
 * @since 1.5(JDK), Jan.04/2011
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.3, Jan.07/2011
 */
@Controller
@RequestMapping(value = "/product")
public class ProductController extends AbstractComponentBaseController
		implements InitializingBean {

	/**
	 * This is injected by IoC. Access to products.
	 */
	private IProductDataService productService = null;

	/**
	 * This is the welcome page or index page for Products.<br/>
	 * Responds to the URI GET: {webapp}/product
	 * 
	 * @param model
	 *            Values to pass through to view.
	 * @return View name to render
	 */
	@RequestMapping(value = "", method = RequestMethod.GET)
	public String index(Model model, HttpServletRequest request) {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /product request. Index Action");
		}
		List<ProductInfo> l = productService.getAll();
		model.addAttribute("productSearchInfo", new ProductSearchInfo());
		model.addAttribute("productList", l);
		model.addAttribute("productListEmpty", l.isEmpty());
		
		String msgBox = (String) request.getSession(true).getAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG);
		request.getSession(true).removeAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG);
		if (msgBox == null) {
			msgBox = "";
		}
		model.addAttribute(RequestConstants.REQUEST_HTTP_MSG_BOX, msgBox);
		if (getLog().isDebugEnabled()) {
			getLog().debug("End Index Action.");
		}
		return "product/index";
	}

	/**
	 * This is the entry point to creating new record.<br/>
	 * Responds to the URI GET: {webapp}/product/create
	 * 
	 * @param model
	 *            Values to pass through to view.
	 * 
	 * @return View name to render
	 */
	@RequestMapping(value = "/create", method = RequestMethod.GET)
	public String create(Model model) {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /product/create request. Create Action.");
		}
		model.addAttribute(RequestConstants.REQUEST_HTTP_FORM_COMMAND,
				RequestConstants.REQUEST_HTTP_FORM_COMMAND_CREATE);
		model.addAttribute("productInfo", new ProductInfo());
		model.addAttribute("message", "Creating new record");
		if (getLog().isDebugEnabled()) {
			getLog().debug("End Create Action.");
		}
		return "product/edit";
	}

	/**
	 * This is the entry to edit a record.<br/>
	 * Responds to the URI GET: {webapp}/product/edit/{id}. Notice: It is passed
	 * an id to work on.
	 * 
	 * @param id
	 *            Primary key for record.
	 * @param model
	 *            Values to pass through to view.
	 * @return View name to render
	 */
	@RequestMapping(value = "/edit/{id}", method = RequestMethod.GET)
	public String edit(@PathVariable int id, Model model) {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /product/edit request. Edit Action.");
			getLog().debug("Using id=[" + id + "]");
		}
		model.addAttribute(RequestConstants.REQUEST_HTTP_FORM_COMMAND,
				RequestConstants.REQUEST_HTTP_FORM_COMMAND_EDIT);
		model.addAttribute("productInfo", productService.get(id));
		model.addAttribute("message", "Editing  record");
		if (getLog().isDebugEnabled()) {
			getLog().debug("End Edit Action.");
		}
		return "product/edit";
	}

	/**
	 * This action is responsible of saving a new record or update a record as
	 * well. <br/>
	 * Responds to the URI POST: {webapp}/product/update
	 * 
	 * @param info
	 *            Record information domain object to process.
	 * @param result
	 *            Result of binding HTTP objects to form instance fields.
	 * @param model
	 *            Values to pass through to view.
	 * @param request
	 *            The HTTP Request object.
	 * @return View name to render
	 */
	@RequestMapping(value = "/update", method = RequestMethod.POST)
	public String update(@Valid ProductInfo info, BindingResult result,
			Model model, HttpServletRequest request) {
		String msg = "";
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /product/update request. Update Action.");
		}
		if (result.hasErrors()) {
			return "product/edit";
		}
		// Decide if it is a new record or record update.
		if (info.getProductId() == 0) {
			if (getLog().isDebugEnabled()) {
				getLog().debug("Saving Record information (Create).");
			}
			try {
				productService.save(info);
				msg = composeMsgBoxMessage("Product created successfully.", "success", GlobalConstants.MSGBOX_DELAY_MILISECS);
				request.getSession(true).setAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG, msg);
			} catch (Exception e) {
				msg = composeMsgBoxMessage("Something went wrong creating the Product, ask your supplier for explanations.", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
				request.getSession(true).setAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG, msg);
			}
			
		} else {
			if (getLog().isDebugEnabled()) {
				getLog().debug("Saving Record information (Update).");
			}
			try {
				productService.update(info);
				msg = composeMsgBoxMessage("Product updated successfully.", "success", GlobalConstants.MSGBOX_DELAY_MILISECS);
				request.getSession(true).setAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG, msg);
			} catch (Exception e) {
				msg = composeMsgBoxMessage("Something went wrong updating the Product, ask your supplier for explanations.", "error", GlobalConstants.MSGBOX_DELAY_MILISECS);
				request.getSession(true).setAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG, msg);
			}
		}
		if (getLog().isDebugEnabled()) {
			getLog().debug("End Update Action.");
		}
		return "redirect:";
	}

	/**
	 * Action to search records.<br/>
	 * Responds to the URI GET: {webapp}/product/search.
	 * 
	 * @param info
	 *            Record information domain object to process.
	 * @param result
	 *            Result of binding HTTP objects to form instance fields.
	 * @param model
	 *            Values to pass through to view.
	 * @param request
	 *            The HTTP Request object.
	 * @return View name to render
	 */
	@RequestMapping(value = "/search", method = RequestMethod.POST)
	public String search(@Valid ProductSearchInfo info, BindingResult result,
			Model model, HttpServletRequest request) {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /product/search request. Search Action.");
		}
		if (result.hasErrors()) {
			model.addAttribute("productListEmpty", false);
			return "product/index";
		}

		// Start logic to search records.
		List<ProductInfo> l = productService.findAllWith(info);
		model.addAttribute("productSearchInfo", info);
		model.addAttribute("productList", l);
		model.addAttribute("productListEmpty", l.isEmpty());
		if (getLog().isDebugEnabled()) {
			getLog().debug("End Search Action.");
		}
		return "product/index";
	}

	/**
	 * Selected records to be deleted.<br/>
	 * Responds to the URI POST: {webapp}/product/delete
	 * 
	 * @param model
	 * @param request
	 *            The HTTP Request object.
	 * @return View name to render
	 */
	@RequestMapping(value = "/delete", method = RequestMethod.POST)
	public String delete(Model model, HttpServletRequest request) {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /product/delete request. Delete Action.");
		}
		// Delete logic here.
		String[] strValues = request.getParameterValues("recToDel");
		boolean isValidDelete = true;
		if (strValues != null && strValues.length > 0) {
			for (int i = 0; i < strValues.length; i++) {
				String s = strValues[i];
				try {
					productService.remove(Integer.parseInt(s));
				} catch (Exception e) {
					isValidDelete = false;
					getLog().info(s);
					e.printStackTrace();
				}
			}
		}
		String msg = "";
		if (isValidDelete) {
			msg = composeMsgBoxMessage(
					"Selected records successfully removed.", "success",
					GlobalConstants.MSGBOX_DELAY_MILISECS);
			/*
			 * getMessageSourceAccessor() .getMessage(
			 * "admon.usermnt.msg.valid.delete" );
			 */
		} else {
			msg = composeMsgBoxMessage(
					"There were some problems removing your selected records.",
					"error", GlobalConstants.MSGBOX_DELAY_MILISECS);
		}
		request.getSession(true).setAttribute(RequestConstants.REQUEST_HTTP_SESSION_MSG, msg);
		if (getLog().isDebugEnabled()) {
			getLog().debug("End Delete Action.");
		}
		return "redirect:";
	}

	/**
	 * Service injected by IoC.
	 * 
	 * @param productService
	 *            Service implementation for accessing products.
	 */
	@Autowired
	public void setProductService(IProductDataService productService) {
		this.productService = productService;
	}

	/**
	 * If the object reference dependency properties are not properly set, an
	 * exception is thrown indicating that they are required to be configured
	 * for the bean to work properly.
	 * 
	 * @throws Exception
	 */
	@Override
	public void afterPropertiesSet() throws Exception {
		 if (productService == null) {
             throw new Exception("productService property is not assigned.");
         }
	}
}
