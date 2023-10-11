using AutoMapper;
using Traveller.API.Business;
using Traveller.API.Data.Entities;
using Traveller.API.Models;
using Traveller.API.Services.Repositories;

namespace Traveller.API.Services
{
    public class CharacterService
    {
        private ICharacterRepository _repository;
        private readonly IMapper _mapper;

        public CharacterService(ICharacterRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CharacterDto> CreateCharacterAsync(CharacterForCreationDto characterForCreationDto)
        {
            Character characterToCreate = _mapper.Map<Character>(characterForCreationDto);

            characterToCreate.STR = DiceRoller.Roll(2, 6);
            characterToCreate.DEX = DiceRoller.Roll(2, 6);
            characterToCreate.END = DiceRoller.Roll(2, 6);
            characterToCreate.INT = DiceRoller.Roll(2, 6);
            characterToCreate.EDU = DiceRoller.Roll(2, 6);
            characterToCreate.SOC = DiceRoller.Roll(2, 6);

            await _repository.CreateCharacterAsync(characterToCreate);

            CharacterDto characterToReturn = _mapper.Map<CharacterDto>(characterToCreate);

            return characterToReturn;            
        }

        public async Task<CharacterDto> GetCharacterAsync(int id)
        {
            Character character = await _repository.GetCharacterAsync(id);
            CharacterDto characterToReturn = _mapper.Map<CharacterDto>(character);
            return characterToReturn;
        }
    }
}
