//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Effort.Test.Data.Northwind
{
    
    public class Shipper
    {
        public virtual int ShipperID { get; set; }
    
        public virtual string CompanyName { get; set; }
    
        public virtual string Phone { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    
    
    }
}