namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StorePickupPoint")]
    public partial class StorePickupPoint
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int AddressId { get; set; }

        public decimal PickupFee { get; set; }

        public string OpeningHours { get; set; }

        public int StoreId { get; set; }
    }
}
