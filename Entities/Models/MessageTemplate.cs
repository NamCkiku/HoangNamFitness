namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageTemplate")]
    public partial class MessageTemplate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string BccEmailAddresses { get; set; }

        [StringLength(1000)]
        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsActive { get; set; }

        public int? DelayBeforeSend { get; set; }

        public int DelayPeriodId { get; set; }

        public int AttachedDownloadId { get; set; }

        public int EmailAccountId { get; set; }

        public bool LimitedToStores { get; set; }
    }
}
