<%-- 
/*----------------------------------------------------------------------------*/
/* Source File:   INDEX.JSP                                                   */
/* Description:   Main and welcome page to the system                         */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Dec.24/2010                                                 */
/* Last Modified: Jan.04/2011                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2010, 2011 CSoftZ                                           */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
  History
  Jan.04/2011 COQ  File created.
------------------------------------------------------------------------------*/

--%>
<%@ include file="../../sitemesh/common/taglibs.jsp"%>
<%@ page session="false" %>
<html>
<head>
<title><spring:message code="app.title.home" /></title>
</head>
<body>
    <h2>Welcome to our site</h2>
    <p>This is a demo application showing one way to program in ASP.NET MVC.</p>
    <p>If you want to learn more about what the MVC Design pattern is you can follow this <a href="http://www.devdaily.com/uml/uml-model-view-controller-mvc-diagram" target="_blank">link</a>.</p> 
    <p>This Demo uses the ASP.NET MVC artifacts and another very useful Design pattern named IoC or DI. You must master this principle and information can
    be found <a href="http://en.wikipedia.org/wiki/Dependency_injection" target="_blank">here</a> and you are encouraged to read the Martin Fowler on the 
    <a href="http://martinfowler.com/articles/injection.html#InversionOfControl" target="_blank">topic</a>.</p> 
</body>
</html>