namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forums_Subscription
    {
        public int Id { get; set; }

        public Guid SubscriptionGuid { get; set; }

        public int CustomerId { get; set; }

        public int ForumId { get; set; }

        public int TopicId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
