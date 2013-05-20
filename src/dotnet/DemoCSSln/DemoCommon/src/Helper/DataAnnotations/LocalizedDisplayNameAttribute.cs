/*==========================================================================*/
/* Source File:   LOCALIZEDDISPLAYNAMEATTRIBUTE.VB                          */
/* Description:   Locales RESX support overriding default behaviour.        */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.07/2010                                               */
/* Last Modified: Dec.07/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.07/2010 COQ  File created.
============================================================================*/

using System;
using System.ComponentModel;
using System.Reflection;

namespace CSoftZ.Demo.Common.Helper.DataAnnotations {
    /// <summary>
    ///  Uses Locales RESX support to get the display name metadata annotations.
    /// </summary>
    public sealed class LocalizedDisplayNameAttribute : DisplayNameAttribute {
        private PropertyInfo _nameProperty;
        private Type _resourceType;

       /// <summary>
       /// Default constructor using parameter.
       /// </summary>
       /// <param name="displayNameKey">String to display.</param>
        public LocalizedDisplayNameAttribute(string displayNameKey)
            : base(displayNameKey) {
        }

        /// <summary>
        /// get/set NameResourceType
        /// </summary>
        public Type NameResourceType {
            get { return _resourceType;}
            set { 
                _resourceType = value;

                // Initialize nameProperty when type property is provided by setter.
                _nameProperty = _resourceType.GetProperty(base.DisplayName, BindingFlags.Static | BindingFlags.Public);
            }
        }

        /// <summary>
        /// Property to use when displaying name.
        /// </summary>
        public string DisplayName {
            get {
                // Check if nameProperty is null and return original display name value
                if (_nameProperty == null) {
                    return base.DisplayName;
                }
                return (string)_nameProperty.GetValue(_nameProperty.DeclaringType, null);
            }
        } 
    }
}
