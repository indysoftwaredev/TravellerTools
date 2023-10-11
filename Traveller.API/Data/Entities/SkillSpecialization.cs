using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveller.API.Data.Entities
{
    public class SkillSpecialization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("SkillId")]
        public int SkillId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
