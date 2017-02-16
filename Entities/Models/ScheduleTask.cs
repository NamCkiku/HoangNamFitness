namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScheduleTask")]
    public partial class ScheduleTask
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Seconds { get; set; }

        [Required]
        public string Type { get; set; }

        public bool Enabled { get; set; }

        public bool StopOnError { get; set; }

        public string LeasedByMachineName { get; set; }

        public DateTime? LeasedUntilUtc { get; set; }

        public DateTime? LastStartUtc { get; set; }

        public DateTime? LastEndUtc { get; set; }

        public DateTime? LastSuccessUtc { get; set; }
    }
}
