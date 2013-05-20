/*----------------------------------------------------------------------------*/
/* Source File:   GLOBALCONSTANTS.JAVA                                        */
/* Description:   Global application constants.                               */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Jan.05/2011                                                 */
/* Last Modified: Jan.05/2011                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2011 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Jan.05/2011 COQ  File created.
 -----------------------------------------------------------------------------*/
package com.csoftz.demo.common.consts;

/**
 * Global application constants. Used as a static class access only. This way it
 * is assured that a change in the constant value is modified in one place.
 * 
 * @since 1.5(JDK), Jan.05/2011
 * @author Carlos Adolfo Ortiz Quirós (COQ)
 * @version 1.1, Jan.05/2011
 */
public final class GlobalConstants {

    /**
     * Comma delimiter to separate items in an array or with any other usage.
     */
    public static final char COMMA_DELIMITER = ',';

    /**
     * In an input string how many consecutive characters are not allowed to be
     * in it.
     */
    public static final int CONSECUTIVE_CHARS_TO_VALIDATE = 3;

    /**
     * Concatenation delimiter.
     */
    public static final char DASH_DELIMITER = '-';

    /**
     * Validation purpose character.
     */
    public static final char SPACE_DELIMITER = ' ';

    /**
     * Concatenation delimiter.
     */
    public static final String DASH_DELIMITER_STR = "-";

    /**
     * This format follows the rules for the SimpleDateFormat class.
     */
    public static final String DEFAULT_FMT_DATE = "yyyy-MM-dd";

    /**
     * Concatenation delimiter for primary keys on record field. Character
     * version.
     */
    public static final char PIPE_DELIMITER = '|';

    /**
     * Concatenation delimiter for primary keys on record field. String version.
     */
    public static final String PIPE_DELIMITER_STR = "|";

    /**
     * This format follows the rules for the SimpleDateFormat class.
     */
    public static final String DEFAULT_FMT_DATE_TIME = "yyyy-MM-dd HH:mm:ss";

    /**
     * Used to set a default value for minimun password capture in case of
     * parameter not being found in databae storage.
     */
    public static final int DEFAULT_PWD_MINIMUN = 7;

    /**
     * Used to set a default value for maximun password capture in case of
     * parameter not being found in databae storage.
     */
    public static final int DEFAULT_PWD_MAXIMUN = 20;

    /**
     * When boolean is true then set to 1.
     */
    public static final int BOOLEAN_TRUE = 1;

    /**
     * When boolean is false then set to 0.
     */
    public static final int BOOLEAN_FALSE = 0;

    /**
     * String representing a 1 value meaning true as boolean value.
     */
    public static final String BOOLEAN_STR_TRUE = "1";

    /**
     * String representing a 0 value meaning false as boolean value.
     */
    public static final String BOOLEAN_STR_FALSE = "0";

    /**
     * Max Upload Size.
     */
    public static final int MAX_UPLOAD_SIZE = 1000000;
    
    /**
     * How many seconds to show up a message box.
     */
    public static final int MSGBOX_DELAY_MILISECS = 5000;
}
