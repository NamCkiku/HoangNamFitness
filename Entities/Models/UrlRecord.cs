namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrlRecord")]
    public partial class UrlRecord
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        [Required]
        [StringLength(400)]
        public string EntityName { get; set; }

        [Required]
        [StringLength(400)]
        public string Slug { get; set; }

        public bool IsActive { get; set; }

        public int LanguageId { get; set; }
    }
}
