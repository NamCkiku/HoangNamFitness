namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocaleStringResource")]
    public partial class LocaleStringResource
    {
        public int Id { get; set; }

        public int LanguageId { get; set; }

        [Required]
        [StringLength(200)]
        public string ResourceName { get; set; }

        [Required]
        public string ResourceValue { get; set; }

        public virtual Language Language { get; set; }
    }
}
