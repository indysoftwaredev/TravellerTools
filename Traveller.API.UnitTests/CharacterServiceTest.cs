using AutoMapper;
using Moq;
using Traveller.API.Data.Entities;
using Traveller.API.Models;
using Traveller.API.Profiles;
using Traveller.API.Services;

namespace Traveller.API.UnitTests
{
    public class CharacterServiceTest
    {
        private static IMapper? _mapper;
        private static Mock<ICharacterRepository>? _characterRepositoryMock;

        public CharacterServiceTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new CharacterProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            if (_characterRepositoryMock == null)
            {
                _characterRepositoryMock = new Mock<ICharacterRepository>();
            }
        }

        private CharacterService createCharacterService()
        {
            return new CharacterService(_characterRepositoryMock.Object, _mapper);
        }

        [Fact]
        public async Task CreateCharacterAsync_ConstructCharacter_STR_MustBeBetween2And12()
        {

            CharacterService service = createCharacterService();

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

            CharacterService service = createCharacterService();

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

            CharacterService service = createCharacterService();

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

            CharacterService service = createCharacterService();

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

            CharacterService service = createCharacterService();

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

            CharacterService service = createCharacterService();

            for (int i = 0; i < 1000; i++)
            {
                CharacterDto characterDto =
                    await service.CreateCharacterAsync(new CharacterForCreationDto());

                int characteristic = characterDto.SOC;
                Assert.True(characteristic >= 2 && characteristic <= 12);
            }
        }

        [Fact]
        public async Task GetCharacterAsync_CharacterExists_ReturnsACharacter()
        {
            _characterRepositoryMock?.Setup(m =>
                m.GetCharacterAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(new Character())
            );

            CharacterService service = createCharacterService();

            CharacterDto characterDto = await service.GetCharacterAsync(1);
            Assert.NotNull(characterDto);
        }

        [Fact]
        public async Task GetCharacterAsync_CharacterDoesNotExists_ReturnsNull()
        {
            _characterRepositoryMock?.Setup(m =>
                m.GetCharacterAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(null as Character)
            );

            CharacterService service = createCharacterService();

            CharacterDto characterDto = await service.GetCharacterAsync(1);
            Assert.Null(characterDto);

        }

    }
}
