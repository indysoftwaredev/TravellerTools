using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Traveller.API.Models;
using Traveller.API.Services;

namespace Traveller.API.Controllers
{
    [Route("api/CreateCharacter")]
    [ApiController]
    public class CharacterCreationController : ControllerBase
    {
        private readonly ICharacterRepository _repository;
        private readonly IMapper _mapper;

        public CharacterCreationController(ICharacterRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Create a new character
        /// </summary>
        /// <param name="createCharacterDto">The new character dto to be added</param>
        /// <returns>The id of the new character</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public async Task<ActionResult<CharacterDto>> CreateCharacterAsync(CharacterForCreationDto createCharacterDto)
        {
            CharacterDto characterDto = await new CharacterCreationService(_repository, _mapper).CreateCharacterAsync(createCharacterDto);

            return CreatedAtRoute("VerifyCharacteristics", new { id = characterDto.Id }, characterDto);
        }

        [HttpGet("{id}", Name ="VerifyCharacteristics")]
        public async Task<ActionResult<CharacterDto>> VerifyCharacteristics(int id)
        {
            //get the character stats for display
            throw new NotImplementedException();

        }

}
}
