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
    
    public partial class transaction
    {
        public int transactionid { get; set; }
        public int transactionamount { get; set; }
        public bool transactiontype { get; set; }
        public int accountid { get; set; }
        public System.DateTime createdOn { get; set; }
    
        public virtual account account { get; set; }
    }
}
