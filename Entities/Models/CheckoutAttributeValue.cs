namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckoutAttributeValue")]
    public partial class CheckoutAttributeValue
    {
        public int Id { get; set; }

        public int CheckoutAttributeId { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ColorSquaresRgb { get; set; }

        public decimal PriceAdjustment { get; set; }

        public decimal WeightAdjustment { get; set; }

        public bool IsPreSelected { get; set; }

        public int DisplayOrder { get; set; }

        public virtual CheckoutAttribute CheckoutAttribute { get; set; }
    }
}
