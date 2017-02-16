namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAttributeValue")]
    public partial class CustomerAttributeValue
    {
        public int Id { get; set; }

        public int CustomerAttributeId { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        public bool IsPreSelected { get; set; }

        public int DisplayOrder { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
