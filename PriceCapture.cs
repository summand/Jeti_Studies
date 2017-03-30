namespace Jeti_v0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceCapture")]
    public partial class PriceCapture
    {
        [Key]
        [Column(Order = 0, TypeName = "datetime2")]
        public DateTime IBTimestamp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Ticker { get; set; }

        public double Price { get; set; }

        public double? Open_Price { get; set; }

        public double? Close_Price { get; set; }

        public double? Bid { get; set; }

        public double? Ask { get; set; }

        public double? Volume { get; set; }
    }
}
