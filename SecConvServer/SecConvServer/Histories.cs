//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecConvServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Histories
    {
        public long HistoryID { get; set; }
        public Nullable<long> UserSenderID { get; set; }
        public Nullable<long> UserReceiverID { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> Duration { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
