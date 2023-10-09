using Microsoft.EntityFrameworkCore;
using Traveller.API.Data.Entities;

namespace Traveller.API.Data.DbContexts
{
    public class CharacterDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public CharacterDbContext(DbContextOptions<CharacterDbContext> options) : base(options)
        {          
            
        }
    }
}
