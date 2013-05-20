<%-- 
/*----------------------------------------------------------------------------*/
/* Source File:   EDIT.JSP                                                    */
/* Description:   Create/Edit product record                                  */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Jan.05/2011                                                 */
/* Last Modified: Jan.06/2011                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
  History
  Jan.04/2011 COQ  File created.
------------------------------------------------------------------------------*/

--%>
<%@ include file="../../sitemesh/common/taglibs.jsp"%>
<%@ page session="false"%>
<html>
<head>
<title><spring:message code="product.edit.title" /></title>
<script type="text/javascript">
    $(document).ready(function() {
    	setupEnvironmentForEditPages();
    	${msgbox}
    });
</script>
</head>
<body>
<h2><spring:message code="product.edit.title" /></h2>
<div id="msg-box" style="display: none"></div>
<br/><br/>
${message }
<form:form modelAttribute="productInfo" action="${ctx}/product/update" method="post">
    <form:hidden path="productId"/>
	<p><form:label for="name" path="name" cssErrorClass="error">Name</form:label><br />
	<form:input path="name" /> <form:errors path="name" /></p>
	<p><form:label for="eMail" path="eMail" cssErrorClass="error">eMail</form:label><br />
    <form:input path="eMail" /> <form:errors path="eMail" /></p>
    <p><form:label for="phone" path="phone" cssErrorClass="error">Phone</form:label><br />
    <form:input path="phone" /> <form:errors path="phone" /></p>
    <p><form:label for="address" path="address" cssErrorClass="error">Address</form:label><br />
    <form:input path="address" /> <form:errors path="address" /></p>
    <p><form:label for="city" path="city" cssErrorClass="error">City</form:label><br />
    <form:input path="city" /> <form:errors path="city" /></p>
    <p><form:label for="estate" path="estate" cssErrorClass="error">Estate</form:label><br />
    <form:input path="estate" /> <form:errors path="estate" /></p>
    <p><form:label for="country" path="country" cssErrorClass="error">Country</form:label><br />
    <form:input path="country" /> <form:errors path="country" /></p>
    <p><form:label for="active" path="active" cssErrorClass="error">Active</form:label><br />
    <form:input path="active" /> <form:errors path="active" /></p>
	<p><input type="submit" value="Save" id="cmd"></p>
	<input type="hidden" id="cmd" name="form-cmd" value="${form-cmd }"/>
</form:form>
</body>
</html>