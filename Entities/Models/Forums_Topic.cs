namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forums_Topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forums_Topic()
        {
            Forums_Post = new HashSet<Forums_Post>();
        }

        public int Id { get; set; }

        public int ForumId { get; set; }

        public int CustomerId { get; set; }

        public int TopicTypeId { get; set; }

        [Required]
        [StringLength(450)]
        public string Subject { get; set; }

        public int NumPosts { get; set; }

        public int Views { get; set; }

        public int LastPostId { get; set; }

        public int LastPostCustomerId { get; set; }

        public DateTime? LastPostTime { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Forums_Forum Forums_Forum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_Post> Forums_Post { get; set; }
    }
}
