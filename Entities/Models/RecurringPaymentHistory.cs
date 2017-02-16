namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecurringPaymentHistory")]
    public partial class RecurringPaymentHistory
    {
        public int Id { get; set; }

        public int RecurringPaymentId { get; set; }

        public int OrderId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual RecurringPayment RecurringPayment { get; set; }
    }
}
