/*==========================================================================*/
/* Source File:   GLOBALCONSTANTS.VB                                        */
/* Description:   Global application Constants used in views (ASPX files)   */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.03/2010                                               */
/* Last Modified: Dec.07/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*==========================================================================
History
Dec.03/2010 COQ  File created.
============================================================================*/

namespace CSoftZ.Demo.Common.Helper.Consts {
    /// <summary>
    /// Global application Constants. Used as a static class access only. This way it
    /// is assured that a change in the constant value is modified in one place.
    /// </summary>
    public sealed class GlobalConstants {
        //' Global GlobalConstants
        public const int YES_VALUE = 1;
        public const int NO_VALUE = 0;
        public const string REQUEST_PAGE_SIZE = "ps";

        // How many seconds to show up a message box.
        public const int MSGBOX_DELAY_MILISECS  = 5000;

        // Search criteria
        public const string REQUEST_SEARCH_CRITERIA_CB_HIDDEN  = "sch";
        public const string REQUEST_SEARCH_CRITERIA_DATA_HIDDEN  = "sdh";
        public const string REQUEST_PAGESIZE_HIDDEN  = "ps";

        // Form related
        public const string REQUEST_FORM_DELETE_RECORDS  = "delRecs";
        public const string REQUEST_FORM_REC_TO_DEL  = "recToDel";
        public const string REQUEST_FORM_DEL_RECS_USED  = "delRecsUsed";
        public const string REQUEST_FORM_REC_SEL = "recSel";
    }
}
