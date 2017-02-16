namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Addresses = new HashSet<Address>();
            StateProvinces = new HashSet<StateProvince>();
            ShippingMethods = new HashSet<ShippingMethod>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool AllowsBilling { get; set; }

        public bool AllowsShipping { get; set; }

        [StringLength(2)]
        public string TwoLetterIsoCode { get; set; }

        [StringLength(3)]
        public string ThreeLetterIsoCode { get; set; }

        public int NumericIsoCode { get; set; }

        public bool SubjectToVat { get; set; }

        public bool Published { get; set; }

        public int DisplayOrder { get; set; }

        public bool LimitedToStores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingMethod> ShippingMethods { get; set; }
    }
}
