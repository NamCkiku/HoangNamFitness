namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxRate")]
    public partial class TaxRate
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int TaxCategoryId { get; set; }

        public int CountryId { get; set; }

        public int StateProvinceId { get; set; }

        public string Zip { get; set; }

        public decimal Percentage { get; set; }
    }
}
