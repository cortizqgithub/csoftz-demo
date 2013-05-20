/*----------------------------------------------------------------------------*/
/* Source File:   REQUESTCONSTANTS.JAVA                                       */
/* Description:   Global application constants, only the HTTP Request keys.   */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Jan.05/2011                                                 */
/* Last Modified: Jan.06/2011                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Jan.05/2011 COQ  File created.
 -----------------------------------------------------------------------------*/
package com.csoftz.demo.common.consts;

/**
 * Global application constants, only the HTTP Request keys.
 * 
 * @since 1.5(JDK), Jan.05/2011
 * @author Carlos Adolfo Ortiz Quirós (COQ)
 * @version 1.1, Jan.05/2011
 */
public final class RequestConstants {
    /**
     * Refers to an HTTP request parameter. 
     */
    public static final String REQUEST_PARAM_ID = "id";

    /**
     * Tag entry to know that "msg" is stored in an HTTP session object. A
     * request object has a session object inside, thus, the naming resembles
     * this fact.
     */
    public static final String REQUEST_HTTP_SESSION_MSG = "msg";


    /**
     * Used to keep track of current connected user.
     */
    public static final String REQUEST_HTTP_SESSION_CONNECTED_USER = "connected-user";
    
    /**
     * To know which command to execute in Form controllers.
     */
    public static final String REQUEST_HTTP_FORM_COMMAND = "form-cmd";
    
    /**
     * Value for form command in controllers.
     */
    public static final int REQUEST_HTTP_FORM_COMMAND_CREATE = 1;
    public static final int REQUEST_HTTP_FORM_COMMAND_EDIT = 2;
    public static final int REQUEST_HTTP_FORM_COMMAND_SAVE = 3;
    public static final int REQUEST_HTTP_FORM_COMMAND_UPDATE = 4;
    public static final int REQUEST_HTTP_FORM_COMMAND_DELETE = 5;
    
    /** 
     * Session stored-scoped-saved-variables.
     */
    public static final String REQUEST_HTTP_MSG_BOX = "msgbox";
    
}
