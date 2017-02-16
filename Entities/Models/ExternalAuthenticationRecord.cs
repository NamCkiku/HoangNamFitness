namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalAuthenticationRecord")]
    public partial class ExternalAuthenticationRecord
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string Email { get; set; }

        public string ExternalIdentifier { get; set; }

        public string ExternalDisplayIdentifier { get; set; }

        public string OAuthToken { get; set; }

        public string OAuthAccessToken { get; set; }

        public string ProviderSystemName { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
