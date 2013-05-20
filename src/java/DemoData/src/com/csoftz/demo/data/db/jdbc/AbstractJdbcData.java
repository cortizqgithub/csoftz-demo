/*----------------------------------------------------------------------------*/
/* Source File:   ABSTRACTJDBCDATA.JAVA                                       */
/* Description:   Abstract class to hold common attributes for derived        */
/*                classes.                                                    */
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
package com.csoftz.demo.data.db.jdbc;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.jdbc.core.support.JdbcDaoSupport;

/**
 * Abstract class to hold common attributes for derived classes in the JDBC
 * technology.
 * 
 * @since 1.5(JDK), Jan.05/2011
 * @author Carlos Adolfo Ortiz Quirós (COQ)
 * @version 1.1, Jan.05/2011
 */
public abstract class AbstractJdbcData extends JdbcDaoSupport {
    /**
     * Logger facility.
     */
    private final Log log = LogFactory.getLog(this.getClass());

    /**
     * Holds the SQL INSERT statement to use, this way it allows the user to
     * inject it via IoC the desired statement.
     */
    protected String sqlInsert;

    /**
     * Holds the SQL UPDATE statement to use, this way it allows the user to
     * inject it via IoC the desired statement.
     */
    protected String sqlUpdate;

    /**
     * Holds the SQL SELECT statement to use, this way it allows the user to
     * inject it via IoC the desired statement.
     */
    protected String sqlSelect;

    /**
     * Holds the SQL SELECT statement to use, this way it allows the user to
     * inject it via IoC the desired statement. But this is a version which
     * needs the PK defined for table.
     */
    protected String sqlSelectForPK;

    /**
     * Holds the SQL DELETE statement to use, this way it allows the user to
     * inject it via IoC the desired statement.
     */
    protected String sqlDelete;

    /**
     * Holds the SQL named procedure call to execute.
     */
    protected String sqlSP;

    /**
     * Default constructor.
     */
    public AbstractJdbcData() {
        this.sqlDelete = "";
        this.sqlInsert = "";
        this.sqlSelect = "";
        this.sqlSelectForPK = "";
        this.sqlUpdate = "";
        this.sqlSP = "";
    }

    /**
     * Holds the SQL INSERT statement to use, this way it allows the user to
     * inject via IoC the desired statement.
     * 
     * @param sqlInsert
     *            the sqlInsert to set
     */
    public void setSqlInsert(String sqlInsert) {
        this.sqlInsert = sqlInsert;
    }

    /**
     * Holds the SQL UPDATE statement to use, this way it allows the user to
     * inject via IoC the desired statement.
     * 
     * @param sqlUpdate
     *            the sqlUpdate to set
     */
    public void setSqlUpdate(String sqlUpdate) {
        this.sqlUpdate = sqlUpdate;
    }

    /**
     * Holds the SQL SELECT statement to use, this way it allows the user to
     * inject via IoC the desired statement.
     * 
     * @param sqlSelect
     *            the sqlSelect to set
     */
    public void setSqlSelect(String sqlSelect) {
        this.sqlSelect = sqlSelect;
    }

    /**
     * Holds the SQL DELETE statement to use, this way it allows the user to
     * inject via IoC the desired statement.
     * 
     * @param sqlDelete
     *            the sqlDelete to set
     */
    public void setSqlDelete(String sqlDelete) {
        this.sqlDelete = sqlDelete;
    }

    /**
     * Holds the SQL SELECT statement to use, this way it allows the user to
     * inject it via IoC the desired statement. But this is a version which
     * needs the PK defined for table.
     * 
     * @param sqlSelectForPK
     *            the sqlSelectForPK to set
     */
    public void setSqlSelectForPK(String sqlSelectForPK) {
        this.sqlSelectForPK = sqlSelectForPK;
    }

    /**
     * Holds the SQL named procedure call to execute.
     * 
     * @param sqlSP
     *            the sqlSP to set
     */
    public void setSqlSP(String sqlSP) {
        this.sqlSP = sqlSP;
    }

    /**
     * @return the log
     */
    public Log getLog() {
        return log;
    }
}
