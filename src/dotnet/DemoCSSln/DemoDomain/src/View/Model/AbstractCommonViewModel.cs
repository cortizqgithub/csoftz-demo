/*==========================================================================*/
/* Source File:   ABSTRACTCOMMONVIEWMODEL.CS                                */
/* Description:   Base class with common methods for subclasses to use.     */
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

namespace CSoftZ.Demo.Domain.View.Model {
    /// <summary>
    /// Base class with common methods for subclasses to use.
    /// </summary>
    public abstract class AbstractCommonViewModel {

        /// <summary>
        ///  To clear current content status for object.
        /// </summary>
        public abstract void Clear();
    }
}
