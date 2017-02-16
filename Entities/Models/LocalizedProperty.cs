namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocalizedProperty")]
    public partial class LocalizedProperty
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        public int LanguageId { get; set; }

        [Required]
        [StringLength(400)]
        public string LocaleKeyGroup { get; set; }

        [Required]
        [StringLength(400)]
        public string LocaleKey { get; set; }

        [Required]
        public string LocaleValue { get; set; }

        public virtual Language Language { get; set; }
    }
}
