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
    
    public partial class Follower
    {
        public int Id { get; set; }
        public int FR_Follower_Users_Id { get; set; }
        public int FR_Following_Users_Id { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}