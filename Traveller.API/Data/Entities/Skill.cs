using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveller.API.Data.Entities
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<SkillSpecialization> SkillSpecializations { get; set; } = 
            new List<SkillSpecialization>();

    }
}
