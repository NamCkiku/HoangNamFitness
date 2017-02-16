namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PredefinedProductAttributeValue")]
    public partial class PredefinedProductAttributeValue
    {
        public int Id { get; set; }

        public int ProductAttributeId { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        public decimal PriceAdjustment { get; set; }

        public decimal WeightAdjustment { get; set; }

        public decimal Cost { get; set; }

        public bool IsPreSelected { get; set; }

        public int DisplayOrder { get; set; }

        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
