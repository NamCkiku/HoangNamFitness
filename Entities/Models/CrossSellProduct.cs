namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrossSellProduct")]
    public partial class CrossSellProduct
    {
        public int Id { get; set; }

        public int ProductId1 { get; set; }

        public int ProductId2 { get; set; }
    }
}
