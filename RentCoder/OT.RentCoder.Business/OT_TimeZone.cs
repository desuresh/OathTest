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
    
    public partial class OT_TimeZone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OT_TimeZone()
        {
            this.OT_UserProfile = new HashSet<OT_UserProfile>();
        }
    
        public int TimeZoneID { get; set; }
        public string TimeZone { get; set; }
        public int CountryID { get; set; }
    
        public virtual OT_Country OT_Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_UserProfile> OT_UserProfile { get; set; }
    }
}
