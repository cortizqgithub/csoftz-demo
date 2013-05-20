/*==========================================================================*/
/* Source File:   YESNOINFO.VB                                              */
/* Description:   Domain object to hold Yes/No values or any other          */ 
/*                convenient value such as Si/No, Aceptar/No Aceptar,       */
/*                True/False, etc, that is, it is used for boolean          */
/*                representation. Using an integer code for Boolean         */
/*                representation and using utilities to map again to boolean*/
/*                true/false. The true value is 1, and the false value is 0 */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
De.03/2010 COQ  File created.
============================================================================*/
namespace CSoftZ.Demo.Domain {
    public class YesNoInfo : AbstractDescriptiveCommonDomain {

        /// <summary>
        /// Default constructor.
        /// </summary>
        public YesNoInfo() {
            base.Clear();
        }
    }
}
