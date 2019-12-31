using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCentral.Domain
{
    public class PostTag
    {
        public string TagName { get; set; }

        [NotMapped]
        public virtual Post Post { get; set; }

        public Guid PostId { get; set; }
    }
}