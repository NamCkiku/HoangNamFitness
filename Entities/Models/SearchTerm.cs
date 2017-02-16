namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchTerm")]
    public partial class SearchTerm
    {
        public int Id { get; set; }

        public string Keyword { get; set; }

        public int StoreId { get; set; }

        public int Count { get; set; }
    }
}
