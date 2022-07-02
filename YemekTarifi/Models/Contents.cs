namespace YemekTarifi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contents
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }

        public int? WriterID { get; set; }

        public bool ContentStatus { get; set; }

        public virtual Headings Headings { get; set; }

        public virtual Writers Writers { get; set; }
    }
}
