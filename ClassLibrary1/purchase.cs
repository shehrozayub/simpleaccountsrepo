//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchase
    {
        public int purchaseID { get; set; }
        public int purchaseAmount { get; set; }
        public string purchaseProduct { get; set; }
        public int accountID { get; set; }
        public System.DateTime createdOn { get; set; }
    
        public virtual account account { get; set; }
    }
}
