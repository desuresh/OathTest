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
    
    public partial class OT_USState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OT_USState()
        {
            this.OT_UserProfile = new HashSet<OT_UserProfile>();
        }
    
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_UserProfile> OT_UserProfile { get; set; }
    }
}
