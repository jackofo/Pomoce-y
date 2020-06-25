using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pomoce.Model
{
	[Table("__MigrationHistory")]
    public partial class C__MigrationHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string MigrationId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string ContextKey { get; set; }

        [Required]
        public byte[] Model { get; set; }

        [Required]
        [StringLength(32)]
        public string ProductVersion { get; set; }
    }
}
