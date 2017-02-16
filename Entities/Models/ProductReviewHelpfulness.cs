namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductReviewHelpfulness")]
    public partial class ProductReviewHelpfulness
    {
        public int Id { get; set; }

        public int ProductReviewId { get; set; }

        public bool WasHelpful { get; set; }

        public int CustomerId { get; set; }

        public virtual ProductReview ProductReview { get; set; }
    }
}
