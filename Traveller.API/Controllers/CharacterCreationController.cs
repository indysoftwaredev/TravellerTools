using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Traveller.API.Models;
using Traveller.API.Services;
using Traveller.API.Services.Repositories;

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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CharacterDto>> CreateCharacterAsync(CharacterForCreationDto createCharacterDto)
        {
            CharacterDto characterDto = await new CharacterService(_repository, _mapper).CreateCharacterAsync(createCharacterDto);
            return CreatedAtRoute("GetCharacter", new { id = characterDto.Id }, characterDto);
        }

        /// <summary>
        /// Get an existing character
        /// </summary>
        /// <param name="id">The id of the character</param>
        /// <returns>The character with the matching id</returns>
        [HttpGet("{id}", Name ="GetCharacter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CharacterDto>> GetCharacter(int id)
        {
            CharacterDto characterDto = await new CharacterService(_repository, _mapper).GetCharacterAsync(id);

            if(characterDto == null)
            {
                return NotFound();
            }

            return Ok(characterDto);
        }

}
}
