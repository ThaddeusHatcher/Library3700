//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library3700.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountStatusLog
    {
        public int AccountStatusLogId { get; set; }
        public int AccountId { get; set; }
        public byte AccountStatusTypeId { get; set; }
        public System.DateTime LogDateTime { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual AccountStatusType AccountStatusType { get; set; }
    }
}