namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnRequest")]
    public partial class ReturnRequest
    {
        public int Id { get; set; }

        public string CustomNumber { get; set; }

        public int StoreId { get; set; }

        public int OrderItemId { get; set; }

        public int CustomerId { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string ReasonForReturn { get; set; }

        [Required]
        public string RequestedAction { get; set; }

        public string CustomerComments { get; set; }

        public string StaffNotes { get; set; }

        public int ReturnRequestStatusId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
