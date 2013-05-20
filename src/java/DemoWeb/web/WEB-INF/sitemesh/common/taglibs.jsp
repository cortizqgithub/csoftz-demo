<%-- 
/*----------------------------------------------------------------------------*/
/* Source File:   TAGLIBS.JSP                                                 */
/* Description:   List for all tag libs used in JSP pages, this file is       */
/*                included in every JSP page used by the application          */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Dec.24/2010                                                 */
/* Last Modified: Dec.24/2010                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2010 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
  History
  Dec.24/2010 COQ  File created.
------------------------------------------------------------------------------*/

--%>
<%@ taglib prefix="spring" uri="http://www.springframework.org/tags"%>
<%@ taglib prefix="form"   uri="http://www.springframework.org/tags/form"%>
<%@ taglib prefix="c"      uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="fn"      uri="http://java.sun.com/jsp/jstl/functions"%>
<%@ taglib prefix="fmt"    uri="http://java.sun.com/jstl/fmt"%>
<%@ taglib prefix="d"      uri="http://displaytag.sf.net"%>
<%@ taglib prefix="sm"     uri="http://www.opensymphony.com/sitemesh/decorator"%>

<c:set var="ctx" value="${pageContext.request.contextPath}" />
