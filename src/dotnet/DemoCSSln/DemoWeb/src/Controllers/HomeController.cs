/*==========================================================================*/
/* Source File:   HOMECONTROLLER.CS                                         */
/* Description:   Controller Class for Home page.                           */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec,03/2010                                               */
/* Version:       1.2                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.03/2010 COQ  File created.
============================================================================*/

using System.Web.Mvc;

namespace CSoftZ.Demo.Web.Controllers {
    /// <summary>
    /// Controller class for Home page.
    /// </summary>
    public class HomeController : Controller {
       
        /// <summary>
        /// Welcome page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index() {
            return View();
        }

        /// <summary>
        /// Leads to the About Us page.
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutUs() {
            return View();
        }

        /// <summary>
        /// Leads to the Contact page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact() {
            return View();
        }
    }
}
