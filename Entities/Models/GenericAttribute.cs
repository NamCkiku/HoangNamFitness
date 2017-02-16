namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenericAttribute")]
    public partial class GenericAttribute
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        [Required]
        [StringLength(400)]
        public string KeyGroup { get; set; }

        [Required]
        [StringLength(400)]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        public int StoreId { get; set; }
    }
}
