using Microsoft.EntityFrameworkCore;
using Traveller.API.Data.Entities;

namespace Traveller.API.Data.DbContexts
{
    public class TravellerDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillSpecialization> skillSpecializations { get; set; }

        public TravellerDbContext(DbContextOptions<TravellerDbContext> options) : base(options)
        {          
            
        }
    }
}
