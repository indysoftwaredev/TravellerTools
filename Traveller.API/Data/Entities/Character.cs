using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveller.API.Data.Entities
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; } = "Traveller";
        public int STR { get; set; }
        public int DEX { get; set; }
        public int END { get; set; }
        public int INT { get; set; }
        public int EDU { get; set; }
        public int SOC { get; set; }

    }
}
