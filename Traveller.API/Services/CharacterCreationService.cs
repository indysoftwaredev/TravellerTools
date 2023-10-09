using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Traveller.API.Data.Entities;
using Traveller.API.Models;

namespace Traveller.API.Services
{
    public class CharacterCreationService
    {
        private ICharacterRepository _repository;
        private readonly IMapper _mapper;

        public CharacterCreationService(ICharacterRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CharacterDto> CreateCharacterAsync(CharacterForCreationDto characterForCreationDto)
        {
            CharacterForCreationDto characterForCreationDto1 = _mapper.Map<CharacterForCreationDto>(characterForCreationDto);

            Character characterToCreate = _mapper.Map<Character>(characterForCreationDto);

            await _repository.CreateCharacterAsync(characterToCreate);
            /*new Data.Entities.Character 
            { 
                Name = characterForCreationDto.Name 
            });*/

            CharacterDto characterToReturn = _mapper.Map<CharacterDto>(characterToCreate);

            /*CharacterDto characterDto = new CharacterDto
            {
                Id = characterEntity.Id,
                Name = characterForCreationDto.Name
            };*/

            return characterToReturn;

            
        }
    }
}
