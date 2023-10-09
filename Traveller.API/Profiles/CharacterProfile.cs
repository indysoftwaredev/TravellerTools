using AutoMapper;

namespace Traveller.API.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Models.CharacterForCreationDto, Data.Entities.Character>();
            CreateMap<Data.Entities.Character, Models.CharacterDto>();
        }

    }
}
