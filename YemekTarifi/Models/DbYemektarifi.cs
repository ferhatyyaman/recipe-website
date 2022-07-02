using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace YemekTarifi.Models
{
    public partial class DbYemektarifi : DbContext
    {
        public DbYemektarifi()
            : base("name=DbYemektarifi")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Abouts> Abouts { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Contents> Contents { get; set; }
        public virtual DbSet<Headings> Headings { get; set; }
        public virtual DbSet<Writers> Writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
