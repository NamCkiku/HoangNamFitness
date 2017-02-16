namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AclRecord")]
    public partial class AclRecord
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        [Required]
        [StringLength(400)]
        public string EntityName { get; set; }

        public int CustomerRoleId { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
    }
}
