//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OT.RentCoder.Business
{
    using System;
    using System.Collections.Generic;
    
    public partial class OT_Company
    {
        public int CompanyID { get; set; }
        public int ResourceTypeID { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string SkypeName { get; set; }
        public string PhoneNumber { get; set; }
        public int SituationID { get; set; }
        public int UserID { get; set; }
        public int IsWorkRemote { get; set; }
        public Nullable<int> AreYouReayToStartWork { get; set; }
        public string Skills { get; set; }
        public Nullable<int> CompanySize { get; set; }
        public string CompanyDescription { get; set; }
    
        public virtual OT_Situation OT_Situation { get; set; }
        public virtual OT_Decision OT_Decision { get; set; }
        public virtual OT_Decision OT_Decision1 { get; set; }
        public virtual OT_User OT_User { get; set; }
        public virtual OT_ResourceType OT_ResourceType { get; set; }
    }
}
