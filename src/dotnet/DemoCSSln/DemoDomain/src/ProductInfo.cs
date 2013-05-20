/*==========================================================================*/
/* Source File:   PRODUCTINFO.CS                                            */
/* Description:   The domain info class for Product objects.                */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                          */
/* Date:          Dec.02/2010                                               */
/* Last Modified: Dec.02/2010                                               */
/* Version:       1.1                                                       */
/* Copyright (c), 2010 CSoftZ                                               */
/*==========================================================================*/

/*===========================================================================
History
Dec.02/2010 COQ  File created.
============================================================================*/

using System;

namespace CSoftZ.Demo.Domain {
    public class ProductInfo : AbstractCommonDomain {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string eMail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Estate { get; set; }
        public string Country { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public short Active { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ProductInfo() {
            this.Clear();
        }

        /// <summary>
        ///  To clear current content status for object.
        /// </summary>
        public override void Clear() {
            ProductId = 0;
            Name = "";
            eMail = "";
            Phone = "";
            Address = "";
            City = "";
            Estate = "";
            Country = "";
            DateCreated = new DateTime();
            DateModified = new DateTime();
            Active = 0;
        }
    }
}
