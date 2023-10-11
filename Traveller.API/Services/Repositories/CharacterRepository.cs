using Microsoft.EntityFrameworkCore;
using Traveller.API.Data.DbContexts;
using Traveller.API.Data.Entities;

namespace Traveller.API.Services.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly TravellerDbContext _context;

        public CharacterRepository(TravellerDbContext context)
        {
            _context = context;
        }

        public async Task<Character> CreateCharacterAsync(Character character)
        {
            await _context.AddAsync(character);
            await _context.SaveChangesAsync();
            return character;
        }

        public async Task<Character> GetCharacterAsync(int id)
        {
            return await _context.Characters
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
