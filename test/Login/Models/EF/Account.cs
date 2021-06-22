namespace Login.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int uID { get; set; }

        [StringLength(255)]
        public string user { get; set; }

        [StringLength(255)]
        public string pass { get; set; }

        public int? isSell { get; set; }

        public int? isAdmin { get; set; }
    }
}
