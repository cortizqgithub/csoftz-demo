<%-- 
/*----------------------------------------------------------------------------*/
/* Source File:   DEFAULT.JSP                                                 */
/* Description:   Default Sitemesh decorator page                             */
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
<%@ include file="../taglibs.jsp"%>
<html>
<head>
<%@ include file="../metas.jsp"%>
<title><spring:message code="app.title" /> - <sm:title default="Welcome!" /></title>
<sm:head />
</head>
<body
	<sm:getProperty property="body.onload" writeEntireProperty="true"/>>
    <div id="container">
        <div id="container-inner">
            <div id="header"><h1><a href="${ ctx}/home">DemoMVC.JSE</a></h1><p>Where your dreams are a reality....</p>
                <div class="clear"></div>
            </div>
            <!-- end header -->
            <div id="nav">
                <ul>
                    <li><a href="${ ctx}/home">Home</a></li>
                    <li><a href="${ ctx}/home/about">About Us</a></li>
                    <li><a href="${ ctx}/product">Products</a></li>
                    <li><a href="${ ctx}/home/contact">Contact</a></li>
                </ul>
            </div>
            <!-- end nav -->
            <div id="slideshow">
                <img src="${ctx }/image/1.jpg" width="920" height="250" alt="bouquet" />
                <img src="${ctx }/image/2.jpg" width="920" height="250" alt="field" />
                <img src="${ctx }/image/3.jpg"" width="920" height="250" alt="horses" />
            </div>
            <!-- end slideshow -->
            <div id="main">
                <div id="content"><sm:body /></div>
                <!-- end content -->
                <div class="sidebar">
                    <h4>
                        Our Services</h4>
                    <ul>
                        <li><a href="#">Curabitur convallis urna quis </a></li>
                        <li><a href="#">Dui blandit et blandit justo </a></li>
                        <li><a href="#">Rhoncus. Sed dui justo, </a></li>
                        <li><a href="#">Ornare sit amet pharetra eu, </a></li>
                        <li><a href="#">Volutpat vel eros. Vestibulum </a></li>
                        <li><a href="#">Ante ipsum primis in faucibus </a></li>
                    </ul>
                    <h4>
                        Latest News</h4>
                    <div class="news-item">
                        <span class="date">20.10.2010</span> <a href="#">Lorem ipsum dolor sit</a> Proin
                        vitae lorem vel tortor vestibulum fringilla vel ut turpis.
                    </div>
                    <div class="news-item">
                        <span class="date">19.10.2010</span> <a href="#">Consectetuer adipiscing elit</a>
                        Proin vitae lorem vel tortor vestibulum fringilla vel ut turpis. Phasellus pulvinar
                        hendrerit ligula
                    </div>
                    <div class="news-item">
                        <span class="date">18.08.2010</span> <a href="#">Praesent vestibulum e</a> Sed sagittis
                        mauris sed mi scelerisque pellentesque. Praesent quis arcu mauris!
                    </div>
                </div>
                <!-- end sidebar -->
                <div class="clear">
                </div>
            </div>
            <!-- end main -->
        </div>
        <!-- end container-inner -->
    </div>
    <!-- end container -->
    <div id="footer">
        <p>
            &copy; DemoMVC 2010, 2011. Design by <a href="http://www.electrictowelrail.org.uk">Electric
                Towel Rail</a> | <a href="http://www.electrictowelrail.org.uk/chrome-towel-rail/">Chrome
                    Towel Rail</a></p>
    </div>
    <!-- end footer -->	
</body>
</html>
