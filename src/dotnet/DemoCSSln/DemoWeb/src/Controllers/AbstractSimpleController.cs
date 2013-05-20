/*==========================================================================*/
/* Source File:   ABSTRACTSIMPLECONTROLLER.VB                               */
/* Description:   A base class on our own to wrap common properties and     */
/*                functionality.                                            */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.03/2010 COQ  File created.
============================================================================*/

using System.Text;
using System.Web.Mvc;
using Spring.Objects.Factory;

namespace CSoftZ.Demo.Web.Controllers {
    public abstract class AbstractSimpleController : Controller, IInitializingObject {
         ///  <summary>
        /// If the object reference dependency properties are not properly set, 
        /// an exception is thrown indicating that they are required to be 
        /// configured for the bean to work properly.
        /// </summary>
        /// <remarks></remarks>
        public void AfterPropertiesSet() {
        }

        /// <summary>
        /// Makes a Javascript composition by calling a function defined in 
        /// 'global.js' file named 'showMessage'.
        /// </summary>
        /// <param name="msg">The message to show up</param>
        /// <param name="msgClass">CSS Class to show. 
        /// Possible values are: info, success, warning, error, validation</param>
        /// <param name="dalayMiliSecs">How many milliseconds to last.</param>
        /// <returns>String with a javascript call for showing message.</returns>
        protected string ComposeMsgBox(string msg, string msgClass, int dalayMiliSecs) {
            StringBuilder s = new StringBuilder();

            s.Append("showMessage(").
              Append("'").Append(msg).Append("', '").
              Append(msgClass).Append("', ").
              Append(dalayMiliSecs).
              Append(");");

            return s.ToString();
        }
    }
}
