//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int Id { get; set; }
        public int FK_Users_Id { get; set; }
        public string Token { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime EndAt { get; set; }
        public int Status { get; set; }
        public string Ip { get; set; }
        public string Country { get; set; }
    
        public virtual User User { get; set; }
    }
}