namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TierPrice")]
    public partial class TierPrice
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int StoreId { get; set; }

        public int? CustomerRoleId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }

        public virtual Product Product { get; set; }
    }
}
