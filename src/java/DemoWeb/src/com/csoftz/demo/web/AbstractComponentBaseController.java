/*----------------------------------------------------------------------------*/
/* Source File:   ABSTRACTCOMPONENTBASECONTROLLER.JAVA                        */
/* Description:   Base abstract class that all controllers must inherit.      */
/*                This class holds common properties and methods shared among */
/*                all controllers.                                            */
/* Author:        Carlos Adolfo Ortiz Quir—s (COQ)                            */
/* Date:          Jan.05/2011                                                 */
/* Last Modified: Jan.06/2011                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Jan.05/2011 COQ  File created.
 -----------------------------------------------------------------------------*/
package com.csoftz.demo.web;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;

/**
 * Base abstract class that all controllers must inherit. <br/>
 * This class holds common properties and methods shared among all controllers.<br/>
 * <br/>
 * Also notice that as being an abstract class, it is required that it cannot be
 * instantiated and descendants must access its properties through getter/setter
 * pairs.
 * 
 * @since 1.5(JDK), Jan.05/2011
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.2, Jan.06/2011
 */
public abstract class AbstractComponentBaseController {
	/**
	 * Logger facility.
	 */
	private transient final Log log = LogFactory.getLog(this.getClass());

	/**
	 * Makes a Javascript composition by calling a function defined in
	 * 'global.js' file named 'showMessage'.
	 * 
	 * @param msg
	 *            The message to show up
	 * @param msgClass
	 *            CSS Class to show. Possible values are: info, success,
	 *            warning, error, validation.
	 * @param dalayMiliSecs
	 *            How many milliseconds to last.
	 * @return String with a javascript call for showing message.
	 */
	protected String composeMsgBoxMessage(String msg, String msgClass,
			int dalayMiliSecs) {
		StringBuilder s = new StringBuilder();

		s.append("showMessage(").append("'").append(msg).append("', '")
				.append(msgClass).append("', ").append(dalayMiliSecs)
				.append(");");

		return s.toString();
	}

	/**
	 * Logger facility.
	 * 
	 * @return the log
	 */
	public Log getLog() {
		return log;
	}
}
