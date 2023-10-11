using Microsoft.EntityFrameworkCore;
using Traveller.API.Data.Entities;

namespace Traveller.API.Data.DbContexts
{
    public class SkillDbContext : DbContext
    {
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillSpecialization> SkillSpecializations { get; set; }

        public SkillDbContext(DbContextOptions<SkillDbContext> options) : base(options)
        {
            
        }
    }
}
