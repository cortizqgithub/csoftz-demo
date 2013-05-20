<%-- 
/*----------------------------------------------------------------------------*/
/* Source File:   INDEX.JSP                                                   */
/* Description:   Main and welcome page to the product system                 */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Dec.24/2010                                                 */
/* Last Modified: Jan.06/2011                                                 */
/* Version:       1.3                                                         */
/* Copyright (c), 2010, 2011 CSoftZ                                           */
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
<title><spring:message code="product.title" /></title>
<script type="text/javascript">
	$(document).ready(function() {
		setupEnvironmentForGridPages();
		${msgbox}
	});
</script>
</head>
<body>
<h2><spring:message code="product.title" /></h2>
<div id="msg-box" style="display: none"></div>
<a href="${ctx }/product/create">New</a>
<br />
<br />
<form:form modelAttribute="productSearchInfo" action="${ctx}/product/search"
	method="post">
	<form:label for="name" path="name" cssErrorClass="error">Name</form:label>
	<form:input path="name" /> <form:errors path="name" />
	<form:label for="phone" path="phone" cssErrorClass="error">Phone</form:label>
	<form:input path="phone" /> <form:errors path="phone" />
	<input type="submit" name="search" id="search" value="Search" />
</form:form>
<form:form action="${ctx}/product/delete" method="post">
	<d:table id="rowLine" class="tableDT" name="productList" pagesize="10"
		requestURI="">
		<d:column titleKey="product.column.product">
			<input align="middle" type="checkbox" name="recToDel"
				value="${rowLine.productId }">
		</d:column>
		<d:column titleKey="product.column.name">
			<a href="${ctx }/product/edit/${rowLine.productId}">${rowLine.name}</a>
		</d:column>
		<d:column property="address" titleKey="product.column.address" />
		<d:column property="phone" titleKey="product.column.phone" />
	</d:table>
	<br/>
	<c:if test="${!productListEmpty}">
		<input type="submit" name="delRecs" id="delRecs" value="Remove" />
	</c:if>
</form:form>
</body>
</html>