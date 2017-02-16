namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forums_PostVote
    {
        public int Id { get; set; }

        public int ForumPostId { get; set; }

        public int CustomerId { get; set; }

        public bool IsUp { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Forums_Post Forums_Post { get; set; }
    }
}
