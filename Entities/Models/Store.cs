namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            ProductReviews = new HashSet<ProductReview>();
            StoreMappings = new HashSet<StoreMapping>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        [Required]
        [StringLength(400)]
        public string Url { get; set; }

        public bool SslEnabled { get; set; }

        [StringLength(400)]
        public string SecureUrl { get; set; }

        [StringLength(1000)]
        public string Hosts { get; set; }

        public int DefaultLanguageId { get; set; }

        public int DisplayOrder { get; set; }

        [StringLength(1000)]
        public string CompanyName { get; set; }

        [StringLength(1000)]
        public string CompanyAddress { get; set; }

        [StringLength(1000)]
        public string CompanyPhoneNumber { get; set; }

        [StringLength(1000)]
        public string CompanyVat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreMapping> StoreMappings { get; set; }
    }
}
