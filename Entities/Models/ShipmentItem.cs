namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipmentItem")]
    public partial class ShipmentItem
    {
        public int Id { get; set; }

        public int ShipmentId { get; set; }

        public int OrderItemId { get; set; }

        public int Quantity { get; set; }

        public int WarehouseId { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
