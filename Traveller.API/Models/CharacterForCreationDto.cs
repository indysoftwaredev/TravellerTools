using System.ComponentModel.DataAnnotations;

namespace Traveller.API.Models
{
    public class CharacterForCreationDto
    {
        /// <summary>
        /// The name of the new character
        /// </summary>
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; } = "Traveller";
    }
}
