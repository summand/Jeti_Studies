namespace Jeti_v0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityMaster")]
    public partial class SecurityMaster
    {
        [Key]
        public int SecurityID { get; set; }

        [Required]
        [StringLength(10)]
        public string SecType { get; set; }

        [Required]
        [StringLength(10)]
        public string Exchange { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        [StringLength(10)]
        public string IBFuturesLocalSymbol { get; set; }

        [StringLength(3)]
        public string FuturesGenericSymbol { get; set; }

        public int? FuturesYear { get; set; }

        [StringLength(10)]
        public string FuturesYearCode { get; set; }

        [StringLength(10)]
        public string FuturesMonth { get; set; }

        [StringLength(1)]
        public string FuturesMonthCode { get; set; }
    }
}
