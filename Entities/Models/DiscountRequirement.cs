namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountRequirement")]
    public partial class DiscountRequirement
    {
        public int Id { get; set; }

        public int DiscountId { get; set; }

        public string DiscountRequirementRuleSystemName { get; set; }

        public virtual Discount Discount { get; set; }
    }
}
