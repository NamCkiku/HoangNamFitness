namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forums_Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forums_Post()
        {
            Forums_PostVote = new HashSet<Forums_PostVote>();
        }

        public int Id { get; set; }

        public int TopicId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string Text { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public int VoteCount { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Forums_Topic Forums_Topic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_PostVote> Forums_PostVote { get; set; }
    }
}
