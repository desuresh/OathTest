﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentCoderEntities : DbContext
    {
        public RentCoderEntities()
            : base("name=RentCoderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OT_Characterizes> OT_Characterizes { get; set; }
        public virtual DbSet<OT_Country> OT_Country { get; set; }
        public virtual DbSet<OT_Decision> OT_Decision { get; set; }
        public virtual DbSet<OT_ResourceType> OT_ResourceType { get; set; }
        public virtual DbSet<OT_Situation> OT_Situation { get; set; }
        public virtual DbSet<OT_Skills> OT_Skills { get; set; }
        public virtual DbSet<OT_TimeZone> OT_TimeZone { get; set; }
        public virtual DbSet<OT_User> OT_User { get; set; }
        public virtual DbSet<OT_UserProfile> OT_UserProfile { get; set; }
        public virtual DbSet<OT_UserSkills> OT_UserSkills { get; set; }
        public virtual DbSet<OT_USState> OT_USState { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<OT_Company> OT_Company { get; set; }
        public virtual DbSet<timezone> timezones { get; set; }
        public virtual DbSet<OT_Role> OT_Role { get; set; }
    }
}