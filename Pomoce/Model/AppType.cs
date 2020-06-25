namespace Pomoce.Model
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class AppType
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        public virtual ICollection<UserApp> Tables { get; set; }
    }
}
