/*----------------------------------------------------------------------------*/
/* Source File:   HOMECONTROLLER.JAVA                                         */
/* Description:   Controller class for home page                              */
/* Author:        Carlos Adolfo Ortiz Quir—s (COQ)                            */
/* Date:          Jan.04/2011                                                 */
/* Last Modified: Jan.05/2011                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Jan.04/2011 COQ  File created.
 -----------------------------------------------------------------------------*/

package com.csoftz.demo.web;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

/**
 * Controller class for home page (HOME.JSP)
 * 
 * @since 1.5(JDK), Jan.04/2011
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.2, Jan.05/2011
 */
@Controller
@RequestMapping(value = "/home")
public class HomeController extends AbstractComponentBaseController {
	/**
	 * Responds to the URI GET: {webapp}/home
	 * 
	 * @return View name to render
	 */
	@RequestMapping(value = "", method = RequestMethod.GET)
	public String index() {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /home request.");
		}
		return "home/index";
	}

	/**
	 * Responds to the URI GET: {webapp}/home/about
	 * 
	 * @return View name to render
	 */
	@RequestMapping(value = "/about", method = RequestMethod.GET)
	public String about() {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /home/about request.");
		}
		return "home/about";
	}

	/**
	 * Responds to the URI GET: {webapp}/home/contact
	 * 
	 * @return View name to render
	 */
	@RequestMapping(value = "/contact", method = RequestMethod.GET)
	public String contact() {
		if (getLog().isDebugEnabled()) {
			getLog().debug("Executing /home/contact request.");
		}
		return "home/contact";
	}
}
