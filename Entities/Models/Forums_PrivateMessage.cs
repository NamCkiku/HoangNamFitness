namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forums_PrivateMessage
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int FromCustomerId { get; set; }

        public int ToCustomerId { get; set; }

        [Required]
        [StringLength(450)]
        public string Subject { get; set; }

        [Required]
        public string Text { get; set; }

        public bool IsRead { get; set; }

        public bool IsDeletedByAuthor { get; set; }

        public bool IsDeletedByRecipient { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Customer Customer1 { get; set; }
    }
}
