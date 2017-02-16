namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecificationAttributeOption")]
    public partial class SpecificationAttributeOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecificationAttributeOption()
        {
            Product_SpecificationAttribute_Mapping = new HashSet<Product_SpecificationAttribute_Mapping>();
        }

        public int Id { get; set; }

        public int SpecificationAttributeId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        public string ColorSquaresRgb { get; set; }

        public int DisplayOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_SpecificationAttribute_Mapping> Product_SpecificationAttribute_Mapping { get; set; }

        public virtual SpecificationAttribute SpecificationAttribute { get; set; }
    }
}
