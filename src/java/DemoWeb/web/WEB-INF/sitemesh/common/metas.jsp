<%-- 
/*----------------------------------------------------------------------------*/
/* Source File:   METAS.JSP                                                   */
/* Description:   Common JSP code.                                            */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Dec.24/2010                                                 */
/* Last Modified: Jan.06/2011                                                 */
/* Version:       1.2                                                         */
/* Copyright (c), 2010, 2011 CSoftZ                                           */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
  History
  Dec.24/2010 COQ  File created.
------------------------------------------------------------------------------*/

--%>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1" />
<link rel="stylesheet" href="<c:url value="/css/blu.css"/>"  type="text/css" />
<link rel="stylesheet" href="<c:url value="/css/displaytag.css"/>"  type="text/css" />
<link rel="stylesheet" href="<c:url value="/css/messageboxes.css"/>"  type="text/css" />
<link rel="stylesheet" href="<c:url value="/css/site.css"/>"  type="text/css" />
<link rel="stylesheet" href="<c:url value="/js/jquery/plugin/lightbox/jquery.lightbox-0.5.css"/>"  type="text/css" />
<link rel="stylesheet" href="<c:url value="/js/jquery/plugin/greybox/greybox.css"/>" type="text/css"/>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<script type="text/javascript" src="http://cdn.jquerytools.org/1.2.4/all/jquery.tools.min.js"></script>
<script type="text/javascript" src="${ctx}/js/jquery/plugin/lightbox/jquery.lightbox-0.5.min.js"></script>
<script type="text/javascript" src="${ctx}/js/jquery/plugin/greybox/greybox.js"></script>
<script type="text/javascript" src="${ctx }/js/jquery/plugin/jquery.blockUI.js"></script>
<script type="text/javascript" src="${ctx}/js/demo/global.js"></script>
  
<link rel="shortcut icon" type="image/x-icon"  href="${ctx }/image/cube_blue.ico" />
<meta name="description" content="Demo MVC" />
<meta name="robots" content="nofollow,noarchive">

<!-- include Cycle plugin -->
<script type="text/javascript" src="http://cloud.github.com/downloads/malsup/cycle/jquery.cycle.all.latest.js"></script>
<script type="text/javascript">
     $(document).ready(function () {
         $('#slideshow').cycle({
             fx: 'fade' // choose your transition type, ex: fade, scrollUp, shuffle, etc...
         });
     });
</script>
</head>