namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Campaign")]
    public partial class Campaign
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public int StoreId { get; set; }

        public int CustomerRoleId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime? DontSendBeforeDateUtc { get; set; }
    }
}
