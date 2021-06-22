namespace test.EFS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public int id { get; set; }

        public string name { get; set; }

        public string image { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public int? cateID { get; set; }

        public int? sell_ID { get; set; }
    }
}
