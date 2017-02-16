namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShippingByWeight")]
    public partial class ShippingByWeight
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int WarehouseId { get; set; }

        public int CountryId { get; set; }

        public int StateProvinceId { get; set; }

        [StringLength(400)]
        public string Zip { get; set; }

        public int ShippingMethodId { get; set; }

        public decimal From { get; set; }

        public decimal To { get; set; }

        public decimal AdditionalFixedCost { get; set; }

        public decimal PercentageRateOfSubtotal { get; set; }

        public decimal RatePerWeightUnit { get; set; }

        public decimal LowerWeightLimit { get; set; }
    }
}
