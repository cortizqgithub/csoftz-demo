/*==========================================================================*/
/* Source File:   ABSTRACTCOMMONDOMAIN.CS                                   */
/* Description:   Base class with common methods for subclasses to use.     */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.02/2010                                               */
/* Last Modified: Dec.07/2010                                               */
/* Version:       1.2                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.02/2010 COQ  File created.
============================================================================*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CSoftZ.Demo.Common.Helper.DataAnnotations;

namespace CSoftZ.Demo.Domain.View.Model {
    public class ProductViewModel : BaseCommonView {
        // Property is used in Grid components.
        public List<ProductInfo> ProductList { get; set; }

        // The following properties are used in Create/Edit pages
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "eMail is required")]
        [LocalizedDisplayName("eMail")]
        public string eMail { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [LocalizedDisplayName("Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [LocalizedDisplayName("Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [LocalizedDisplayName("City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Estate is required")]
        [LocalizedDisplayName("Estate")]
        public string Estate { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [LocalizedDisplayName("Country")]
        public string Country { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        [Required(ErrorMessage = "Active is required")]
        [LocalizedDisplayName("Active")]
        public short Active { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProductViewModel()
            : base() {
            this.Clear();
        }

        /// <summary>
        ///  To clear current content status for object.
        /// </summary>
        public override void Clear() {
            base.Clear();
            ProductList = new List<ProductInfo>();
            ProductId = 0;
            Name = "";
            eMail = "";
            Phone = "";
            Address = "";
            City = "";
            Estate = "";
            Country = "";
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
            Active = 0;
        }
    }
}
