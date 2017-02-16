namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Forums_Forum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forums_Forum()
        {
            Forums_Topic = new HashSet<Forums_Topic>();
        }

        public int Id { get; set; }

        public int ForumGroupId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int NumTopics { get; set; }

        public int NumPosts { get; set; }

        public int LastTopicId { get; set; }

        public int LastPostId { get; set; }

        public int LastPostCustomerId { get; set; }

        public DateTime? LastPostTime { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public virtual Forums_Group Forums_Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_Topic> Forums_Topic { get; set; }
    }
}
