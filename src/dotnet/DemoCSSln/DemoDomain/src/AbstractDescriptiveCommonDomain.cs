/*==========================================================================*/
/* Source File:   ABSTRACTDESCRIPTIVECOMMONDOMAIN.VB                        */
/* Description:   Base class with common methods for subclasses to use.     */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.03/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Sep.01/2010 COQ  File created.
============================================================================*/

namespace CSoftZ.Demo.Domain {
    /// <summary>
    /// Base class with common methods for subclasses to use.
    /// </summary>
    public abstract class AbstractDescriptiveCommonDomain : AbstractCommonDomain {
        public int Code {get; set;}
        public string Description {get; set;}

        /// <summary>
        /// Default constructor.
        /// </summary>
        public AbstractDescriptiveCommonDomain()
            : base() {
                this.Clear();
        }

        /// <summary>
        /// To clear current content status for object.
        /// </summary>
        public override void Clear() {
            Code = 0;
            Description = "";
        }
    }
}
