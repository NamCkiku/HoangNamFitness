namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RewardPointsHistory")]
    public partial class RewardPointsHistory
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int StoreId { get; set; }

        public int Points { get; set; }

        public int PointsBalance { get; set; }

        public decimal UsedAmount { get; set; }

        public string Message { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public int? UsedWithOrder_Id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Order Order { get; set; }
    }
}
