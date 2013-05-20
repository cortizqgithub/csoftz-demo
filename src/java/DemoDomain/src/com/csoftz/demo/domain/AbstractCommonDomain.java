/*----------------------------------------------------------------------------*/
/* Source File:   ABSTRACTCOMMONDOMAIN.JAVA                                   */
/* Description:   Base class with common methods for subclasses to use.       */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          Dec.24/2010                                                 */
/* Last Modified: Dec.24/2010                                                 */
/* Version:       1.0                                                         */
/* Copyright (c), 2010 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 Dec.24/2010 COQ  File created.
 -----------------------------------------------------------------------------*/

package com.csoftz.demo.domain;

import org.apache.commons.lang.builder.ToStringBuilder;

/**
 * Base class with common methods for subclasses to use.
 * 
 * @since 1.5(JDK), Dec.24/2010
 * @author Carlos Adolfo Ortiz Quir—s (COQ)
 * @version 1.1, Dec.24/2010
 */
public abstract class AbstractCommonDomain {

    /**
     * Default Constructor.
     */
    public AbstractCommonDomain() {
        super();
    }

    /**
     * To clear current content status for object.
     */
    public abstract void clear();

    /**
     * Override parent method in order to give this object an String
     * representation of itself.
     * 
     * @see java.lang.Object#toString()
     */
    public String toString() {
        return ToStringBuilder.reflectionToString(this);
    }
}