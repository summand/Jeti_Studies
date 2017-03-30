namespace Jeti_v0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ActiveContract
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime ActivityDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IBFuturesLocalSymbol { get; set; }
    }
}
