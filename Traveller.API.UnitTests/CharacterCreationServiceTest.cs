using AutoMapper;
using Moq;
using Traveller.API.Models;
using Traveller.API.Profiles;
using Traveller.API.Services;

namespace Traveller.API.UnitTests
{
    public class CharacterCreationServiceTest
    {
        private static IMapper _mapper;
        private static Mock<ICharacterRepository> _characterRepository;

        public CharacterCreationServiceTest()
        {
            if(_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new CharacterProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            if(_characterRepository == null)
            {
                _characterRepository = new Mock<ICharacterRepository>();
            }
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_STR_MustBeBetween2And12()
        {

            CharacterService service =
                new CharacterService(_characterRepository.Object, _mapper);

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.STR;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_DEX_MustBeBetween2And12()
        {

            CharacterService service =
                new CharacterService(_characterRepository.Object, _mapper);

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.DEX;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_END_MustBeBetween2And12()
        {

            CharacterService service =
                new CharacterService(_characterRepository.Object, _mapper);

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.END;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_INT_MustBeBetween2And12()
        {

            CharacterService service =
                new CharacterService(_characterRepository.Object, _mapper);

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.INT;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_EDU_MustBeBetween2And12()
        {

            CharacterService service =
                new CharacterService(_characterRepository.Object, _mapper);

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.EDU;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_SOC_MustBeBetween2And12()
        {

            CharacterService service =
                new CharacterService(_characterRepository.Object, _mapper);

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.SOC;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }
    }
}
