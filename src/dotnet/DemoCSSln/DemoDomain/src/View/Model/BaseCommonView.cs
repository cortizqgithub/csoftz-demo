/*==========================================================================*/
/* Source File:   BASECOMMONVIEW.CS                                         */
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
    /// Base class with common methods and properties.
    /// </summary>
    public class BaseCommonView : AbstractCommonViewModel {
        public int SearchCriteria { get; set; }
        public string SearchData { get; set; }
        public string SearchCriteriaHidden { get; set; }
        public string SearchDataHidden { get; set; }
        public int PageSize { get; set; }
        public short PreserveCriteria { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public BaseCommonView() {
            this.Clear();
        }

         /// <summary>
        ///  To clear current content status for object.
        /// </summary>
        public override void Clear() {
            SearchCriteria = 0;
            SearchData = "";
            SearchCriteriaHidden = "";
            SearchDataHidden = "";
            PageSize = 10;
            PreserveCriteria = 0;
        }
    }
}
