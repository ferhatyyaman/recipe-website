//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekTarifi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbYemektarifiEntities : DbContext
    {
        public DbYemektarifiEntities()
            : base("name=DbYemektarifiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Abouts> Abouts { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Contents> Contents { get; set; }
        public virtual DbSet<Headings> Headings { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Writers> Writers { get; set; }
    }
}
