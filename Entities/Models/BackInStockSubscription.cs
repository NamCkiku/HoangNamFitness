namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BackInStockSubscription")]
    public partial class BackInStockSubscription
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
