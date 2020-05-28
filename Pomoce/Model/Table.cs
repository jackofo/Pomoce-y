namespace Pomoce.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class UserApp
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string User { get; set; }

        [Required]
        [StringLength(1024)]
        public string Data { get; set; }

        public Guid AppType { get; set; }

        public virtual AppType AppType1 { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}