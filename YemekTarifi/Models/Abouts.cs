namespace YemekTarifi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abouts
    {
        [Key]
        public int AboutID { get; set; }

        [StringLength(1000)]
        public string AboutDetails1 { get; set; }

        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        [StringLength(1000)]
        public string AboutImage1 { get; set; }

        [StringLength(1000)]
        public string AboutImage2 { get; set; }
    }
}
