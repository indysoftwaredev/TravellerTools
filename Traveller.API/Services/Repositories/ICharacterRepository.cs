using Traveller.API.Data.Entities;

namespace Traveller.API.Services.Repositories
{
    public interface ICharacterRepository
    {
        Task<bool> SaveChangesAsync();
        Task<Character> CreateCharacterAsync(Character character);
        Task<Character> GetCharacterAsync(int id);

    }
}
